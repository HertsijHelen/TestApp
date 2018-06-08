using System;
using System.ComponentModel.DataAnnotations;

namespace TestApp.Entities
{
    public class Employee
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(50, ErrorMessage = "Not more than 50 Symbols")]
        public string Name { get; set; }

        [Display(Name = "Position")]
        [Required(ErrorMessage = "Required")]
        [StringLength(512, ErrorMessage = "Not more than 50 Symbols")]
        public string Position { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "Required")]
        public int Age { get; set; }

        [Display(Name = "StartDate")]
        [Required(ErrorMessage = "Required")]
        public DateTime StartDate { get; set; }
    }
}