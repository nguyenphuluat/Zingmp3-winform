using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ZingMP3_buildproject.Model.Object;
using ZingMP3_buildproject.Control;

namespace ZingMP3_buildproject.View
{
    public partial class AddAllSing : Form
    {
        public AddAllSing()
        {
            InitializeComponent();
        }

        private void bntBrowse_Click(object sender, EventArgs e)
        {
            this.ListFileMP3 = new FolderBrowserDialog();
            DialogResult result = ListFileMP3.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtLinkFile.Text = ListFileMP3.SelectedPath;
            }
        }

        private void txtLinkFile_TextChanged(object sender, EventArgs e)
        {
            if (!txtLinkFile.Text.Equals(""))
            {
                this.bntComfig.Enabled = true;
            }
        }

        private void bntComfig_Click(object sender, EventArgs e)
        {

            FileInfo info;
            String mes = "";
            SingObject so = new SingObject();
            SingObject so_template = new SingObject();
            SingControl sc = new SingControl();
            if (rdoTrongNuoc.Checked)
            {
                so.setSing_national(true);
            }
            else
            {
                so.setSing_national(false);
            }
            string file_mp3_temp = "";
            string[] temp;  
            string file_name;
            string file_mp3 = "";
            foreach (string file in Directory.EnumerateFiles(txtLinkFile.Text, "*.mp3"))
            {

                info = new FileInfo(file);

                file_mp3_temp = info.FullName;
                temp = file_mp3_temp.Split('\\');
                file_name = temp[temp.Length - 1];
                file_name = file_name.Substring(0, file_name.Length - 4);

                file_mp3 = @"C:\Csharp\ZingMp3\Path_mp3\" + file_name + ".mp3";
                //Copy file
                file_mp3 = Library.File_Me.CoppyFile(file_mp3_temp, file_mp3);
                if (!file_mp3.Equals(""))
                {
                    string[] files = file_mp3.Split('\\');
                    file_mp3 = @"..\..\..\..\";
                    for (int i = files.Length - 2; i < files.Length; i++)
                    {
                        file_mp3 += files[i] + "\\";
                    }
                    file_mp3 = file_mp3.Substring(0, file_mp3.Length - 1);
                }

                so.setSing_name(info.Name);
                WMPLib.IWMPMedia media = this.Media.newMedia(info.FullName);
                so.setSing_time((int)media.duration);
                so.setSing_singer("Đang cập nhật");
                so.setSing_content("Đang cập nhật");
                so.setSing_author("Đang cập nhật");
                so.setSing_path_mp3(file_mp3);
                so.setSing_category_id(13);
                
                so.setSing_created_date(info.CreationTime.ToString().Split(' ')[0]);
                so_template = sc.getSing(so.getSing_name());
                if (so_template == null)
                {
                    sc.addSing(so);
                    mes += so.getSing_name() + " --- Đã được thêm.\n";
                }
                else
                {
                    mes += so.getSing_name() + " --- Đã tồn tại.\n";
                }
                
            }
            if (!mes.Equals(""))
            {
                MessageBox.Show(mes);
                SingView.singview.SingView_Load(sender, e);
                this.Close();
            }
            else
            {
                mes += "Không có bài hát nào được tìm thấy trong tệp";
                MessageBox.Show(mes);
            }
            
            
        }
    }
}
