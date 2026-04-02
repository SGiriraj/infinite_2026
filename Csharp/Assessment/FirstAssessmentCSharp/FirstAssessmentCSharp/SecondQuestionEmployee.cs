using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAssessmentCSharp
{
    struct DateOfBirth
    {
        public int day;
        public int month;
        public int year;
    }

    struct Employ
    {
        public string name;
        public DateOfBirth dob;
    }
    internal class SecondQuestionEmployee
    {
        public static void Run()
        {
            Console.Write("Enter number of employees: ");
            int number_Of_Employee = Convert.ToInt32(Console.ReadLine());
            Employ[] emp = new Employ[number_Of_Employee];

            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine($"Enter details for Employee {i + 1}");

                Console.Write("Name of the employee: ");
                emp[i].name = Console.ReadLine();

                Console.Write("Input day of the birth: ");
                emp[i].dob.day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input month of the birth: ");
                emp[i].dob.month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input year for the birth: ");
                emp[i].dob.year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("\n--- Employee Details ---");

            foreach (Employ e in emp)
            {
                Console.WriteLine($"Name: {e.name}");
                Console.WriteLine($"DOB: {e.dob.day}/{e.dob.month}/{e.dob.year}");
                Console.WriteLine();
            }
        }
    }
}
