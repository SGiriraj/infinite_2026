using System;

namespace SecondAssignmentCSharp
{
    public class SecondQuestion
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        public static void Second(int n)
        {
            
            foreach (Days day in Enum.GetValues(typeof(Days)))
            {
                if ((int)day == n)
                {
                    Console.WriteLine($"Day {n} is {day}");
                    return; 
                }
            }


            Console.WriteLine("Invalid day number. Please enter 0-6.");
        }
    }
}