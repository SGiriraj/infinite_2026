using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.SessionState;

namespace FoodOrderManagement
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();

            // Total Visitors
            if (Application["TotalUsers"] == null)
            {
                Application["TotalUsers"] = 1;
            }
            else
            {
                Application["TotalUsers"] =
                    (int)Application["TotalUsers"] + 1;
            }

            // Active Users
            if (Application["ActiveUsers"] == null)
            {
                Application["ActiveUsers"] = 1;
            }
            else
            {
                Application["ActiveUsers"] =
                    (int)Application["ActiveUsers"] + 1;
            }

            Application.UnLock();
        }

        void Session_End(object sender, EventArgs e)
        {
            Application.Lock();

            Application["ActiveUsers"] =
                (int)Application["ActiveUsers"] - 1;

            Application.UnLock();
        }
    }
}