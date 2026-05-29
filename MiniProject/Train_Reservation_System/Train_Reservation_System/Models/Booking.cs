using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Train_Reservation_System.Models
{
    class Booking
    {
        public int BookingId { get; set; }

        public int UserId { get; set; }

        public int TrainNo { get; set; }

        public List<Passenger> Passengers
        {
            get;
            set;
        }

        public decimal Amount { get; set; }

        public DateTime BookDate { get; set; }

        public DateTime TravelDate { get; set; }
    }
}
