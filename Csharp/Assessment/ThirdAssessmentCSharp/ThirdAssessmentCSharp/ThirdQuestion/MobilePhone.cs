using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssessmentCSharp.ThirdQuestion
{
    public class MobilePhone
    {
        public delegate void RingEventHandler();

       
        public event RingEventHandler OnRing;

       
        public void ReceiveCall()
        {
            Console.WriteLine("Incoming call...\n");

            
            OnRing?.Invoke();
        }
    }
}
