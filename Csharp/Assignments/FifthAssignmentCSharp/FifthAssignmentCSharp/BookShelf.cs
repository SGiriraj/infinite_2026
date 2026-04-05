using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthAssignmentCSharp
{


    public class BookShelf
    {
        private Books[] bookArray = new Books[5]; // store 5 books

        // Indexer
        public Books this[int index]
        {
            get
            {
                if (index >= 0 && index < bookArray.Length)
                    return bookArray[index];
                else
                    throw new IndexOutOfRangeException("Invalid Index");
            }
            set
            {
                if (index >= 0 && index < bookArray.Length)
                    bookArray[index] = value;
                else
                    throw new IndexOutOfRangeException("Invalid Index");
            }
        }
        public void DisplayAll()
        {
            foreach (Books book in bookArray)
            {
                if (book != null)
                    book.Display();
            }
        }
    }
}
