using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class BaoCao
    {
        public string MaDP { get; set; }
        public string TenKH { get; set; }
        public string TenNV { get; set; }
        public int SoPhong { get; set; }
        public string NgayDen { get; set; }
        public string NgayDi { get; set; }
        public double Gia { get; set; }

        public BaoCao() { }
        public BaoCao(string madp, string tenkh, string tennv, int sophong, string ngayden, string ngaydi, double gia)
        {
            this.MaDP = madp;
            this.TenKH = tenkh;
            this.TenNV = tennv;
            this.SoPhong = sophong;
            this.NgayDen = ngayden;
            this.NgayDi = ngaydi;
            this.Gia = gia;
        }
    }
}