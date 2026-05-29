using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Reservation_System.Events
{
    public delegate void BookingHandler
        (string message);
}