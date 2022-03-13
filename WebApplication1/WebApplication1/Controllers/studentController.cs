using System;
using System.Collections.Generic;
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
        public ActionResult Savedata(student student)
        {
            db.students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}