//-----------------------------------------------------------------------
// <copyright file="EmployeesRepository.cs" company="Tecwi">
// Copyright (c) Tecwi. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//-------------------------------------------------------------------------
namespace TestApp.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TestApp.Entities;

    public class EmployeesRepository: IRepository<Employee>
    {
        private DataContext db = new DataContext();
       
        public IEnumerable<Employee> GetAll()
        {
            return db.Employees;
        }
       
        public Employee Create(Employee item)
        {
            try
            {
                db.Employees.Add(item);
                db.SaveChanges();
                return item;
            }
            catch
            {
                return null;
            }
        }
        public bool Update(int id,Employee item)
        {
            Employee e = db.Employees.Find(id);
            try
            {
                e.Name = item.Name;
                e.Position = item.Position;
                e.Age = item.Age;
                e.StartDate = item.StartDate;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
         }
         public bool Delete(int id)
         {
            Employee emp = db.Employees.Find(id);
            try
            {
                db.Employees.Remove(emp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
      
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}