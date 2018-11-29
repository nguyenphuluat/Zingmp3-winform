using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZingMP3_buildproject.Model.Object
{
    public class UserObject
    {
        private int user_id;
        private string user_name;
        private string user_pass;
        private string user_fullname;
        private string user_address;
        private string user_phone;
        //GET SET  
        public UserObject() { }
        public UserObject(int user_id, string user_name, string user_pass, string user_fullname, string user_address, string user_phone) {
            this.user_id = user_id;
            this.user_name = user_name;
            this.user_pass = user_pass;
            this.user_address = user_address;
            this.user_phone = user_phone;
        }
        public UserObject(string user_name, string user_pass, string user_fullname, string user_address, string user_phone)
        {
            
            this.user_name = user_name;
            this.user_pass = user_pass;
            this.user_address = user_address;
            this.user_phone = user_phone;
        }
        public void setUser_id(int user_id)
        {
            this.user_id = user_id;
        }
        public int getUser_id()
        {
            return this.user_id;
        }

        public void setUser_name(string user_name)
        {
            this.user_name = user_name;
        }
        public string getUser_name()
        {
            return this.user_name;
        }

        public void setUser_pass(string user_pass)
        {
            this.user_pass = user_pass;
        }
        public string getUser_pass()
        {
            return this.user_pass;
        }

        public void setUser_fullname(string user_fullname)
        {
            this.user_fullname = user_fullname;
        }
        public string getUser_fullname()
        {
            return this.user_fullname;
        }
        public void setUser_address(string user_address)
        {
            this.user_address = user_address;
        }
        public string getUser_address()
        {
            return this.user_address;
        }

        public void setUser_phone(string user_phone)
        {
            this.user_phone = user_phone;
        }
        public string getUser_phone()
        {
            return this.user_phone;
        }

    }
}
