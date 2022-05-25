using Khanh_Duy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Khanh_Duy.Controllers
{
    public class ProductController : Controller
    {
        // GET: Prodcut
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult ListProduct()
        {
            var lstP = new ProductController().ListPro();
            return View(lstP);
        }
        public List<Computer> ListPro()
        {
            List<Computer> lstC = new List<Computer>();

            lstC.Add(new Computer()
            {
                Id = 01,
                Name = "Hp Panvilion",
                Price = 13500000,
                Producer = "HP",
                yearMaking = new DateTime(2021, 10, 25)
            });
            lstC.Add(new Computer()
            {
                Id = 02,
                Name = "msi hitachi",
                Price = 18500000,
                Producer = "MSI",
                yearMaking = new DateTime(2021, 11, 25)
            });
            lstC.Add(new Computer()
            {
                Id = 03,
                Name = "Lenovo Ideapad",
                Price = 22500000,
                Producer = "LENOVO",
                yearMaking = new DateTime(2021, 08, 20)
            });
            lstC.Add(new Computer()
            {
                Id = 04,
                Name = "Dell Panvilion",
                Price = 16500000,
                Producer = "Dell",
                yearMaking = new DateTime(2018, 10, 15)
            });
            lstC.Add(new Computer()
            {
                Id = 05,
                Name = "Asus MateBook",
                Price = 16000000,
                Producer = "Asus",
                yearMaking = new DateTime(2022, 06, 10)
            });
            return lstC;
        }
        public ActionResult dsgiam()
        {
            var lstP = new ProductController().ListPro().OrderByDescending(x => x.Price).ToList();
            return View(lstP);
        }
        public ActionResult dstang()
        {
            var lstP = new ProductController().ListPro().OrderBy(x => x.Price).ToList();
            return View(lstP);
        }
        public ActionResult dstop3()
        {
            var lstP = new ProductController().ListPro().OrderByDescending(x => x.Price).Take(3).ToList();
            return View(lstP);
        }
        public ActionResult dshp()
        {
            var lstP = new ProductController().ListPro().Where(x => x.Producer == "HP").ToList();
            return View(lstP);
        }
        public ActionResult spmoinhat()
        {
            var lstP = new ProductController().ListPro().OrderByDescending(x => x.yearMaking).Take(2).ToList();
            return View(lstP);
        }
        public ActionResult ListP()
        {
            var p = DSComputer.lstCom;
            return View(p);
        }
        public ActionResult addNew()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addNew(Computer c)
        {
            //đk check : nếu mà nhập liệu chuẩn và đủ nó mới thực hiện lệnh lưu và
            //chuyển hướng sang trang index còn k ta phải quay lại trang view để nhập tiếp
            if (ModelState.IsValid == true)
            {
                DSComputer.lstCom.Add(c);

                return RedirectToAction("ListP");
            }
            else
            {
                //kèm thông báo lỗi
                ModelState.AddModelError("", "Bạn chưa nhập đủ dữ liệu!");
                return View();
            }
          
        }
    }
}