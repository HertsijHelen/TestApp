//-----------------------------------------------------------------------
// <copyright file="NinjectRegistration.cs" company="Tecwi">
// Copyright (c) Tecwi. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//---

namespace TestApp.Util
{
    using TestApp.Entities;
    using TestApp.Repositories;
    using Ninject.Modules;

    public class NinjectRegistration:NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Employee>>().To<EmployeesRepository>();
        }
    }
}