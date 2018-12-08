using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZingMP3_buildproject.Control;
using System.Collections;
using ZingMP3_buildproject.Model.Object;
using System.Windows.Media;
using System.IO;
using ZingMP3_buildproject.Model;



namespace ZingMP3_buildproject.View
{
    public partial class SingView : Form
    {
        bool running = false;
        Int32 rIndex = 0;
        public static SingView singview;
        public SingView()
        {
            InitializeComponent();
            singview = this;
            
        }
       
        private void btnSingManagerment_Click(object sender, EventArgs e)
        {
            SingControl sc = new SingControl();
            dtgCategory.Visible = false;
            dtgUser.Visible = false;
            dtgSing.Visible = true;
            btnAddAll.Visible = true;
            btnActive.Text = "Thêm bài hát";
            rIndex = 0;
            running = false;
            MediaZing.URL = "";
           
            dtgSing.Rows.Clear();
            List<SingObject> sings = sc.getSings(null, 100);
            for (int i = 0; i < sings.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dtgSing.Rows[i].Clone();
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = sings[i].getSing_id();
                row.Cells[2].Value = sings[i].getSing_name();
                row.Cells[3].Value = sings[i].getCategory_name();
                row.Cells[4].Value = sings[i].getSing_author();
                row.Cells[5].Value = sings[i].getSing_singer();
                row.Cells[6].Value = sings[i].getSing_content();
                row.Cells[7].Value = sings[i].getSing_time();
                row.Cells[8].Value = Image.FromFile(@"..\..\..\..\Img\Run.png");
                row.Cells[9].Value = Image.FromFile(@"..\..\..\..\Img\Edit.png");
                row.Cells[10].Value = Image.FromFile(@"..\..\..\..\Img\Del.png");
                dtgSing.Rows.Add(row);

            }
            if (!running)
            {
                DataGridViewRow row = (DataGridViewRow)dtgSing.Rows[rIndex].Clone();
                row.Cells[8].Value = Image.FromFile(@"..\..\..\..\Img\Pause.png");
            }
            

        }

        public void SingView_Load(object sender, EventArgs e)
        {
            SingControl sc = new SingControl();
            dtgCategory.Visible = false;
            dtgUser.Visible = false;
            dtgSing.Visible = true;
            //for (int i = 0; i < sings.Count; i++)
            //{
            //    DataGridViewRow row = (DataGridViewRow)dtgSing.Rows[0].Clone();
            //    row.Cells["clStt"].Value = i + 1;
            //    row.Cells["clId"].Value = sings[i].getSing_id();
            //    row.Cells["clSingName"].Value = sings[i].getSing_name();
            //    row.Cells["clAuthor"].Value = sings[i].getSing_author();
            //    row.Cells["clSinger"].Value = sings[i].getSing_singer();
            //    row.Cells["clContent"].Value = sings[i].getSing_content();
            //    row.Cells["clTime"].Value = sings[i].getSing_time();
            //    row.Cells["clActive"].Value = "Xóa";

            //    dtgSing.Rows.Add(row);

            //}
            //dtgSing.DataSource = sings;
            btnActive.Text = "Thêm bài hát";
            dtgSing.Rows.Clear();
            SingObject so = new SingObject();
            //so.setSing_singer("Bằng kiều");
            List<SingObject> sings = sc.getSings(null, 100);
            for (int i = 0; i < sings.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dtgSing.Rows[i].Clone();
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = sings[i].getSing_id();
                row.Cells[2].Value = sings[i].getSing_name();
                row.Cells[3].Value = sings[i].getCategory_name();
                row.Cells[4].Value = sings[i].getSing_author();
                row.Cells[5].Value = sings[i].getSing_singer();
                row.Cells[6].Value = sings[i].getSing_content();
                row.Cells[7].Value = sings[i].getSing_time();
                row.Cells[8].Value = Image.FromFile(@"..\..\..\..\Img\Run.png");
                row.Cells[9].Value = Image.FromFile(@"..\..\..\..\Img\Edit.png");
                row.Cells[10].Value = Image.FromFile(@"..\..\..\..\Img\Del.png");
                
                dtgSing.Rows.Add(row);

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            if(btnActive.Text.Equals("Thêm bài hát"))
            {
                SingAE ae = new SingAE();
                ae.ShowDialog();
            }
            else if (btnActive.Text.Equals("Thêm thể loại"))
            {
                SingAE ae = new SingAE();
                ae.ShowDialog();
            }
            else if (btnActive.Text.Equals("Thêm người dùng"))
            {
            }

        }

        
        
        
        
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm...";
                txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void MediaZing_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Test the current state of the player and display a message for each state.
            switch (e.newState)
            {
                //case 0:    // Undefined
                //    currentStateLabel.Text = "Undefined";
                //    break;

                case 1:    // Stopped
                    dtgSing.Rows[rIndex].Cells[8].Value = Image.FromFile(@"..\..\..\..\Img\Run.png");
                    running = false;
                    break;

                case 2:    // Paused
                    dtgSing.Rows[rIndex].Cells[8].Value = Image.FromFile(@"..\..\..\..\Img\Run.png");
                    break;

                case 3:    // Playing
                    dtgSing.Rows[rIndex].Cells[8].Value = Image.FromFile(@"..\..\..\..\Img\Pause.png");
                    break;

                //case 4:    // ScanForward
                //    currentStateLabel.Text = "ScanForward";
                //    break;

                //case 5:    // ScanReverse
                //    currentStateLabel.Text = "ScanReverse";
                //    break;

                //case 6:    // Buffering
                //    currentStateLabel.Text = "Buffering";
                //    break;

                //case 7:    // Waiting
                //    currentStateLabel.Text = "Waiting";
                //    break;

                //case 8:    // MediaEnded
                //    currentStateLabel.Text = "MediaEnded";
                //    break;

                //case 9:    // Transitioning
                //    currentStateLabel.Text = "Transitioning";
                //    break;

                //case 10:   // Ready
                //    currentStateLabel.Text = "Ready";
                //    break;

                //case 11:   // Reconnecting
                //    currentStateLabel.Text = "Reconnecting";
                //    break;

                //case 12:   // Last
                //    currentStateLabel.Text = "Last";
                //    break;

                //default:
                //    currentStateLabel.Text = ("Unknown State: " + e.newState.ToString());
                //    break;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(!txtSearch.Text.Equals("") && !txtSearch.Text.Equals("Tìm kiếm...")){
                SingControl sc = new SingControl();
                dtgSing.Rows.Clear();
                List<SingObject> sings = sc.getSearchSings(txtSearch.Text);
                for (int i = 0; i < sings.Count; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dtgSing.Rows[i].Clone();
                    row.Cells[0].Value = i + 1;
                    row.Cells[1].Value = sings[i].getSing_id();
                    row.Cells[2].Value = sings[i].getSing_name();
                    row.Cells[3].Value = sings[i].getCategory_name();
                    row.Cells[4].Value = sings[i].getSing_author();
                    row.Cells[5].Value = sings[i].getSing_singer();
                    row.Cells[6].Value = sings[i].getSing_content();
                    row.Cells[7].Value = sings[i].getSing_time();
                    row.Cells[8].Value = Image.FromFile(@"..\..\..\..\Img\Run.png");
                    row.Cells[9].Value = Image.FromFile(@"..\..\..\..\Img\Edit.png");
                    row.Cells[10].Value = Image.FromFile(@"..\..\..\..\Img\Del.png");

                    dtgSing.Rows.Add(row);

                }
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            AddAllSing ads = new AddAllSing();
            ads.Show();
        }

       
        private void btnCategoryManagerment_Click(object sender, EventArgs e)
        {
            CategoryModel cm = new CategoryModel();
            DataTable dt = cm.getCategorys();
            dtgCategory.DataSource = dt;
            dtgCategory.Visible = true;
            dtgSing.Visible = false;
            dtgUser.Visible = false;
            btnActive.Text = "Thêm thể loại";
            btnAddAll.Visible = false;

            dtgCategory.Columns[0].HeaderText = "Mã thể loại";
            dtgCategory.Columns[1].HeaderText = "Tên thể loại";
        }

        private void btnUserManagerment_Click(object sender, EventArgs e)
        {
            UserModel um = new UserModel();
            DataTable dt = um.getUsers();
            dtgUser.DataSource = dt;
            dtgUser.Visible = true;
            dtgSing.Visible = false;
            dtgCategory.Visible = false;
            btnActive.Text = "Thêm người dùng";
            btnAddAll.Visible = false;

            dtgUser.Columns[0].HeaderText = "User Id";
            dtgUser.Columns[1].HeaderText = "User Name";
            dtgUser.Columns[2].HeaderText = "User Pass";
            
            dtgUser.Columns[3].HeaderText = "User Fullname";
            dtgUser.Columns[4].HeaderText = "User Address";
            dtgUser.Columns[0].HeaderText = "User Phone";


            
        }

        private void dtgSing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            int clIndex = e.ColumnIndex;

            if (senderGrid.Columns[clIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                Int32 row = e.RowIndex;

                int sing_id = Int32.Parse(dtgSing.Rows[row].Cells[1].Value.ToString());
                SingObject so = new SingObject();
                SingControl sc = new SingControl();
                so = sc.getSing(sing_id);
                //-----------------------Run or pause a sing-------------------------
                if (clIndex == 8)
                {


                    try
                    {
                        //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        //player.SoundLocation = so.getSing_path_mp3();

                        if (rIndex != row)
                        {

                            string RelativePath = so.getSing_path_mp3();
                            string AbsolutePath = Path.GetFullPath(Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), RelativePath));
                            MediaZing.URL = AbsolutePath;

                            senderGrid.Rows[rIndex].Cells[8].Value = Image.FromFile(@"..\..\..\..\Img\Run.png");
                            rIndex = row;
                            //player.Play();
                            senderGrid.Rows[row].Cells[8].Value = Image.FromFile(@"..\..\..\..\Img\Pause.png");
                            running = true;

                        }
                        else
                        {
                            if (!running)
                            {
                                rIndex = row;
                                string RelativePath = so.getSing_path_mp3();
                                string AbsolutePath = Path.GetFullPath(Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), RelativePath));
                                MediaZing.URL = AbsolutePath;
                                //player.Play();
                                senderGrid.Rows[row].Cells[8].Value = Image.FromFile(@"..\..\..\..\Img\Pause.png");
                                running = true;
                            }
                            else
                            {
                                MediaZing.URL = "";

                                //player.Stop();
                                senderGrid.Rows[row].Cells[8].Value = Image.FromFile(@"..\..\..\..\Img\Run.png");
                                running = false;
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                //------------------------------edit a sing------------------------------
                else if (clIndex == 9)
                {
                    SingAE edit = new SingAE();
                    edit.SingEdit(so);
                    edit.ShowDialog();

                }
                //------------------------------del a sing-------------------------------
                else if (clIndex == 10)
                {
                    DialogResult rs = MessageBox.Show("Bạn có muốn xóa bài hát này", "Cảnh bảo", MessageBoxButtons.OKCancel);
                    if (rs == DialogResult.OK)
                    {
                        MediaZing.URL = "";
                        sc.delSing(so);
                        this.SingView_Load(sender, e);

                    }
                }

            }
        }

        

       

      

        

      

       
    }
}
