using System;

namespace Train_Reservation_System.Events
{
    internal class BookingEvents
    {
        public event BookingHandler
            OnBookingCompleted;

        public void BookingSuccess()
        {
            if (OnBookingCompleted != null)
            {
                OnBookingCompleted
                (
                    "Ticket Booked Successfully"
                );
            }
        }
    }
}