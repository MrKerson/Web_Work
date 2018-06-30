using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Work.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        /*public ActionResult _LayoutName()
        {
            //var _count = 0;

            //if (User.Identity.IsAuthenticated)
            //{
            //    ViewBag.Name = User.Identity.Name;
            //    _count = 1;
            //    ViewBag.Count = _count;
            //    return View();
            //}

            //ViewBag.Count = _count;                
            return View();
        }//*/
    }
}