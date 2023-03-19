using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102210219_PhanThanhNgan_De02
{
    public class DataProvider
    {
        private static DataProvider _Instance;
        public static DataProvider Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DataProvider();
                return _Instance;
            }
        }
        private static string connectionString = @"Data Source=THANHNGAN13\SQLEXPRESS;Initial Catalog=DE_02;Integrated Security=True";
        private SqlConnection _connection = new SqlConnection(connectionString);

        public DataTable GetRecord(string query)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally { cnn.Close(); }
            return dt;
        }

        public bool ExecuteQuery(string query)
        {
            try
            {
                _connection.Open();
                SqlCommand cmd = new SqlCommand(query, _connection);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex) { }
            finally { _connection.Close(); }
            return false;
        }
    }
}
