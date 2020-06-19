using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.DaTa_Access_Object
{
    public class CT_DatPhongDAO
    {
        public void AddCT_DatPhong(string madp, string thoigiannhan, string ngayden, string ngaydi)
        {
            Connect_Database connect = new Connect_Database();
            MySqlConnection mySql = connect.Connection();
            string sql = "INSERT INTO `ct_datphong`( `MaDP`, `ThoiGianNhan`, `NgayDen`, `NgayDi`)" +
                " VALUES ('"+madp+"','"+thoigiannhan+"','"+ngayden+"','"+ngaydi+"')";
            MySqlCommand command = new MySqlCommand(sql, mySql);
            command.ExecuteReader();
        }
    }
}