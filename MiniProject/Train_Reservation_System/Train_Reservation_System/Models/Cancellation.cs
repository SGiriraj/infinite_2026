using System;

namespace Train_Reservation_System.Models
{
    class Cancellation
    {
        public int CancellationId { get; set; }

        public int BookingId { get; set; }

        public DateTime CancelDate { get; set; }

        public decimal RefundAmount { get; set; }
    }
}