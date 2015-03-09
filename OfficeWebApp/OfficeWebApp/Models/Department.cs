using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfficeWebApp.Models
{
    public class Department
    {
        public int DepartmentId { set; get; }

        public string Code { set; get; }
        public string Name { set; get; }

        public virtual List<Section> Sections { set; get; } 
    }
}