using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Khanh_Duy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Chuyển dướng qua action khác cùng controller 
            //return RedirectToAction("About");

            //Chuyển hướng qua action khác khác controller
            // return RedirectToAction("Index", "User");
            //Chuyển hướng tới url
            // return Redirect("https://google.com");
            return View();
        }

    }
}