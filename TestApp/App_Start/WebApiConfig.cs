//-----------------------------------------------------------------------
// <copyright file="WebApiConfig.cs" company="Tecwi">
//     Copyright (c) Tecwi. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//-----------------------------------------------------------------------

namespace TestApp
{
    using System.Web.Http;
    using System.Net.Http.Headers;
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // API Routes
            config.MapHttpAttributeRoutes();
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
               name: "ApiByActionAndId",
               routeTemplate: "api/{controller}/{action}/{id}",
               defaults: new { action = "Get" }
            );
        }
    }
}
