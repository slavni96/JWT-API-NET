using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApi.JWT_Framework
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Servizi e configurazione dell'API Web
            config.Filters.Add(new AuthorizeAttribute());

            // Route dell'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
