using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKhachSan.Controllers
{
    public class LoginController : Controller
    {
        
        public ActionResult Login()
        {
            int[] marks = new int[] { 99, 98, 92, 97, 95 };
            string a = Request.Form["user"];
            string b = Request.Form["password"];
            ViewBag.user = a;
            ViewBag.pass = b;
            ViewBag.array = marks;
            if (a == "phamduycuong" && b == "1340") 
            {
                return Redirect("/Room/Index");
            }
            else
            {
                return View();
            }
            
        } 
    }
}