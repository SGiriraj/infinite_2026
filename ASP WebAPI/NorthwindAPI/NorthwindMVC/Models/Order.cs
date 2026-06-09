using System;

namespace NorthwindMVC.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public Nullable<int> EmployeeID { get; set; }
    }
}