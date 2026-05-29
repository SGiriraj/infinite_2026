using System.Configuration;
using System.Data.SqlClient;

namespace Train_Reservation_System.Database
{
    sealed class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            string conStr = ConfigurationManager
                .ConnectionStrings["TrainDBConnection"]
                .ConnectionString;

            return new SqlConnection(conStr);
        }
    }
}