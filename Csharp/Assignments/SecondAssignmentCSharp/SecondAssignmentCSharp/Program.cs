using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignmentCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=Convert.ToInt32(Console.ReadLine());

            FirstQuestion.First(number);
            int Daynumber=Convert.ToInt32(Console.ReadLine());
            SecondQuestion.Second(Daynumber);

            
            
            Console.WriteLine("----------Third Question----------");
            int length= Convert.ToInt32(Console.ReadLine());
            int[]arr= new int[length];
            for(int i=0; i<length; i++)
            {
                Console.WriteLine($"Index {i}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            ArrayFirstQuestion.ArrayFirst(arr);

            ArraySecondQuestion.ProcessMarks();

            ArrayThirdQuestion.CopyArrayManual(arr);

            string s= Console.ReadLine(); 






        }
    }
}
