using System;
using System.Data.SqlClient;

namespace Train_Reservation_System.Database
{
    class CancellationDB
    {
        public void CancelTicket
        (
            int bookingId,
            int cancelCount
        )
        {
            using (SqlConnection con =
                DBHelper.GetConnection())
            {
                con.Open();

                SqlTransaction trans =
                    con.BeginTransaction();

                try
                {
                    string fetchQuery =
                    @"SELECT TrainNo,
                             TravelClass,
                             Amount,
                             TicketCount
                      FROM Bookings
                      WHERE BookingId=@BookingId";

                    SqlCommand fetchCmd =
                        new SqlCommand
                        (fetchQuery, con, trans);

                    fetchCmd.Parameters.AddWithValue
                        ("@BookingId", bookingId);

                    SqlDataReader dr =
                        fetchCmd.ExecuteReader();

                    if (!dr.Read())
                    {
                        Console.WriteLine
                            ("\nInvalid Booking Id");

                        dr.Close();

                        return;
                    }

                    int trainNo =
                        Convert.ToInt32
                        (dr["TrainNo"]);

                    string travelClass =
                        dr["TravelClass"].ToString();

                    decimal amount =
                        Convert.ToDecimal
                        (dr["Amount"]);

                    int bookedTickets =
                        Convert.ToInt32
                        (dr["TicketCount"]);

                    dr.Close();

                    if (cancelCount > bookedTickets)
                    {
                        Console.WriteLine
                        (
                            "\nCancel Count Exceeds Booked Tickets"
                        );

                        return;
                    }

                    decimal refund =
                        (amount * cancelCount) - 25;

                    string cancelQuery =
                    @"INSERT INTO Cancellations
                    VALUES
                    (
                        @BookingId,
                        @CancelDate,
                        @RefundAmount
                    )";

                    SqlCommand cmd1 =
                        new SqlCommand
                        (cancelQuery, con, trans);

                    cmd1.Parameters.AddWithValue
                        ("@BookingId", bookingId);

                    cmd1.Parameters.AddWithValue
                        ("@CancelDate",
                        DateTime.Now);

                    cmd1.Parameters.AddWithValue
                        ("@RefundAmount",
                        refund);

                    cmd1.ExecuteNonQuery();

                    string updateQuery = "";

                    if (travelClass == "2AC")
                    {
                        updateQuery =
                        @"UPDATE Trains
                          SET AC2Seats =
                          AC2Seats + @CancelCount
                          WHERE TrainNo=@TrainNo";
                    }
                    else if (travelClass == "3AC")
                    {
                        updateQuery =
                        @"UPDATE Trains
                          SET AC3Seats =
                          AC3Seats + @CancelCount
                          WHERE TrainNo=@TrainNo";
                    }
                    else
                    {
                        updateQuery =
                        @"UPDATE Trains
                          SET SleeperSeats =
                          SleeperSeats + @CancelCount
                          WHERE TrainNo=@TrainNo";
                    }

                    SqlCommand cmd2 =
                        new SqlCommand
                        (updateQuery, con, trans);

                    cmd2.Parameters.AddWithValue
                        ("@TrainNo", trainNo);

                    cmd2.Parameters.AddWithValue
                        ("@CancelCount", cancelCount);

                    cmd2.ExecuteNonQuery();

                    string bookingUpdateQuery =
                    @"UPDATE Bookings
                      SET TicketCount =
                      TicketCount - @CancelCount
                      WHERE BookingId=@BookingId";

                    SqlCommand cmd3 =
                        new SqlCommand
                        (bookingUpdateQuery, con, trans);

                    cmd3.Parameters.AddWithValue
                        ("@BookingId", bookingId);

                    cmd3.Parameters.AddWithValue
                        ("@CancelCount", cancelCount);

                    cmd3.ExecuteNonQuery();

                    trans.Commit();

                    Console.WriteLine
                    (
                        $"\nRefund Amount : {refund}"
                    );

                    Console.WriteLine
                    (
                        "\nTicket Cancelled Successfully"
                    );
                }
                catch (Exception ex)
                {
                    trans.Rollback();

                    Console.WriteLine
                    (
                        $"\nERROR : {ex.Message}"
                    );
                }
            }
        }
    }
}