using System.Configuration;
using System.Data.SqlClient;

namespace ProyectoVarela.Utilerias
{
    public static class SqlHelper
    {
        public static string userName;
        public static string password;
        public static string GetConnectionString()
        {
            string baseConnectionString = ConfigurationManager.ConnectionStrings["ProyectoVarelaConnectionString"].ConnectionString;
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder(baseConnectionString);

            connectionStringBuilder.UserID = userName;
            connectionStringBuilder.Password = password;

            return connectionStringBuilder.ToString();
        }

        //public static string GetConnectionString()
        //{
        //    string connectionString = ConfigurationManager
        //        .ConnectionStrings["ProyectoVarelaConnectionString"]
        //        .ConnectionString;

        //    return connectionString;
        //}
    }
}
