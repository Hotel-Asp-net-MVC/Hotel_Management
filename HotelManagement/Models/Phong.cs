using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyKhachSan.Models
{
    public class Phong
    {
        private string MaPhong { get; set; }
        private string MaLoaiPhong { get; set; }
        private int SoPhong { get; set; }
        private string TrangThai { get; set; }
        public Phong() { }
        public Phong(string maphong, string maloaiphong, int sophong, string trangthai)
        {
            this.MaPhong = maphong;
            this.MaLoaiPhong = maloaiphong;
            this.SoPhong = sophong;
            this.TrangThai = trangthai;
        }
    }
}