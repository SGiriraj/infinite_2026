using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdAssessmentCSharp.FirstQuestion;
using ThirdAssessmentCSharp.SecondQuestion;
using ThirdAssessmentCSharp.ThirdQuestion;

namespace ThirdAssessmentCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CricketTeam obj1= new CricketTeam();
            //obj1.Pointscalculation(10);
            //FileHandling obj2 = new FileHandling();
            //obj2.Write();
            MobilePhone phone = new MobilePhone();

            RingtonePlayer ringtone = new RingtonePlayer();
            ScreenDisplay screen = new ScreenDisplay();
            VibrationMotor vibration = new VibrationMotor();

            phone.OnRing += ringtone.PlayRingtone;
            phone.OnRing += screen.ShowCallerInfo;
            phone.OnRing += vibration.Vibrate;


            phone.ReceiveCall();
        }
    }
}
