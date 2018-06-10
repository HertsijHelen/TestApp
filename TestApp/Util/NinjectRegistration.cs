using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApp.Entities;
using TestApp.Repositories;
using Ninject.Modules;

namespace TestApp.Util
{
    public class NinjectRegistration:NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Employee>>().To<EmployeesRepository>();
        }
    }
}