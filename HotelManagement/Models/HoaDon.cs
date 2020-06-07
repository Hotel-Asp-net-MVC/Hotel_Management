using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class HoaDon
    {
        public string MaHoaDon { get; set; }
        public string MaDP { get; set; }
        public string MaKHThanhToan { get; set; }
        public string MaNV { get; set; }
        public string NgayThanhToan { get; set; }
        public double Gia { get; set; }

        public HoaDon() { }
        public HoaDon(string mahd,string madp, string makh, string manv, string ngtt, double gia)
        {
            this.MaHoaDon = mahd;
            this.MaDP = madp;
            this.MaKHThanhToan = makh;
            this.MaNV = manv;
            this.NgayThanhToan = ngtt;
            this.Gia = gia;
        }
    }
}