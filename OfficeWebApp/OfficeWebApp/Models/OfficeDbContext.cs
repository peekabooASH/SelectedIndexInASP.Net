using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OfficeWebApp.Models
{
    public class OfficeDbContext : DbContext
    {
        public DbSet<Department> Departments { set; get; }
        public DbSet<Section> Sections { set; get; }
    }
}