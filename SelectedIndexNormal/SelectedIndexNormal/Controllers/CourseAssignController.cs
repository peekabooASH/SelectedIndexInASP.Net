using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SelectedIndexNormal.Models;

namespace SelectedIndexNormal.Controllers
{
    public class CourseAssignController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: /CourseAssign/
        public ActionResult Index()
        {
            var courseassigns = db.CourseAssigns.Include(c => c.Course);
            return View(courseassigns.ToList());
        }

        // GET: /CourseAssign/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseAssign courseassign = db.CourseAssigns.Find(id);
            if (courseassign == null)
            {
                return HttpNotFound();
            }
            return View(courseassign);
        }

        // GET: /CourseAssign/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code");
            return View();
        }

        // POST: /CourseAssign/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="CourseAssignId,CourseId")] CourseAssign courseassign)
        {
            if (ModelState.IsValid)
            {
                db.CourseAssigns.Add(courseassign);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code", courseassign.CourseId);
            return View(courseassign);
        }

        // GET: /CourseAssign/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseAssign courseassign = db.CourseAssigns.Find(id);
            if (courseassign == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code", courseassign.CourseId);
            return View(courseassign);
        }

        // POST: /CourseAssign/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="CourseAssignId,CourseId")] CourseAssign courseassign)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseassign).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code", courseassign.CourseId);
            return View(courseassign);
        }

        // GET: /CourseAssign/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseAssign courseassign = db.CourseAssigns.Find(id);
            if (courseassign == null)
            {
                return HttpNotFound();
            }
            return View(courseassign);
        }

        // POST: /CourseAssign/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseAssign courseassign = db.CourseAssigns.Find(id);
            db.CourseAssigns.Remove(courseassign);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        //public JsonResult GetInfo(int? CourseId)
        //{
        //    using (var context = new DatabaseContext())
        //    {
        //        context.Configuration.ProxyCreationEnabled = false;


        //        var courseInfo = context.Courses.Where(x => x.CourseId == CourseId).FirstOrDefault();

        //        //if (courseInfo == null)
        //        //{
        //        //    var tmp = context.Teachers.Where(x => x.TeacherId == teacherID).FirstOrDefault();
        //        //    courseInfo = new CourseAssign();
        //        //    courseInfo.AssignTaken = 0;
        //        //    courseInfo.RemainingTaken = tmp.Credit;
        //        //}
        //        return Json(courseInfo, JsonRequestBehavior.AllowGet);
        //    }
        //}





    }
}
