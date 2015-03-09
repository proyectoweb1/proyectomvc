using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace proyectoWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Producto",
                url: "Producto",
                defaults: new { controller = "Producto", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "transacciones",
               url: "transacciones",
               defaults: new { controller = "Transaccion", action = "Index", id = UrlParameter.Optional }
           );
          
           routes.MapRoute(
              name: "buscar",
              url: "buscar",
              defaults: new { controller = "Producto", action = "Search", id = UrlParameter.Optional }
          );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Productos", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
