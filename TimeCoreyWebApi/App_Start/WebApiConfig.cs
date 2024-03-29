﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TimeCoreyWebApi
{
    /// <summary>
    /// WebApi config file
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registers the routes 
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

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
