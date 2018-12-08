using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZingMP3_buildproject.Model.Object;

namespace ZingMP3_buildproject.View
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        public AddUser(UserObject uo)
        {
            InitializeComponent();
            
            btnAE.Text = "Sửa";
            txtUserName.Text = uo.getUser_name();
            txtUserName.ReadOnly = true;
            lblUserId.Text = uo.getUser_id().ToString();
            txtUserPass.Text = uo.getUser_pass();
            txtUserFullNmae.Text = uo.getUser_fullname();
            txtUserAddress.Text = uo.getUser_address();
            txtUserPhone.Text = uo.getUser_phone();
           
        }

        private void btnAE_Click(object sender, EventArgs e)
        {
            Control.UserControl uc = new Control.UserControl();
            UserObject uo = new UserObject();
            uo.setUser_name(txtUserName.Text);
            uo.setUser_pass(txtUserPass.Text);
            uo.setUser_fullname(txtUserFullNmae.Text);
            uo.setUser_address(txtUserAddress.Text);
            uo.setUser_phone(txtUserPhone.Text);
            if (btnAE.Text.Equals("Thêm"))
            {
                uc.addUser(uo);
            }
            else if (btnAE.Text.Equals("Sửa"))
            {
                uo.setUser_id(Int32.Parse(lblUserId.Text));
                uc.editUser(uo);
            }
            this.Close();
        }
    }
}
