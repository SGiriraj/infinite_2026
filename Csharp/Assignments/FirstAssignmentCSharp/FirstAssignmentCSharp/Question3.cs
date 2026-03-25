using System;

namespace FirstAssignmentCSharp
{
    internal class Question3
    {
        public int Calulator(int i, int j, char operation)
        {
            switch (operation)
            {
                case '+': return i + j;
                case '-': return i - j;
                case '*': return i * j;
                case '/': return j != 0 ? i / j : 0;
                default:
                    Console.WriteLine("Invalid Operation");
                    return 0;
            }
        }
    }

}