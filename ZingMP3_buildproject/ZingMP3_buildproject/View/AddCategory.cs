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
    public partial class AddCategory : Form
    {
        
        public AddCategory()
        {
            InitializeComponent();
        }

        public AddCategory(CategoryObject co)
        {
            InitializeComponent();
            btnAdd.Text = "Sửa";
            txtCategory.Text = co.getCategory_name();
            lblCategory_id.Text = co.getCategory_id().ToString();
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txtCategory.Text.Equals(""))
            { 
                CategoryControl cc = new CategoryControl();
                CategoryObject co = new CategoryObject();
                co.setCategory_name(txtCategory.Text);
                if (btnAdd.Text.Equals("Thêm"))
                {
                    cc.addCategory(co);
                }
                else if (btnAdd.Text.Equals("Sửa"))
                {
                    co.setCategory_id(Int32.Parse(lblCategory_id.Text));
                    cc.editCategory(co);
                }
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Tên thể loại không hợp lệ. Vui lòng kiểm tra lại");
            }
        }
    }
}
