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
    }
}