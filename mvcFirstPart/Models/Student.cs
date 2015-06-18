using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcFirstPart.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required(ErrorMessage = "enter student name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "enter student email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage = "enter student departmentID")]
        
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

    }
}