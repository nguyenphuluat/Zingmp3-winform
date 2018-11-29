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
                
                
                tmp += "sing_dowloaded = '"+similar.getSing_dowloaded()+"' ";
            }
            return tmp;
        }
    }
}
