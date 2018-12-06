using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZingMP3_buildproject.Control;
using ZingMP3_buildproject.Model.Object;

namespace ZingMP3_buildproject.View
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void txtUserName_Enter(object sender, EventArgs e)

        {
            if (txtUserName.Text == "user name")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Gray;
            }        
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "user name";
                txtUserName.ForeColor = Color.DarkGray;
            }
        }

        private void txtUserPass_Enter(object sender, EventArgs e)
        {
            if (txtUserPass.Text == "user pass")
            {
                txtUserPass.Text = "";

                txtUserPass.ForeColor = Color.Gray;
            }
            
        }

        private void txtUserPass_Leave(object sender, EventArgs e)
        {
            if (txtUserPass.Text == "")
            {
                
                txtUserPass.Text = "user pass";
                txtUserPass.ForeColor = Color.DarkGray;
            }
        }

        private void txtUserPass_TextChanged(object sender, EventArgs e)
        {
            txtUserPass.PasswordChar = '\u25CF';
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user_name = txtUserName.Text.Trim();
            string user_pass = txtUserPass.Text.Trim();
            if (user_name != "" && user_pass != "")
            {
                LoginControl lc = new LoginControl();

                UserObject user = lc.Login(user_name, user_pass);
                if (user != null)
                {
                    SingView SingView = new SingView();
                    SingView.Show();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Login", MessageBoxButtons.OK);
                }
                
            }
        }
    }
}
