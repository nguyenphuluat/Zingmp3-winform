using System;
using System.Drawing;
using System.Windows.Forms;
using ZingMp3.Control;
using ZingMp3.Model.Object;

namespace ZingMp3
{
    public partial class Form1 : Form
    {
        SingControl singControl =new SingControl();
        int tongPage,hienTaiPage=1,lePage,i=0;
        Boolean running = false;
        string name = "";
        PictureBox PictureBox = new PictureBox();


        public Form1()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            xuKyHienThiSearch();

            name=txtSearch.Text;
            string[] s=new string[100];
            singControl.singSearch(name, s);

            int count = Convert.ToInt32(s[99]);

            phanTrang(count, s);
            hienThiHeart();
        }
        private void xuKyHienThiSearch()
        {
            grbBaiHatNoiBat.Visible = false;
            grbBaiHatPhuHopTimKiem.Visible = true;
            hideDownload(1);
            hideDelete(0);
        }
        public void phanTrang(int count,string [] s)
        {
            tongPage = count / 8;
            tongPage++;
            lePage = count % 8;

            if (count > 0)
            {
                loadSearch(tongPage, lePage, hienTaiPage, s);
            }
            else
            {
                hienGrSearch(0, 0, 0, 0, 0, 0, 0, 0);
            }
        }
        public void loadSearch(int tongPage,int lePage,int hienTaiPage,string[]s)
        {
            if (lePage == 0)
            {
                layString(1, 1, 1, 1, 1, 1, 1, 1,s);
                hienGrSearch(1, 1, 1, 1, 1, 1, 1, 1);
            }
            else
            {
                if (hienTaiPage < tongPage)
                {
                    layString(1, 1, 1, 1, 1, 1, 1, 1,s);
                    hienGrSearch(1, 1, 1, 1, 1, 1, 1, 1);
                }
                else
                {
                    
                    if (lePage == 1)
                    {
                        layString(1, 0, 0, 0, 0, 0, 0,0,s);
                        hienGrSearch(1,0,0,0,0,0,0,0);
                        
                    }
                    if (lePage == 2)
                    {
                        layString(1, 1, 0, 0, 0, 0, 0,0,s);
                        hienGrSearch(1, 1, 0, 0, 0, 0, 0, 0);
                    }
                    if (lePage == 3)
                    {
                        layString(1, 1, 1, 0, 0, 0, 0,0,s);
                        hienGrSearch(1, 1, 1, 0, 0, 0, 0, 0);
                    }
                    if (lePage == 4)
                    {
                        layString(1, 1, 1, 1, 0, 0, 0,0,s);
                        hienGrSearch(1, 1, 1, 1, 0, 0, 0, 0);
                    }
                    if (lePage == 5)
                    {
                        layString(1, 1, 1, 1, 1, 0, 0,0,s);
                        hienGrSearch(1, 1, 1, 1, 1, 0, 0, 0);
                    }
                    if (lePage == 6)
                    {
                        layString(1, 1, 1, 1, 1, 1, 0,0,s);
                        hienGrSearch(1, 1, 1, 1, 1, 1, 0, 0);
                    }
                    if (lePage == 7)
                    {
                        layString(1, 1, 1, 1, 1, 1, 1,0,s);
                        hienGrSearch(1, 1, 1, 1, 1, 1, 1, 0);
                    }
                }
            }
        }
        public void layString(int i1, int i2, int i3, int i4, int i5, int i6, int i7,int i8,String []s)
        {
            if (i1 == 1)
            {
                singsearch1.Text = s[(8 * hienTaiPage) - 8];
            }
            if (i2 == 1)
            {
                singsearch2.Text = s[(8 * hienTaiPage) - 7];
            }
            if (i3 == 1)
            {
                singsearch3.Text = s[(8 * hienTaiPage) - 6];
            }
            if (i4 == 1)
            {
                singsearch4.Text = s[(8 * hienTaiPage) - 5];
            }
            if (i5 == 1)
            {
                singsearch5.Text = s[(8 * hienTaiPage) - 4];
            }
            if (i6 == 1)
            {
                singsearch6.Text = s[(8 * hienTaiPage) - 3];
            }
            if (i7 == 1)
            {
                singsearch7.Text = s[(8 * hienTaiPage) - 2];
            }
            if (i8 == 1)
            {
                singsearch8.Text = s[(8 * hienTaiPage) - 1];
            }
        }
        public void hienGrSearch(int i,int i2,int i3, int i4, int i5, int i6 ,int i7, int i8)
        {
            if (i == 0)
            {
                grbSeacrh1.Visible = false;
            }
            else
            {
                grbSeacrh1.Visible = true;
            }
            if (i2== 0)
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
            if (i6 == 0)
            {
                grbSeacrh6.Visible = false;
            }
            else
            {
                grbSeacrh6.Visible = true;
            }
            if (i7 == 0)
            {
                grbSeacrh7.Visible = false;
            }
            else
            {
                grbSeacrh7.Visible = true;
            }
            if (i8 == 0)
            {
                grbSeacrh8.Visible = false;
            }
            else
            {
                grbSeacrh8.Visible = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Play.Visible = false;
            grbBaiHatNoiBat.Visible = true;
            grbBaiHatPhuHopTimKiem.Visible = false;
            anNenLabel();

            string[] s=new string[100];
            String[] a = new string[100];

            singControl.singTrend(s,a);

            String[] s1 = new string[Convert.ToInt32(s[99])];
            String[] a1 = new string[Convert.ToInt32(s[99])];
            for (int i = 0; i < Convert.ToInt32(s[99]); i++)
            {
                s1[i] = s[i];
                a1[i] = a[i];
            }

            trend(s1, a1);

            if (Convert.ToInt32(s[99]) >= 4)
            {
                singtrend1.Text = s1[0];
                singtrend2.Text = s1[1];
                singtrend3.Text = s1[2];
                singtrend4.Text = s1[3];

                hienTrend(1, 1, 1, 1);
            }
            else
            {
                if(Convert.ToInt32(s[99]) == 3)
                {
                    singtrend1.Text = s1[0];
                    singtrend2.Text = s1[1];
                    singtrend3.Text = s1[2];
                    hienTrend(1, 1, 1, 0);
                }
                else
                {
                    if(Convert.ToInt32(s[99]) == 2)
                    {
                        singtrend1.Text = s1[0];
                        singtrend2.Text = s1[1];
                        hienTrend(1, 1, 0, 0);
                    }
                    else
                    {
                        if(Convert.ToInt32(s[99]) == 1)
                        {
                            singtrend1.Text = s1[0];
                            hienTrend(1, 0, 0, 0);
                        }
                        else
                        {
                            hienTrend(0, 0, 0, 0);
                        }
                    }
                }
            }
            anTheLoai(0);
        }
        public void anTheLoai(int i)
        {
            if (i%2== 0)
            {
                panel.Visible = false;
            }
            else
            {
                panel.Visible = true;
            }
        }
        public void hienTrend(int i1,int i2,int i3,int i4)
        {
            if (i1 == 1)
            {
                groupBox4.Visible = true;
            }
            else
            {
                groupBox4.Visible = false;
            }

            if (i2 == 1)
            {
                groupBox5.Visible = true;
            }
            else
            {
                groupBox5.Visible = false;
            }

            if (i3 == 1)
            {
                groupBox6.Visible = true;
            }
            else
            {
                groupBox6.Visible = false;
            }

            if (i4 == 1)
            {
                groupBox9.Visible = true;
            }
            else
            {
                groupBox9.Visible = false;
            }
        }
        public void trend(string[]s,string[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                string max = a[i];
                for(int j = i+1; j < a.Length; j++)
                {
                    if (Convert.ToInt32(max) < Convert.ToInt32(a[j]))
                    {
                        string tem = s[i];
                        s[i] = s[j];
                        s[j] = tem;
                        String tem2 = a[i];
                        a[i] = a[j];
                        a[j] = tem2;
                    }
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (hienTaiPage < tongPage)
            {
                hienTaiPage++;
                btnSearch_Click(sender, e);
                txtTrang.Text = Convert.ToString(hienTaiPage);
            } 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (hienTaiPage > 1)
            {
                hienTaiPage--;
                btnSearch_Click(sender, e);
                txtTrang.Text = Convert.ToString(hienTaiPage);
            }
        }
        public string xuLyTenBaiHat(string s)
        {
            string[] a = s.Split('-');
            a[0] = a[0].Substring(0, a[0].Length - 1);
            return a[0];
        }
        private void playMusic(string name, PictureBox pb)
        {
            SingObject singObject = new SingObject();
            singObject = singControl.getSingName(name);
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = singObject.getSing_path_mp3();
                if (!running)
                {
                    player.Play();
                    pb.Image = Image.FromFile(@"..\..\..\..\Img\Pause.png");
                    running = true;
                    singObject.setSing_listened(singObject.getSing_listened() + 1);
                    singControl.editSing(singObject);
                    this.PictureBox = pb;
                }
                else
                {
                    if (pb != PictureBox)
                    {
                        player.Stop();
                        PictureBox.Image = Image.FromFile(@"..\..\..\..\Img\Run.png");
                        running = false;

                        playMusic(name, pb);
                    }
                    else
                    {
                        player.Stop();
                        pb.Image = Image.FromFile(@"..\..\..\..\Img\Run.png");
                        running = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void playImg1_Click(object sender, EventArgs e)
        {
            playMusic(xuLyTenBaiHat(singsearch1.Text),playImg1);
        }
        private void playImg2_Click(object sender, EventArgs e)
        {
            playMusic(xuLyTenBaiHat(singsearch2.Text), playImg2);
        }
        private void playImg3_Click(object sender, EventArgs e)
        {
            playMusic(xuLyTenBaiHat(singsearch3.Text), playImg3);
        }
        private void playImg4_Click(object sender, EventArgs e)
        {
            playMusic(xuLyTenBaiHat(singsearch4.Text), playImg4);
        }
        private void playImg5_Click(object sender, EventArgs e)
        {
            playMusic(xuLyTenBaiHat(singsearch5.Text), playImg5);
        }
        private void playImg6_Click(object sender, EventArgs e)
        {
            playMusic(xuLyTenBaiHat(singsearch6.Text), playImg6);
        }
        private void playImg7_Click(object sender, EventArgs e)
        {
            playMusic(xuLyTenBaiHat(singsearch7.Text), playImg7);
        }
        private void playImg8_Click(object sender, EventArgs e)
        {
            playMusic(xuLyTenBaiHat(singsearch8.Text), playImg8);
        }
        private void playpictureBox1_Click(object sender, EventArgs e)
        {
            playMusic(xuLyTenBaiHat(singtrend1.Text), playpictureBox1);
        }
        private void playpictureBox2_Click(object sender, EventArgs e)
        {
            playMusic(xuLyTenBaiHat(singtrend2.Text), playpictureBox2);
        }
        private void playpictureBox3_Click(object sender, EventArgs e)
        {
            playMusic(xuLyTenBaiHat(singtrend3.Text), playpictureBox3);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            playMusic(xuLyTenBaiHat(singtrend4.Text), playpictureBox4);
        }
        private void download1_Click(object sender, EventArgs e)
        {
            xuLyDownload(xuLyTenBaiHat(singsearch1.Text));
        }
        private void xuLyDownload(string name)
        {
            SingObject singObject = new SingObject();
            singObject = singControl.getSingName(name);

            singObject.setSing_dowloaded(true);
            singControl.editSing(singObject);
        }
        private void download2_Click(object sender, EventArgs e)
        {
            xuLyDownload(xuLyTenBaiHat(singsearch2.Text));
        }
        private void download3_Click(object sender, EventArgs e)
        {
            xuLyDownload(xuLyTenBaiHat(singsearch3.Text));
        }
        private void download4_Click(object sender, EventArgs e)
        {
            xuLyDownload(xuLyTenBaiHat(singsearch4.Text));
        }
        private void download5_Click(object sender, EventArgs e)
        {
            xuLyDownload(xuLyTenBaiHat(singsearch5.Text));
        }
        private void download6_Click(object sender, EventArgs e)
        {
            xuLyDownload(xuLyTenBaiHat(singsearch6.Text));
        }
        private void download7_Click(object sender, EventArgs e)
        {
            xuLyDownload(xuLyTenBaiHat(singsearch7.Text));
        }
        private void download8_Click(object sender, EventArgs e)
        {
            xuLyDownload(xuLyTenBaiHat(singsearch8.Text));
        }
        private void caNhan_Click(object sender, EventArgs e)
        {
            xuLyHienThiCaNhan();
            string[] s = new string[100];
            singControl.singSearch(name, s);
            int count = Convert.ToInt32(s[99]);
            SingObject[] singObjects = new SingObject[count];
            string[] a = new string[count];
            int d = 0;
            int id=getIdMin();
            for (int i = 0; i < count; i++)
            {
                singObjects[i] = new SingObject();
                singObjects[i] = singControl.getSing(id);
                if (singObjects[i].getSing_dowloaded() == true)
                {
                    a[d] = singObjects[i].getSing_name()+ " ----- "+ singObjects[i].getSing_name();
                    d++;
                }
                id++;
            }
            phanTrang(d, a);
            hienThiHeart();
            anTheLoai(0);
        }
        private void xuLyHienThiCaNhan()
        {
            grbBaiHatNoiBat.Visible = false;
            grbBaiHatPhuHopTimKiem.Visible = true;
            hideDelete(1);
            hideDownload(0);
        }
        public int getIdMin()
        {
            SingObject singObject = new SingObject();
            for (int i=0; ; i++)
            {
                singObject = singControl.getSing(i);
                if(singObject != null)
                {
                    return i;
                }
            }
        }
        private void delete1_Click(object sender, EventArgs e)
        {
            xuLyXoa(xuLyTenBaiHat(singsearch1.Text));
        }
        private void delete2_Click(object sender, EventArgs e)
        {
            xuLyXoa(xuLyTenBaiHat(singsearch2.Text));
        }
        private void delete3_Click(object sender, EventArgs e)
        {
            xuLyXoa(xuLyTenBaiHat(singsearch3.Text));
        }
        private void delete4_Click(object sender, EventArgs e)
        {
            xuLyXoa(xuLyTenBaiHat(singsearch3.Text));
        }
        private void delete5_Click(object sender, EventArgs e)
        {
            xuLyXoa(xuLyTenBaiHat(singsearch4.Text));
        }
        private void delete6_Click(object sender, EventArgs e)
        {
            xuLyXoa(xuLyTenBaiHat(singsearch5.Text));
        }
        private void delete7_Click(object sender, EventArgs e)
        {
            xuLyXoa(xuLyTenBaiHat(singsearch6.Text));
        }
        private void delete8_Click(object sender, EventArgs e)
        {
            xuLyXoa(xuLyTenBaiHat(singsearch7.Text));
        }
        private void xuLyXoa(string name)
        {
            SingObject singObject = new SingObject();
            singObject = singControl.getSingName(name);

            singObject.setSing_dowloaded(false);
            singControl.editSing(singObject);

            caNhan_Click(new object(),new EventArgs());
        }
        private void trangChu_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
        private void like1_Click(object sender, EventArgs e)
        {
            xuLyChonHeart(xuLyTenBaiHat(singsearch1.Text));
        }
        private void xuLyChonHeart(string name)
        {
            SingObject singObject = new SingObject();
            singObject = singControl.getSingName(name);

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
        }
        private void like2_Click(object sender, EventArgs e)
        {
            xuLyChonHeart(xuLyTenBaiHat(singsearch2.Text));
        }
        private void like3_Click(object sender, EventArgs e)
        {
            xuLyChonHeart(xuLyTenBaiHat(singsearch3.Text));
        }
        private void like4_Click(object sender, EventArgs e)
        {
            xuLyChonHeart(xuLyTenBaiHat(singsearch4.Text));
        }
        private void like5_Click(object sender, EventArgs e)
        {
            xuLyChonHeart(xuLyTenBaiHat(singsearch5.Text));
        }
        private void like6_Click(object sender, EventArgs e)
        {
            xuLyChonHeart(xuLyTenBaiHat(singsearch6.Text));
        }
        private void like7_Click(object sender, EventArgs e)
        {
            xuLyChonHeart(xuLyTenBaiHat(singsearch7.Text));
        }
        private void like8_Click(object sender, EventArgs e)
        {
            xuLyChonHeart(xuLyTenBaiHat(singsearch8.Text));
        }
        private void danhMucYeuThich_Click(object sender, EventArgs e)
        {
            hienThiYeuDanhMucYeuThich();
            string[] s = new string[100];
            singControl.singSearch(name, s);

            int count = Convert.ToInt32(s[99]);
            SingObject[] singObjects = new SingObject[count];
            string[] a = new string[count];
            int d = 0;
            int id = getIdMin();
            for (int i = 0; i < count; i++)
            {
                singObjects[i] = new SingObject();
                singObjects[i] = singControl.getSing(id);
                if (singObjects[i].getSing_focus() == true)
                {
                    a[d] = singObjects[i].getSing_name() + " ----- " + singObjects[i].getSing_name();
                    d++;
                }
                id++;
            }
            phanTrang(d, a);
            hienThiHeart();
            anTheLoai(0);
        }
        private void hienThiYeuDanhMucYeuThich()
        {
            xuLyHienThiCaNhan();
            hideDelete(0);
            hideDownload(1);
        }
        private void anNenLabel()
        {
            Label[] labels = {singsearch1,singsearch2,singsearch3,singsearch4,singsearch5,singsearch6,singsearch7,
            singsearch8,singtrend1,singtrend2,singtrend3,singtrend4};
            PictureBox[] pictureBoxes ={playImg1,playImg2,playImg3,playImg4,playImg5,playImg6,playImg7,playImg8,download1,download2,download3,download4,download5,download6,download7,download8,delete1,delete2,delete3,delete4,delete5,delete6,delete7,delete8,playpictureBox1,playpictureBox2,playpictureBox3,playpictureBox4, like1, like2, like3, like4, like5, like6, like7, like8 };
            hideLabelBacground(pictureBoxes, labels);
            hideDelete(0);
        }
        //hàm ẩn nền label và pixturebox
        public void hideLabelBacground(PictureBox[] pictureBoxes,Label [] labels)
        {
            if (pictureBoxes != null)
            {
                for (int i = 0; i < pictureBoxes.Length; i++)
                {
                    pictureBoxes[i].BackColor = System.Drawing.Color.Transparent;
                }
            }
            if (labels != null)
            {
                for (int i = 0; i < labels.Length; i++)
                {
                    labels[i].BackColor = System.Drawing.Color.Transparent;
                }
            }
            panel.BackColor = System.Drawing.Color.Transparent;
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
                delete6.Visible = false;
                delete7.Visible = false;
                delete8.Visible = false;
            }
            else
            {
                delete1.Visible = true;
                delete2.Visible = true;
                delete3.Visible = true;
                delete4.Visible = true;
                delete5.Visible = true;
                delete6.Visible = true;
                delete7.Visible = true;
                delete8.Visible = true;
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
                download6.Visible = false;
                download7.Visible = false;
                download8.Visible = false;
            }
            else
            {
                download1.Visible = true;
                download2.Visible = true;
                download3.Visible = true;
                download4.Visible = true;
                download5.Visible = true;
                download6.Visible = true;
                download7.Visible = true;
                download8.Visible = true;
            }
        }
        private void trongNuoc_Click(object sender, EventArgs e)
        {
            xuLyHienThiCaNhan();
            string[] s = new string[100];
            singControl.singSearch(name, s);
            int count = Convert.ToInt32(s[99]);
            SingObject[] singObjects = new SingObject[count];
            string[] a = new string[count];
            int d = 0;
            int id = getIdMin();
            for (int i = 0; i < count; i++)
            {
                singObjects[i] = new SingObject();
                singObjects[i] = singControl.getSing(id);
                if (singObjects[i].getSing_national() == true)
                {
                    a[d] = singObjects[i].getSing_name() + " ----- " + singObjects[i].getSing_singer();
                    d++;
                }
                id++;
            }
            phanTrang(d, a);
            hienThiHeart();
            anTheLoai(0);
            hideDownload(1);
        }
        private void NuocNgoai_Click(object sender, EventArgs e)
        {
            xuLyHienThiCaNhan();
            string[] s = new string[100];
            singControl.singSearch(name, s);
            int count = Convert.ToInt32(s[99]);
            SingObject[] singObjects = new SingObject[count];
            string[] a = new string[count];
            int d = 0;
            int id = getIdMin();
            for (int i = 0; i < count; i++)
            {
                singObjects[i] = new SingObject();
                singObjects[i] = singControl.getSing(id);
                if (singObjects[i].getSing_national() == false)
                {
                    a[d] = singObjects[i].getSing_name() + " ----- " + singObjects[i].getSing_singer();
                    d++;
                }
                id++;
            }
            phanTrang(d, a);
            hienThiHeart();
            anTheLoai(0);
            hideDownload(1);
        }
        private void imgCaSiVietNam_Click(object sender, EventArgs e)
        {
            trongNuoc_Click(sender, e);
        }
        private void ImgNhacHot_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
        private void imgTheGioiVPop_Click(object sender, EventArgs e)
        {
            NuocNgoai_Click(sender, e);
        }
        private void theLoai_Click(object sender, EventArgs e)
        {
            this.i++;
            anTheLoai(i);
        }
        //luat hàm để xử lý refresh lại các hình trái tim xem có yêu thích không
        public void hienThiHeart()
        {
            SingObject singObject = new SingObject();
            SubHeart(like1, singObject, singsearch1);
            SubHeart(like2, singObject, singsearch2);
            SubHeart(like3, singObject, singsearch3);
            SubHeart(like4, singObject, singsearch4);
            SubHeart(like5, singObject, singsearch5);
            SubHeart(like6, singObject, singsearch6);
            SubHeart(like7, singObject, singsearch7);
            SubHeart(like8, singObject, singsearch8);
        }
        //luat subHeart để hiển thị xem một item nào đó có trong yêu thích hay không
        private void SubHeart(PictureBox pictureBox,SingObject singObject,Label label)
        {
            singObject = singControl.getSingName(xuLyTenBaiHat(label.Text));
            if (singObject != null && singObject.getSing_focus() == true)
            {
                pictureBox.Image = Image.FromFile(@"..\..\..\..\Img\heart.png");
            }
            else
            {
                pictureBox.Image = Image.FromFile(@"..\..\..\..\Img\heart_break.png");
            }
        }
    }
}
