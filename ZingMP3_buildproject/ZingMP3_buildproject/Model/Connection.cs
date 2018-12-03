using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ZingMP3_buildproject.Model
{
    class Connection
    {
        public static SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=DESKTOP-TKMNHTF\SQLEXPRESS;Initial Catalog=zingmp3_data;Integrated Security=True");
        }
        //lệnh trả về 1 bảng 
        public static DataTable getTable(string sql)
        {
            SqlConnection con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.Close();
            return dt;
        }

        //lệnh không trả về bảng
        public static void ExcuteNonQuery(String sql)
        {
           
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
            con.Close();
        }

            
    }
}
