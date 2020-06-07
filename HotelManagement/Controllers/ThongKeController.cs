using HotelManagement.DaTa_Access_Object;
using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManagement.Controllers
{
    public class ThongKeController : Controller
    {
        string request = null;
        //thống kê doanh thu theo tháng
        //thống kê doanh thu theo năm 
        //public JsonResult GetJsonData()
        //{

        //    string name = null;
        //    HoaDonDAO HD = new HoaDonDAO();
        //    List<double> doanhthucacthang = new List<double>();
           
        //        doanhthucacthang = HD.get_doanhthuthang("2020");
            
        //    return Json(doanhthucacthang, JsonRequestBehavior.AllowGet);
        //}
        // GET: ThongKe


        public ActionResult UIThongKe()
        {
            ViewBag.ngaythangnam = DateTime.Now.ToString("yyyy");



            HoaDonDAO HD = new HoaDonDAO();
            List<double> doanhthucacthang = new List<double>();
            doanhthucacthang = HD.get_doanhthuthang("2020");
            string value = null;
            for (int i=0;i<doanhthucacthang.Count();i++)
            {
                if(i< doanhthucacthang.Count() - 1)
                {
                    value += doanhthucacthang[i].ToString() + " ";
                }
                else
                {
                    value += doanhthucacthang[i].ToString();
                }
                
            }
            ViewBag.valu = value;
            return View();
        }
        public ActionResult ThongKe()
        {
            string nam = Request.Form["nam"];
            
            HoaDonDAO HD = new HoaDonDAO();
            List<double> doanhthucacthang = new List<double>();
          
            if (nam != "")
            {
               
            doanhthucacthang = HD.get_doanhthuthang(nam);
            string value = null;
            for (int i=0;i<doanhthucacthang.Count();i++)
            {
                if(i< doanhthucacthang.Count() - 1)
                {
                    value += doanhthucacthang[i].ToString() + " ";
                }
                else
                {
                    value += doanhthucacthang[i].ToString();
                }
                
            }
            ViewBag.valu = value;
                return View("ThongKe");
            }
            else
            {
                doanhthucacthang = HD.get_doanhthuthang("2020");
                string value = null;
                for (int i = 0; i < doanhthucacthang.Count(); i++)
                {
                    if (i < doanhthucacthang.Count() - 1)
                    {
                        value += doanhthucacthang[i].ToString() + " ";
                    }
                    else
                    {
                        value += doanhthucacthang[i].ToString();
                    }

                }
                ViewBag.valu = value;
                ViewBag.nam = "k cos re";
                return View("ThongKe");
            }
            
        }
    }
}