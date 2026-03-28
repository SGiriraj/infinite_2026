using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignmentCSharp
{
    internal class StringQuestions
    {
        public static void String_Word_Length(string str)
        {
            Console.WriteLine(str.Length);
        }
        public static void String_Word_Reverse(string str)
        {
            char[] charArray = str.ToCharArray();

            Array.Reverse(charArray);

            string reversed = new string(charArray);
            
            Console.WriteLine(reversed);
        }

    }
}
