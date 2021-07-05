namespace HousesForRentAndSellSystem
{
    partial class FormCustomer_Requirement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer_Requirement));
            this.button1 = new System.Windows.Forms.Button();
            this.dgvCustomerRequirement = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSavePrice = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTieuChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRequirement)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(801, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 34);
            this.button1.TabIndex = 67;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvCustomerRequirement
            // 
            this.dgvCustomerRequirement.AllowUserToAddRows = false;
            this.dgvCustomerRequirement.AllowUserToDeleteRows = false;
            this.dgvCustomerRequirement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerRequirement.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvCustomerRequirement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerRequirement.Location = new System.Drawing.Point(3, 114);
            this.dgvCustomerRequirement.Name = "dgvCustomerRequirement";
            this.dgvCustomerRequirement.ReadOnly = true;
            this.dgvCustomerRequirement.RowTemplate.Height = 28;
            this.dgvCustomerRequirement.Size = new System.Drawing.Size(836, 238);
            this.dgvCustomerRequirement.TabIndex = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTieuChi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 91);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit your requirements:";
            // 
            // btnSavePrice
            // 
            this.btnSavePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnSavePrice.FlatAppearance.BorderSize = 2;
            this.btnSavePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrice.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePrice.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSavePrice.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePrice.Image")));
            this.btnSavePrice.Location = new System.Drawing.Point(765, 59);
            this.btnSavePrice.Name = "btnSavePrice";
            this.btnSavePrice.Size = new System.Drawing.Size(40, 37);
            this.btnSavePrice.TabIndex = 83;
            this.btnSavePrice.UseVisualStyleBackColor = false;
            this.btnSavePrice.Click += new System.EventHandler(this.btnSavePrice_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(277, 39);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(180, 37);
            this.txtDiaChi.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 30);
            this.label4.TabIndex = 81;
            this.label4.Text = "Address:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(85, 39);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(110, 37);
            this.txtMaPhieu.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 30);
            this.label3.TabIndex = 79;
            this.label3.Text = " Form ID:";
            // 
            // txtTieuChi
            // 
            this.txtTieuChi.Location = new System.Drawing.Point(536, 39);
            this.txtTieuChi.Name = "txtTieuChi";
            this.txtTieuChi.Size = new System.Drawing.Size(180, 37);
            this.txtTieuChi.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 83;
            this.label1.Text = "Criteria:";
            // 
            // FormCustomer_Requirement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(841, 357);
            this.Controls.Add(this.btnSavePrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCustomerRequirement);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormCustomer_Requirement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCustomer_Requirement";
            this.Load += new System.EventHandler(this.FormCustomer_Requirement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRequirement)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvCustomerRequirement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSavePrice;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTieuChi;
        private System.Windows.Forms.Label label1;
    }
}