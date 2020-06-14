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
            string nam = DateTime.Now.ToString("yyyy");



            HoaDonDAO HD = new HoaDonDAO();
            List<double> doanhthucacthang = new List<double>();
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
            return View();
        }
        // lấy doanh thu các tháng trong năm
        public ActionResult ThongKe()
        {
            string nam = Request.Form["nam"];
            
            HoaDonDAO HD = new HoaDonDAO();
            List<double> doanhthucacthang = new List<double>();
          
            if (nam != "")
            {
               
            doanhthucacthang = HD.get_doanhthuthang(nam);
            string value = null;
            for (int i=0;i<12;i++)
            {
                    if(i< doanhthucacthang.Count())
                    {
                        if (i < 11)
                        {
                            value += doanhthucacthang[i].ToString() + " ";
                        }
                        else
                        {
                            value += doanhthucacthang[i].ToString();
                        }
                    }
                    else
                    {
                        if (i < 11)
                        {
                            value +="null"+ " ";
                        }
                        else
                        {
                            value += "null";
                        }
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
                
                return View("ThongKe");
            }
            
        }
        public ActionResult SoSanhDefaut()
        {
            return View();
        }
        public ActionResult SoSanhDoanhThu()
        {
            string nam1 = Request.Form["nam1"];
            string nam2 = Request.Form["nam2"];

            HoaDonDAO HD = new HoaDonDAO();
            List<double> doanhthucacthangnam1 = new List<double>();
            List<double> doanhthucacthangnam2 = new List<double>();
            string valuenam1 = null;
            string valuenam2 = null;
            if (nam1 != ""&& nam2!="")
            {
                // lấy doanh thu năm thứ nhất
                doanhthucacthangnam1 = HD.get_doanhthuthang(nam1);
                
                for (int i = 0; i < 12; i++)
                {
                    if (i < doanhthucacthangnam1.Count())
                    {
                        if (i < 11)
                        {
                            valuenam1 += doanhthucacthangnam1[i].ToString() + " ";
                        }
                        else
                        {
                            valuenam1 += doanhthucacthangnam1[i].ToString();
                        }
                    }
                    else
                    {
                        if (i < 11)
                        {
                            valuenam1 += "null" + " ";
                        }
                        else
                        {
                            valuenam1 += "null";
                        }
                    }

                }

                // lấy doanh thu năm thứ hai
                doanhthucacthangnam2 = HD.get_doanhthuthang(nam2);

                for (int i = 0; i < 12; i++)
                {
                    if (i < doanhthucacthangnam2.Count())
                    {
                        if (i < 11)
                        {
                            valuenam2 += doanhthucacthangnam2[i].ToString() + " ";
                        }
                        else
                        {
                            valuenam2 += doanhthucacthangnam2[i].ToString();
                        }
                    }
                    else
                    {
                        if (i < 11)
                        {
                            valuenam2 += "null" + " ";
                        }
                        else
                        {
                            valuenam2 += "null";
                        }
                    }

                }


                ViewBag.valuenam1 = valuenam1;
                ViewBag.valuenam2 = valuenam2;
                ViewBag.nam1 = nam1;
                ViewBag.nam2 = nam2;
                return View();
            }
            
            return View();
        }
    }
}