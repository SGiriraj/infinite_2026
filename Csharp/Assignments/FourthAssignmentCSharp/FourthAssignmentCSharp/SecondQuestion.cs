using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthAssignmentCSharp
{
    internal class SecondQuestion
    {
        public void SwapChars()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            if (str.Length > 1)
            {
                char first = str[0];
                char last = str[str.Length - 1];

                string middle = str.Substring(1, str.Length - 2);

                string result = last + middle + first;

                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Result: " + str);
            }
        }
        }
}
