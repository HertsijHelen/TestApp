using System;
using System.Web.Http;
using Ninject;
using Ninject.Modules;
using Ninject.Web.WebApi;
using TestApp.Util;


namespace TestApp
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //----register ninject 
            //NinjectModule registration = new NinjectRegistration();
            //var kernel = new StandardKernel(registration);
            //GlobalConfiguration.Configuration.DependencyResolver=new NinjectDependencyResolver(kernel);
        }

       
    }
}