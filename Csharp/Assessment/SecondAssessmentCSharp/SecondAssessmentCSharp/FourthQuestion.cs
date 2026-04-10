using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssessmentCSharp
{
    internal class FourthQuestion
    {
        public delegate int CalculatorDelegate(int a, int b);
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int PerformOperation(int a, int b, CalculatorDelegate operation)
        {
            return operation(a, b);
        }

       
        static void Main(string[] args)
        {
            Console.Write("Enter first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n--- Calculator Results ---");
            Console.WriteLine("Addition result: " + PerformOperation(num1, num2, Add));
            Console.WriteLine("Subtraction result: " + PerformOperation(num1, num2, Subtract));
            Console.WriteLine("Multiplication result: " + PerformOperation(num1, num2, Multiply)); ;

            Console.ReadLine();


        }
    }
}
