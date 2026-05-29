using System;
using System.Collections.Generic;
using Train_Reservation_System.Database;
using Train_Reservation_System.Events;
using Train_Reservation_System.Exceptions;
using Train_Reservation_System.Models;

namespace Train_Reservation_System
{
    class Program
    {
        static UserDB userDB = new UserDB();

        static int LoggedInUserId;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine
                    ("\n===== TRAIN RESERVATION SYSTEM =====");

                Console.WriteLine("1. Admin Login");
                Console.WriteLine("2. Public Login");
                Console.WriteLine("3. Register");
                Console.WriteLine("4. Exit");

                Console.Write("\nEnter Choice : ");

                int choice =
                    Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Login();
                        break;

                    case 2:
                        Login();
                        break;

                    case 3:
                        Register();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine
                            ("Invalid Choice");
                        break;
                }
            }
        }

        static void Register()
        {
            PublicUser user =
                new PublicUser();

            Console.Write("\nEnter Username : ");

            user.Username =
                Console.ReadLine();

            Console.Write("Enter Password : ");

            user.Password =
                Console.ReadLine();

            bool result =
                userDB.RegisterUser(user);

            if (result)
            {
                Console.WriteLine
                    ("\nRegistration Successful");
            }
            else
            {
                Console.WriteLine
                    ("\nRegistration Failed");
            }
        }

        static void Login()
        {
            Console.Write("\nEnter Username : ");

            string username =
                Console.ReadLine();

            Console.Write("Enter Password : ");

            string password =
                Console.ReadLine();

            string role =
                userDB.Login(username, password);

            if (role != null)
            {
                LoggedInUserId =
                    userDB.GetUserId
                    (
                        username,
                        password
                    );
            }

            if (role == "Admin")
            {
                Console.WriteLine
                    ("\nAdmin Login Successful");

                AdminMenu();
            }
            else if (role == "Public")
            {
                Console.WriteLine
                    ("\nPublic Login Successful");

                PublicMenu();
            }
            else
            {
                Console.WriteLine
                    ("\nInvalid Username or Password");
            }
        }

        static void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine
                    ("\n===== ADMIN MENU =====");

                Console.WriteLine("1. Add Train");
                Console.WriteLine("2. View Trains");
                Console.WriteLine("3. Delete Train");
                Console.WriteLine("4. Logout");

                Console.Write("\nEnter Choice : ");

                int choice =
                    Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTrain();
                        break;

                    case 2:
                        ViewTrains();
                        break;

                    case 3:
                        DeleteTrain();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine
                            ("Invalid Choice");
                        break;
                }
            }
        }

        static void PublicMenu()
        {
            while (true)
            {
                Console.WriteLine
                    ("\n===== PUBLIC USER MENU =====");

                Console.WriteLine("1. View Trains");
                Console.WriteLine("2. Book Ticket");
                Console.WriteLine("3. Cancel Ticket");
                Console.WriteLine("4. Logout");

                Console.Write("\nEnter Choice : ");

                int choice =
                    Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ViewTrains();
                        break;

                    case 2:
                        BookTicket();
                        break;

                    case 3:
                        CancelTicket();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine
                            ("Invalid Choice");
                        break;
                }
            }
        }

        static void AddTrain()
        {
            Console.WriteLine
                ("\n===== ADD TRAIN =====");

            Train train =
                new Train();

            Console.Write
                ("Enter Train Number : ");

            train.TrainNo =
                Convert.ToInt32(Console.ReadLine());

            Console.Write
                ("Enter Train Name : ");

            train.TrainName =
                Console.ReadLine();

            Console.Write
                ("Enter Source Station : ");

            train.SourceStation =
                Console.ReadLine();

            Console.Write
                ("Enter Destination Station : ");

            train.DestinationStation =
                Console.ReadLine();

            Console.Write
                ("Enter 2AC Seats : ");

            train.AC2Seats =
                Convert.ToInt32(Console.ReadLine());

            Console.Write
                ("Enter 3AC Seats : ");

            train.AC3Seats =
                Convert.ToInt32(Console.ReadLine());

            Console.Write
                ("Enter Sleeper Seats : ");

            train.SleeperSeats =
                Convert.ToInt32(Console.ReadLine());

            Console.Write
                ("Enter 2AC Charge : ");

            train.AC2Charge =
                Convert.ToDecimal(Console.ReadLine());

            Console.Write
                ("Enter 3AC Charge : ");

            train.AC3Charge =
                Convert.ToDecimal(Console.ReadLine());

            Console.Write
                ("Enter Sleeper Charge : ");

            train.SleeperCharge =
                Convert.ToDecimal(Console.ReadLine());

            TrainDB trainDB =
                new TrainDB();

            trainDB.AddTrain(train);
        }

        static void DeleteTrain()
        {
            Console.Write
                ("\nEnter Train Number : ");

            int trainNo =
                Convert.ToInt32(Console.ReadLine());

            TrainDB trainDB =
                new TrainDB();

            trainDB.DeleteTrain(trainNo);
        }

        static void ViewTrains()
        {
            TrainDB trainDB =
                new TrainDB();

            trainDB.ViewTrains();
        }

        static void BookTicket()
        {
            Booking booking =
                new Booking();

            booking.UserId =
                LoggedInUserId;

            Console.Write
                ("Enter Train Number : ");

            booking.TrainNo =
                Convert.ToInt32(Console.ReadLine());

            Console.Write
                ("Enter Number Of Passengers (Max 3) : ");

            int passengerCount =
                Convert.ToInt32(Console.ReadLine());

            if (passengerCount <= 0 ||
               passengerCount > 3)
            {
                Console.WriteLine
                    ("\nMaximum 3 Passengers Allowed");

                return;
            }

            booking.Passengers =
                new List<Passenger>();

            TrainDB trainDB =
                new TrainDB();

            decimal totalAmount = 0;

            for (int i = 1;
                i <= passengerCount;
                i++)
            {
                Console.WriteLine
                    ($"\n===== Passenger {i} =====");

                Passenger passenger =
                    new Passenger();

                Console.Write
                    ("Enter Passenger Name : ");

                passenger.PassengerName =
                    Console.ReadLine();

                Console.Write
                    ("Enter Gender : ");

                passenger.Gender =
                    Console.ReadLine();

                Console.Write
                    ("Enter Class (2AC/3AC/Sleeper) : ");

                passenger.TravelClass =
                    Console.ReadLine();

                passenger.IsWomenFriendly =
                    passenger.Gender
                    .Equals
                    (
                        "Female",
                        StringComparison
                        .OrdinalIgnoreCase
                    );

                decimal charge =
                    trainDB.GetTrainCharge
                    (
                        booking.TrainNo,
                        passenger.TravelClass
                    );

                totalAmount += charge;

                booking.Passengers
                    .Add(passenger);

                if (passenger.IsWomenFriendly)
                {
                    Console.WriteLine
                    (
                        "Women Friendly Booking Enabled"
                    );
                }
            }

            booking.Amount =
                totalAmount;

            Console.WriteLine
            (
                $"\nTotal Amount : {booking.Amount}"
            );

            booking.BookDate =
                DateTime.Now;

            Console.Write
                ("Enter Travel Date : ");

            booking.TravelDate =
                Convert.ToDateTime(Console.ReadLine());

            BookingDB bookingDB =
                new BookingDB();

            bookingDB.BookTicket(booking);

            BookingEvents bookingEvent =
                new BookingEvents();

            bookingEvent.OnBookingCompleted +=
                ShowMessage;

            bookingEvent.BookingSuccess();
        }
        static void CancelTicket()
        {
            Console.Write
                ("\nEnter Booking Id : ");

            int bookingId =
                Convert.ToInt32(Console.ReadLine());

            Console.Write
                ("Enter Cancel Ticket Count : ");

            int cancelCount =
                Convert.ToInt32(Console.ReadLine());

            if (cancelCount <= 0 ||
               cancelCount > 3)
            {
                Console.WriteLine
                    ("\nInvalid Cancel Count");

                return;
            }

            CancellationDB cancellationDB =
                new CancellationDB();

            cancellationDB.CancelTicket
            (
                bookingId,
                cancelCount
            );
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine
                ($"\nEVENT : {message}");
        }
    }
}