//-----------------------------------------------------------------------
// <copyright file="Employee.cs" company="Tecwi">
// Copyright (c) Tecwi. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//-------------------------------------------------------------------
namespace TestApp.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
   
    /// <summary>
    /// The class of Employees
    /// </summary>
    public class Employee
    {
        /// <summary>
        ///  Gets or sets theId of Employee
        /// </summary>
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        /// <summary>
        ///  Gets or sets the Name of Employee
        /// </summary>
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(50, ErrorMessage = "Not more than 50 Symbols")]
        public string Name { get; set; }

        /// <summary>
        ///  Gets or sets the Position of Employee
        /// </summary>
        [Display(Name = "Position")]
        [Required(ErrorMessage = "Required")]
        [StringLength(512, ErrorMessage = "Not more than 50 Symbols")]
        public string Position { get; set; }

        /// <summary>
        ///  Gets or sets the Age of Employee
        /// </summary>
        [Display(Name = "Age")]
        [Required(ErrorMessage = "Required")]
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the Startdate of Employee
        /// </summary>
        [Display(Name = "StartDate")]
        [Required(ErrorMessage = "Required")]
        public DateTime StartDate { get; set; }
    }
}