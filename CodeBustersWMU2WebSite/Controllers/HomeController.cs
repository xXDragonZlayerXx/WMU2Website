using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeBustersWMU2WebSite.Models;

namespace CodeBustersWMU2WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TaskService ts = new TaskService();
            return View(ts.GetTasks());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}