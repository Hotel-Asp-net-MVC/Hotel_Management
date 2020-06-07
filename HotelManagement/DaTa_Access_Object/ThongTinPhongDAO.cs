using HotelManagement.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.DaTa_Access_Object
{
    public class ThongTinPhongDAO
    {
        public List<ThongTinPhong> GetAllThongTinPhong()
        {
            List<ThongTinPhong> ThongTin = new List<ThongTinPhong>();
            Connect_Database connect = new Connect_Database();
            MySqlConnection mySql = connect.Connection();
            string sql = "select * FROM phong, loaiphong WHERE phong.MaLoaiPhong=loaiphong.MaLoaiPhong";
            MySqlCommand command = new MySqlCommand(sql, mySql);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ThongTinPhong TTP = new ThongTinPhong((string)reader["TenLoaiPhong"], (int)reader["SoPhong"], (string)reader["TrangThai"],null, null, null);
                    ThongTin.Add(TTP);
                }
            }
            for (int i=0;i<ThongTin.Count();i++)
            {
                if (ThongTin[i].TrangThai!="Trong")
                {
                     string sqltt= "select * from phong ,datphong, ct_datphong, khachhang WHERE phong.MaPhong= datphong.MaPhong AND datphong.MaKH=khachhang.MaKH AND datphong.MaDP= ct_datphong.MaDP and phong.SoPhong="+ ThongTin[i].SoPhong +"";
                    MySqlCommand command_ct = new MySqlCommand(sqltt, mySql);
                    var reader = command_ct.ExecuteReader();
                    while (reader.Read())
                    {
                        ThongTin[i].TenKhachHang = (string)reader["TenKH"];
                        ThongTin[i].ThoiGianDen = ((DateTime)(reader["NgayDen"])).ToString();
                        ThongTin[i].ThoiGianDi=reader["NgayDi"].ToString();
                    }
                    
                    
                }
            }
            return ThongTin;
        }
        //lấy thông tin đặt phòng trong ngày
       //public ThongTinPhong GetThongTinDatPhong(string maphong, string ngay, string thang , string nam)
       //{
       //     Connect_Database connect = new Connect_Database();
       //     MySqlConnection mySql = connect.Connection();
       //     string sql = "";
       //     MySqlCommand command = new MySqlCommand(sql, mySql);
       //     ThongTinPhong thongtin = new ThongTinPhong();

       //     var reader = command.ExecuteReader();
       //     while (reader.Read())
       //     {

       //         thongtin.
       //     }

       //     return 0;
       //}
    }
}