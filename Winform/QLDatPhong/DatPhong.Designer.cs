namespace Winform.QLDatPhong
{
    partial class DatPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvgRoom = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvgDatPhong = new System.Windows.Forms.DataGridView();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dvgCustomer = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIdPhong = new System.Windows.Forms.TextBox();
            this.numNguoiToiDa = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.rdKhac = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatPhong)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNguoiToiDa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đặt Phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.dvgRoom);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 194);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Phòng";
            // 
            // dvgRoom
            // 
            this.dvgRoom.AllowUserToAddRows = false;
            this.dvgRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column12});
            this.dvgRoom.Location = new System.Drawing.Point(0, 43);
            this.dvgRoom.Name = "dvgRoom";
            this.dvgRoom.Size = new System.Drawing.Size(639, 145);
            this.dvgRoom.TabIndex = 0;
            this.dvgRoom.Click += new System.EventHandler(this.dvgRoom_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Status";
            this.Column2.HeaderText = "Status";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NguoiToiDa";
            this.Column3.HeaderText = "Số Người Tối Đa";
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NameTang";
            this.Column4.HeaderText = "Tầng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NameLoaiPhong";
            this.Column5.HeaderText = "Loại Phòng";
            this.Column5.Name = "Column5";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Price";
            this.Column12.HeaderText = "Giá";
            this.Column12.Name = "Column12";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dvgDatPhong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 448);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1138, 201);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đặt Phòng";
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
            this.dvgDatPhong.Location = new System.Drawing.Point(6, 41);
            this.dvgDatPhong.Name = "dvgDatPhong";
            this.dvgDatPhong.Size = new System.Drawing.Size(1132, 154);
            this.dvgDatPhong.TabIndex = 0;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.Image = global::Winform.Properties.Resources.plus;
            this.btnDatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.Location = new System.Drawing.Point(25, 235);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(108, 37);
            this.btnDatPhong.TabIndex = 63;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.dvgCustomer);
            this.groupBox4.Location = new System.Drawing.Point(653, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(481, 196);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Khách Hàng";
            // 
            // dvgCustomer
            // 
            this.dvgCustomer.AllowUserToAddRows = false;
            this.dvgCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dvgCustomer.Location = new System.Drawing.Point(6, 44);
            this.dvgCustomer.Name = "dvgCustomer";
            this.dvgCustomer.Size = new System.Drawing.Size(468, 145);
            this.dvgCustomer.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Id";
            this.Column6.HeaderText = "Id";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "FullName";
            this.Column7.HeaderText = "Họ Và Tên";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CCCD";
            this.Column8.HeaderText = "CCCD";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Email";
            this.Column9.HeaderText = "Email";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Phone";
            this.Column10.HeaderText = "Phone";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Gender";
            this.Column11.HeaderText = "Giới Tính";
            this.Column11.Name = "Column11";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.txtIdPhong);
            this.groupBox3.Controls.Add(this.numNguoiToiDa);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dateEnd);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.dateStart);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dateBirthday);
            this.groupBox3.Controls.Add(this.rdKhac);
            this.groupBox3.Controls.Add(this.rdNu);
            this.groupBox3.Controls.Add(this.rdNam);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Controls.Add(this.txtSDT);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCCCD);
            this.groupBox3.Controls.Add(this.txtFullName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMaKH);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(2, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1138, 164);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Book Phòng";
            // 
            // txtIdPhong
            // 
            this.txtIdPhong.Location = new System.Drawing.Point(729, 32);
            this.txtIdPhong.Name = "txtIdPhong";
            this.txtIdPhong.ReadOnly = true;
            this.txtIdPhong.Size = new System.Drawing.Size(120, 20);
            this.txtIdPhong.TabIndex = 28;
            // 
            // numNguoiToiDa
            // 
            this.numNguoiToiDa.Location = new System.Drawing.Point(999, 33);
            this.numNguoiToiDa.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numNguoiToiDa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNguoiToiDa.Name = "numNguoiToiDa";
            this.numNguoiToiDa.ReadOnly = true;
            this.numNguoiToiDa.Size = new System.Drawing.Size(126, 20);
            this.numNguoiToiDa.TabIndex = 27;
            this.numNguoiToiDa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(914, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Số Người Thuê";
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "dd/MM/yyyy";
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(728, 130);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(121, 20);
            this.dateEnd.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(654, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Ngày Trả";
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "dd/MM/yyyy";
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(729, 98);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(115, 20);
            this.dateStart.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(648, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Ngày Thuê";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(669, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(669, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Phòng";
            // 
            // dateBirthday
            // 
            this.dateBirthday.CustomFormat = "dd/MM/yyyy";
            this.dateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirthday.Location = new System.Drawing.Point(405, 127);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(175, 20);
            this.dateBirthday.TabIndex = 17;
            // 
            // rdKhac
            // 
            this.rdKhac.AutoSize = true;
            this.rdKhac.Location = new System.Drawing.Point(530, 98);
            this.rdKhac.Name = "rdKhac";
            this.rdKhac.Size = new System.Drawing.Size(50, 17);
            this.rdKhac.TabIndex = 16;
            this.rdKhac.Text = "Khác";
            this.rdKhac.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(468, 98);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 15;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(405, 98);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 14;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ngày Sinh";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(405, 64);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(175, 20);
            this.txtAddress.TabIndex = 12;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(405, 29);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(175, 20);
            this.txtSDT.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "SĐT";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(66, 127);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(66, 91);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(186, 20);
            this.txtCCCD.TabIndex = 5;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(66, 61);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(186, 20);
            this.txtFullName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CCCD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(66, 29);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(186, 20);
            this.txtMaKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã KH";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(729, 68);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(120, 20);
            this.txtPrice.TabIndex = 29;
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
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 648);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "DatPhong";
            this.Text = "DatPhong";
            this.Load += new System.EventHandler(this.DatPhong_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgRoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatPhong)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNguoiToiDa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvgRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvgDatPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dvgCustomer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateBirthday;
        private System.Windows.Forms.RadioButton rdKhac;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.NumericUpDown numNguoiToiDa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.TextBox txtIdPhong;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
    }
}