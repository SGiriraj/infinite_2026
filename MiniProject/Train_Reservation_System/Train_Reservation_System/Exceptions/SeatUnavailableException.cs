using System;

namespace Train_Reservation_System.Exceptions
{
    internal class SeatNotAvailableException
        : Exception
    {
        public SeatNotAvailableException
            (string message)
            : base(message)
        {

        }
    }
}