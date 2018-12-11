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
    public partial class ClientGUI : Form
    {
        SingControl singControl = new SingControl();
        int tongPage, hienTaiPage = 1, lePage, i = 0, trangDangPhat;
        Boolean running = false;
        string name = "",nhan;
        PictureBox PictureBox = new PictureBox();
        string[] s;
        int[] id;



        public ClientGUI()
        {
            InitializeComponent();
        }


        private void xuKyHienThiSearch()
        {
            grbBaiHatNoiBat.Visible = false;
            labelBaiHatNoiBat.Visible = true;
            hideDownload(1);
            hideDelete(0);
        }
        public void phanTrang(int count, string[] q)
        {
            tongPage = count / 5;
            tongPage++;
            lePage = count % 5;

            if (lePage == 0)
            {
                if (hienTaiPage == tongPage)
                {
                    hienTaiPage--;
                }
                tongPage--;
            }

            if (count > 0)
            {
                loadSearch(tongPage, lePage, hienTaiPage, q);
            }
            else
            {
                hienGrSearch(0, 0, 0, 0, 0);
            }
        }
        public void loadSearch(int tongPage, int lePage, int hienTaiPage, string[] q)
        {
            if (lePage == 0)
            {
                hienGrSearch(1, 1, 1, 1, 1);
                layString(1, 1, 1, 1, 1, q);

            }
            else
            {
                if (hienTaiPage < tongPage)
                {
                    hienGrSearch(1, 1, 1, 1, 1);
                    layString(1, 1, 1, 1, 1, q);
                }
                else
                {

                    if (lePage == 1)
                    {
                        hienGrSearch(1, 0, 0, 0, 0);
                        layString(1, 0, 0, 0, 0, q);

                    }
                    if (lePage == 2)
                    {
                        hienGrSearch(1, 1, 0, 0, 0);
                        layString(1, 1, 0, 0, 0, q);
                    }
                    if (lePage == 3)
                    {
                        hienGrSearch(1, 1, 1, 0, 0);
                        layString(1, 1, 1, 0, 0, q);
                    }
                    if (lePage == 4)
                    {
                        hienGrSearch(1, 1, 1, 1, 0);
                        layString(1, 1, 1, 1, 0, q);
                    }
                    if (lePage == 5)
                    {
                        hienGrSearch(1, 1, 1, 1, 1);
                        layString(1, 1, 1, 1, 1, q);
                    }
                    if (lePage == 6)
                    {
                        hienGrSearch(1, 1, 1, 1, 1);
                        layString(1, 1, 1, 1, 1, q);
                    }
                    if (lePage == 7)
                    {
                        hienGrSearch(1, 1, 1, 1, 1);
                        layString(1, 1, 1, 1, 1, q);
                    }
                }
            }
            int[] idi = { Convert.ToInt32(labelSearch1.Text), Convert.ToInt32(labelSearch2.Text), Convert.ToInt32(labelSearch3.Text), Convert.ToInt32(labelSearch4.Text), Convert.ToInt32(labelSearch5.Text)};
            //hàm xem đã tải chưa nếu tải rồi thì đổi màu
            xuLyTaiRoi(idi);
        }

        public void xuLyTaiRoi(int[] idi)
        {
            PictureBox[] pb = { download1, download2, download3, download4, download5 };
            SingObject SingObject = new SingObject();
            for (int i = 0; i < idi.Length; i++)
            {
                SingObject = singControl.getSing(idi[i]);
                if (SingObject != null)
                {
                    if (SingObject.getSing_dowloaded() == true)
                    {
                        pb[i].Image = Image.FromFile(@"..\..\..\..\Img\download_true.png");
                    }
                    else
                    {
                        pb[i].Image = Image.FromFile(@"..\..\..\..\Img\download_false.png");
                    }
                }

            }
        }
        public void layString(int i1, int i2, int i3, int i4, int i5, String[] q)
        {
            if (i1 == 1)
            {
                singsearch1.Text = q[(5 * hienTaiPage) - 5];
                labelSearch1.Text = id[(5 * hienTaiPage)-5 ].ToString();
            }
            if (i2 == 1)
            {
                singsearch2.Text = q[(5 * hienTaiPage) - 4];
                labelSearch2.Text = id[(5 * hienTaiPage) - 4].ToString();
            }
            if (i3 == 1)
            {
                singsearch3.Text = q[(5 * hienTaiPage) - 3];
                labelSearch3.Text = id[(5 * hienTaiPage) - 3].ToString();
            }
            if (i4 == 1)
            {
                singsearch4.Text = q[(5 * hienTaiPage) - 2];
                labelSearch4.Text = id[(5 * hienTaiPage) -2].ToString();
            }
            if (i5 == 1)
            {
                singsearch5.Text = q[(5 * hienTaiPage) - 1];
                labelSearch5.Text = id[(5 * hienTaiPage) - 1].ToString();
            }

        }
        public void hienGrSearch(int i, int i2, int i3, int i4, int i5)
        {
            if (i == 0)
            {
                grbSeacrh1.Visible = false;
            }
            else
            {
                grbSeacrh1.Visible = true;
            }
            if (i2 == 0)
            {
                grbSeacrh2.Visible = false;
            }
            else
            {
                grbSeacrh2.Visible = true;
            }
            if (i3 == 0)
            {
                grbSeacrh3.Visible = false;
            }
            else
            {
                grbSeacrh3.Visible = true;
            }
            if (i4 == 0)
            {
                grbSeacrh4.Visible = false;
            }
            else
            {
                grbSeacrh4.Visible = true;
            }
            if (i5 == 0)
            {
                grbSeacrh5.Visible = false;
            }
            else
            {
                grbSeacrh5.Visible = true;
            }
        }

        public void hienTrend(int i1, int i2, int i3, int i4)
        {
            if (i1 == 1)
            {
                panelTrend1.Visible = true;
            }
            else
            {
                panelTrend1.Visible = false;
            }

            if (i2 == 1)
            {
                panelTrend1.Visible = true;
            }
            else
            {
                panelTrend1.Visible = false;
            }

            if (i3 == 1)
            {
                panelTrend3.Visible = true;
            }
            else
            {
                panelTrend3.Visible = false;
            }

            if (i4 == 1)
            {
                panelTrend4.Visible = true;
            }
            else
            {
                panelTrend4.Visible = false;
            }
        }
        public void trend(string[] s, int[] a ,int [] id)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int max = a[i];
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (max < a[j])
                    {
                        string tem = s[i];
                        s[i] = s[j];
                        s[j] = tem;
                        int tem2 = a[i];
                        a[i] = a[j];
                        a[j] = tem2;
                        int tem3 = id[i];
                        id[i] = id[j];
                        id[j] = tem3;
                    }
                }
            }
        }

        private void playMusic(PictureBox pb,Label la)
        {
            SingObject singObject = new SingObject();
            //singObject = singControl.getSing(name);
            singObject = singControl.getSing(Convert.ToInt32(la.Text));
            
            try
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                //player.SoundLocation = singObject.getSing_path_mp3();
                if (!running)
                {
                    //player.Play();
                    string RelativePath = singObject.getSing_path_mp3();
                    string AbsolutePath = Path.GetFullPath(Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), RelativePath));
                    MediaZing.URL = AbsolutePath;

                    pb.Image = Image.FromFile(@"..\..\..\..\Img\Pause.png");
                    running = true;
                    singObject.setSing_listened(singObject.getSing_listened() + 1);
                    singControl.editSing(singObject);
                    this.PictureBox = pb;

                    txtSingContent.Text = singObject.getSing_content();

                    trangDangPhat = hienTaiPage;
                    nhan = title.Text;
                }
                else
                {
                    if (pb != PictureBox)
                    {
                        //player.Stop();
                        MediaZing.URL = "";
                        PictureBox.Image = Image.FromFile(@"..\..\..\..\Img\Run.png");
                        running = false;

                        playMusic( pb,la);
                    }
                    else
                    {
                        //player.Stop();
                        MediaZing.URL = "";
                        pb.Image = Image.FromFile(@"..\..\..\..\Img\Run.png");
                        running = false;
                    }

                }

                //xuLyHienThiPlay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void xuLyHienThiPlay()
        {
            PictureBox[] pixbox = { playImg1, playImg2, playImg3, playImg4, playImg5 };
            for (int i = 0; i < 5; i++)
            {
                if (this.PictureBox == pixbox[i] && hienTaiPage==trangDangPhat && title.Text==nhan)
                {
                    pixbox[i].Image = Image.FromFile(@"..\..\..\..\Img\Pause.png");
                }
                else 
                {
                    pixbox[i].Image = Image.FromFile(@"..\..\..\..\Img\Run.png");
                }
            }
        }

        private void xuLyDownload(int idi)
        {
            SingObject singObject = new SingObject();
            singObject = singControl.getSing(idi);

            singObject.setSing_dowloaded(true);
            singControl.editSing(singObject);
            int[] idi2 = { Convert.ToInt32(labelSearch1.Text), Convert.ToInt32(labelSearch2.Text), Convert.ToInt32(labelSearch3.Text), Convert.ToInt32(labelSearch4.Text), Convert.ToInt32(labelSearch5.Text) };
            //hàm xem đã tải chưa nếu tải rồi thì đổi màu
            xuLyTaiRoi(idi2);
            MessageBox.Show("đã tải bài hát thành công !");
        }
        private void xuLyHienThiCaNhan()
        {
            grbBaiHatNoiBat.Visible = false;
            labelBaiHatNoiBat.Visible = true;
            hideDelete(1);
            hideDownload(0);
        }

        private void xuLyXoa(int idi)
        {
            SingObject singObject = new SingObject();
            singObject = singControl.getSing(idi);

            singObject.setSing_dowloaded(false);
            singControl.editSing(singObject);

            caNhan_Click_1(new object(), new EventArgs());
        }
        private void xuLyChonHeart(int idi)
        {
            SingObject singObject = new SingObject();
            singObject = singControl.getSing(idi);

            if (singObject.getSing_focus() == true)
            {
                singObject.setSing_focus(false);
            }
            else
            {
                singObject.setSing_focus(true);
            }
            singControl.editSing(singObject);

            hienThiHeart();

            if (title.Text == "Yêu thích")
            {
                danhMucYeuThich_Click_1(new object(), new EventArgs());
            }
        }
        private void hienThiYeuDanhMucYeuThich()
        {
            xuLyHienThiCaNhan();
            hideDelete(0);
            hideDownload(1);
        }


        //hàm ẩn hiện các icon xóa tải yêu thích phát
        //hàm ẩn hiện xóa
        public void hideDelete(int i)
        {
            if (i == 0)
            {
                delete1.Visible = false;
                delete2.Visible = false;
                delete3.Visible = false;
                delete4.Visible = false;
                delete5.Visible = false;
            }
            else
            {
                delete1.Visible = true;
                delete2.Visible = true;
                delete3.Visible = true;
                delete4.Visible = true;
                delete5.Visible = true;
            }
        }
        //hàm ẩn hiện download
        public void hideDownload(int i)
        {
            if (i == 0)
            {
                download1.Visible = false;
                download2.Visible = false;
                download3.Visible = false;
                download4.Visible = false;
                download5.Visible = false;
            }
            else
            {
                download1.Visible = true;
                download2.Visible = true;
                download3.Visible = true;
                download4.Visible = true;
                download5.Visible = true;
            }
        }
        //luat hàm để xử lý refresh lại các hình trái tim xem có yêu thích không
        public void hienThiHeart()
        {
            SingObject singObject = new SingObject();
            SubHeart(like1, singObject, labelSearch1);
            SubHeart(like2, singObject, labelSearch2);
            SubHeart(like3, singObject, labelSearch3);
            SubHeart(like4, singObject, labelSearch4);
            SubHeart(like5, singObject, labelSearch5);
        }
        //luat subHeart để hiển thị xem một item nào đó có trong yêu thích hay không
        private void SubHeart(PictureBox pictureBox, SingObject singObject, Label label)
        {
            singObject = singControl.getSing(Convert.ToInt32(label.Text));
            if (singObject != null && singObject.getSing_focus() == true)
            {
                pictureBox.Image = Image.FromFile(@"..\..\..\..\Img\heart.png");
            }
            else
            {
                pictureBox.Image = Image.FromFile(@"..\..\..\..\Img\heart_break.png");
            }
        }

        private void ClientGUI_Load(object sender, EventArgs e)
        {
            grbBaiHatNoiBat.Visible = true;
            labelBaiHatNoiBat.Visible = false;
            List<SingObject> SingObjects=new List<SingObject>();
            SingObjects = singControl.getSings(null,100);

            s= new string[SingObjects.Count];
            int[] a = new int [SingObjects.Count];
            id = new int [SingObjects.Count];

            for (int i = 0; i < SingObjects.Count; i++)
            {
                s[i] = SingObjects[i].getSing_name() + " *----* "+ SingObjects[i].getSing_singer();
                a[i] = SingObjects[i].getSing_listened();
                id[i] = SingObjects[i].getSing_id();
            }


            trend(s, a, id);

            if (SingObjects.Count >= 4)
            {
                singtrend1.Text = s[0];
                singtrend2.Text = s[1];
                singtrend3.Text = s[2];
                singtrend4.Text = s[3];

                labelTrend1.Text = id[0].ToString();
                labelTrend2.Text = id[1].ToString();
                labelTrend3.Text = id[2].ToString();
                labelTrend4.Text = id[3].ToString();

                hienTrend(1, 1, 1, 1);
            }
            else
            {
                if (SingObjects.Count == 3)
                {
                    singtrend1.Text = s[0];
                    singtrend2.Text = s[1];
                    singtrend3.Text = s[2];

                    labelTrend1.Text = id[0].ToString();
                    labelTrend2.Text = id[1].ToString();
                    labelTrend3.Text = id[2].ToString();

                    hienTrend(1, 1, 1, 0);
                }
                else
                {
                    if (SingObjects.Count == 2)
                    {
                        singtrend1.Text = s[0];
                        singtrend2.Text = s[1];

                        labelTrend1.Text = id[0].ToString();
                        labelTrend2.Text = id[1].ToString();

                        hienTrend(1, 1, 0, 0);
                    }
                    else
                    {
                        if (SingObjects.Count == 1)
                        {
                            singtrend1.Text = s[0];

                            labelTrend1.Text = id[0].ToString();

                            hienTrend(1, 0, 0, 0);
                        }
                        else
                        {
                            hienTrend(0, 0, 0, 0);
                        }
                    }
                }
            }
            labelSearch1.Visible = false;
            labelSearch2.Visible = false;
            labelSearch3.Visible = false;
            labelSearch4.Visible = false;
            labelSearch5.Visible = false;

            labelTrend1.Visible = false;
            labelTrend2.Visible = false;
            labelTrend3.Visible = false;
            labelTrend4.Visible = false;
        }

        private void imgCaSiVietNam_Click(object sender, EventArgs e)
        {
            xuLyHienThiCaNhan();
            List<SingObject> singObjects = singControl.getSings(null, 100);
            string[] a = new string[singObjects.Count];
            int d = 0;
            id = new int[singObjects.Count];
            for (int i = 0; i < singObjects.Count; i++)
            {
                if (singObjects[i].getSing_national() == true)
                {
                    a[d] = singObjects[i].getSing_name() + " *-----* " + singObjects[i].getSing_singer();
                    d++;
                    id[i] = singObjects[i].getSing_id();
                }

            }
            title.Text = "Trong nước";
            hienTaiPage = 1;
            this.s = a;
            //labelTrang3.Text = hienTaiPage.ToString();
            phanTrang(d, a);
            hienThiTrang();
            hienThiHeart();
            //anTheLoai(0);
            hideDelete(0);
            hideDownload(1);
            xuLyHienThiPlay();
        }

        private void ImgNhacHot_Click(object sender, EventArgs e)
        {
            ClientGUI_Load(sender, e);
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
                    //playMusic(name, PictureBox);
                    PictureBox.Image = Image.FromFile(@"..\..\..\..\Img\Run.png");
                    running = false;
                    break;

                case 2:    // Paused
                    //playMusic(name, PictureBox);
                    PictureBox.Image = Image.FromFile(@"..\..\..\..\Img\Run.png");
                    running = false;
                    break;

                case 3:    // Playing
                    //playMusic(name, PictureBox);
                    PictureBox.Image = Image.FromFile(@"..\..\..\..\Img\Pause.png");
                    running = true;
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

        private void theLoai_Click(object sender, EventArgs e)
        {
            this.i++;
            //anTheLoai(i);
        }

        private void imgTheGioiVPop_Click(object sender, EventArgs e)
        {
            xuLyHienThiCaNhan();
            List<SingObject> singObjects1 = singControl.getSings(null, 100);
            string[] a = new string[singObjects1.Count];
            int d = 0;
            id = new int[singObjects1.Count];
            for (int i = 0; i < singObjects1.Count; i++)
            {
                if (singObjects1[i].getSing_national() == false)
                {
                    a[d] = singObjects1[i].getSing_name() + " *-----* " + singObjects1[i].getSing_singer();
                    d++;
                    id[i] = singObjects1[i].getSing_id();
                }

            }
            title.Text = "Quốc tế";
            hienTaiPage = 1;
            this.s = a;
            //labelTrang3.Text = hienTaiPage.ToString();
            phanTrang(d, a);
            hienThiTrang();
            hienThiHeart();
            hideDelete(0);
            hideDownload(1);
            xuLyHienThiPlay();
        }



        //5 nút yêu thíc khi click


        private void like1_Click_1(object sender, EventArgs e)
        {
            xuLyChonHeart(Convert.ToInt32(labelSearch1.Text));
        }
        private void like2_Click(object sender, EventArgs e)
        {
            xuLyChonHeart(Convert.ToInt32(labelSearch2.Text));
        }
        private void like3_Click_1(object sender, EventArgs e)
        {
            xuLyChonHeart(Convert.ToInt32(labelSearch3.Text));
        }

        private void like4_Click_1(object sender, EventArgs e)
        {
            xuLyChonHeart(Convert.ToInt32(labelSearch4.Text));
        }

        private void like5_Click_1(object sender, EventArgs e)
        {
            xuLyChonHeart(Convert.ToInt32(labelSearch5.Text));
        }



        //nút next trang
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (hienTaiPage < tongPage)
            {
                hienTaiPage++;
                loadSearch(tongPage, lePage, hienTaiPage, s);
                //labelTrang3.Text = Convert.ToString(hienTaiPage);
                hienThiTrang();
                hienThiHeart();
                xuLyHienThiPlay();
            }
        }
        //nút lùi trnag
        private void btnPrePage_Click(object sender, EventArgs e)
        {
            if (hienTaiPage > 1)
            {
                hienTaiPage--;
                loadSearch(tongPage, lePage, hienTaiPage, s);
                //labelTrang3.Text = Convert.ToString(hienTaiPage);
                hienThiTrang();
                hienThiHeart();
                xuLyHienThiPlay();
            }
        }
        //4 nút phát nhạc ở phần nhạc hot
        private void playpictureBox1_Click_1(object sender, EventArgs e)
        {
            playMusic(playpictureBox1,labelTrend1);
        }

        private void playpictureBox2_Click_1(object sender, EventArgs e)
        {
            playMusic(playpictureBox2,labelTrend2);
        }

        private void playpictureBox3_Click_1(object sender, EventArgs e)
        {
            playMusic(playpictureBox3, labelTrend3);
        }

        private void playpictureBox4_Click_1(object sender, EventArgs e)
        {
            playMusic(playpictureBox4, labelTrend4);
        }
        //8 nút download khi click
        private void download5_Click_1(object sender, EventArgs e)
        {
            xuLyDownload(Convert.ToInt32(labelSearch5.Text));
        }

        private void download2_Click_1(object sender, EventArgs e)
        {
            xuLyDownload(Convert.ToInt32(labelSearch2.Text));
        }

        private void download3_Click_1(object sender, EventArgs e)
        {
            xuLyDownload(Convert.ToInt32(labelSearch3.Text));
        }

        private void download4_Click_1(object sender, EventArgs e)
        {
            xuLyDownload(Convert.ToInt32(labelSearch4.Text));
        }

        private void download1_Click_1(object sender, EventArgs e)
        {
            xuLyDownload(Convert.ToInt32(labelSearch1.Text));
        }



        //5 nút play lúc tìm kiếm cá nhân yêu thích
        private void playImg1_Click_1(object sender, EventArgs e)
        {
            playMusic( playImg1,labelSearch1);
        }

        private void playImg2_Click_1(object sender, EventArgs e)
        {
            playMusic(playImg2,labelSearch2);
        }

        private void playImg3_Click_1(object sender, EventArgs e)
        {
            playMusic( playImg3, labelSearch3);

        }

        private void playImg4_Click_1(object sender, EventArgs e)
        {
            playMusic(playImg4, labelSearch4);
        }

        private void playImg5_Click_1(object sender, EventArgs e)
        {
            playMusic(playImg5, labelSearch5);
        }



        //5 nút xóa

        private void delete2_Click_1(object sender, EventArgs e)
        {
            xuLyXoa(Convert.ToInt32(labelSearch2.Text));
        }

        private void delete3_Click_1(object sender, EventArgs e)
        {
            xuLyXoa(Convert.ToInt32(labelSearch3.Text));
        }

        private void delete4_Click_1(object sender, EventArgs e)
        {
            xuLyXoa(Convert.ToInt32(labelSearch4.Text));
        }

        private void delete5_Click_1(object sender, EventArgs e)
        {
            xuLyXoa(Convert.ToInt32(labelSearch5.Text));
        }

        private void delete1_Click_1(object sender, EventArgs e)
        {
            xuLyXoa(Convert.ToInt32(labelSearch1.Text));
        }


        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            s = new string[100];
            xuKyHienThiSearch();
            title.Text = "Kết Quả tìm kiếm";
            name = txtSearch.Text;

            SingObject item = new SingObject();
            item.setSing_name(name);
            item.setSing_content("sing_search");
            List<SingObject> objects = new List<SingObject>();
            objects = singControl.getSings(item, 100);
            string[] a = new string[objects.Count];
            int d = 0;
            id = new int[objects.Count];
            for (int i = 0; i < objects.Count; i++)
            {
                a[d] = objects[i].getSing_name() + " *-----* " + objects[i].getSing_singer();
                d++;
                id[i] = objects[i].getSing_id();
            }
            title.Text = "Bài hát phù hợp tìm kiếm";
            this.s = a;
            hienTaiPage = 1;

            //labelTrang3.Text = hienTaiPage.ToString();

            phanTrang(d, s);

            hienThiTrang();
            hienThiHeart();
            xuLyHienThiPlay();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            btnSearch_Click_1(sender, e);
        }
        //về trang chủ
        private void trangChu_Click(object sender, EventArgs e)
        {
            ClientGUI_Load(sender, e);
        }

        private void caNhan_Click_1(object sender, EventArgs e)
        {
            s = new string[100];
            xuLyHienThiCaNhan();
            SingObject item = new SingObject();
            item.setSing_dowloaded(true);
            item.setSing_content("sing_dowloaded");
            List<SingObject> objects = new List<SingObject>();
            objects = singControl.getSings(item, 100);
            string[] a = new string[objects.Count];
            int d = 0;
            id = new int[objects.Count];
            for (int i = 0; i < objects.Count; i++)
            {
                a[d] = objects[i].getSing_name() + " *-----* " + objects[i].getSing_singer();
                id[i] = objects[i].getSing_id();
                d++;
            }
            title.Text = "Cá nhân";
            this.s = a;
            hienTaiPage = 1;

            //labelTrang3.Text = hienTaiPage.ToString();
            phanTrang(d, s);
            hienThiTrang();
            hienThiHeart();
            xuLyHienThiPlay();
        }

        private void danhMucYeuThich_Click_1(object sender, EventArgs e)
        {
            s = new string[100];
            hienThiYeuDanhMucYeuThich();
            SingObject item = new SingObject();
            item.setSing_focus(true);
            item.setSing_content("sing_focus");
            List<SingObject> objects = new List<SingObject>();
            objects = singControl.getSings(item, 100);
            string[] a = new string[objects.Count];
            int d = 0;
            id = new int[objects.Count];
            for (int i = 0; i < objects.Count; i++)
            {
                a[d] = objects[i].getSing_name() + " *-----* " + objects[i].getSing_singer();
                d++;
                id[i] = objects[i].getSing_id();
            }
            if (title.Text != "Yêu thích")
            {
                hienTaiPage = 1;
            }
            title.Text = "Yêu thích";
            this.s = a;

            //labelTrang3.Text = hienTaiPage.ToString();
            phanTrang(d, a);
            hienThiTrang();
            hienThiHeart();
            xuLyHienThiPlay();
        }

        private void dangNhap_Click_1(object sender, EventArgs e)
        {
            LoginView LoginView = new LoginView();
            LoginView.ShowDialog();
        }

        public void hienThiTrang()
        {
            int[] page = new int[tongPage];

            for (int i = 0; i < tongPage; i++)
            {
                page[i] = i + 1;
            }

            int viTri = kiemPageHienTai(page);

            if (tongPage <= 5)
            {
                if (tongPage == 1)
                {
                    labelTrang1.Text = "";
                    labelTrang2.Text = "";
                    labelTrang3.Text = "1";
                    labelTrang4.Text = "";
                    labelTrang5.Text = "";
                }
                else
                {
                    if (tongPage == 2)
                    {
                        labelTrang1.Text = "";
                        labelTrang2.Text = "1";
                        labelTrang3.Text = "";
                        labelTrang4.Text = "2";
                        labelTrang5.Text = "";
                    }
                    else
                    {
                        if (tongPage == 3)
                        {
                            labelTrang1.Text = "";
                            labelTrang2.Text = "1";
                            labelTrang3.Text = "2";
                            labelTrang4.Text = "3";
                            labelTrang5.Text = "";
                        }
                        else
                        {
                            if (tongPage == 4)
                            {
                                labelTrang1.Text = "1";
                                labelTrang2.Text = "2";
                                labelTrang3.Text = "3";
                                labelTrang4.Text = "4";
                                labelTrang5.Text = "";
                            }
                            else
                            {
                                if (tongPage == 5)
                                {
                                    labelTrang1.Text = "1";
                                    labelTrang2.Text = "2";
                                    labelTrang3.Text = "3";
                                    labelTrang4.Text = "4";
                                    labelTrang5.Text = "5";
                                }
                                else
                                {
                                    if (tongPage == 0)
                                    {
                                        labelTrang1.Text = "";
                                        labelTrang2.Text = "";
                                        labelTrang3.Text = "0";
                                        labelTrang4.Text = "";
                                        labelTrang5.Text = "";
                                    }
                                }

                            }
                        }
                    }
                }
            }
            else
            {
                labelTrang5.Text = "...";
                if (hienTaiPage <= 4)
                {
                    if (hienTaiPage == 1)
                    {
                        labelTrang1.Text = page[viTri].ToString();
                        labelTrang2.Text = page[viTri + 1].ToString();
                        labelTrang3.Text = page[viTri + 2].ToString();
                        labelTrang4.Text = page[viTri + 3].ToString();
                    }
                    else
                    {
                        if (hienTaiPage == 2)
                        {
                            labelTrang1.Text = page[viTri - 1].ToString();
                            labelTrang2.Text = page[viTri].ToString();
                            labelTrang3.Text = page[viTri + 1].ToString();
                            labelTrang4.Text = page[viTri + 2].ToString();
                        }
                        else
                        {
                            if (hienTaiPage == 3)
                            {
                                labelTrang1.Text = page[viTri - 2].ToString();
                                labelTrang2.Text = page[viTri - 1].ToString();
                                labelTrang3.Text = page[viTri].ToString();
                                labelTrang4.Text = page[viTri + 1].ToString();
                            }
                            else
                            {
                                if (hienTaiPage == 4)
                                {
                                    labelTrang1.Text = page[viTri - 3].ToString();
                                    labelTrang2.Text = page[viTri - 2].ToString();
                                    labelTrang3.Text = page[viTri - 1].ToString();
                                    labelTrang4.Text = page[viTri].ToString();
                                }
                            }
                        }
                    }
                }
                else
                {
                    labelTrang1.Text = "...";

                    if (viTri == tongPage - 4)
                    {
                        labelTrang2.Text = page[viTri].ToString();
                        labelTrang3.Text = page[viTri + 1].ToString();
                        labelTrang4.Text = page[viTri + 2].ToString();
                        labelTrang5.Text = page[viTri + 3].ToString();
                    }
                    else
                    {
                        if (viTri == tongPage - 3)
                        {
                            labelTrang2.Text = page[viTri - 1].ToString();
                            labelTrang3.Text = page[viTri].ToString();
                            labelTrang4.Text = page[viTri + 1].ToString();
                            labelTrang5.Text = page[viTri + 2].ToString();
                        }
                        else
                        {
                            if (viTri == tongPage - 2)
                            {
                                labelTrang2.Text = page[viTri - 2].ToString();
                                labelTrang3.Text = page[viTri - 1].ToString();
                                labelTrang4.Text = page[viTri].ToString();
                                labelTrang5.Text = page[viTri + 1].ToString();
                            }
                            else
                            {
                                if (viTri == tongPage - 1)
                                {
                                    labelTrang2.Text = page[viTri - 3].ToString();
                                    labelTrang3.Text = page[viTri - 2].ToString();
                                    labelTrang4.Text = page[viTri - 1].ToString();
                                    labelTrang5.Text = page[viTri].ToString();
                                }
                            }
                        }




                    }
                }
            }

            Label[] labels = { labelTrang1, labelTrang2, labelTrang3, labelTrang4, labelTrang5 };

            for (int i = 0; i < 5; i++)
            {
                labels[i].BorderStyle = BorderStyle.None;
                if (hienTaiPage.ToString() == labels[i].Text)
                {
                    labels[i].BorderStyle = BorderStyle.Fixed3D;
                }
            }
        }
        public int kiemPageHienTai(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (hienTaiPage == a[i])
                {
                    return i;
                }
            }
            return -1;
        }


    }
}
