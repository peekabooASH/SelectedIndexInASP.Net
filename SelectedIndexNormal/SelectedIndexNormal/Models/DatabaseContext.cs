using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SelectedIndexNormal.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Course> Courses { set; get; }
        public DbSet<CourseAssign> CourseAssigns { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}