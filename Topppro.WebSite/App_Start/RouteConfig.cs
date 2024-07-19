using System;
using System.Web.Mvc;
using System.Web.Routing;
using Topppro.Entities;

namespace Topppro.WebSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("");
            routes.IgnoreRoute("world.html");
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "Modules_HiRes", // Route name
            //    url: "{controller}/Modules/HiRes", // URL with parameters
            //    defaults: new { controller = "Processors", action = "Modules_HiRes" } // Parameter defaults
            //);

            routes.MapRoute(
                name: "HiRes", // Route name
                url: "{region}/{culture}/{controller}/{id}/{name}/HiRes", // URL with parameters
                defaults: new { region = Enum.GetName(typeof(Region_Enum), Region_Enum.am), culture = Context.Current.Culture.TwoLetterISOLanguageName, action = "HiRes" }, // Parameter defaults
                constraints: new { region = "[a-zA-Z]{2}", culture = "[a-zA-Z]{2}" }
            );

            routes.MapRoute(
                name: "Software", // Route name
                url: "{region}/{culture}/{controller}/{id}/{name}/Software", // URL with parameters
                defaults: new { region = Enum.GetName(typeof(Region_Enum), Region_Enum.am), culture = Context.Current.Culture.TwoLetterISOLanguageName, action = "Software" }, // Parameter defaults
                constraints: new { region = "[a-zA-Z]{2}", culture = "[a-zA-Z]{2}" }
            );

            routes.MapRoute(
                name: "Detail", // Route name
                url: "{region}/{culture}/{controller}/{id}/{name}", // URL with parameters
                defaults: new { region = Enum.GetName(typeof(Region_Enum), Region_Enum.am), culture = Context.Current.Culture.TwoLetterISOLanguageName, action = "Detail" }, // Parameter defaults
                constraints: new { region = "[a-zA-Z]{2}", culture = "[a-zA-Z]{2}" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{region}/{culture}/{controller}/{action}/{id}",
                defaults: new { region = Enum.GetName(typeof(Region_Enum), Region_Enum.am), culture = Context.Current.Culture.TwoLetterISOLanguageName, controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { region = "[a-zA-Z]{2}", culture = "[a-zA-Z]{2}" }
            );
        }
    }
}