using System.Configuration;
using System.Data.SqlClient;

namespace FoodOrderManagement
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            string cs = ConfigurationManager
                .ConnectionStrings["FoodDBCS"]
                .ConnectionString;

            return new SqlConnection(cs);
        }
    }
}