using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyKhachSan.Models
{
    public class LoaiPhong
    {
        private string MaLoaiPhong { get; set; }
        private string TenLoaiPhong { get; set; }
        private int GiaTheoGio { get; set; }
        private int GiaTheoNgay { get; set; }
        private int GiaQuaDem { get; set; }
        private int GiaTuan { get; set; }
        private int GiaThang { get; set; }
        private int SoNguoiLon { get; set; }
        private int SoTreEm { get; set; }
        public LoaiPhong(string maloaiphong, string tenlp, int gio, int ngay, int dem , int tuan, int thang , int nguoilon, int treem)
        {
            this.MaLoaiPhong = maloaiphong;
            this.TenLoaiPhong = tenlp;
            this.GiaTheoGio = gio;
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