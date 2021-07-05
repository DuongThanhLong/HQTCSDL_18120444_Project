namespace HousesForRentAndSellSystem
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.cbmLoaiNha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCapNhatYC = new System.Windows.Forms.Button();
            this.btnXemDSNhaBan = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMe = new System.Windows.Forms.Button();
            this.btnXemGiaNB = new System.Windows.Forms.Button();
            this.btnXemTinhTrangNha = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDuong = new System.Windows.Forms.TextBox();
            this.comboChiNhanh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchByPrice = new System.Windows.Forms.Button();
            this.txtMHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnYeuCauKH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(524, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 37);
            this.btnSearch.TabIndex = 64;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelSide
            // 
            this.panelSide.Location = new System.Drawing.Point(3, 131);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(7, 70);
            this.panelSide.TabIndex = 62;
            // 
            // cbmLoaiNha
            // 
            this.cbmLoaiNha.FormattingEnabled = true;
            this.cbmLoaiNha.Location = new System.Drawing.Point(350, 12);
            this.cbmLoaiNha.Name = "cbmLoaiNha";
            this.cbmLoaiNha.Size = new System.Drawing.Size(168, 38);
            this.cbmLoaiNha.TabIndex = 60;
            this.cbmLoaiNha.SelectedIndexChanged += new System.EventHandler(this.cbmLoaiNha_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 59;
            this.label1.Text = "House Type:";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(254, 221);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowTemplate.Height = 28;
            this.dgvCustomer.Size = new System.Drawing.Size(940, 374);
            this.dgvCustomer.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.btnYeuCauKH);
            this.panel1.Controls.Add(this.btnCapNhatYC);
            this.panel1.Controls.Add(this.btnXemDSNhaBan);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnMe);
            this.panel1.Controls.Add(this.btnXemGiaNB);
            this.panel1.Controls.Add(this.btnXemTinhTrangNha);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 598);
            this.panel1.TabIndex = 57;
            // 
            // btnCapNhatYC
            // 
            this.btnCapNhatYC.FlatAppearance.BorderSize = 0;
            this.btnCapNhatYC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatYC.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatYC.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatYC.Image")));
            this.btnCapNhatYC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatYC.Location = new System.Drawing.Point(9, 257);
            this.btnCapNhatYC.Name = "btnCapNhatYC";
            this.btnCapNhatYC.Size = new System.Drawing.Size(239, 70);
            this.btnCapNhatYC.TabIndex = 76;
            this.btnCapNhatYC.Text = "View A Contract";
            this.btnCapNhatYC.UseVisualStyleBackColor = true;
            this.btnCapNhatYC.Click += new System.EventHandler(this.btnCapNhatYC_Click_1);
            // 
            // btnXemDSNhaBan
            // 
            this.btnXemDSNhaBan.FlatAppearance.BorderSize = 0;
            this.btnXemDSNhaBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDSNhaBan.ForeColor = System.Drawing.Color.White;
            this.btnXemDSNhaBan.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDSNhaBan.Image")));
            this.btnXemDSNhaBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDSNhaBan.Location = new System.Drawing.Point(9, 458);
            this.btnXemDSNhaBan.Name = "btnXemDSNhaBan";
            this.btnXemDSNhaBan.Size = new System.Drawing.Size(239, 70);
            this.btnXemDSNhaBan.TabIndex = 73;
            this.btnXemDSNhaBan.Text = "View House For Sell";
            this.btnXemDSNhaBan.UseVisualStyleBackColor = true;
            this.btnXemDSNhaBan.Click += new System.EventHandler(this.btnXemDSNhaBan_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(6, 193);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(239, 70);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "View All Contracts";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMe
            // 
            this.btnMe.FlatAppearance.BorderSize = 0;
            this.btnMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMe.ForeColor = System.Drawing.Color.White;
            this.btnMe.Image = ((System.Drawing.Image)(resources.GetObject("btnMe.Image")));
            this.btnMe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMe.Location = new System.Drawing.Point(9, 131);
            this.btnMe.Name = "btnMe";
            this.btnMe.Size = new System.Drawing.Size(239, 70);
            this.btnMe.TabIndex = 6;
            this.btnMe.Text = "Me";
            this.btnMe.UseVisualStyleBackColor = true;
            this.btnMe.Click += new System.EventHandler(this.btnMe_Click);
            // 
            // btnXemGiaNB
            // 
            this.btnXemGiaNB.FlatAppearance.BorderSize = 0;
            this.btnXemGiaNB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemGiaNB.ForeColor = System.Drawing.Color.White;
            this.btnXemGiaNB.Image = ((System.Drawing.Image)(resources.GetObject("btnXemGiaNB.Image")));
            this.btnXemGiaNB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemGiaNB.Location = new System.Drawing.Point(9, 382);
            this.btnXemGiaNB.Name = "btnXemGiaNB";
            this.btnXemGiaNB.Size = new System.Drawing.Size(239, 70);
            this.btnXemGiaNB.TabIndex = 3;
            this.btnXemGiaNB.Text = "View House Price";
            this.btnXemGiaNB.UseVisualStyleBackColor = true;
            this.btnXemGiaNB.Click += new System.EventHandler(this.btnXemGiaNB_Click);
            // 
            // btnXemTinhTrangNha
            // 
            this.btnXemTinhTrangNha.FlatAppearance.BorderSize = 0;
            this.btnXemTinhTrangNha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemTinhTrangNha.ForeColor = System.Drawing.Color.White;
            this.btnXemTinhTrangNha.Image = ((System.Drawing.Image)(resources.GetObject("btnXemTinhTrangNha.Image")));
            this.btnXemTinhTrangNha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemTinhTrangNha.Location = new System.Drawing.Point(9, 321);
            this.btnXemTinhTrangNha.Name = "btnXemTinhTrangNha";
            this.btnXemTinhTrangNha.Size = new System.Drawing.Size(239, 70);
            this.btnXemTinhTrangNha.TabIndex = 2;
            this.btnXemTinhTrangNha.Text = "View House Status";
            this.btnXemTinhTrangNha.UseVisualStyleBackColor = true;
            this.btnXemTinhTrangNha.Click += new System.EventHandler(this.btnXemTinhTrangNha_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 125);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(191, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 41);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1156, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 34);
            this.button1.TabIndex = 65;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 66;
            this.label2.Text = "Street:";
            // 
            // txtTenDuong
            // 
            this.txtTenDuong.Location = new System.Drawing.Point(350, 128);
            this.txtTenDuong.Name = "txtTenDuong";
            this.txtTenDuong.Size = new System.Drawing.Size(168, 37);
            this.txtTenDuong.TabIndex = 67;
            this.txtTenDuong.TextChanged += new System.EventHandler(this.txtTenDuong_TextChanged);
            // 
            // comboChiNhanh
            // 
            this.comboChiNhanh.FormattingEnabled = true;
            this.comboChiNhanh.Location = new System.Drawing.Point(350, 70);
            this.comboChiNhanh.Name = "comboChiNhanh";
            this.comboChiNhanh.Size = new System.Drawing.Size(168, 38);
            this.comboChiNhanh.TabIndex = 69;
            this.comboChiNhanh.SelectedIndexChanged += new System.EventHandler(this.comboChiNhanh_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 68;
            this.label3.Text = "Branch:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 30);
            this.label4.TabIndex = 70;
            this.label4.Text = "House ID:";
            // 
            // txtMaNha
            // 
            this.txtMaNha.Location = new System.Drawing.Point(350, 179);
            this.txtMaNha.Name = "txtMaNha";
            this.txtMaNha.Size = new System.Drawing.Size(168, 37);
            this.txtMaNha.TabIndex = 71;
            this.txtMaNha.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtStreet);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(526, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 105);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search house by Status and Street";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 2;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(420, 40);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(42, 39);
            this.btnTimKiem.TabIndex = 90;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(82, 43);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(109, 37);
            this.txtStreet.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 30);
            this.label9.TabIndex = 88;
            this.label9.Text = "Street:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(286, 43);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(109, 37);
            this.txtStatus.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 30);
            this.label7.TabIndex = 86;
            this.label7.Text = "Status:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(824, 131);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(108, 37);
            this.txtGia.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 30);
            this.label5.TabIndex = 74;
            this.label5.Text = "Search house with lower price:";
            // 
            // btnSearchByPrice
            // 
            this.btnSearchByPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnSearchByPrice.FlatAppearance.BorderSize = 2;
            this.btnSearchByPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByPrice.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSearchByPrice.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchByPrice.Image")));
            this.btnSearchByPrice.Location = new System.Drawing.Point(938, 131);
            this.btnSearchByPrice.Name = "btnSearchByPrice";
            this.btnSearchByPrice.Size = new System.Drawing.Size(42, 37);
            this.btnSearchByPrice.TabIndex = 73;
            this.btnSearchByPrice.UseVisualStyleBackColor = false;
            this.btnSearchByPrice.Click += new System.EventHandler(this.btnSearchByPrice_Click);
            // 
            // txtMHD
            // 
            this.txtMHD.Location = new System.Drawing.Point(730, 179);
            this.txtMHD.Name = "txtMHD";
            this.txtMHD.Size = new System.Drawing.Size(109, 37);
            this.txtMHD.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 30);
            this.label6.TabIndex = 92;
            this.label6.Text = "Contract ID:";
            // 
            // txtNha
            // 
            this.txtNha.Location = new System.Drawing.Point(934, 179);
            this.txtNha.Name = "txtNha";
            this.txtNha.Size = new System.Drawing.Size(109, 37);
            this.txtNha.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(858, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 30);
            this.label8.TabIndex = 90;
            this.label8.Text = "House:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(532, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 28);
            this.label10.TabIndex = 94;
            this.label10.Text = "See a contract:";
            // 
            // btnYeuCauKH
            // 
            this.btnYeuCauKH.FlatAppearance.BorderSize = 0;
            this.btnYeuCauKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeuCauKH.ForeColor = System.Drawing.Color.White;
            this.btnYeuCauKH.Image = ((System.Drawing.Image)(resources.GetObject("btnYeuCauKH.Image")));
            this.btnYeuCauKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeuCauKH.Location = new System.Drawing.Point(6, 525);
            this.btnYeuCauKH.Name = "btnYeuCauKH";
            this.btnYeuCauKH.Size = new System.Drawing.Size(239, 70);
            this.btnYeuCauKH.TabIndex = 82;
            this.btnYeuCauKH.Text = "Update Requirements";
            this.btnYeuCauKH.UseVisualStyleBackColor = true;
            this.btnYeuCauKH.Click += new System.EventHandler(this.btnYeuCauKH_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearchByPrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMaNha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboChiNhanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenDuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.cbmLoaiNha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.ComboBox cbmLoaiNha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnXemGiaNB;
        private System.Windows.Forms.Button btnXemTinhTrangNha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDuong;
        private System.Windows.Forms.ComboBox comboChiNhanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXemDSNhaBan;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchByPrice;
        private System.Windows.Forms.Button btnCapNhatYC;
        private System.Windows.Forms.TextBox txtMHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnYeuCauKH;
    }
}