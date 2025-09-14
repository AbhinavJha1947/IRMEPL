using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class DbManager
    {
        private readonly string _connectionString;
        private readonly string _dataProvider;
        private readonly DbProviderFactory _factory;
        private readonly ILogger<DbManager> _logger;

        public DbManager(IConfiguration configuration, ILogger<DbManager> logger = null)
        {
            _logger = logger;
            _connectionString = configuration.GetConnectionString("DefaultConnection") ??
                                configuration.GetConnectionString("IRMEPLConnectionString");

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new ArgumentException("Connection string not found in configuration");
            }

            _dataProvider = "System.Data.SqlClient";
            _factory = SqlClientFactory.Instance;
        }

        #region Update Methods
        public int Update(string sql)
        {
            try
            {
                using (DbConnection connection = _factory.CreateConnection())
                {
                    connection.ConnectionString = _connectionString;

                    using (DbCommand command = _factory.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = sql;

                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error executing update: {Sql}", sql);
                throw;
            }
        }

        public int Update(string sql, SqlConnection objCon, SqlTransaction trn)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = objCon;
                    command.CommandText = sql;
                    command.Transaction = trn;

                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error executing update with transaction: {Sql}", sql);
                throw;
            }
        }

        public int Update(string sql, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            return Update(sql, objCon, trn);
        }
        #endregion

        #region Insert Methods
        public int Insert(string sql, bool getId)
        {
            try
            {
                using (DbConnection connection = _factory.CreateConnection())
                {
                    connection.ConnectionString = _connectionString;

                    using (DbCommand command = _factory.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = sql;

                        connection.Open();
                        command.ExecuteNonQuery();

                        int id = -1;

                        if (getId)
                        {
                            string identitySelect = GetIdentitySelectQuery();
                            command.CommandText = identitySelect;

                            var result = command.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                id = Convert.ToInt32(result);
                            }
                        }
                        return id;
                    }
                }
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error executing insert: {Sql}", sql);
                throw;
            }
        }

        public int Insert(string sql, bool getId, SqlConnection objCon, SqlTransaction trn)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = objCon;
                    command.CommandText = sql;
                    command.Transaction = trn;

                    command.ExecuteNonQuery();

                    int id = -1;

                    if (getId)
                    {
                        string identitySelect = GetIdentitySelectQuery();
                        command.CommandText = identitySelect;

                        var result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            id = Convert.ToInt32(result);
                        }
                    }
                    return id;
                }
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error executing insert with transaction: {Sql}", sql);
                throw;
            }
        }

        public int Insert(string sql, bool getId, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            return Insert(sql, getId, objCon, trn);
        }

        public void Insert(string sql)
        {
            Insert(sql, false);
        }

        public void Insert(string sql, SqlConnection objCon, SqlTransaction trn)
        {
            Insert(sql, false, objCon, trn);
        }

        public void Insert(string sql, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            Insert(sql, false, objCon, trn);
        }
        #endregion

        #region DataSet Methods
        public DataSet GetDataSet(string sql)
        {
            try
            {
                using (DbConnection connection = _factory.CreateConnection())
                {
                    connection.ConnectionString = _connectionString;
                    connection.Open();

                    using (DbCommand command = _factory.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = sql;

                        using (DbDataAdapter adapter = _factory.CreateDataAdapter())
                        {
                            adapter.SelectCommand = command;

                            DataSet ds = new DataSet();
                            adapter.Fill(ds);

                            return ds;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error getting dataset: {Sql}", sql);
                throw;
            }
        }

        public DataSet GetDataSet_SP(string spName, params SqlParameter[] parameters)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(spName, connection))
                using (var adapter = new SqlDataAdapter(command))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    DataSet ds = new DataSet();
                    connection.Open();
                    adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error executing stored procedure: {SpName}", spName);
                throw;
            }
        }

        public DataSet GetDataSet(string sql, SqlConnection objCon, SqlTransaction trn)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = objCon;
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;
                    command.Transaction = trn;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        return ds;
                    }
                }
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error getting dataset with transaction: {Sql}", sql);
                throw;
            }
        }

        public DataSet GetDataSet(string sql, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            return GetDataSet(sql, objCon, trn);
        }
        #endregion

        #region DataTable Methods
        public DataTable GetDataTable(string sql)
        {
            DataSet ds = GetDataSet(sql);
            return ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable();
        }

        public DataTable GetDataTable(string sql, SqlConnection objCon, SqlTransaction trn)
        {
            DataSet ds = GetDataSet(sql, objCon, trn);
            return ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable();
        }

        public DataTable GetDataTable(string sql, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            return GetDataTable(sql, objCon, trn);
        }
        #endregion

        #region DataRow Methods
        public DataRow GetDataRow(string sql)
        {
            DataTable dt = GetDataTable(sql);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        // FIXED: This was calling GetDataRow recursively - now calls GetDataTable
        public DataRow GetDataRow(string sql, SqlConnection objCon, SqlTransaction trn)
        {
            DataTable dt = GetDataTable(sql, objCon, trn);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public DataRow GetDataRow(string sql, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            return GetDataRow(sql, objCon, trn);
        }
        #endregion

        #region Scalar Methods
        public object GetScalar(string sql)
        {
            try
            {
                using (DbConnection connection = _factory.CreateConnection())
                {
                    connection.ConnectionString = _connectionString;

                    using (DbCommand command = _factory.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = sql;

                        connection.Open();
                        return command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error getting scalar: {Sql}", sql);
                throw;
            }
        }

        public object GetScalar(string sql, SqlConnection objCon, SqlTransaction trn)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = objCon;
                    command.CommandText = sql;
                    command.Transaction = trn;

                    return command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error getting scalar with transaction: {Sql}", sql);
                throw;
            }
        }

        public object GetScalar(string sql, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            return GetScalar(sql, objCon, trn);
        }
        #endregion

        #region Helper Methods
        private string GetIdentitySelectQuery()
        {
            return _dataProvider switch
            {
                "System.Data.OleDb" => "SELECT @@IDENTITY",
                "System.Data.SqlClient" => "SELECT SCOPE_IDENTITY()",
                "System.Data.OracleClient" => "SELECT MySequence.NEXTVAL FROM DUAL",
                _ => "SELECT SCOPE_IDENTITY()"
            };
        }

        public static string Escape(string s)
        {
            if (string.IsNullOrEmpty(s))
                return "NULL";
            else
                return "'" + s.Trim().Replace("'", "''") + "'";
        }

        public static string Escape(string s, int maxLength)
        {
            if (string.IsNullOrEmpty(s))
                return "NULL";
            else
            {
                s = s.Trim();
                if (s.Length > maxLength) s = s.Substring(0, maxLength);
                return "'" + s.Replace("'", "''") + "'";
            }
        }
        #endregion

        #region Delete Method (if needed)
        public int Delete(string sql)
        {
            return Update(sql); // Delete is essentially an update operation
        }

        public int Delete(string sql, SqlConnection objCon, SqlTransaction trn)
        {
            return Update(sql, objCon, trn);
        }

        public int Delete(string sql, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            return Update(sql, objCon, trn);
        }
        #endregion
    }
}