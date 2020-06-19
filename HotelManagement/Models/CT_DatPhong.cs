using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class CT_DatPhong
    {
        public int MaCTDP { get; set; }
        public string MaDP { get; set; }
        public string ThoiGianNhan { get; set; }
        public string NgayDen { get; set; }
        public string NgayDi { get; set; }
        public CT_DatPhong() { }
        public CT_DatPhong(int mact, string madp, string thoigiannhan, string ngayden, string ngaydi)
        {
            this.MaCTDP = mact;
            this.MaDP = madp;
            this.ThoiGianNhan = thoigiannhan;
            this.NgayDen = ngayden;
            this.NgayDi = ngaydi;
        }

    }
}