using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.Models
{
    public class LoaiPhong
    {
        public string MaLoaiPhong { get; set; }
        public string TenLoaiPhong { get; set; }
        
        public double GiaTheoNgay { get; set; }
        public double GiaQuaDem { get; set; }
        public double GiaTuan { get; set; }
        public double GiaThang { get; set; }
        public int SoNguoiLon { get; set; }
        public int SoTreEm { get; set; }
        public LoaiPhong(string maloaiphong, string tenlp, int nguoilon, int treem, double ngay, double dem, double tuan, double thang)
        {
            this.MaLoaiPhong = maloaiphong;
            this.TenLoaiPhong = tenlp;
          
            this.GiaTheoNgay = ngay;
            this.GiaQuaDem = dem;
            this.GiaTuan = tuan;
            this.GiaThang = thang;
            this.SoNguoiLon = nguoilon;
            this.SoTreEm = treem;
        }
        public LoaiPhong()
        {

        }
    }
}