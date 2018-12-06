using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZingMP3_buildproject.Model.Object;

namespace ZingMP3_buildproject.Model.sql
{
    class Condition
    {
        public static string ConditionForSings(SingObject similar){
            string tmp = "";

            if (similar != null)
            {
                if (similar.getSing_content() == "sing_dowloaded")
                {
                    tmp += "sing_dowloaded = '" + similar.getSing_dowloaded() + "' ";
                }
                if (similar.getSing_content() == "sing_focus")
                {
                    tmp += "sing_focus = '" + similar.getSing_focus() + "' ";
                }
                if (similar.getSing_content() == "sing_search")
                {
                    tmp += " sing_name like '%" + similar.getSing_name() + "%' OR sing_singer like '%" + similar.getSing_name() + "%' OR sing_author like '%" + similar.getSing_name()
                + "%' OR sing_content like '%" + similar.getSing_name() + "%' OR category_name like '%" + similar.getSing_name() + "%'";
                }
                
            }
            return tmp;
        }
    }
}
