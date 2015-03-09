using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SelectedIndexNormal.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Display(Name = "Course Code")]
        public string Code { get; set; }
        public string Name { get; set; }
        public double Credit { get; set; }
      
    }
}