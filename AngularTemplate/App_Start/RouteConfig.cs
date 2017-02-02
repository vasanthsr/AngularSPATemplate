// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="Microsoft">
//   Copyright © 2017 Microsoft
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.AngularTemplate
{
    using System.Web.Routing;

    using App.AngularTemplate.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Add("Default", new DefaultRoute());
        }
    }
}
