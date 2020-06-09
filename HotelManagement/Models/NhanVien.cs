using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string ViTri { get; set; }
        public string UsesName { get; set; }
        public string Password { get; set; }
        public string CMND { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public NhanVien() { }
        public NhanVien(string manv, string tennv, string vitri, string user, string pass, string cmnd, string gioitinh,string dc, string dt, string email)
        {
            this.MaNV = manv;
            this.TenNV = tennv;
            this.ViTri = vitri;
            this.UsesName = user;
            this.Password = pass;
            this.CMND = cmnd;
            this.GioiTinh = gioitinh;
            this.DiaChi = dc;
            this.DienThoai = dt;
            this.Email = email;

        }
    }
}