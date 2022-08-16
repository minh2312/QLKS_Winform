namespace Winform
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.QLTang = new System.Windows.Forms.ToolStripMenuItem();
            this.QLLoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.QLRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThuêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLDatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.QLTraPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.toolStripMenuItem2,
            this.quảnLýThuêPhòngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.changePass});
            this.tàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tàiKhoảnToolStripMenuItem.Image = global::Winform.Properties.Resources.profile;
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "- Quản Lý Tài Khoản";
            // 
            // changePass
            // 
            this.changePass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(229, 22);
            this.changePass.Text = "- Đổi Mật Khẩu";
            this.changePass.Click += new System.EventHandler(this.changePass_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLTang,
            this.QLLoaiPhong,
            this.QLRoom});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Image = global::Winform.Properties.Resources.note;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(90, 23);
            this.toolStripMenuItem2.Text = "Quản Lý";
            // 
            // QLTang
            // 
            this.QLTang.Name = "QLTang";
            this.QLTang.Size = new System.Drawing.Size(214, 24);
            this.QLTang.Text = "- Quản Lý Tầng";
            this.QLTang.Click += new System.EventHandler(this.QLTang_Click);
            // 
            // QLLoaiPhong
            // 
            this.QLLoaiPhong.Name = "QLLoaiPhong";
            this.QLLoaiPhong.Size = new System.Drawing.Size(214, 24);
            this.QLLoaiPhong.Text = "- Quản Lý Loại Phòng";
            this.QLLoaiPhong.Click += new System.EventHandler(this.QLLoaiPhong_Click);
            // 
            // QLRoom
            // 
            this.QLRoom.Name = "QLRoom";
            this.QLRoom.Size = new System.Drawing.Size(214, 24);
            this.QLRoom.Text = "- Quản Lý Phòng";
            this.QLRoom.Click += new System.EventHandler(this.QLRoom_Click);
            // 
            // quảnLýThuêPhòngToolStripMenuItem
            // 
            this.quảnLýThuêPhòngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLDatPhong,
            this.QLTraPhong});
            this.quảnLýThuêPhòngToolStripMenuItem.Image = global::Winform.Properties.Resources._2544056;
            this.quảnLýThuêPhòngToolStripMenuItem.Name = "quảnLýThuêPhòngToolStripMenuItem";
            this.quảnLýThuêPhòngToolStripMenuItem.Size = new System.Drawing.Size(145, 23);
            this.quảnLýThuêPhòngToolStripMenuItem.Text = "Quản Lý Thuê Phòng";
            // 
            // QLDatPhong
            // 
            this.QLDatPhong.Name = "QLDatPhong";
            this.QLDatPhong.Size = new System.Drawing.Size(138, 22);
            this.QLDatPhong.Text = "- Đặt Phòng";
            this.QLDatPhong.Click += new System.EventHandler(this.QLDatPhong_Click);
            // 
            // QLTraPhong
            // 
            this.QLTraPhong.Name = "QLTraPhong";
            this.QLTraPhong.Size = new System.Drawing.Size(138, 22);
            this.QLTraPhong.Text = "- Trả Phòng";
            this.QLTraPhong.Click += new System.EventHandler(this.QLTraPhong_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "2544056.png");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Winform.Properties.Resources._20210617172417_2f9e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khác Sạn";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePass;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem QLTang;
        private System.Windows.Forms.ToolStripMenuItem QLLoaiPhong;
        private System.Windows.Forms.ToolStripMenuItem QLRoom;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThuêPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLDatPhong;
        private System.Windows.Forms.ToolStripMenuItem QLTraPhong;
    }
}