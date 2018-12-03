namespace ZingMP3_buildproject.View
{
    partial class AddAllSing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAllSing));
            this.bntBrowse = new System.Windows.Forms.Button();
            this.grbKhuVuc = new System.Windows.Forms.GroupBox();
            this.rdoQuocTe = new System.Windows.Forms.RadioButton();
            this.rdoTrongNuoc = new System.Windows.Forms.RadioButton();
            this.txtLinkFile = new System.Windows.Forms.TextBox();
            this.bntComfig = new System.Windows.Forms.Button();
            this.ListFileMP3 = new System.Windows.Forms.FolderBrowserDialog();
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.grbKhuVuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            this.SuspendLayout();
            // 
            // bntBrowse
            // 
            this.bntBrowse.Location = new System.Drawing.Point(274, 81);
            this.bntBrowse.Name = "bntBrowse";
            this.bntBrowse.Size = new System.Drawing.Size(75, 23);
            this.bntBrowse.TabIndex = 0;
            this.bntBrowse.Text = "browse....";
            this.bntBrowse.UseVisualStyleBackColor = true;
            this.bntBrowse.Click += new System.EventHandler(this.bntBrowse_Click);
            // 
            // grbKhuVuc
            // 
            this.grbKhuVuc.Controls.Add(this.rdoQuocTe);
            this.grbKhuVuc.Controls.Add(this.rdoTrongNuoc);
            this.grbKhuVuc.Location = new System.Drawing.Point(44, 17);
            this.grbKhuVuc.Name = "grbKhuVuc";
            this.grbKhuVuc.Size = new System.Drawing.Size(305, 48);
            this.grbKhuVuc.TabIndex = 1;
            this.grbKhuVuc.TabStop = false;
            this.grbKhuVuc.Text = "Khu vực";
            // 
            // rdoQuocTe
            // 
            this.rdoQuocTe.AutoSize = true;
            this.rdoQuocTe.Location = new System.Drawing.Point(191, 19);
            this.rdoQuocTe.Name = "rdoQuocTe";
            this.rdoQuocTe.Size = new System.Drawing.Size(63, 17);
            this.rdoQuocTe.TabIndex = 0;
            this.rdoQuocTe.Text = "Quốc tế";
            this.rdoQuocTe.UseVisualStyleBackColor = true;
            // 
            // rdoTrongNuoc
            // 
            this.rdoTrongNuoc.AutoSize = true;
            this.rdoTrongNuoc.Checked = true;
            this.rdoTrongNuoc.Location = new System.Drawing.Point(55, 19);
            this.rdoTrongNuoc.Name = "rdoTrongNuoc";
            this.rdoTrongNuoc.Size = new System.Drawing.Size(80, 17);
            this.rdoTrongNuoc.TabIndex = 0;
            this.rdoTrongNuoc.TabStop = true;
            this.rdoTrongNuoc.Text = "Trong nước";
            this.rdoTrongNuoc.UseVisualStyleBackColor = true;
            // 
            // txtLinkFile
            // 
            this.txtLinkFile.Location = new System.Drawing.Point(44, 83);
            this.txtLinkFile.Name = "txtLinkFile";
            this.txtLinkFile.ReadOnly = true;
            this.txtLinkFile.Size = new System.Drawing.Size(211, 20);
            this.txtLinkFile.TabIndex = 2;
            this.txtLinkFile.TextChanged += new System.EventHandler(this.txtLinkFile_TextChanged);
            // 
            // bntComfig
            // 
            this.bntComfig.Enabled = false;
            this.bntComfig.Location = new System.Drawing.Point(274, 126);
            this.bntComfig.Name = "bntComfig";
            this.bntComfig.Size = new System.Drawing.Size(75, 23);
            this.bntComfig.TabIndex = 3;
            this.bntComfig.Text = "Xác Nhận";
            this.bntComfig.UseVisualStyleBackColor = true;
            this.bntComfig.Click += new System.EventHandler(this.bntComfig_Click);
            // 
            // Media
            // 
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(44, 126);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(211, 23);
            this.Media.TabIndex = 4;
            this.Media.Visible = false;
            // 
            // AddAllSing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.bntComfig);
            this.Controls.Add(this.txtLinkFile);
            this.Controls.Add(this.grbKhuVuc);
            this.Controls.Add(this.bntBrowse);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "AddAllSing";
            this.Text = "Chọn File";
            this.grbKhuVuc.ResumeLayout(false);
            this.grbKhuVuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntBrowse;
        private System.Windows.Forms.GroupBox grbKhuVuc;
        private System.Windows.Forms.RadioButton rdoQuocTe;
        private System.Windows.Forms.RadioButton rdoTrongNuoc;
        private System.Windows.Forms.TextBox txtLinkFile;
        private System.Windows.Forms.Button bntComfig;
        private System.Windows.Forms.FolderBrowserDialog ListFileMP3;
        private AxWMPLib.AxWindowsMediaPlayer Media;
    }
}