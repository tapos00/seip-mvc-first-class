using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcFirstPart.Models
{
    public class ProjectDB:DbContext
    {
        public ProjectDB() : base("seipConnection")
        {
            
        }
        public DbSet<Department> Departments { set; get; }
        public DbSet<Student> Students { get; set; }
    }
}