using System;

namespace Train_Reservation_System.Services
{
    internal class CancellationService
    {
        public decimal CalculateRefund(decimal amount)
        {
            decimal refund = amount - 25;

            return refund;
        }

        public void ShowRefund(decimal refund)
        {
            Console.WriteLine($"\nRefund Amount : {refund}");
        }
    }
}