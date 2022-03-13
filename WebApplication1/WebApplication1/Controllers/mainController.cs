using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class mainController : Controller
    {
        // GET: main
        employeeEntities db = new employeeEntities();
        

        public ActionResult Prashansa()
        {
            List<empdetail> data = db.empdetails.ToList();
            return View(data);
        }
      
    }
}