using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.DaTa_Access_Object
{
    public class DatPhongDAO
    {
        public void AddDatPhong(string madp, string makh,string sophong, string ngaydat, string songl, string sotre, string tiencoc)
        {
            Connect_Database connect = new Connect_Database();
            MySqlConnection mySql = connect.Connection();
            string map = null;
            // lấy mã phòng từ số phòng
            string sql_map = "SELECT `MaPhong` FROM `phong` WHERE SoPhong='"+sophong+"'";
            MySqlCommand command_map = new MySqlCommand(sql_map, mySql);
            using (var reader = command_map.ExecuteReader())
            {
                while (reader.Read())
                {
                    map = (string)reader["MaPhong"];
                }
            }
            
               
            //------------------

            string sql = "INSERT INTO `datphong`(`MaDP`, `MaKH`, `MaPhong`, `NgayDat`, `SoNguoiLon`, `SoTreCon`, `TienDatCoc`) " +
                "VALUES ('"+madp+"','"+makh+"','"+map+"','"+ngaydat+"','"+songl+"','"+sotre+"','"+tiencoc+"')";
            MySqlCommand command = new MySqlCommand(sql, mySql);
            command.ExecuteReader();
        }
    }
}