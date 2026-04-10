using System;

namespace SecondAssessmentCSharp
{
    internal class FirstQuestion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Type (UG / G): ");
            string type = Console.ReadLine().ToUpper();

            Student student;

            if (type == "UG")
            {
                student = new UnderGraduate();
            }
            else if (type == "G")
            {
                student = new Graduate();
            }
            else
            {
                Console.WriteLine("Invalid Student Type");
                return;
            }

            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Student ID: ");
            student.StudentId = Console.ReadLine();

            Console.Write("Enter Grade: ");
            student.Grade = float.Parse(Console.ReadLine());

            bool passed = student.IsPassed(student.Grade);

            Console.WriteLine("\n----- RESULT -----");
            Console.WriteLine($"Name       : {student.Name}");
            Console.WriteLine($"Student ID : {student.StudentId}");
            Console.WriteLine($"Grade      : {student.Grade}");
            Console.WriteLine($"Status     : {(passed ? "PASSED" : "FAILED ")}");

            Console.ReadLine();
        }
    }
}