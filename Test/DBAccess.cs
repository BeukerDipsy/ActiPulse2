using System;
using System.Data;
using System.Data.SqlClient;

namespace ActiPulse
{
    class DBAccess
    {
        private static readonly string StrConnString = "Data Source=actipulse.database.windows.net;Initial Catalog=actipulse;Persist Security Info=True;User ID=CloudSAbed32ed5; Password=W8woord!";
        private readonly SqlConnection Connection = new SqlConnection(StrConnString);

        public void OpenConnection()
        {
            try
            {
                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error opening connection.", ex);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (Connection.State != ConnectionState.Closed)
                {
                    Connection.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error closing connection.", ex);
            }
        }

        public int ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                OpenConnection();
                cmd.Connection = Connection;
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error executing query.", ex); // HIER MOET NOG EEN EROOR SCHERM VOOR KOMEN ALS ER 2 usernames hetzelfde zijn
            }
            finally
            {
                CloseConnection();
            }
        }

        public SqlDataReader ExecuteReader(SqlCommand cmd)
        {
            try
            {
                OpenConnection();
                cmd.Connection = Connection;
                return cmd.ExecuteReader(); 
            }
            catch (SqlException ex)
            {
                throw new Exception("Error executing reader.", ex);
            }
        }

        public DataTable ExecuteAdapter(SqlCommand cmd)
        {
            try
            {
                OpenConnection();
                cmd.Connection = Connection;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error executing data adapter.", ex);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}