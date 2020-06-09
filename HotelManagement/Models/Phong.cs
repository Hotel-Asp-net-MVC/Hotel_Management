using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class Phong
    {
        public string MaPhong { get; set; }
        public string MaLoaiPhong { get; set; }
        public int SoPhong { get; set; }
        public string TrangThai { get; set; }
        public string TenLoaiPhong{get; set;}

        public Phong() { }
        public Phong(string map, string malp, int sop, string tt, string tenlp)
        {
            this.MaPhong = malp;
            this.MaLoaiPhong = malp;
            this.SoPhong = sop;
            this.TrangThai = tt;
            this.TenLoaiPhong = tenlp;
        }
    }
}