using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthAssignmentCSharp
{
    internal class IndexersAndComposition
    {
        static void Main()
        {
            BookShelf shelf = new BookShelf();

          
            shelf[0] = new Books("The Alchemist", "Paulo Coelho");
            shelf[1] = new Books("Wings of Fire", "A.P.J Abdul Kalam");
            shelf[2] = new Books("Rich Dad Poor Dad", "Robert Kiyosaki");
            shelf[3] = new Books("Atomic Habits", "James Clear");
            shelf[4] = new Books("Ikigai", "Hector Garcia");

       
            shelf.DisplayAll();
        }
    }
}
