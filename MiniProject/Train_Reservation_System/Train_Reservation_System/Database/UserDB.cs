using System;
using System.Data.SqlClient;
using Train_Reservation_System.Models;

namespace Train_Reservation_System.Database
{
    class UserDB
    {
        public bool RegisterUser(PublicUser user)
        {
            using (SqlConnection con =
                DBHelper.GetConnection())
            {
                string query =
                @"INSERT INTO Users
                VALUES(@Username,@Password,'Public')";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue
                    ("@Username", user.Username);

                cmd.Parameters.AddWithValue
                    ("@Password", user.Password);

                con.Open();

                int rows =
                    cmd.ExecuteNonQuery();

                return rows > 0;
            }
        }

        public string Login
            (string username, string password)
        {
            using (SqlConnection con =
                DBHelper.GetConnection())
            {
                string query =
                @"SELECT UserType
                  FROM Users
                  WHERE Username=@Username
                  AND Password=@Password";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue
                    ("@Username", username);

                cmd.Parameters.AddWithValue
                    ("@Password", password);

                con.Open();

                object result =
                    cmd.ExecuteScalar();

                return result?.ToString();
            }
        }

        public int GetUserId
            (string username, string password)
        {
            using (SqlConnection con =
                DBHelper.GetConnection())
            {
                string query =
                @"SELECT UserId
                  FROM Users
                  WHERE Username=@Username
                  AND Password=@Password";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue
                    ("@Username", username);

                cmd.Parameters.AddWithValue
                    ("@Password", password);

                con.Open();

                return Convert.ToInt32
                    (cmd.ExecuteScalar());
            }
        }
    }
}