using Newtonsoft.Json;
using System.Web.Http;

namespace NorthwindAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // FIX FOR SELF REFERENCING LOOP
            config.Formatters.JsonFormatter.SerializerSettings
                  .ReferenceLoopHandling =
                  ReferenceLoopHandling.Ignore;
        }
    }
}