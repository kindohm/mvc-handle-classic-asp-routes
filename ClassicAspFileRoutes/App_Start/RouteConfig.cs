using System.Web.Mvc;
using System.Web.Routing;

namespace ClassicAspFileRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Classic",
                url: "Path/To/classic.asp",
                defaults: new { controller = "Home", action = "Results" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Search", id = UrlParameter.Optional }
            );
        }
    }
}