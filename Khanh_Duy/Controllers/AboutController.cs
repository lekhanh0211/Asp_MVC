using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Khanh_Duy.Help;
using Khanh_Duy.Models;

namespace Khanh_Duy.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult TinTuc()
        {
            //int a = 10;
            //ViewBag.A = a;
            //ViewBag.a = 10;
            //C1 : truyền bằng ViewBag
            MathHelper mt = new MathHelper();
            ViewBag.a = mt.Tong(15, 20);

            //C2 :Truyền qua tham số của view thường dùng để truyền cả 1  class sang
            //var st = new Student();

            //st.Id = 1;
            //st.Name = "Đỗ Mỹ Linh";
            //st.Class = "12A4";
            //st.Status = true;
            //return View(st);

            List<Student> st = new List<Student>();
            var st1 = new Student();

            st1.Id = 1;
            st1.Name = "Đỗ Mỹ Linh";
            st1.Class = "12A4";
            st1.Status = true;
            st.Add(st1);
            var st2 = new Student();

            st2.Id = 2;
            st2.Name = "Lê Ánh Nguyệt";
            st2.Class = "12A2";
            st2.Status = true;
            st.Add(st2);
            return View(st);

        }

    }
}
