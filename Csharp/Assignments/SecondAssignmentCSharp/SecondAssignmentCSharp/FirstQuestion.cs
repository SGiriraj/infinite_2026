using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignmentCSharp
{
    public  class FirstQuestion
    {
        public static void First(int n)
        {
            int row = 4;
            int column = 4;

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= column; j++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(n + " ");
                    }
                    else
                    {
                        Console.Write(n + "");

                    }



                }
                Console.WriteLine();
            }
        }
    }
}
