using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Reservation_System.Models
{
    class Train
    {
        public int TrainNo { get; set; }

        public string TrainName { get; set; }

        public string SourceStation { get; set; }

        public string DestinationStation { get; set; }

        public int AC2Seats { get; set; }

        public int AC3Seats { get; set; }

        public int SleeperSeats { get; set; }

        public decimal AC2Charge { get; set; }

        public decimal AC3Charge { get; set; }

        public decimal SleeperCharge { get; set; }

        public bool IsDeleted { get; set; }
    }
}