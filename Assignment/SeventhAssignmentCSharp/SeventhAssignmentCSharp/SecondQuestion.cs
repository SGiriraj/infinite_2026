using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeventhAssignmentCSharp
{
    internal class SecondQuestion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Second Question");

            Console.Write("Enter number of words: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] words = new string[n];

            Console.WriteLine("Enter the words:");

            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }

            var result = words
                .Where(word => word.StartsWith("a", StringComparison.OrdinalIgnoreCase)
                            && word.EndsWith("m", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Output:");

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}
