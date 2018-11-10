using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Annotation_Video2.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("EmployeeName")]
        [Required(ErrorMessage = "Employee name is require")]
        [StringLength(35,MinimumLength =4)]
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }

    }
}