using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data
{
    public class DbHelper
    {
        private readonly string _connectionString;

        public DbHelper(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        public SqlConnection GetConnection() => new SqlConnection(_connectionString);

        public string ExecuteScalarString(string commandText)
        {
            using var con = GetConnection();
            using var cmd = new SqlCommand(commandText, con);
            con.Open();
            return Convert.ToString(cmd.ExecuteScalar());
        }

        public long ExecuteScalarLong(string commandText)
        {
            using var con = GetConnection();
            using var cmd = new SqlCommand(commandText, con);
            con.Open();
            return Convert.ToInt64(cmd.ExecuteScalar());
        }

        public DataTable ExecuteDataTable(string commandText)
        {
            using var con = GetConnection();
            using var cmd = new SqlCommand(commandText, con);
            using var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataSet ExecuteDataSet(string commandText)
        {
            using var con = GetConnection();
            using var cmd = new SqlCommand(commandText, con);
            using var adapter = new SqlDataAdapter(cmd);
            var ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        public void ExecuteNonQuery(string commandText)
        {
            using var con = GetConnection();
            using var cmd = new SqlCommand(commandText, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
