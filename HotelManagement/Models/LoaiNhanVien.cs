using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyKhachSan.Models
{
    public class LoaiNhanVien
    {
        private string MaLoaiNV { get; set; }
        private string TenLoaiNV { get; set; }
        public LoaiNhanVien() {  }
        public LoaiNhanVien(string maloainv, string teloainv)
        {
            this.MaLoaiNV = maloainv;
            this.TenLoaiNV = teloainv;
        }
    }
}