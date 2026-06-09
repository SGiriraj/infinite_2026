using NorthwindAPI.Models;

using System.Linq;
using System.Web.Http;

namespace NorthwindAPI.Controllers
{
    public class OrdersController : ApiController
    {
        masterEntities1 db = new masterEntities1();

        [HttpGet]
        public IHttpActionResult Get()
        {
            var orders = db.Orders
                           .Where(x => x.EmployeeID == 5)
                           .Select(x => new
                           {
                               x.OrderID,
                               x.EmployeeID,
                               x.CustomerID,
                               x.OrderDate
                           })
                           .ToList();

            return Ok(orders);
        }
    }
}