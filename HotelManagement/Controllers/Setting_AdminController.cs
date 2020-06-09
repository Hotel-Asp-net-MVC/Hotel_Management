using HotelManagement.DaTa_Access_Object;
using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKhachSan.Controllers
{
   
    public class Setting_AdminController : Controller
    {
        
        
        // GET: Setting_Admin
        public ActionResult Infor_Hotelier()
        {
            //show tất cả loại phòng
            LoaiPhongDAO loaiphong_dao = new LoaiPhongDAO();
            List<LoaiPhong> listloaiphong = new List<LoaiPhong>();
            listloaiphong = loaiphong_dao.GetAllLoaiPhong();
            ViewBag.listloaiphong = listloaiphong;
            //--------end---------------

            //show tất cả phòng
            PhongDAO phong_dao = new PhongDAO();
            List<Phong> listphong = new List<Phong>();
            listphong = phong_dao.GetAllPhong();
            ViewBag.listphong = listphong;
            //-----end---------------

            //show tất cả nhân viên
            NhanVienDAO nhanvien_dao = new NhanVienDAO();
            List<NhanVien> listnhanvien = new List<NhanVien>();
            listnhanvien = nhanvien_dao.GetAllNhanVien();
            ViewBag.listnhanvien = listnhanvien;
            //------end---------------

            return View();
        }
        //thêm mới loại phòng
        public ActionResult AddLoaiPhong()
        {
            //thêm mới loại phòng 
            string tenloaiphong = Request.Form["typeRoom"];
            string maloaiphong = Request.Form["idRoom"];
            string nguoilon = Request.Form["songuoilon"];
            string trecon = Request.Form["trecon"];
            string gia = Request.Form["gia"];
           
            LoaiPhongDAO loaiphong_dao = new LoaiPhongDAO();
            loaiphong_dao.AddLoaiPhong(tenloaiphong, maloaiphong, nguoilon, trecon, gia);

            // reload lại tất cả thông tin
            //----reload loại phong 
            List<LoaiPhong> listloaiphong = new List<LoaiPhong>();
            listloaiphong = loaiphong_dao.GetAllLoaiPhong();
            ViewBag.listloaiphong = listloaiphong;
            //-----reload danh sách phòng
            PhongDAO phong_dao = new PhongDAO();
            List<Phong> listphong = new List<Phong>();
            listphong = phong_dao.GetAllPhong();
            ViewBag.listphong = listphong;

            //----reload danh sách nhân viên
            NhanVienDAO nhanvien_dao = new NhanVienDAO();
            List<NhanVien> listnhanvien = new List<NhanVien>();
            listnhanvien = nhanvien_dao.GetAllNhanVien();
            ViewBag.listnhanvien = listnhanvien;

            return View("Infor_Hotelier");
        }

        // thêm mới phòng
        public ActionResult AddPhong()
        {
            //thêm mới 1 phòng
            string maphong =Request.Form["maphong"];
            string tenloaiphong = Request.Form["loaiphong"];
            string sophong = Request.Form["sophong"];
            PhongDAO phong_dao = new PhongDAO();
            phong_dao.AddPhong(maphong, sophong, tenloaiphong);
            // reload lại tất cả thông tin
            //----reload loại phong 
            List<LoaiPhong> listloaiphong = new List<LoaiPhong>();
            LoaiPhongDAO loaiphong_dao = new LoaiPhongDAO();
            listloaiphong = loaiphong_dao.GetAllLoaiPhong();
            ViewBag.listloaiphong = listloaiphong;

            //-----reload danh sách phòng
            List<Phong> listphong = new List<Phong>();
            listphong = phong_dao.GetAllPhong();
            ViewBag.listphong = listphong;

            //----reload danh sách nhân viên
            NhanVienDAO nhanvien_dao = new NhanVienDAO();
            List<NhanVien> listnhanvien = new List<NhanVien>();
            listnhanvien = nhanvien_dao.GetAllNhanVien();
            ViewBag.listnhanvien = listnhanvien;
            return View("Infor_Hotelier");
        }

        //thêm mới 1 nhân viên
        public ActionResult AddNhanVien()
        {
            //thêm mới nhân viên
            string vitri = Request.Form["Pos"];
            string user = Request.Form["nameAccount"];
            string pass = Request.Form["psw"];
            string tennv = Request.Form["nameStaff"];
            string sdt = Request.Form["sdt"];
            string cmnd = Request.Form["cmnd"];
            NhanVienDAO nhanvien_dao = new NhanVienDAO();
            nhanvien_dao.AddNhanVien(tennv, vitri, user,pass,sdt,cmnd);

            //reload tất cả thông tin
            //----reload danh sách loại phòng
            List<LoaiPhong> listloaiphong = new List<LoaiPhong>();
            LoaiPhongDAO loaiphong_dao = new LoaiPhongDAO();
            listloaiphong = loaiphong_dao.GetAllLoaiPhong();
            ViewBag.listloaiphong = listloaiphong;

            //----reload danh sách phòng
            PhongDAO phong_dao = new PhongDAO();
            List<Phong> listphong = new List<Phong>();
            listphong = phong_dao.GetAllPhong();
            ViewBag.listphong = listphong;

            //----reload danh sách nhân viên
            List<NhanVien> listnhanvien = new List<NhanVien>();
            listnhanvien = nhanvien_dao.GetAllNhanVien();
            ViewBag.listnhanvien = listnhanvien;

            return View("Infor_Hotelier");
        }
    }
}