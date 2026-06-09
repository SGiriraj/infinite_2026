using NorthwindMVC.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;

namespace NorthwindMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<Order> orders = null;

            using (var client = new HttpClient())
            {
                // API URL
                client.BaseAddress =
                    new Uri("https://localhost:44322/");

                // Calling API
                var responseTask =
                    client.GetAsync("api/orders");

                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask =
                        result.Content.ReadAsAsync<IList<Order>>();

                    readTask.Wait();

                    orders = readTask.Result;
                }
                else
                {
                    orders = new List<Order>();

                    ModelState.AddModelError(
                        string.Empty,
                        "Server Error");
                }
            }

            return View(orders);
        }
    }
}