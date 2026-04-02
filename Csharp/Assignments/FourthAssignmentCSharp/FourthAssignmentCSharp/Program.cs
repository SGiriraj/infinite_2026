using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthAssignmentCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstQuestion q1 = new FirstQuestion();
            SecondQuestion q2 = new SecondQuestion();
            ThirdQuestion q3 = new ThirdQuestion();

            Console.WriteLine("---- Question 1 ----");
            q1.RemoveChar();

            Console.WriteLine("\n---- Question 2 ----");
            q2.SwapChars();

            Console.WriteLine("\n---- Question 3 ----");
            q3.SortStack();
        }
    }
}
