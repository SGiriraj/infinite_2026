using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignmentCSharp
{
    internal class Sales
    {
           protected int SalesNo, ProductNo, Qty;
            protected double Price, TotalAmount;
            protected string DateOfSale;
            public Sales(int salesNo, int productNo, double price, int qty, string date)
            {
                SalesNo = salesNo;
                ProductNo = productNo;
                Price = price;
                Qty = qty;
                DateOfSale = date;
            }
        }
        class SaleDetails : Sales
        {
            public SaleDetails(int salesNo, int productNo, double price, int qty, string date)
                : base(salesNo, productNo, price, qty, date)
            {
            }
            public void Sales()
            {
                TotalAmount = Qty * Price;
            }
            public static void ShowData(SaleDetails s)
            {
                Console.WriteLine("Sales No: " + s.SalesNo);
                Console.WriteLine("Product No: " + s.ProductNo);
                Console.WriteLine("Price: " + s.Price);
                Console.WriteLine("Quantity: " + s.Qty);
                Console.WriteLine("Date: " + s.DateOfSale);
                Console.WriteLine("Total Amount: " + s.TotalAmount);
            }
        }
    
}
