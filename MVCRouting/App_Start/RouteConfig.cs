using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "fr_inventory",
                url: "fr/inventory/{action}",
                defaults: new { controller = "Inventory", action = "Index" }
                );

            routes.MapRoute(
                name: "es_inventory",
                url: "es/inventory",
                defaults: new { controller = "Inventory", action = "Index" }
                );

            routes.MapRoute(
                name: "inventory_search",
                url: "inventory/Search",
                defaults: new { controller = "Inventory", action = "Search" }
                );

            routes.MapRoute(
                name: "fr_inventory_search",
                url: "fr/inventory/Search",
                defaults: new { controller = "Inventory", action = "Search" }
                );

            routes.MapRoute(
                name: "inventory",
                url: "inventory/{action}",
                defaults: new { controller = "Inventory", action = "Index" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}
