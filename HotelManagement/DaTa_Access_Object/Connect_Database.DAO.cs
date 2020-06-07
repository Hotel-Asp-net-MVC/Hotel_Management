using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.DaTa_Access_Object
{
	public class Connect_Database
	{
		public MySqlConnection Connection()
        {
            //string host = "localhost";
            //int port = 3306;
            //string database = "quanlikhachsan";
            //string username = "";
            //string password = "";
            MySqlConnection mySqlConnection = new MySqlConnection();
            mySqlConnection.ConnectionString = "Server=localhost;Port=3306;Database=quanlikhachsan;Uid=phamduycuong;Pwd=phamduycuong1340;";
            /*mySqlConnection.ConnectionString = "Server = " + host + "; Database = " + database
                   + ";port=" + port + ";User Id=" + username + ";password=" + password +"";*/
            mySqlConnection.Open();
            return mySqlConnection;
        }
    }
}