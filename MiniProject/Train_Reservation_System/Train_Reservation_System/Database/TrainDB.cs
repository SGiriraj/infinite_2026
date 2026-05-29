using System;
using System.Data.SqlClient;
using Train_Reservation_System.Models;

namespace Train_Reservation_System.Database
{
    class TrainDB
    {
        public void ViewTrains()
        {
            using (SqlConnection con =
                DBHelper.GetConnection())
            {
                string query =
                @"SELECT *
                  FROM Trains
                  WHERE IsDeleted = 0";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                con.Open();

                SqlDataReader dr =
                    cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine
                    (
                        $"\nTrain No : {dr["TrainNo"]}" +
                        $"\nTrain Name : {dr["TrainName"]}" +
                        $"\nSource : {dr["SourceStation"]}" +
                        $"\nDestination : {dr["DestinationStation"]}" +
                        $"\n2AC Seats : {dr["AC2Seats"]}" +
                        $"\n3AC Seats : {dr["AC3Seats"]}" +
                        $"\nSleeper Seats : {dr["SleeperSeats"]}" +
                        $"\n2AC Charge : {dr["AC2Charge"]}" +
                        $"\n3AC Charge : {dr["AC3Charge"]}" +
                        $"\nSleeper Charge : {dr["SleeperCharge"]}"
                    );
                }
            }
        }

        public void AddTrain(Train train)
        {
            using (SqlConnection con =
                DBHelper.GetConnection())
            {
                string query =
                @"INSERT INTO Trains
                VALUES
                (
                    @TrainNo,
                    @TrainName,
                    @SourceStation,
                    @DestinationStation,
                    @AC2Seats,
                    @AC3Seats,
                    @SleeperSeats,
                    @AC2Charge,
                    @AC3Charge,
                    @SleeperCharge,
                    0
                )";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue
                    ("@TrainNo", train.TrainNo);

                cmd.Parameters.AddWithValue
                    ("@TrainName", train.TrainName);

                cmd.Parameters.AddWithValue
                    ("@SourceStation",
                    train.SourceStation);

                cmd.Parameters.AddWithValue
                    ("@DestinationStation",
                    train.DestinationStation);

                cmd.Parameters.AddWithValue
                    ("@AC2Seats",
                    train.AC2Seats);

                cmd.Parameters.AddWithValue
                    ("@AC3Seats",
                    train.AC3Seats);

                cmd.Parameters.AddWithValue
                    ("@SleeperSeats",
                    train.SleeperSeats);

                cmd.Parameters.AddWithValue
                    ("@AC2Charge",
                    train.AC2Charge);

                cmd.Parameters.AddWithValue
                    ("@AC3Charge",
                    train.AC3Charge);

                cmd.Parameters.AddWithValue
                    ("@SleeperCharge",
                    train.SleeperCharge);

                con.Open();

                cmd.ExecuteNonQuery();

                Console.WriteLine
                    ("\nTrain Added Successfully");
            }
        }

        public void DeleteTrain(int trainNo)
        {
            using (SqlConnection con =
                DBHelper.GetConnection())
            {
                string query =
                @"UPDATE Trains
                  SET IsDeleted = 1
                  WHERE TrainNo=@TrainNo";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue
                    ("@TrainNo", trainNo);

                con.Open();

                int rows =
                    cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    Console.WriteLine
                        ("\nTrain Deleted Successfully");
                }
                else
                {
                    Console.WriteLine
                        ("\nTrain Not Found");
                }
            }
        }

        public decimal GetTrainCharge
            (int trainNo, string travelClass)
        {
            using (SqlConnection con =
                DBHelper.GetConnection())
            {
                string query = "";

                if (travelClass == "2AC")
                {
                    query =
                    @"SELECT AC2Charge
                      FROM Trains
                      WHERE TrainNo=@TrainNo";
                }
                else if (travelClass == "3AC")
                {
                    query =
                    @"SELECT AC3Charge
                      FROM Trains
                      WHERE TrainNo=@TrainNo";
                }
                else
                {
                    query =
                    @"SELECT SleeperCharge
                      FROM Trains
                      WHERE TrainNo=@TrainNo";
                }

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue
                    ("@TrainNo", trainNo);

                con.Open();

                return Convert.ToDecimal
                    (cmd.ExecuteScalar());
            }
        }
    }
}