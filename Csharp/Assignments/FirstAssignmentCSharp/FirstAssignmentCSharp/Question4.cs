using System;

namespace FirstAssignmentCSharp
{
    internal class Question4
    {
        public void Table(int num)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");

            }
        }
    }
}