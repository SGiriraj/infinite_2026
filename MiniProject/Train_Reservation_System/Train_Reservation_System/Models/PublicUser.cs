using System;


namespace Train_Reservation_System.Models
{
    class PublicUser : User
    {
        public override void ShowMenu()
        {
            Console.WriteLine("PUBLIC USER MENU");
        }
    }
}
