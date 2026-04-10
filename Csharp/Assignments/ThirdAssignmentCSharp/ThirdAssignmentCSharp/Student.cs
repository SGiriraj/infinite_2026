using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignmentCSharp
{
    internal class Student
    {
        public int rollno, semester;
        public string name, className, branch;

        public Student(int r, string n, string c, int sem, string b)
        {
            rollno = r;
            name = n;
            className = c;
            semester = sem;
            branch = b;
        }
        public void ShowData()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Roll No: " + rollno);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Class: " + className);
            Console.WriteLine("Semester: " + semester);
            Console.WriteLine("Branch: " + branch);
        }




    }
    internal class Result : Student
    {
        public int[] marks = new int[5];

        public Result(int r, string n, string c, int sem, string b)
            : base(r, n, c, sem, b)
        {
        }

        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Subject " + (i + 1) + ": ");
                marks[i] = int.Parse(Console.ReadLine());
            }
        }

        public void DisplayResult()
        {
            int total = 0;
            bool isFail = false;

            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {
                    isFail = true;
                }
                total += marks[i];
            }

            float avg = total / 5.0f;

            Console.WriteLine("\nAverage Marks: " + avg);

            if (isFail)
            {
                Console.WriteLine("Result: FAILED (Marks < 35)");
            }
            else if (avg < 50)
            {
                Console.WriteLine("Result: FAILED (Average < 50)");
            }
            else
            {
                Console.WriteLine("Result: PASSED");
            }
        }
    } 
}
