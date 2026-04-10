using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhAssignmentCSharp
{
    public class FirstQuestion
    {
        public static void First()
        {
            List<int> numbers = new List<int>();

            Console.Write("Enter how many numbers: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the numbers:");

            for (int i = 0; i < n; i++)
            {
                numbers.Add(Convert.ToInt32((Console.ReadLine())));
            }

            var result = numbers
                         .Select(x => new { Number = x, Square = x * x })
                         .Where(x => x.Square > 20);

            Console.WriteLine("Output:");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Number} - {item.Square}");
            }
        }
       
    }
}
