using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class LoaiNhanVien
    {
        public string MaLoaiNV { get; set; }
        public string TenLoaiNV { get; set; }
        public LoaiNhanVien() {  }
        public LoaiNhanVien(string maloainv, string teloainv)
        {
            this.MaLoaiNV = maloainv;
            this.TenLoaiNV = teloainv;
        }
    }
}