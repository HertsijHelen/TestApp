//-----------------------------------------------------------------------
// <copyright file="BundleConfig.cs" company="Tecwi">
// Copyright (c) Tecwi. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//-------------------------------------------------------------------
namespace TestApp
{
    using System.Web.Optimization;
    
    /// <summary>
    /// Configuration of Bundles
    /// </summary>
    public class BundleConfig
    {      
        /// <summary>
        /// register bundles
        /// </summary>
        /// <param name="bundles">Register BundlesCollection</param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/libraries/angular.js",
                        "~/Scripts/libraries/angular-animate.js",
                        "~/Scripts/libraries/angular-sanitize.js",
                        "~/Scripts/libraries/ui-bootstrap-tpls-2.5.0.js"));

            bundles.Add(new ScriptBundle("~/bundles/myScripts").Include(
                       "~/Scripts/angular.js",
                       "~/Scripts/factory.js",
                       "~/Scripts/controller.js",
                       "~/Scripts/filter.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css"));
        }
    }
}
