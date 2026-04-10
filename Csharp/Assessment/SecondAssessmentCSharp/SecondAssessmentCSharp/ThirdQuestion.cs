using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssessmentCSharp
{
    internal class ThirdQuestion
    {

        static void CheckNumber(int number)
        {
            if (number < 0)
            {
                throw new Exception("Number cannot be negative.");
            }
            else
            {
                Console.WriteLine("Valid number entered: " + number);
            }
        }


        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter an integer: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    CheckNumber(n);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    break;
                }
            }

        }
    }
    }
