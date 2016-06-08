﻿using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleWebStore.WebUI
{
    public class RouteConfig
    {

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: null,
               url: "",
               defaults: new { Controller = "Product", action = "List", category = (string)null, page = 1 }
             );

            routes.MapRoute(
                null,
                "Page{page}",
                new { Controller = "Product", action = "List", category = (string)null },
                new { page = @"\d+" }
                );

            routes.MapRoute(
                null,
                "{category}",
                new { Controller = "Product", action = "List", page = 1 }
                );

            routes.MapRoute(
                null,
                "categroy/Page{page}",
                new { Controller = "Product", action = "List" },
                new { page = @"\d+" }
                );

            routes.MapRoute(
                null,
                "{Controller}/{Action}"
                );

            //routes.MapRoute(
            //    name: null,
            //    url: "Page{page}",
            //    defaults: new { Controller = "Product", action = "List" }
            //    );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Product", action = "List", id = UrlParameter.Optional }
            //    );
        }
    }
}
