using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfficeWebApp.Models
{
    public class Section
    {
        public int SectionId { set; get; }
        public string Code { set; get; }
        public string Description { set; get; }
        public int DepartmentId { set; get; }
        public virtual Department Department { set; get; }

    }
}