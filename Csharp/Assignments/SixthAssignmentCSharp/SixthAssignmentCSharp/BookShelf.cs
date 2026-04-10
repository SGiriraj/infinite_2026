using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthAssignmentCSharp
{
    internal class BookShelf
    {
        private Books[] bookList = new Books[5];


        public Books this[int index]
        {
            get {  return bookList[index]; }
            set { bookList[index] = value; }
        }
    }
}
