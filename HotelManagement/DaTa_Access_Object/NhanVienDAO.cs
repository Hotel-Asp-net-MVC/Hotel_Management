using HotelManagement.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.DaTa_Access_Object
{
    public class NhanVienDAO
    {
        public List<NhanVien> GetAllNhanVien()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();

            Connect_Database connect = new Connect_Database();
            MySqlConnection mySql = connect.Connection();
            string sql = "select * from nhanvien";
            MySqlCommand command = new MySqlCommand(sql, mySql);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    NhanVien NV = new NhanVien((string)reader["MaNV"], (string)reader["TenNV"], (string)reader["ViTri"], (string)reader["UserName"], (string)reader["Password"],
                        (string)reader["CMND"], (string)reader["GioiTinh"], (string)reader["DiaChi"], (string)reader["DienThoai"], (string)reader["Email"]);
                    nhanViens.Add(NV);
                }
            }
            return nhanViens;
        }
        public void AddNhanVien(string tennv,string vitri, string user , string pass, string sdt, string cmnd)
        {
            string manv = "NV" + cmnd;
            Connect_Database connect = new Connect_Database();
            MySqlConnection mySql = connect.Connection();
            string sql = "INSERT INTO `nhanvien`(`MaNV`, `TenNV`, `ViTri`, `UserName`, `Password`, `CMND`, `GioiTinh`, `DiaChi`, `DienThoai`, `Email`) VALUES " +
                "('"+manv+"','"+tennv+"','"+vitri+"','"+user+"','"+pass+"','"+cmnd+"','','','"+sdt+"','')";
            MySqlCommand command = new MySqlCommand(sql, mySql);
            command.ExecuteReader();
        }
    }
}