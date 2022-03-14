using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        employeeEntities db = new employeeEntities();
        public ActionResult Index()
        {
            List<student> data = db.students.ToList();
            return View(data);
        }
        public ActionResult create()
        {

            return View();
        }
        public ActionResult Edit(int id)
        {
            student data = db.students.Find(id);
            return View(data);
        }
        public ActionResult Savedata(student student)
        {
            db.students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Updatedata(student student)
        {
           // student std = db.students.Find(student.sid);
            db.Entry(student).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            student data = db.students.Find(id);
            return View(data);
        }
        public ActionResult DeleteData(student student)
        {
            student delete = db.students.Find(student.sid);
            db.students.Remove(delete);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
       
}