using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.DaTa_Access_Object
{
    public class KhachHangDAO
    {
        public void AddKhachHang(string makh, string tenkh, string cmnd, string gioitinh, string diachi ,string dt, string quoctich)
        {
            Connect_Database connect = new Connect_Database();
            MySqlConnection mySql = connect.Connection();
            string sql = "INSERT INTO `khachhang`(`MaKH`, `TenKH`, `CMND`, `GioiTinh`, `DiaChi`, `DienThoai`, `QuocTich`)" +
                " VALUES ('"+makh+"','"+tenkh+"','"+cmnd+"','"+gioitinh+"','"+diachi+"','"+dt+"','"+quoctich+"')";
            MySqlCommand command = new MySqlCommand(sql, mySql);
            command.ExecuteReader();
        }
    }
}