namespace HousesForRentAndSellSystem
{
    partial class FormOwner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOwner));
            this.button1 = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.cbmLoaiNha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCapNhatTinhTrangNha = new System.Windows.Forms.Button();
            this.btnMe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveStatus = new System.Windows.Forms.Button();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHouseId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1156, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 34);
            this.button1.TabIndex = 76;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelSide
            // 
            this.panelSide.Location = new System.Drawing.Point(3, 131);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(7, 70);
            this.panelSide.TabIndex = 74;
            // 
            // cbmLoaiNha
            // 
            this.cbmLoaiNha.FormattingEnabled = true;
            this.cbmLoaiNha.Location = new System.Drawing.Point(404, 12);
            this.cbmLoaiNha.Name = "cbmLoaiNha";
            this.cbmLoaiNha.Size = new System.Drawing.Size(202, 38);
            this.cbmLoaiNha.TabIndex = 73;
            this.cbmLoaiNha.SelectedIndexChanged += new System.EventHandler(this.cbmLoaiNha_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 72;
            this.label1.Text = "House Type:";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(257, 261);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowTemplate.Height = 28;
            this.dgvCustomer.Size = new System.Drawing.Size(940, 339);
            this.dgvCustomer.TabIndex = 71;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.btnCapNhatTinhTrangNha);
            this.panel1.Controls.Add(this.btnMe);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 600);
            this.panel1.TabIndex = 70;
            // 
            // btnCapNhatTinhTrangNha
            // 
            this.btnCapNhatTinhTrangNha.FlatAppearance.BorderSize = 0;
            this.btnCapNhatTinhTrangNha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatTinhTrangNha.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatTinhTrangNha.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatTinhTrangNha.Image")));
            this.btnCapNhatTinhTrangNha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatTinhTrangNha.Location = new System.Drawing.Point(9, 207);
            this.btnCapNhatTinhTrangNha.Name = "btnCapNhatTinhTrangNha";
            this.btnCapNhatTinhTrangNha.Size = new System.Drawing.Size(239, 70);
            this.btnCapNhatTinhTrangNha.TabIndex = 7;
            this.btnCapNhatTinhTrangNha.Text = "View Rentals";
            this.btnCapNhatTinhTrangNha.UseVisualStyleBackColor = true;
            this.btnCapNhatTinhTrangNha.Click += new System.EventHandler(this.btnCapNhatTinhTrangNha_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveStatus);
            this.groupBox2.Controls.Add(this.txtTinhTrang);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtHouseId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(257, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 158);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update house status:";
            // 
            // btnSaveStatus
            // 
            this.btnSaveStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnSaveStatus.FlatAppearance.BorderSize = 2;
            this.btnSaveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStatus.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSaveStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveStatus.Image")));
            this.btnSaveStatus.Location = new System.Drawing.Point(285, 39);
            this.btnSaveStatus.Name = "btnSaveStatus";
            this.btnSaveStatus.Size = new System.Drawing.Size(40, 37);
            this.btnSaveStatus.TabIndex = 83;
            this.btnSaveStatus.UseVisualStyleBackColor = false;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(82, 89);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(177, 37);
            this.txtTinhTrang.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 30);
            this.label5.TabIndex = 81;
            this.label5.Text = "Status:";
            // 
            // txtHouseId
            // 
            this.txtHouseId.Location = new System.Drawing.Point(82, 39);
            this.txtHouseId.Name = "txtHouseId";
            this.txtHouseId.Size = new System.Drawing.Size(177, 37);
            this.txtHouseId.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 30);
            this.label6.TabIndex = 79;
            this.label6.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNha);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(643, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 158);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of Rentals:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SeaGreen;
            this.button2.Location = new System.Drawing.Point(239, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 40);
            this.button2.TabIndex = 83;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 30);
            this.label3.TabIndex = 79;
            this.label3.Text = "ID:";
            // 
            // txtNha
            // 
            this.txtNha.Location = new System.Drawing.Point(56, 39);
            this.txtNha.Name = "txtNha";
            this.txtNha.Size = new System.Drawing.Size(177, 37);
            this.txtNha.TabIndex = 84;
            // 
            // FormOwner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.cbmLoaiNha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOwner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOwner";
            this.Load += new System.EventHandler(this.FormOwner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.ComboBox cbmLoaiNha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCapNhatTinhTrangNha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveStatus;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHouseId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNha;
    }
}