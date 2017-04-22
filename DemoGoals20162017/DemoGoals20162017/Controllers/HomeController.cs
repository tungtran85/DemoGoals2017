using DemoGoals20162017.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoGoals20162017.Controllers
{
    public class HomeController : Controller
    {
        ILog log = log4net.LogManager.GetLogger(typeof(HomeController));

        public ActionResult Index()
        {
            log.Debug("Debug message");
            log.Warn("Warn message");
            log.Error("Error message");
            log.Fatal("Fatal message");
            return View();
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

        [HttpPost]
        public ActionResult DemoPostListObject(List<ObjectCustom> lst)
        {
            if (lst != null
                && lst.Count > 0
                && lst[0].Id > 0
                && !string.IsNullOrEmpty(lst[0].Name)
                && lst[0].Hobboy.Count > 0)
            {
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}