//-----------------------------------------------------------------------
// <copyright file="DataContext.cs" company="Tecwi">
// Copyright (c) Tecwi. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//-------------------------------------------------------------------
namespace TestApp.Entities
{
    using System.Data.Entity;

    /// <summary>
    /// Database connection
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Initializes a TestApp new instance of the <see cref="DataContext"/> class
        /// </summary>
        public DataContext()
            : base("DefaultConnection")
        {
        }

        /// <summary>
        ///  Gets or sets DbSet of Employee
        /// </summary>
        public DbSet<Employee> Employees { get; set; }
    }
}