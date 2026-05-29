using System;

namespace Train_Reservation_System.Exceptions
{
    internal class PassengerLimitExceededException
        : Exception
    {
        public PassengerLimitExceededException
            (string message)
            : base(message)
        {

        }
    }
}