using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Reservation_System.Models
{
    class Passenger
    {
        public string PassengerName
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }

        public string TravelClass
        {
            get;
            set;
        }

        public bool IsWomenFriendly
        {
            get;
            set;
        }
    }
}