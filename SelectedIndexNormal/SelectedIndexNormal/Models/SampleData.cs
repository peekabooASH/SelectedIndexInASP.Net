using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SelectedIndexNormal.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {

        protected override void Seed(DatabaseContext context)
        {
            context.Courses.Add(new Course(){Code = "CSE",Credit=3.0,Name = "Computer Science"} );
            context.Courses.Add(new Course() { Code = "CE", Credit = 4.0, Name = "Civil" });
            context.SaveChanges();

        }
    }
}