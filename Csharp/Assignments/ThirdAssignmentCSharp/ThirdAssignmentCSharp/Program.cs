using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignmentCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount s = new SavingsAccount("Jeevan", "D", 5000, 10000);
            s.ProcessTransaction();
            s.ShowData();

            CurrentAccount c = new CurrentAccount("Arun", "W", 2000, 15000);
            c.ProcessTransaction();
            c.ShowData();

            Result s1= new Result(101, "Jeevan", "BCA", 4, "CS");

            s1.ShowData();      // base class
            s1.GetMarks();      // derived
            s1.DisplayResult();



            SaleDetails obj = new SaleDetails(101, 5001, 100.5, 2, "31-03-2026");

            obj.Sales();  

            SaleDetails.ShowData(obj);
        }
    }
}
