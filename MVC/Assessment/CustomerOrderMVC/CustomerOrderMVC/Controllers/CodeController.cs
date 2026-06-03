using System.Linq;
using System.Web.Mvc;
using CustomerOrderMVC.Models;

namespace CustomerOrderMVC.Controllers
{
    public class CodeController : Controller
    {
        masterEntities1 db = new masterEntities1();

        public ActionResult GermanyCustomers()
        {
            var result = db.Customers
                           .Where(c => c.Country == "Germany")
                           .ToList();

            return View(result);
        }

        public ActionResult OrderDetails()
        {
            var result = db.Orders
                           .Where(o => o.OrderID == 10248)
                           .ToList();

            return View(result);
        }
    }
}