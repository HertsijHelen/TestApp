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
    using TestApp.Entities;
    
    /// <summary>
    /// Initialize a new instance of EmployeesRepository
    /// </summary>
    public class EmployeesRepository : IRepository<Employee>
    {
        /// <summary>
        /// Initialize a new Instance of DataContext
        /// </summary>
        private DataContext db = new DataContext();

        /// <summary>
        /// The property of disposed DataContext
        /// </summary>
        private bool disposed = false;

        /// <summary>
        /// Get all records from Employees table
        /// </summary>
        /// <returns>record from employees table</returns>
        public IEnumerable<Employee> GetAll()
        {
            return this.db.Employees;
        }
       
       /// <summary>
       /// Add a new record to Employees table
       /// </summary>
       /// <param name="item">the record wich need to added</param>
       /// <returns>return item</returns>
        public Employee Create(Employee item)
        {
            try
            {
                this.db.Employees.Add(item);
                this.db.SaveChanges();
                return item;
            }
            catch
            {
                return null;
            }
        }
        
        /// <summary>
        /// Update a recod Employees table by id
        /// </summary>
        /// <param name="id">a record wich need to update</param>
        /// <param name="item">record wich update</param>
        /// <returns>return true or false</returns>
        public bool Update(int id, Employee item)
        {
            Employee e = this.db.Employees.Find(id);
            try
            {
                e.Name = item.Name;
                e.Position = item.Position;
                e.Age = item.Age;
                e.StartDate = item.StartDate;
                this.db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
         }
        
        /// <summary>
        /// Remove a record from Employees table by id
        /// </summary>
        /// <param name="id">a record wich delete</param>
        /// <returns>return true of false</returns>
         public bool Delete(int id)
         {
            Employee emp = db.Employees.Find(id);
            try
            {
                this.db.Employees.Remove(emp);
                this.db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
      
        /// <summary>
        /// the method for dispose DataContext class
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.db.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// The method for 
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}