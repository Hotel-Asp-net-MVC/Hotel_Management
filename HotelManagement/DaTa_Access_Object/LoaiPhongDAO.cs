using HotelManagement.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.DaTa_Access_Object
{
    public class LoaiPhongDAO
    {
        public List<LoaiPhong> GetAllLoaiPhong()
        {
            List<LoaiPhong> loaiphong = new List<LoaiPhong>();
            Connect_Database connect = new Connect_Database();
            MySqlConnection mySql = connect.Connection();
            string sql = "SELECT * FROM `loaiphong`";
            MySqlCommand command = new MySqlCommand(sql, mySql);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                   
                    LoaiPhong LP = new LoaiPhong((string)reader["MaLoaiPhong"], (string)reader["TenLoaiPhong"], (int)reader["SoNguoiLon"], (int)reader["SoTreCon"],(double)reader["GiaTheoNgay"],(double)reader["GiaQuaDem"], (double)reader["GiaTuan"], (double)reader["GiaThang"]);
                    loaiphong.Add(LP);
                }
            }
            //mySql.Close();
            return loaiphong;
        }

        public void AddLoaiPhong(string maloaiphong, string tenloaiphong, string songuoilon, string sotrecon, string giatheongay)
        {
            Connect_Database connect = new Connect_Database();
            MySqlConnection mySql = connect.Connection();
            string sql = "INSERT INTO `loaiphong`(`MaLoaiPhong`, `TenLoaiPhong`, `SoNguoiLon`, `SoTreCon`, `GiaTheoNgay`, `GiaQuaDem`, `GiaTuan`, `GiaThang`) VALUES ('"+maloaiphong+"','"+tenloaiphong+"','"+songuoilon+"','"+sotrecon+"','"+giatheongay+"','','','')";
            MySqlCommand command = new MySqlCommand(sql, mySql);
            command.ExecuteReader();
        }
    }
}