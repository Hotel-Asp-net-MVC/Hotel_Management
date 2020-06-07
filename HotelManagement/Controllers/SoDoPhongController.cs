using HotelManagement.DaTa_Access_Object;
using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManagement.Controllers
{
    public class SoDoPhongController : Controller
    {
        List<ThongTinPhong> thongtinphong = new List<ThongTinPhong>();
        ThongTinPhongDAO thongtin = new ThongTinPhongDAO();
        public ActionResult SoDoPhong()
        {
            //List<ThongTinPhong> thongtinphong = new List<ThongTinPhong>();
            //ThongTinPhongDAO thongtin = new ThongTinPhongDAO();
            thongtinphong = thongtin.GetAllThongTinPhong();
            ViewBag.thongtinphong = thongtinphong;
            return View();
        }
        //
        
        public ActionResult ShowLoaiPhongTrong()
        {

            thongtinphong = thongtin.GetAllThongTinPhong();
            List<ThongTinPhong> PhongTrong = new List<ThongTinPhong>();
            for(int i=0;i<thongtinphong.Count();i++)
            {
                if (thongtinphong[i].TrangThai == "Trong")
                {
                    PhongTrong.Add(thongtinphong[i]);
                }
            }
            ViewBag.thongtinphong = PhongTrong;
            return View("SoDoPhong");
        }

        public ActionResult ShowPhongNhan()
        {

            thongtinphong = thongtin.GetAllThongTinPhong();
            List<ThongTinPhong> PhongNhan = new List<ThongTinPhong>();
            for (int i = 0; i < thongtinphong.Count(); i++)
            {
                if (thongtinphong[i].TrangThai == "Nhan Phong")
                {
                    PhongNhan.Add(thongtinphong[i]);
                }
            }
            ViewBag.thongtinphong = PhongNhan;
            return View("SoDoPhong");
        }

        public ActionResult ShowPhongQuaHan()
        {

            thongtinphong = thongtin.GetAllThongTinPhong();
            List<ThongTinPhong> PhongQuaHan = new List<ThongTinPhong>();
            for (int i = 0; i < thongtinphong.Count(); i++)
            {
                if (thongtinphong[i].TrangThai == "Qua Han")
                {
                    PhongQuaHan.Add(thongtinphong[i]);
                }
            }
            ViewBag.thongtinphong = PhongQuaHan;
            return View("SoDoPhong");
        }
        public ActionResult ShowPhongDaDat()
        {

            thongtinphong = thongtin.GetAllThongTinPhong();
            List<ThongTinPhong> PhongDadat = new List<ThongTinPhong>();
            for (int i = 0; i < thongtinphong.Count(); i++)
            {
                if (thongtinphong[i].TrangThai == "Da Dat")
                {
                    PhongDadat.Add(thongtinphong[i]);
                }
            }
            ViewBag.thongtinphong = PhongDadat;
            return View("SoDoPhong");
        }

        public ActionResult ShowPhongKhongDen()
        {

            thongtinphong = thongtin.GetAllThongTinPhong();
            List<ThongTinPhong> PhongKhongDen = new List<ThongTinPhong>();
            for (int i = 0; i < thongtinphong.Count(); i++)
            {
                if (thongtinphong[i].TrangThai == "Khong Den")
                {
                    PhongKhongDen.Add(thongtinphong[i]);
                }
            }
            ViewBag.thongtinphong = PhongKhongDen;
            return View("SoDoPhong");
        }
        public ActionResult Refresh()
        {
            //lấy trạng thái cũ
            thongtinphong = thongtin.GetAllThongTinPhong();

            string date = DateTime.Now.ToString("dd").ToString();
            string month = DateTime.Now.ToString("mm").ToString();
            string year= DateTime.Now.ToString("yyyy").ToString();
            for (int i=0;i<thongtinphong.Count();i++)
            {
                if (thongtinphong[i].TrangThai == "Trong")
                {
                    
                }
                else if (thongtinphong[i].TrangThai == "Da Dat")
                {

                }
                else if(thongtinphong[i].TrangThai == "Da Nhan")
                {

                }
            }
            PhongDAO phong = new PhongDAO();
            phong.UpdateStatusPhong("Da Dat","P001");
            thongtinphong = thongtin.GetAllThongTinPhong();
            ViewBag.thongtinphong = thongtinphong;
            return View("SoDoPhong");
        }
        public void functionRefresh()
        {
            thongtinphong = thongtin.GetAllThongTinPhong();
        }
    }
}