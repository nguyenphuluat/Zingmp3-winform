using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using ZingMP3_buildproject.Model.Object;
using ZingMP3_buildproject.Model;
using System.Data;


namespace ZingMP3_buildproject.Control
{
    public class SingControl
    {
        SingModel sm = new SingModel();
        public void addSing(SingObject item)
        {
            sm.addSing(item);
        }
        public void editSing(SingObject item)
        {
            sm.editSing(item);
        }
        public void delSing(SingObject item)
        {
            sm.delSing(item);
        }

        public SingObject getSing(int sing_id) 
        {
            SingObject item = null;
            DataTableReader dt = sm.getSing(sing_id).CreateDataReader();
            if (dt.Read())
            {
                item = new SingObject();
                item.setSing_id(dt.GetInt32(0));
                item.setSing_category_id(dt.GetInt32(1));
                item.setSing_name(dt.GetString(2));
                item.setSing_author(dt.GetString(3));
                item.setSing_singer(dt.GetString(4));
                item.setSing_listened(dt.GetInt32(5));
                item.setSing_created_date(dt.GetString(6));
                item.setSing_focus(dt.GetBoolean(7));
                item.setSing_content(dt.GetString(8));
                item.setSing_path_mp3(dt.GetString(9));
                item.setSing_time(dt.GetInt32(10));
                item.setSing_dowloaded(dt.GetBoolean(11));
                item.setSing_national(dt.GetBoolean(12));
                //item.setCategory_id(dt.GetInt32(13));
                if (dt.GetString(14) != null)
                {
                    item.setCategory_name(dt.GetString(14));
                }
                else
                {
                    item.setCategory_name("");
                }
            }
            return item;
        }

        public SingObject getSing(string sing_name)
        {

            SingObject item = null;

            DataTableReader dt = sm.getSing(sing_name).CreateDataReader();

            if (dt.Read())
            {
                item = new SingObject();
                item.setSing_id(dt.GetInt32(0));
                item.setSing_category_id(dt.GetInt32(1));
                item.setSing_name(dt.GetString(2));
                item.setSing_author(dt.GetString(3));
                item.setSing_singer(dt.GetString(4));
                item.setSing_listened(dt.GetInt32(5));
                item.setSing_created_date(dt.GetString(6));
                item.setSing_focus(dt.GetBoolean(7));
                item.setSing_content(dt.GetString(8));
                item.setSing_path_mp3(dt.GetString(9));
                item.setSing_time(dt.GetInt32(10));
                item.setSing_dowloaded(dt.GetBoolean(11));
                item.setSing_national(dt.GetBoolean(12));
                //item.setCategory_id(dt.GetInt32(13));
                if (dt.GetString(14) != null)
                {
                    item.setCategory_name(dt.GetString(14));
                }
                else
                {
                    item.setCategory_name("");
                }
            }

            return item;
        }

        public List<SingObject> getSings(SingObject similar, int limit)
        {
            List<SingObject> items = new List<SingObject>();

            SingObject item = null;
            DataTableReader dt = sm.getSings(similar, limit).CreateDataReader();

            while (dt.Read())
            {
                item = new SingObject();
                item.setSing_id(dt.GetInt32(0));
                item.setSing_category_id(dt.GetInt32(1));
                item.setSing_name(dt.GetString(2));
                item.setSing_author(dt.GetString(3));
                item.setSing_singer(dt.GetString(4));
                item.setSing_listened(dt.GetInt32(5));
                item.setSing_created_date(dt.GetString(6));
                item.setSing_focus(dt.GetBoolean(7));
                item.setSing_content(dt.GetString(8));
                item.setSing_path_mp3(dt.GetString(9));
                item.setSing_time(dt.GetInt32(10));
                item.setSing_dowloaded(dt.GetBoolean(11));
                item.setSing_national(dt.GetBoolean(12));
                //item.setCategory_id(dt.GetInt32(13));
                if (dt.GetString(14) != null)
                {
                    item.setCategory_name(dt.GetString(14));
                }
                else
                {
                    item.setCategory_name("");
                }
                
                items.Add(item);
                
            }

            return items;
        }

        public List<SingObject> getSearchSings(string search)
        {
            List<SingObject> items = new List<SingObject>();

            SingObject item = null;
            DataTableReader dt = sm.getSings(search).CreateDataReader();

            while (dt.Read())
            {
                item = new SingObject();
                item.setSing_id(dt.GetInt32(0));
                item.setSing_category_id(dt.GetInt32(1));
                item.setSing_name(dt.GetString(2));
                item.setSing_author(dt.GetString(3));
                item.setSing_singer(dt.GetString(4));
                item.setSing_listened(dt.GetInt32(5));
                item.setSing_created_date(dt.GetString(6));
                item.setSing_focus(dt.GetBoolean(7));
                item.setSing_content(dt.GetString(8));
                item.setSing_path_mp3(dt.GetString(9));
                item.setSing_time(dt.GetInt32(10));
                item.setSing_dowloaded(dt.GetBoolean(11));
                item.setSing_national(dt.GetBoolean(12));
                //item.setCategory_id(dt.GetInt32(13));
                if (dt.GetString(14) != null)
                {
                    item.setCategory_name(dt.GetString(14));
                }
                else
                {
                    item.setCategory_name("");
                }

                items.Add(item);

            }

            return items;
        }
    }
}
