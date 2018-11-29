using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZingMP3_buildproject.Model;
using System.Data;
using ZingMP3_buildproject.Model.Object;

namespace ZingMP3_buildproject.Control
{
    class LoginControl
    {
        UserModel um = new UserModel();
        public UserObject Login(string user_name, string user_pass)
        {
            UserObject item = null;
            DataTableReader dt = um.getUser(user_name, user_pass).CreateDataReader();
            if (dt != null)
            {
                
                if (dt.Read())
                {
                    item = new UserObject();
                    item.setUser_id(dt.GetInt32(0));
                    item.setUser_name(dt.GetString(1));
                    item.setUser_pass(dt.GetString(2));
                    item.setUser_fullname(dt.GetString(3));
                    item.setUser_address(dt.GetString(4));
                    item.setUser_phone(dt.GetString(5));

                }
                
               
            }
                
            return item;
        }
    }
}
