using System.Configuration;
using System.Data.SqlClient;

namespace ProyectoVarela.Utilerias
{
    public static class SqlHelper
    {
        public static string GetConnectionString()
        {
            string baseConnectionString = ConfigurationManager.ConnectionStrings["ProyectoVarelaConnectionString"].ConnectionString;

            return baseConnectionString;
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
