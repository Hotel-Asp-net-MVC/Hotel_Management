
using HotelManagement.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.DaTa_Access_Object
{
    public class BaoCaoDAO
    {
        //lấy tất cả thông tin để xuất báo cáo
        public List<BaoCao> GetAllBaoCao(string nam, string thangden, string thangdi,string ngayden, string ngaydi)
        {
            List<BaoCao> ListBaoCao = new List<BaoCao>();

            Connect_Database connect = new Connect_Database();
            MySqlConnection mySql = connect.Connection();
            //string sql = "SELECT vdatphong.MaDP, vkhachhang.TenKH, vnhanvien.TenNV, vphong.SoPhong, vct_datphong.NgayDen, vct_datphong.NgayDi,vhoadon.Gia" +
            //    " from vkhachhang, vdatphong, vct_datphong , vhoadon, vnhanvien, vphong WHERE vkhachhang.MaKH=vdatphong.MaKH AND vdatphong.MaDP=vct_datphong.MaDP AND vkhachhang.MaKH=vhoadon.MaKHThanhToan AND vnhanvien.MaNV=vhoadon.MaNV AND vphong.MaPhong=vdatphong.MaPhong and year(vhoadon.NgayThanhToan)='"+nam+"' AND month(vhoadon.NgayThanhToan)>='"+thangden+"' and month(vhoadon.NgayThanhToan)<='"+thangdi+"' AND day(vhoadon.NgayThanhToan)>='"+ngayden+"' and day(vhoadon.NgayThanhToan)<='"+ngaydi+"'";

            string sql = "SELECT * " +
                " from vkhachhang, vdatphong, vct_datphong , vhoadon, vnhanvien, vphong WHERE vkhachhang.MaKH=vdatphong.MaKH AND vdatphong.MaDP=vct_datphong.MaDP AND vkhachhang.MaKH=vhoadon.MaKHThanhToan AND vnhanvien.MaNV=vhoadon.MaNV AND vphong.MaPhong=vdatphong.MaPhong and year(vhoadon.NgayThanhToan)='" + nam + "' AND month(vhoadon.NgayThanhToan)>='" + thangden + "' and month(vhoadon.NgayThanhToan)<='" + thangdi + "' AND day(vhoadon.NgayThanhToan)>='" + ngayden + "' and day(vhoadon.NgayThanhToan)<='" + ngaydi + "'";

            MySqlCommand command = new MySqlCommand(sql, mySql);
            
            using (var reader = command.ExecuteReader())
            {
                
                while (reader.Read())
                {
                   
                    BaoCao BC = new BaoCao((string)reader["MaDP"], (string)reader["TenKH"], (string)reader["TenNV"], (int)reader["SoPhong"], ((DateTime)reader["NgayDen"]).ToString(), ((DateTime)reader["NgayDi"]).ToString(), (double)reader["Gia"]);
                    ListBaoCao.Add(BC);
                }
            }
            return ListBaoCao;
        }
    }
}