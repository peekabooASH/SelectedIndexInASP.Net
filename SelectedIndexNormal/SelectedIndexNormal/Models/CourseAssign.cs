using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelectedIndexNormal.Models
{
    public class CourseAssign
    {
        public int CourseAssignId { set; get; }
        public int CourseId { set; get; }
        public virtual Course Course { set; get; }
    }
}