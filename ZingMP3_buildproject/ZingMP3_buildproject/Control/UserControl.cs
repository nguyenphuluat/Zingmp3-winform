using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZingMP3_buildproject.Model;
using ZingMP3_buildproject.Model.Object;

namespace ZingMP3_buildproject.Control
{
    class UserControl
    {
        UserModel cm = new UserModel();
        public void addUser(UserObject item)
        {
            cm.addUser(item);
        }
        public void editUser(UserObject item)
        {
            cm.editUser(item);
        }
        public void dellUser(UserObject item)
        {
            cm.delUser(item);
        }

        
    }
}
