using ASM_NguyenThanhduong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASM_NguyenThanhduong.Controllers
{
    public class HomeController : Controller
    {
        MyDbContext _db = new MyDbContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult About(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
     
    }
}