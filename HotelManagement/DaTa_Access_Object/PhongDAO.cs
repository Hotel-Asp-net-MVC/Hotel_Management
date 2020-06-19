using HotelManagement.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.DaTa_Access_Object
{
    public class PhongDAO
    {
        //update trạng thái phòng khi có thay đổi (qua ngày mới )
        public void UpdateStatusPhong(string status, string maphong)
        {
            //UPDATE `phong` SET `TrangThai`='Da Dat' WHERE phong.MaPhong='p001'
            Connect_Database connect = new Connect_Database();
            MySqlConnection mySql = connect.Connection();
            string sql = "UPDATE `phong` SET `TrangThai`='"+status+"' WHERE phong.MaPhong='"+maphong+"' ";
            MySqlCommand command = new MySqlCommand(sql, mySql);
            command.ExecuteReader();
        }
        //update trạng thái phòng theo số phòng

        public void UpdateStatus(string status, string sophong)
        {
            //UPDATE `phong` SET `TrangThai`='Da Dat' WHERE phong.MaPhong='p001'
            Connect_Database connect = new Connect_Database();
            MySqlConnection mySql = connect.Connection();
            string sql = "UPDATE `phong` SET `TrangThai`='" + status + "' WHERE phong.SoPhong='" + sophong + "' ";
            MySqlCommand command = new MySqlCommand(sql, mySql);
            command.ExecuteReader();
        }
        // lấy thông tin của tất cả các phong
        public List<Phong> GetAllPhong()
        {
            List<Phong> ListPhong = new List<Phong>();
            Connect_Database connect = new Connect_Database();
            MySqlConnection mySql = connect.Connection();
            string sql = "select * from phong, loaiphong WHERE phong.MaLoaiPhong=loaiphong.MaLoaiPhong";
            MySqlCommand command = new MySqlCommand(sql, mySql);
            using(var reader= command.ExecuteReader())
            {
                while(reader.Read())
                {
                    Phong P = new Phong((string)reader["MaPhong"], (string)reader["MaLoaiPhong"], (int)reader["SoPhong"], (string)reader["TrangThai"], (string)reader["TenLoaiPhong"]);
                    ListPhong.Add(P);
                }
            }
            return ListPhong;
        }

        //thêm mới 1 phòng
        public void AddPhong(string maphong, string sophong , string tenlp )
        {
            string maloaiphong = null ;
            Connect_Database connect = new Connect_Database();
            MySqlConnection mySql = connect.Connection();
            string sql = "SELECT MaLoaiPhong FROM `loaiphong` WHERE loaiphong.TenLoaiPhong='"+tenlp+"'";
            MySqlCommand command = new MySqlCommand(sql, mySql);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    maloaiphong = (string)reader["MaLoaiPhong"];
                }
            }


            //string sql_addphong = "INSERT INTO `phong`(`MaPhong`, `MaLoaiPhong`, `SoPhong`, `TrangThai`) VALUES ('"+maphong+"','"+maloaiphong+"','"+sophong+"','Trống')";
            string sql_addphong = "INSERT INTO `phong`(`MaPhong`, `MaLoaiPhong`, `SoPhong`, `TrangThai`) VALUES ('"+maphong+"','"+maloaiphong+"','"+sophong+"','Trong')";
            MySqlCommand cmd = new MySqlCommand(sql_addphong, mySql);
            cmd.ExecuteReader();

        }
        
    }
}