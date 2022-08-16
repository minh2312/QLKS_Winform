namespace Winform.QLDatPhong
{
    partial class TraPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSoNgayThue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dateNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dateNgayDat = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNameRoom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNameCus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdRoom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgDatPhong = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btn_thoat1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trả Phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lbSoNgayThue);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTotalPrice);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.dateNgayTra);
            this.groupBox1.Controls.Add(this.dateNgayDat);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbNameRoom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbNameCus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIdCustomer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdRoom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dvgDatPhong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 434);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đặt Phòng";
            // 
            // lbSoNgayThue
            // 
            this.lbSoNgayThue.AutoSize = true;
            this.lbSoNgayThue.Location = new System.Drawing.Point(698, 352);
            this.lbSoNgayThue.Name = "lbSoNgayThue";
            this.lbSoNgayThue.Size = new System.Drawing.Size(48, 17);
            this.lbSoNgayThue.TabIndex = 18;
            this.lbSoNgayThue.Text = "..........";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(567, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Số Ngày Thuê";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(1009, 391);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(122, 25);
            this.txtTotalPrice.TabIndex = 16;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(701, 388);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(122, 25);
            this.txtPrice.TabIndex = 15;
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dateNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayTra.Location = new System.Drawing.Point(701, 302);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Size = new System.Drawing.Size(200, 25);
            this.dateNgayTra.TabIndex = 14;
            // 
            // dateNgayDat
            // 
            this.dateNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dateNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayDat.Location = new System.Drawing.Point(701, 264);
            this.dateNgayDat.Name = "dateNgayDat";
            this.dateNgayDat.Size = new System.Drawing.Size(200, 25);
            this.dateNgayDat.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(926, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tổng Tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(630, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày Trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày Đặt";
            // 
            // lbNameRoom
            // 
            this.lbNameRoom.AutoSize = true;
            this.lbNameRoom.Location = new System.Drawing.Point(87, 310);
            this.lbNameRoom.Name = "lbNameRoom";
            this.lbNameRoom.Size = new System.Drawing.Size(48, 17);
            this.lbNameRoom.TabIndex = 8;
            this.lbNameRoom.Text = "..........";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên Phòng";
            // 
            // lbNameCus
            // 
            this.lbNameCus.AutoSize = true;
            this.lbNameCus.Location = new System.Drawing.Point(86, 391);
            this.lbNameCus.Name = "lbNameCus";
            this.lbNameCus.Size = new System.Drawing.Size(48, 17);
            this.lbNameCus.TabIndex = 6;
            this.lbNameCus.Text = "..........";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Khách";
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(83, 344);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.ReadOnly = true;
            this.txtIdCustomer.Size = new System.Drawing.Size(204, 25);
            this.txtIdCustomer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Khách";
            // 
            // txtIdRoom
            // 
            this.txtIdRoom.Location = new System.Drawing.Point(83, 267);
            this.txtIdRoom.Name = "txtIdRoom";
            this.txtIdRoom.ReadOnly = true;
            this.txtIdRoom.Size = new System.Drawing.Size(204, 25);
            this.txtIdRoom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phòng";
            // 
            // dvgDatPhong
            // 
            this.dvgDatPhong.AllowUserToAddRows = false;
            this.dvgDatPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDatPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19});
            this.dvgDatPhong.Location = new System.Drawing.Point(6, 40);
            this.dvgDatPhong.Name = "dvgDatPhong";
            this.dvgDatPhong.Size = new System.Drawing.Size(1144, 193);
            this.dvgDatPhong.TabIndex = 0;
            this.dvgDatPhong.Click += new System.EventHandler(this.dvgDatPhong_Click);
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Id";
            this.Column13.HeaderText = "Id";
            this.Column13.Name = "Column13";
            this.Column13.Width = 80;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "FullName";
            this.Column14.HeaderText = "Tên Khách Đặt";
            this.Column14.Name = "Column14";
            this.Column14.Width = 220;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "RoomName";
            this.Column15.HeaderText = "Tên Phòng";
            this.Column15.Name = "Column15";
            this.Column15.Width = 220;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "Price";
            this.Column16.HeaderText = "Giá";
            this.Column16.Name = "Column16";
            this.Column16.Width = 120;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "StartDate";
            this.Column17.HeaderText = "Ngày Nhận Phòng";
            this.Column17.Name = "Column17";
            this.Column17.Width = 160;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "EndDate";
            this.Column18.HeaderText = "Ngày Trả Phòng";
            this.Column18.Name = "Column18";
            this.Column18.Width = 160;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "Status";
            this.Column19.HeaderText = "Trạng Thái";
            this.Column19.Name = "Column19";
            this.Column19.Width = 128;
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnTraPhong.Image")));
            this.btnTraPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraPhong.Location = new System.Drawing.Point(15, 499);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(150, 42);
            this.btnTraPhong.TabIndex = 70;
            this.btnTraPhong.Text = "Trả phòng";
            this.btnTraPhong.UseVisualStyleBackColor = false;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.Location = new System.Drawing.Point(449, 499);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(228, 42);
            this.btnXuatExcel.TabIndex = 71;
            this.btnXuatExcel.Text = "Xuất phiếu thanh toán";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btn_thoat1
            // 
            this.btn_thoat1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat1.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat1.Image")));
            this.btn_thoat1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat1.Location = new System.Drawing.Point(971, 502);
            this.btn_thoat1.Name = "btn_thoat1";
            this.btn_thoat1.Size = new System.Drawing.Size(173, 39);
            this.btn_thoat1.TabIndex = 72;
            this.btn_thoat1.Text = "Thoát";
            this.btn_thoat1.UseVisualStyleBackColor = true;
            // 
            // TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 564);
            this.Controls.Add(this.btn_thoat1);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TraPhong";
            this.Text = "TraPhong";
            this.Load += new System.EventHandler(this.TraPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvgDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dateNgayTra;
        private System.Windows.Forms.DateTimePicker dateNgayDat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNameRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNameCus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btn_thoat1;
        private System.Windows.Forms.Label lbSoNgayThue;
        private System.Windows.Forms.Label label10;
    }
}