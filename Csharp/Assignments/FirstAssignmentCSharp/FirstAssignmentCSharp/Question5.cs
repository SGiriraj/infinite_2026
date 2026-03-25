using System;

namespace FirstAssignmentCSharp
{
    internal class Question5
    {
       public int SumOrTriple(int x, int y)
        {

            if (x == y)
            {
                return 3 * (x + y);
            }
            else
            {
                return x + y;


            }
        }
    }
}
