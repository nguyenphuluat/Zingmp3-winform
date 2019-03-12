using System.Drawing;
namespace ZingMP3_buildproject.View
{
    partial class SingView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.wrapper = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnActive = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.MediaZing = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnUserManagerment = new System.Windows.Forms.Button();
            this.btnCategoryManagerment = new System.Windows.Forms.Button();
            this.btnSingManagerment = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgCategory = new System.Windows.Forms.DataGridView();
            this.dtgUser = new System.Windows.Forms.DataGridView();
            this.dtgSing = new System.Windows.Forms.DataGridView();
            this.clStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSinger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRun = new System.Windows.Forms.DataGridViewImageColumn();
            this.clEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.wrapper.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaZing)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSing)).BeginInit();
            this.SuspendLayout();
            // 
            // wrapper
            // 
            this.wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(149)))));
            this.wrapper.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.wrapper.ColumnCount = 1;
            this.wrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wrapper.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.wrapper.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapper.Location = new System.Drawing.Point(0, 0);
            this.wrapper.Name = "wrapper";
            this.wrapper.RowCount = 2;
            this.wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wrapper.Size = new System.Drawing.Size(984, 461);
            this.wrapper.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnActive, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddAll, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLogout, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDel, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(976, 39);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 33);
            this.panel1.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserName.Location = new System.Drawing.Point(69, 8);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(83, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Good_boy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZingMP3_buildproject.Properties.Resources.User_Files_icon;
            this.pictureBox1.Location = new System.Drawing.Point(19, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnActive
            // 
            this.btnActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(128)))));
            this.btnActive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnActive.FlatAppearance.BorderSize = 0;
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.Color.White;
            this.btnActive.Location = new System.Drawing.Point(274, 4);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(132, 30);
            this.btnActive.TabIndex = 2;
            this.btnActive.Text = "button3";
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(128)))));
            this.btnAddAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddAll.FlatAppearance.BorderSize = 0;
            this.btnAddAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAll.ForeColor = System.Drawing.Color.White;
            this.btnAddAll.Location = new System.Drawing.Point(424, 4);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(161, 30);
            this.btnAddAll.TabIndex = 2;
            this.btnAddAll.Text = "Thêm danh sách bài hát";
            this.btnAddAll.UseVisualStyleBackColor = false;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(841, 4);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 31);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEdit.BackColor = System.Drawing.Color.Blue;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(679, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDel.BackColor = System.Drawing.Color.IndianRed;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(762, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(67, 30);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 50);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(976, 407);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCheckIn);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.MediaZing);
            this.panel2.Controls.Add(this.btnUserManagerment);
            this.panel2.Controls.Add(this.btnCategoryManagerment);
            this.panel2.Controls.Add(this.btnSingManagerment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 401);
            this.panel2.TabIndex = 0;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(19, 360);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(0, 13);
            this.lblCheckIn.TabIndex = 3;
            this.lblCheckIn.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(0, 313);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Tìm kiếm...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // MediaZing
            // 
            this.MediaZing.Enabled = true;
            this.MediaZing.Location = new System.Drawing.Point(0, 103);
            this.MediaZing.Name = "MediaZing";
            this.MediaZing.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaZing.OcxState")));
            this.MediaZing.Size = new System.Drawing.Size(144, 195);
            this.MediaZing.TabIndex = 1;
            this.MediaZing.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MediaZing_PlayStateChange);
            // 
            // btnUserManagerment
            // 
            this.btnUserManagerment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagerment.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagerment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUserManagerment.Location = new System.Drawing.Point(-8, 65);
            this.btnUserManagerment.Name = "btnUserManagerment";
            this.btnUserManagerment.Size = new System.Drawing.Size(159, 35);
            this.btnUserManagerment.TabIndex = 0;
            this.btnUserManagerment.Text = "Quản lý tài khoản";
            this.btnUserManagerment.UseVisualStyleBackColor = true;
            this.btnUserManagerment.Click += new System.EventHandler(this.btnUserManagerment_Click);
            // 
            // btnCategoryManagerment
            // 
            this.btnCategoryManagerment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryManagerment.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryManagerment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCategoryManagerment.Location = new System.Drawing.Point(-7, 33);
            this.btnCategoryManagerment.Name = "btnCategoryManagerment";
            this.btnCategoryManagerment.Size = new System.Drawing.Size(159, 35);
            this.btnCategoryManagerment.TabIndex = 0;
            this.btnCategoryManagerment.Text = "Quản lý thế loại";
            this.btnCategoryManagerment.UseVisualStyleBackColor = true;
            this.btnCategoryManagerment.Click += new System.EventHandler(this.btnCategoryManagerment_Click);
            // 
            // btnSingManagerment
            // 
            this.btnSingManagerment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingManagerment.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingManagerment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSingManagerment.Location = new System.Drawing.Point(-7, 1);
            this.btnSingManagerment.Name = "btnSingManagerment";
            this.btnSingManagerment.Size = new System.Drawing.Size(158, 35);
            this.btnSingManagerment.TabIndex = 0;
            this.btnSingManagerment.Text = "Quản lý bài hát";
            this.btnSingManagerment.UseVisualStyleBackColor = true;
            this.btnSingManagerment.Click += new System.EventHandler(this.btnSingManagerment_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgCategory);
            this.panel3.Controls.Add(this.dtgUser);
            this.panel3.Controls.Add(this.dtgSing);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(153, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 401);
            this.panel3.TabIndex = 1;
            // 
            // dtgCategory
            // 
            this.dtgCategory.AllowUserToAddRows = false;
            this.dtgCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCategory.BackgroundColor = System.Drawing.Color.White;
            this.dtgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCategory.Location = new System.Drawing.Point(0, 0);
            this.dtgCategory.Name = "dtgCategory";
            this.dtgCategory.ReadOnly = true;
            this.dtgCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCategory.Size = new System.Drawing.Size(820, 401);
            this.dtgCategory.TabIndex = 4;
            // 
            // dtgUser
            // 
            this.dtgUser.AllowUserToAddRows = false;
            this.dtgUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUser.BackgroundColor = System.Drawing.Color.White;
            this.dtgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgUser.Location = new System.Drawing.Point(0, 0);
            this.dtgUser.Name = "dtgUser";
            this.dtgUser.ReadOnly = true;
            this.dtgUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUser.Size = new System.Drawing.Size(820, 401);
            this.dtgUser.TabIndex = 3;
            this.dtgUser.Visible = false;
            // 
            // dtgSing
            // 
            this.dtgSing.AllowUserToDeleteRows = false;
            this.dtgSing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSing.BackgroundColor = System.Drawing.Color.White;
            this.dtgSing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clStt,
            this.clId,
            this.clSingName,
            this.clCategory,
            this.clAuthor,
            this.clSinger,
            this.clContent,
            this.clTime,
            this.clRun,
            this.clEdit,
            this.clDel});
            this.dtgSing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgSing.EnableHeadersVisualStyles = false;
            this.dtgSing.Location = new System.Drawing.Point(0, 0);
            this.dtgSing.Name = "dtgSing";
            this.dtgSing.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSing.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSing.Size = new System.Drawing.Size(820, 401);
            this.dtgSing.TabIndex = 2;
            this.dtgSing.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSing_CellContentClick);
            // 
            // clStt
            // 
            this.clStt.FillWeight = 64.29488F;
            this.clStt.HeaderText = "STT";
            this.clStt.Name = "clStt";
            this.clStt.ReadOnly = true;
            this.clStt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clId
            // 
            this.clId.FillWeight = 120.2314F;
            this.clId.HeaderText = "Mã bài hát";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            // 
            // clSingName
            // 
            this.clSingName.FillWeight = 120.2314F;
            this.clSingName.HeaderText = "Tên bài hát";
            this.clSingName.Name = "clSingName";
            this.clSingName.ReadOnly = true;
            // 
            // clCategory
            // 
            this.clCategory.FillWeight = 120.2314F;
            this.clCategory.HeaderText = "Thể loại";
            this.clCategory.Name = "clCategory";
            this.clCategory.ReadOnly = true;
            // 
            // clAuthor
            // 
            this.clAuthor.FillWeight = 120.2314F;
            this.clAuthor.HeaderText = "Tác giả";
            this.clAuthor.Name = "clAuthor";
            this.clAuthor.ReadOnly = true;
            // 
            // clSinger
            // 
            this.clSinger.FillWeight = 120.2314F;
            this.clSinger.HeaderText = "Ca sĩ";
            this.clSinger.Name = "clSinger";
            this.clSinger.ReadOnly = true;
            // 
            // clContent
            // 
            this.clContent.FillWeight = 120.2314F;
            this.clContent.HeaderText = "Chi tiết";
            this.clContent.Name = "clContent";
            this.clContent.ReadOnly = true;
            // 
            // clTime
            // 
            this.clTime.FillWeight = 120.2314F;
            this.clTime.HeaderText = "Thời lượng";
            this.clTime.Name = "clTime";
            this.clTime.ReadOnly = true;
            // 
            // clRun
            // 
            this.clRun.FillWeight = 73.08775F;
            this.clRun.HeaderText = "Chạy";
            this.clRun.Name = "clRun";
            this.clRun.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clRun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clEdit
            // 
            this.clEdit.FillWeight = 65.16024F;
            this.clEdit.HeaderText = "Sửa";
            this.clEdit.Name = "clEdit";
            this.clEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clDel
            // 
            this.clDel.FillWeight = 55.83757F;
            this.clDel.HeaderText = "Xóa";
            this.clDel.Name = "clDel";
            this.clDel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(147)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.wrapper);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "SingView";
            this.Text = "SingView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SingView_FormClosed);
            this.Load += new System.EventHandler(this.SingView_Load);
            this.wrapper.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaZing)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel wrapper;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSingManagerment;
        private System.Windows.Forms.Button btnCategoryManagerment;
        private System.Windows.Forms.Button btnUserManagerment;
        private System.Windows.Forms.Button btnActive;
        private AxWMPLib.AxWindowsMediaPlayer MediaZing;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgSing;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSinger;
        private System.Windows.Forms.DataGridViewTextBoxColumn clContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTime;
        private System.Windows.Forms.DataGridViewImageColumn clRun;
        private System.Windows.Forms.DataGridViewImageColumn clEdit;
        private System.Windows.Forms.DataGridViewImageColumn clDel;
        private System.Windows.Forms.DataGridView dtgUser;
        private System.Windows.Forms.DataGridView dtgCategory;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblCheckIn;
    }
}