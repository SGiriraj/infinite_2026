using System;
using System.Data.SqlClient;
using Train_Reservation_System.Models;

namespace Train_Reservation_System.Database
{
    class BookingDB
    {
        public void BookTicket(Booking booking)
        {
            using (SqlConnection con =
                DBHelper.GetConnection())
            {
                con.Open();

                SqlTransaction trans =
                    con.BeginTransaction();

                try
                {
                    string bookingQuery =
                    @"INSERT INTO Bookings
                    (
                        UserId,
                        TrainNo,
                        Amount,
                        BookDate,
                        TravelDate
                    )
                    VALUES
                    (
                        @UserId,
                        @TrainNo,
                        @Amount,
                        @BookDate,
                        @TravelDate
                    );

                    SELECT SCOPE_IDENTITY();";

                    SqlCommand bookingCmd =
                        new SqlCommand
                        (bookingQuery, con, trans);

                    bookingCmd.Parameters.AddWithValue
                        ("@UserId", booking.UserId);

                    bookingCmd.Parameters.AddWithValue
                        ("@TrainNo", booking.TrainNo);

                    bookingCmd.Parameters.AddWithValue
                        ("@Amount", booking.Amount);

                    bookingCmd.Parameters.AddWithValue
                        ("@BookDate", booking.BookDate);

                    bookingCmd.Parameters.AddWithValue
                        ("@TravelDate",
                        booking.TravelDate);

                    int bookingId =
                        Convert.ToInt32
                        (
                            bookingCmd
                            .ExecuteScalar()
                        );

                    foreach (Passenger passenger
                        in booking.Passengers)
                    {
                        string passengerQuery =
                        @"INSERT INTO PassengerDetails
                        (
                            BookingId,
                            PassengerName,
                            Gender,
                            TravelClass,
                            IsWomenFriendly
                        )
                        VALUES
                        (
                            @BookingId,
                            @PassengerName,
                            @Gender,
                            @TravelClass,
                            @IsWomenFriendly
                        )";

                        SqlCommand passengerCmd =
                            new SqlCommand
                            (
                                passengerQuery,
                                con,
                                trans
                            );

                        passengerCmd.Parameters
                            .AddWithValue
                            (
                                "@BookingId",
                                bookingId
                            );

                        passengerCmd.Parameters
                            .AddWithValue
                            (
                                "@PassengerName",
                                passenger.PassengerName
                            );

                        passengerCmd.Parameters
                            .AddWithValue
                            (
                                "@Gender",
                                passenger.Gender
                            );

                        passengerCmd.Parameters
                            .AddWithValue
                            (
                                "@TravelClass",
                                passenger.TravelClass
                            );

                        passengerCmd.Parameters
                            .AddWithValue
                            (
                                "@IsWomenFriendly",
                                passenger.IsWomenFriendly
                            );

                        passengerCmd.ExecuteNonQuery();

                        string updateQuery = "";

                        if (passenger.TravelClass
                            == "2AC")
                        {
                            updateQuery =
                            @"UPDATE Trains
                              SET AC2Seats =
                              AC2Seats - 1
                              WHERE TrainNo=@TrainNo";
                        }
                        else if (passenger
                            .TravelClass == "3AC")
                        {
                            updateQuery =
                            @"UPDATE Trains
                              SET AC3Seats =
                              AC3Seats - 1
                              WHERE TrainNo=@TrainNo";
                        }
                        else
                        {
                            updateQuery =
                            @"UPDATE Trains
                              SET SleeperSeats =
                              SleeperSeats - 1
                              WHERE TrainNo=@TrainNo";
                        }

                        SqlCommand updateCmd =
                            new SqlCommand
                            (
                                updateQuery,
                                con,
                                trans
                            );

                        updateCmd.Parameters
                            .AddWithValue
                            (
                                "@TrainNo",
                                booking.TrainNo
                            );

                        updateCmd.ExecuteNonQuery();
                    }

                    trans.Commit();

                    Console.WriteLine
                    (
                        $"\nBooking Id : {bookingId}"
                    );

                    Console.WriteLine
                    (
                        "\nTicket Booked Successfully"
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