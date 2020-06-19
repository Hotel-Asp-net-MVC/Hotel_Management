using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class ThongTinPhong
    {
        public string MaPhong { get; set; }
        public string LoaiPhong { get; set; }
        public int SoPhong { get; set; }
        public string TenKhachHang { get; set; }
        public string TrangThai { get; set; }
        public string ThoiGianDen { get; set; }
        public string ThoiGianDi { get; set; }
        public double GiaNgay { get; set; }
        public ThongTinPhong(string maphong,string LP, int SP, string TT, string TKH, string TGD, string TGiD, double giangay)
        {
            this.MaPhong = MaPhong;
            this.LoaiPhong = LP;
            this.SoPhong = SP;
            this.TenKhachHang = TKH;
            this.TrangThai = TT;
            this.ThoiGianDen = TGD;
            this.ThoiGianDi = TGiD;
            this.GiaNgay = giangay;
        }
        public ThongTinPhong()
        { }
    }
}