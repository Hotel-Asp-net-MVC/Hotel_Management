using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyKhachSan.DaTa_Access_Object
{
	public class Connect_Database
	{
		public MySqlConnection Connection()
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            mySqlConnection.ConnectionString = "Server=localhost;Port=3306;Database=quanlikhachsan;Uid=root;Pwd=;";

            return mySqlConnection;
        }
    }
}