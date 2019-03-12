using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Extensions.Forms;
using ZingMP3_buildproject.Model.Object;
using ZingMP3_buildproject.Control;
using ZingMP3_buildproject.View;
using ZingMP3_buildproject;

namespace TestZing_mp3.Test
{
    [TestFixture]

    public class Login_Test
    {
        [Test]
        public void Login(string userName, string passWord)
        {
            UserObject uo = new UserObject();
            UserObject uo_tesst = new UserObject(1, "admin", "admin","Nguyễn Trọng Hải", "Giao An, Giao Thủy, Nam Định", "0975086498" );
            LoginControl lc = new LoginControl();
            uo = lc.Login(userName, passWord);

            Assert.AreEqual(uo,uo_tesst);
            
        }
    }
}
