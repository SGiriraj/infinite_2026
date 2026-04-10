using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignmentCSharp
{
    internal class ArraySecondQuestion
    {
        public static void ProcessMarks()
        {
            int[] marks = new int[10];

            Console.WriteLine("Enter 10 marks:");
            for (int i = 0; i < 10; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = marks.Sum();
            double average = marks.Average();
            int min = marks.Min();
            int max = marks.Max();

            Console.WriteLine($"\nTotal: {total}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Minimum marks: {min}");
            Console.WriteLine($"Maximum marks: {max}");

            Array.Sort(marks);
            Console.WriteLine("Ascending order: " + string.Join(", ", marks));

            Array.Reverse(marks); 
            Console.WriteLine("Descending order: " + string.Join(", ", marks));
        }
    }
}
