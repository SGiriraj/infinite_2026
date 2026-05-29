using System;


namespace Train_Reservation_System.Models
{
    class Admin : User
    {
        public override void ShowMenu()
        {
            Console.WriteLine("ADMIN MENU");
        }
    }
}
