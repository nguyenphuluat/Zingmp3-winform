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
using System.IO;




namespace ZingMP3_buildproject.View
{
    public partial class SingAE : Form
    {

        public SingAE()
        {
            InitializeComponent();
        }

        public void  SingEdit(SingObject item)
        {
            this.txtSingName.Text = item.getSing_name();
            this.txtCreatDate.Text = item.getSing_created_date();
            this.txtAuthor.Text = item.getSing_author();
            this.txtContent.Text = item.getSing_content();
            this.txtFileMp3.Text = item.getSing_path_mp3();
            this.txtSinger.Text = item.getSing_singer();
            this.txtTime.Text = item.getSing_time().ToString();
            this.btnAE.Text = "Sửa";
            this.lblSing_id.Text = item.getSing_id().ToString();
            
            //(cbxCategory.SelectedItem as dynamic).Value = item.getCategory_id();
            //item.getSing_national() ? this.cbxNational.SelectedText = "Trong nước" : this.cbxNational.SelectedText = "Quốc tế";
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFileMp3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory =  @"D:\\ ";
            file.RestoreDirectory = true;
            file.Title = "Chọn file mp3";
            file.DefaultExt = "mp3";
            
            DialogResult dr = file.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try  
                {
                    txtFileMp3.Text = file.FileName;
                    txtFileMp3.BackColor = Color.White;
                    //Mp3FileReader reader = new Mp3FileReader("txtFileMp3.Text");
                    //TimeSpan duration = reader.TotalTime;
                    
                }  
                catch  (Exception ex)  
                {  
                    MessageBox.Show ( "Lỗi:"  + ex.Message);  
                }  
            }
        }

        private void txtSingName_TextChanged(object sender, EventArgs e)
        {
            if (!txtSingName.Text.Equals(""))
            {
                txtSingName.BackColor = Color.White;
            }
            else
            {
                this.txtSingName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(193)))));
            }
        }

        private void SingAE_Load(object sender, EventArgs e)
        {
            cbxCategory.DisplayMember = "Text";
            cbxCategory.ValueMember = "Value";
            CategoryControl cc = new CategoryControl();
            List<CategoryObject> items = cc.getCategorys();

            for (int i = 0; i < items.Count; i++)
            {
                cbxCategory.Items.Add(new { Text = items[i].getCategory_name(), Value = items[i].getCategory_id() });

            }
           
            
            
        }

        private void txtSinger_TextChanged(object sender, EventArgs e)
        {
            if (!txtSinger.Text.Equals(""))
            {
                txtSinger.BackColor = Color.White;
            }
            else
            {
                txtSinger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(193)))));
            }
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            if (!txtAuthor.Text.Equals(""))
            {
                txtAuthor.BackColor = Color.White;
            }
            else
            {
                txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(193)))));
            }
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            if (!txtContent.Text.Equals(""))
            {
                txtContent.BackColor = Color.White;
            }
            else
            {
                txtContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(193)))));
            }
        }

        private void btnAE_Click(object sender, EventArgs e)
        {
            string sing_name = txtSingName.Text.Trim();
            bool sing_national = cbxNational.Text.Equals("Trong nước") ? true : false;
            string singer = txtSinger.Text.Trim();
            //--------------XU LY FILE MP3----------------
            string file_mp3_temp = txtFileMp3.Text;
            string[] temp = file_mp3_temp.Split('\\');
            string file_name = temp[temp.Length - 1];
            file_name = file_name.Substring(0, file_name.Length - 4);
            string file_mp3 = @"C:\Csharp\ZingMp3\Path_mp3\"+ file_name +".mp3";
            //Copy file
            file_mp3 = Library.File_Me.CoppyFile(file_mp3_temp, file_mp3);
            


            if (!file_mp3.Equals(""))
            {
                string[] file = file_mp3.Split('\\');
                file_mp3 = @"..\..\..\..\";
                for (int i = file.Length - 2; i < file.Length; i++)
                {
                    file_mp3 += file[i] + "\\";
                }
                file_mp3 = file_mp3.Substring(0, file_mp3.Length - 1);
            }
            string author = txtAuthor.Text.Trim();
            string sing_content = txtContent.Text.Trim();
            string sing_create_date = txtCreatDate.Text;
            Double sing_time = 0;
            try {
                //get relativePath
                string RelativePath = txtFileMp3.Text;
                string AbsolutePath = Path.GetFullPath(Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), RelativePath));
                WMPLib.IWMPMedia media = this.MediaAE.newMedia(AbsolutePath);
                sing_time = media.duration;
            }catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }

            
            int sing_category = 0;
            if (cbxCategory.SelectedIndex != -1)
            {
                sing_category = (cbxCategory.SelectedItem as dynamic).Value;
            }

            string messager = "";
            if (sing_name.Equals(""))
            {
                messager += "Tên bài hát\n";
            }
            if (singer.Equals(""))
            {
                messager += "Tên ca sĩ\n";
            }
            if (sing_category == 0)
            {
                messager += "Thể loại\n";
            }
            if (file_mp3.Equals(""))
            {
                messager += "File mp3\n";
            }
            if (author.Equals(""))
            {
                messager += "Tác giả\n";
            }
            if (sing_content.Equals(""))
            {
                messager += "Nội dung bài hát\n";
            }


            if (!messager.Equals(""))
            {
                messager += "không được để trống.";
                MessageBox.Show(messager, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SingObject so = new SingObject();
                so.setSing_category_id(sing_category);
                so.setSing_singer(singer);
                so.setSing_author(author);
                so.setSing_content(sing_content);
                so.setSing_created_date(sing_create_date);
                so.setSing_name(sing_name);
                so.setSing_listened(0);
                so.setSing_path_mp3(file_mp3);
                so.setSing_national(sing_national);
                so.setSing_time((int)sing_time);

                SingControl sc = new SingControl();
                if(btnAE.Text.Equals("Thêm"))
                {
                    sc.addSing(so);
                }
                else if (btnAE.Text.Equals("Sửa"))
                {
                    so.setSing_id(Int32.Parse(lblSing_id.Text));
                    sc.editSing(so);
                }

                SingView.singview.SingView_Load(sender, e);
                this.Close();
                
                
               

            }
            
        }

        private void txtFileMp3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtFileMp3.BackColor = Color.White;
                //get relativePath
                string RelativePath = txtFileMp3.Text;
                string AbsolutePath = Path.GetFullPath(Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), RelativePath));
                WMPLib.IWMPMedia media = this.MediaAE.newMedia(AbsolutePath);
                txtTime.Text = media.durationString;
            }catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
            txtTime.BackColor = Color.White;
        }

       
        

        

     
 
        
    }
}
