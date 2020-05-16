using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyKhachSan.Models
{
    public class NhanVien
    {
        private string MaNV { get; set; }
        private string MaLoaiNV { get; set; }
        private string UsesName { get; set; }
        private string Password { get; set; }
        private string TenNV { get; set; }
        private string CMND { get; set; }
        private string GioiTinh { get; set; }
        private string DiaChi { get; set; }
        private string DienThoai { get; set; }
        private string Email { get; set; }

        public NhanVien() {  }
        public NhanVien(string manv, string loainv,string user, string pass, string tennv,string cnnd, string gioitinh, string diachi,string sdt, string email)
        {
            this.MaNV = manv;
            this.MaLoaiNV = loainv;
            this.UsesName = user;
            this.Password = pass;
            this.TenNV = tennv;
            this.CMND = cnnd;
            this.GioiTinh = gioitinh;
            this.DiaChi = diachi;
            this.DienThoai = sdt;
            this.Email = email;
        }
    }
}