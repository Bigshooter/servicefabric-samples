﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace WordCount.WebService
{
    using System.Web.Http;

    public static class RouteConfig
    {
        /// <summary>
        /// Routing registration.
        /// </summary>
        /// <param name="routes">The http routes.</param>
        public static void RegisterRoutes(HttpRouteCollection routes)
        {
            routes.MapHttpRoute(
                name: "Default",
                routeTemplate: "{action}",
                defaults: new {controller = "Default", action = "Index"},
                constraints: new {}
                );

            routes.MapHttpRoute(
                name: "AddWord",
                routeTemplate: "AddWord/{word}",
                defaults: new {controller = "Default", action = "AddWord"},
                constraints: new {}
                );

            routes.MapHttpRoute(
                name: "Files",
                routeTemplate: "Files/{name}",
                defaults: new {controller = "File", action = "Get"},
                constraints: new {}
                );
        }
    }
}