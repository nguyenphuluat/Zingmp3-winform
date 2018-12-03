using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ZingMP3_buildproject.Model.Object;

namespace ZingMP3_buildproject.Model
{
    class UserModel
    {
        public void addUser(UserObject item)
        {
            string sql = "INSERT INTO tbluser (user_name, user_pass, user_fullname, user_address, user_phone) VALUES('"
                +item.getUser_name()+"', '"+item.getUser_pass()+"', '"
                +item.getUser_fullname()+"', '"+item.getUser_address()+"', '"
                +item.getUser_phone()+"' );";
            
            Connection.ExcuteNonQuery(sql);
        }
        public void editUser(UserObject item)
        {

        }
        public void delUser(UserObject item)
        {

        }
        public DataTable getUser(string user_name, string user_pass)
        {
            String sql = "SELECT * FROM tbluser WHERE user_name='"+user_name+"' AND user_pass= '"+user_pass+"'";
            DataTable dt = new DataTable();
            dt = Connection.getTable(sql);

            return dt;
        }

    }
}
