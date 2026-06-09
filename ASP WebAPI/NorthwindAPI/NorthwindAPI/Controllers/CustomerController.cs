using NorthwindAPI.Models;
using System;
using System.Web.Http;

namespace NorthwindAPI.Controllers
{
    public class CustomersController : ApiController
    {
        masterEntities1 db = new masterEntities1();

        // GET api/customers?country=USA
        [HttpGet]
        public IHttpActionResult Get(string country)
        {
            var customers = db.GetCustomersByCountry(country);

            return Ok(customers);
        }
    }
}