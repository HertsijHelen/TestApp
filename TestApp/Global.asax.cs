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
            //NinjectModule registration = new NinjectRegistration();
            //var kernel = new StandardKernel(registration);
            //GlobalConfiguration.Configuration.DependencyResolver=new NinjectDependencyResolver(kernel);
        }

        //protected void Session_Start(object sender, EventArgs e)
        //{

        //}

        //protected void Application_BeginRequest(object sender, EventArgs e)
        //{

        //}

        //protected void Application_AuthenticateRequest(object sender, EventArgs e)
        //{

        //}

        //protected void Application_Error(object sender, EventArgs e)
        //{

        //}

        //protected void Session_End(object sender, EventArgs e)
        //{

        //}

        //protected void Application_End(object sender, EventArgs e)
        //{

        //}
    }
}