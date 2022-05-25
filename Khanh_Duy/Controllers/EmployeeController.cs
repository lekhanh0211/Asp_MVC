using Khanh_Duy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Khanh_Duy.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View(DanhSachEmployee.lstE);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee e)
        {
            if (ModelState.IsValid == true)
            {
                DanhSachEmployee.lstE.Add(e);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Bạn nhập chưa đủ dữ liệu!!!");
                return View();
            }
           
        }
    }
}