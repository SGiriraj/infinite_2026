using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignmentCSharp
{
    internal class ArrayThirdQuestion
    {
        public static void CopyArrayManual(int[] source)
        {
            int[] destination = new int[source.Length];

         
            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }

            Console.WriteLine("Elements in the new array:");
            foreach (int item in destination)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
