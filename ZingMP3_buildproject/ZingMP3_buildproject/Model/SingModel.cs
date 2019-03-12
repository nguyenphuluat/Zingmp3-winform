using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ZingMP3_buildproject.Model.Object;
using ZingMP3_buildproject.Model.sql;

namespace ZingMP3_buildproject.Model
{
    public class SingModel
    {
        public void addSing(SingObject item)
        {
            string sql = "INSERT INTO tblsing( sing_category_id, sing_name, sing_author,"
                +" sing_singer, sing_listened, sing_created_date, sing_focus, sing_content, "
                +"sing_path_mp3, sing_time, sing_dowloaded, sing_national) VALUES ('"
                +item.getSing_category_id()+"', N'"+item.getSing_name()+"', N'"
                +item.getSing_author()+"', N'"+item.getSing_singer()+"', N'"+item.getSing_listened()+"', '"
                +item.getSing_created_date()+"', '"+item.getSing_focus()+"', N'"+item.getSing_content()+"', '"
                +item.getSing_path_mp3()+"', '"+item.getSing_time()+"', '"+item.getSing_dowloaded()+"', '"
                +item.getSing_national()+"' ); ";

           Connection.ExcuteNonQuery(sql);
        }
        public void editSing(SingObject item)
        {
            string sql = "UPDATE tblsing SET sing_category_id = '" + item.getSing_category_id()
                + "' , sing_name = N'" + item.getSing_name() + "', sing_author = N'" + item.getSing_author() + "',"
                + " sing_singer = N'" + item.getSing_singer() + "', sing_listened = '" + item.getSing_listened()
                + "', sing_created_date = '" + item.getSing_created_date() + "', sing_focus = '" + item.getSing_focus()
                + "', sing_content = N'" + item.getSing_content() + "', "
                + "sing_path_mp3 = '" + item.getSing_path_mp3() + "', sing_time = '" + item.getSing_time()
                + "', sing_dowloaded = '" + item.getSing_dowloaded() + "', sing_national = '" + item.getSing_national()
                
                + "' WHERE sing_id = '" + item.getSing_id() + "';";
                

            Connection.ExcuteNonQuery(sql);
        }
        public void delSing(SingObject item)
        {
            string sql = "DELETE FROM tblsing WHERE sing_id = '" + item.getSing_id() + "';";
            Connection.ExcuteNonQuery(sql);
        }



        public DataTable getSing(int sing_id)
        {
            String sql = "SELECT * FROM tblsing LEFT JOIN tblcategory ON sing_category_id = category_id "
                +"WHERE sing_id = '"+sing_id+"'";
            DataTable dt = new DataTable();
            dt = Connection.getTable(sql);

            return dt;
        }
        public DataTable getSing(string sing_name)
        {
            String sql = "SELECT * FROM tblsing LEFT JOIN tblcategory ON sing_category_id = category_id "
                + "WHERE sing_name = N'" + sing_name + "'";
            DataTable dt = new DataTable();
            dt = Connection.getTable(sql);

            return dt;
        }
        public DataTable getSings(SingObject similar, int limit)
        {
            String sql = "SELECT * FROM tblsing LEFT JOIN tblcategory ON sing_category_id = category_id  ";
            sql += "";
            if (similar != null)
            {
                sql += "WHERE ";
                sql += Condition.ConditionForSings(similar);
            }
            //sql += " LIMIT " + limit + ";";
            DataTable dt = new DataTable();
            dt = Connection.getTable(sql);

            return dt;
        }

        //search sing
        public DataTable getSings(string search)
        {
            String sql = "SELECT * FROM tblsing LEFT JOIN tblcategory ON sing_category_id = category_id  ";
            sql += "where sing_name like '%" + search + "%' OR sing_singer like '%" + search + "%' OR sing_author like '%" + search
                + "%' OR sing_content like '%" + search + "%' OR category_name like '%" + search + "%'";
           
            //sql += " LIMIT " + limit + ";";
            DataTable dt = new DataTable();
            dt = Connection.getTable(sql);

            return dt;
        }
    }
}
