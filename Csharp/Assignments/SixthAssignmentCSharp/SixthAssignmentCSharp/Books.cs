using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthAssignmentCSharp
{
    internal class Books
    {
        public string BookName;
        public string AuthorName;


        public Books(string bookName,string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine("Book Name: " + BookName);
            Console.WriteLine("Author Name: " + AuthorName);
            Console.WriteLine("--------------------------");

        }
    }
}
