using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthAssignmentCSharp
{
    internal class ThirdQuestion
    {
        public void SortStack()
        {
            Stack<int> stack = new Stack<int>();

            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                stack.Push(int.Parse(Console.ReadLine()));
            }

            int[] arr = stack.ToArray();
            Array.Sort(arr);
            Array.Reverse(arr);

            Stack<int> sortedStack = new Stack<int>();

            foreach (int item in arr)
            {
                sortedStack.Push(item);
            }

            Console.WriteLine("Sorted Stack (Descending):");
            foreach (int item in sortedStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
