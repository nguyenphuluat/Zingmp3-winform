namespace ZingMP3_buildproject.View
{
    partial class Index
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grHeader = new System.Windows.Forms.GroupBox();
            this.plHot = new System.Windows.Forms.Panel();
            this.btnPrivate = new System.Windows.Forms.Button();
            this.btnPublic = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.clsing_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clsing_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clsing_singer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(568, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(311, 22);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(885, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // grHeader
            // 
            this.grHeader.Controls.Add(this.plHot);
            this.grHeader.Controls.Add(this.btnPrivate);
            this.grHeader.Controls.Add(this.btnPublic);
            this.grHeader.Controls.Add(this.txtSearch);
            this.grHeader.Controls.Add(this.btnSearch);
            this.grHeader.Location = new System.Drawing.Point(0, 0);
            this.grHeader.Name = "grHeader";
            this.grHeader.Size = new System.Drawing.Size(974, 43);
            this.grHeader.TabIndex = 2;
            this.grHeader.TabStop = false;
            // 
            // plHot
            // 
            this.plHot.Location = new System.Drawing.Point(2, 43);
            this.plHot.Name = "plHot";
            this.plHot.Size = new System.Drawing.Size(966, 410);
            this.plHot.TabIndex = 2;
            // 
            // btnPrivate
            // 
            this.btnPrivate.BackgroundImage = global::ZingMP3_buildproject.Properties.Resources._33102552_2028170937224057_7261889425146118144_n;
            this.btnPrivate.Location = new System.Drawing.Point(139, 4);
            this.btnPrivate.Name = "btnPrivate";
            this.btnPrivate.Size = new System.Drawing.Size(127, 37);
            this.btnPrivate.TabIndex = 2;
            this.btnPrivate.Text = "Nhạc của tui";
            this.btnPrivate.UseVisualStyleBackColor = true;
            // 
            // btnPublic
            // 
            this.btnPublic.BackgroundImage = global::ZingMP3_buildproject.Properties.Resources._33113918_2028171393890678_8131066178790490112_n;
            this.btnPublic.Location = new System.Drawing.Point(6, 4);
            this.btnPublic.Name = "btnPublic";
            this.btnPublic.Size = new System.Drawing.Size(127, 37);
            this.btnPublic.TabIndex = 2;
            this.btnPublic.Text = "Hot";
            this.btnPublic.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(2, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 185);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhạc Nước Ngoài";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Location = new System.Drawing.Point(2, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 213);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhạc Việt";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(982, 166);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clsing_id,
            this.clsing_name,
            this.clsing_singer});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(3, 16);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(982, 194);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // clsing_id
            // 
            this.clsing_id.Text = "";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 454);
            this.Controls.Add(this.grHeader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Index";
            this.Text = "Index";
            this.grHeader.ResumeLayout(false);
            this.grHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grHeader;
        private System.Windows.Forms.Panel plHot;
        private System.Windows.Forms.Button btnPrivate;
        private System.Windows.Forms.Button btnPublic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader clsing_id;
        private System.Windows.Forms.ColumnHeader clsing_name;
        private System.Windows.Forms.ColumnHeader clsing_singer;
    }
}