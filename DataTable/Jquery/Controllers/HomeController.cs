using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jquery.Models;
using System.Web.Mvc;

namespace Jquery.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities DB = new EmployeeDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            int a = 0; // declare for nothing
            var data = DB.Students.ToList();
            return View(data);
        }
    }
}