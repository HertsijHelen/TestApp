//-----------------------------------------------------------------------
// <copyright file="EmployeesRepository.cs" company="Tecwi">
// Copyright (c) Tecwi. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//-------------------------------------------------------------------------
namespace TestApp.WebAPI
{
    using System.Collections.Generic;
    using System.Web.Http;
    using System.Web.Http.Description;
    using TestApp.Entities;
    using TestApp.Repositories;
    using Ninject;

    public class EmployeesController : ApiController
    {
        IRepository<Employee> repo;
        public EmployeesController()
        {
            IKernel k = new StandardKernel();
            k.Bind<IRepository<Employee>>().To<EmployeesRepository>();
            repo = k.Get<IRepository<Employee>>();

        }

        // GET: api/Employees
        [HttpGet]
        public IHttpActionResult GetEmployees()
        {
            IEnumerable<Employee> listEmployee = repo.GetAll();
            return Ok(listEmployee);
        }
        //Post: api/Employees
        [HttpPost]
        [ResponseType(typeof(Employee))]
        public Employee PostItem(Employee item)
        {
            return repo.Create(item);
        }

        // PUT: api/Employees/5
        [HttpPut]
        [ResponseType(typeof(Employee))]
        public IEnumerable<Employee> PutItem(int id, Employee item)
        {
            bool onUpdate = repo.Update(id, item);
            if(onUpdate==true)
            {
                return repo.GetAll();
            }
            else
            {
                return null;
            }
        }
 
        // DELETE: api/Employees/5
        [HttpDelete]
        [ResponseType(typeof(Employee))]
        public IEnumerable<Employee> DeleteItem(int id)
        {
            bool onDelete = repo.Delete(id);
            if (onDelete == true)
            {
                return repo.GetAll();
            }
            else
            {
                return null;
            }           
        }
    }
}