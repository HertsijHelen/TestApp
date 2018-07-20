//-----------------------------------------------------------------------
// <copyright file="Global.cs" company="Tecwi">
// Copyright (c) Tecwi. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//-------------------------------------------------------------------
namespace TestApp
{
    using System;
    using System.Web.Http;
    using System.Web.Optimization;

    /// <summary>
    /// A Configuration of the Solution
    /// </summary>
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}