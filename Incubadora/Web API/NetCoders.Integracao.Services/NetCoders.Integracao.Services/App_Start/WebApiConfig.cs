using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NetCoders.Integracao.Services
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            
            //Iremos avisar o IIS (Servidor) que liberamos
            //E habilitamos as chamadas externas.
            config.EnableCors();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
