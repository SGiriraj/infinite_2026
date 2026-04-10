using System;

namespace Seven
{
    public class Class1
    {
        public string CalculateConcession(int age, double totalFare)
        {
            if (age <= 5)
            {
                return "Little Champs - Free Ticket";
            }
            else if (age > 60)
            {
                double discountedFare = totalFare - (totalFare * 0.30);
                return "Senior Citizen - Fare: " + discountedFare;
            }
            else
            {
                return "Ticket Booked - Fare: " + totalFare;
            }
        }
    }
}