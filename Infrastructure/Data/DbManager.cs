using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Data.Common;

namespace Infrastructure.Data
{
    public class DbManager
    {
       // private static readonly string dataProvider = ConfigurationManager.AppSettings.Get("DataProvider");
       // private static readonly DbProviderFactory factory = DbProviderFactories.GetFactory(dataProvider);
       // private static readonly string connectionString = ConfigurationManager.ConnectionStrings[dataProvider].ConnectionString;

        public static int Update(string sql)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;

                using (DbCommand command = factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sql;

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static int Update(string sql, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = objCon;
            command.CommandText = sql;
            command.Transaction = trn;

            //objCon.Open();
            return command.ExecuteNonQuery();
            //}
            //
        }
        public static int Insert(string sql, bool getId)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;

                using (DbCommand command = factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sql;

                    connection.Open();
                    command.ExecuteNonQuery();

                    int id = -1;

                    // Check if new identity is needed.
                    if (getId)
                    {
                        // Execute db specific autonumber or identity retrieval code
                        // SELECT SCOPE_IDENTITY() -- for SQL Server
                        // SELECT @@IDENTITY -- for MS Access
                        // SELECT MySequence.NEXTVAL FROM DUAL -- for Oracle
                        string identitySelect;
                        switch (dataProvider)
                        {
                            // Access
                            case "System.Data.OleDb":
                                identitySelect = "SELECT @@IDENTITY";
                                break;
                            // Sql Server
                            case "System.Data.SqlClient":
                                //identitySelect = "SELECT SCOPE_IDENTITY()";
                                identitySelect = "SELECT @@IDENTITY";
                                break;
                            // Oracle
                            case "System.Data.OracleClient":
                                identitySelect = "SELECT MySequence.NEXTVAL FROM DUAL";
                                break;
                            default:
                                identitySelect = "SELECT @@IDENTITY";
                                break;
                        }
                        command.CommandText = identitySelect;
                        if (command.ExecuteScalar().ToString() != "")
                        {
                            id = int.Parse(command.ExecuteScalar().ToString());
                        }
                        else
                        {
                            id = 0;
                        }
                    }
                    return id;
                }
            }
        }

        public static int Insert(string sql, bool getId, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            //using (DbConnection connection = factory.CreateConnection())
            //{
            //    connection.ConnectionString = connectionString;

            //    using (DbCommand command = factory.CreateCommand())
            //    {
            SqlCommand command = new SqlCommand();
            command.Connection = objCon;
            command.CommandText = sql;
            command.Transaction = trn;

            command.ExecuteNonQuery();

            int id = -1;

            // Check if new identity is needed.
            if (getId)
            {
                // Execute db specific autonumber or identity retrieval code
                // SELECT SCOPE_IDENTITY() -- for SQL Server
                // SELECT @@IDENTITY -- for MS Access
                // SELECT MySequence.NEXTVAL FROM DUAL -- for Oracle
                string identitySelect;
                switch (dataProvider)
                {
                    // Access
                    case "System.Data.OleDb":
                        identitySelect = "SELECT @@IDENTITY";
                        break;
                    // Sql Server
                    case "System.Data.SqlClient":
                        //identitySelect = "SELECT SCOPE_IDENTITY()";
                        identitySelect = "SELECT @@IDENTITY";
                        break;
                    // Oracle
                    case "System.Data.OracleClient":
                        identitySelect = "SELECT MySequence.NEXTVAL FROM DUAL";
                        break;
                    default:
                        identitySelect = "SELECT @@IDENTITY";
                        break;
                }
                command.CommandText = identitySelect;
                if (command.ExecuteScalar().ToString() != "")
                {
                    id = int.Parse(command.ExecuteScalar().ToString());
                }
                else
                {
                    id = -1;
                }
            }
            return id;
            //    }
            //}
        }
        public static void Insert(string sql)
        {
            Insert(sql, false);
        }

        public static void Insert(string sql, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            Insert(sql, false, ref objCon, ref trn);
        }


        public static DataSet GetDataSet(string spName)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;

                using (DbCommand command = factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    //command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spName;

                    using (DbDataAdapter adapter = factory.CreateDataAdapter())
                    {
                        adapter.SelectCommand = command;

                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        return ds;
                    }
                }
            }
        }

        public static DataSet GetDataSet(string spName, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = objCon;
            command.CommandType = CommandType.Text;
            command.CommandText = spName;
            command.Transaction = trn;

            using (DbDataAdapter adapter = factory.CreateDataAdapter())
            {
                adapter.SelectCommand = command;

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }


        
        public static DataTable GetDataTable(string spName)
        {
            return GetDataSet(spName).Tables[0];
        }

        public static DataTable GetDataTable(string spName, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            return GetDataSet(spName, ref objCon, ref trn).Tables[0];
        }


        public static DataRow GetDataRow(string sql)
        {
            DataRow row = null;

            DataTable dt = GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                row = dt.Rows[0];
            }

            return row;
        }


        public static DataRow GetDataRow(string sql, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            DataRow row = null;

            DataTable dt = GetDataTable(sql, ref objCon, ref trn);
            if (dt.Rows.Count > 0)
            {
                row = dt.Rows[0];
            }

            return row;
        }

        public static object GetScalar(string sql)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;

                using (DbCommand command = factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sql;

                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }

        public static object GetScalar(string sql, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            using (DbCommand command = factory.CreateCommand())
            {
                command.Connection = objCon;
                command.CommandText = sql;

                return command.ExecuteScalar();
            }
        }

        
        public static string Escape(string s)
        {
            if (String.IsNullOrEmpty(s))
                return "NULL";
            else
                return "'" + s.Trim().Replace("'", "''") + "'";
        }

        public static string Escape(string s, int maxLength)
        {
            if (String.IsNullOrEmpty(s))
                return "NULL";
            else
            {
                s = s.Trim();
                if (s.Length > maxLength) s = s.Substring(0, maxLength - 1);
                return "'" + s.Trim().Replace("'", "''") + "'";
            }
        }

    }
}