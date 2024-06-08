using System.Data.SqlClient;

namespace Руководство
{
    internal class Database
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-9F7TNRV\SQLEXPRESS;Initial Catalog=characters;Integrated Security=True");
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}