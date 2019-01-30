using System.Web.Http;
using TestBackEndStarCorp.Api.Formatter;

namespace TestBackEndStarCorp.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.RemoveAt(0);
            config.Formatters.Insert(0, new JilFormatter());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}", defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
