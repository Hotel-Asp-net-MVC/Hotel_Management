using HotelManagement.Models;
using MySql.Data.MySqlClient;
using HotelManagement.DaTa_Access_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HotelManagement.DaTa_Access_Object
{//SELECT *, SUM(Gia) FROM hoadon GROUP BY MONTH(NgayThanhToan)
    public class HoaDonDAO
    {
       // lấy thông tin hóa đơn
        public List<HoaDon> getallhoadon()
        {
            //List<HoaDon> hoadon =new List<HoaDon>();

            //Connect_Database a = new Connect_Database();
            //MySqlConnection mySqlConnection = a.Connection();

            //string sql = "select * from hoadon";
            //MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
            //using (var reader = cmd.ExecuteReader())
            //{
            //    while (reader.Read())
            //    {
            //        /*hoadon.Add(new HoaDon(reader["MaHoaDon"].ToString(), reader["MaDP"].ToString(), reader["MaKHThanhToan"].ToString(),
            //            reader["MaNV"].ToString(), reader["NgayThanhToan"].ToString(), (float)reader["Gia"]));
            //        */
            //        //  hoadon.Add(new HoaDon(reader["FullName"].ToString(), reader["Gender"].ToString(), reader["IDCardNumber"].ToString(), reader["Address"].ToString(), reader["Point"].ToString(), (float)reader["RoomID"]));
            //        hoadon.Add(new HoaDon()
            //        {
            //            MaHoaDon = reader["MaHoaDon"].ToString(),
            //            MaDP = reader["MaDP"].ToString(),
            //            MaKHThanhToan = reader["MaKHThanhToan"].ToString(),

            //            MaNV = reader["MaNV"].ToString(),
            //            NgayThanhToan = reader["NgayThanhToan"].ToString(),
            //            Gia = (float)reader["Gia"]


            //        });
            //    }
            //}
           
            List<HoaDon> hoadon = new List<HoaDon>();
            Connect_Database a = new Connect_Database();
            MySqlConnection mySqlConnection = a.Connection();
            DataTable dataTable = null;
          
            try
            {



                switch (mySqlConnection.State)

                {

                    case ConnectionState.Open:
                        string sql = "select * from hoadon";
                        MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
                        command.Connection = mySqlConnection;
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = command;
                        DataSet dataSet = new DataSet();
                        da.Fill(dataSet);
                        dataTable = new DataTable();
                        da.Fill(dataTable);
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            HoaDon customer = new HoaDon(dataTable.Rows[i][0].ToString(), dataTable.Rows[i][1].ToString(), dataTable.Rows[i][2].ToString(),dataTable.Rows[i][3].ToString(), dataTable.Rows[i][4].ToString(),(double)(dataTable.Rows[i][5]));
                            hoadon.Add(customer);
                        }

                        return hoadon;


                    case ConnectionState.Closed:
                        throw new Exception("The database connection state is Closed");



                    default:

                        break;

                }
            }
            catch (MySqlException)

            {
            }

            finally
            {
                if (mySqlConnection.State != System.Data.ConnectionState.Closed)

                {
                    mySqlConnection.Close();

                }

            }
            return hoadon;
        }
        // thống kê doah thu các tháng trong năm
        public List<double> get_doanhthuthang(string nam)
        {
            List<double> array_doanhthu = new List<double>();
            List<HoaDon> hoadon = new List<HoaDon>();

            Connect_Database a = new Connect_Database();
            MySqlConnection mySqlConnection = a.Connection();

            string sql = "SELECT *, SUM(Gia) FROM hoadon where year(NgayThanhToan)="+nam+" GROUP BY MONTH(NgayThanhToan)";
            MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    array_doanhthu.Add((double)reader["SUM(Gia)"]);
                }
            }
            return array_doanhthu;
        }
    }
}