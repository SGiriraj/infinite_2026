using System;


namespace FirstAssignmentCSharp
{
    internal class Question1
    {
        public void CheckingEqual(int a, int b)
        {

            if (a == b)
                Console.WriteLine($"{a} and {b} are equal");
            else
                Console.WriteLine($"{a} and {b} are not equal");
        }
    }
}