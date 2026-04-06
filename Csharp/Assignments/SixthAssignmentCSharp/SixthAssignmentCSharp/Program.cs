using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthAssignmentCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===========First Question======");
            BookShelf shelf = new BookShelf();
            shelf[0] = new Books("Harry Potter", "J.K.Rowling");
            shelf[1] = new Books("The Hobbit", "J.R.R.Tolkien");
            shelf[2] = new Books("1984", "George Orwell");
            shelf[3] = new Books("Pride and Prejudice", "Jane Austen");
            shelf[4] = new Books("The Alchemist", "Paulo Coelho");

            for(int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }
            Console.WriteLine("==========Second Question======");
           
            FileHandler fh = new FileHandler();
            fh.ProcessFile();

            Console.ReadLine();
        }
    }
}
