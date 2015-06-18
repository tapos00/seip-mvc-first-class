using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcFirstPart.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
         [Required(ErrorMessage = "department name plz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "department code plz")]
        public string Code { get; set; }
        public virtual ICollection<Student> Students { set; get; } 
    }
}