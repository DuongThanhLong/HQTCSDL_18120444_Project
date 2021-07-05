using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HousesForRentAndSellSystem
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=MIRINDACOCA;Initial Catalog=QUANLYTHUENHA;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void movePanelSide(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            movePanelSide(btnBranch);
            string query = @"SELECT * FROM ChiNhanh";
            var dap = new SqlDataAdapter(query, cn);
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            movePanelSide(btnEmployee);
            string query = @"SELECT * FROM NhanVien";
            var dap = new SqlDataAdapter(query, cn);
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;

            txtMaCN.DataBindings.Clear();
            txtMaCN.DataBindings.Add("Text", dgvCustomer.DataSource, "MaCN");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dgvCustomer.DataSource, "TenNV");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvCustomer.DataSource, "SDT_NV");
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dgvCustomer.DataSource, "GioiTinhNV");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvCustomer.DataSource, "DiaChiNV");
            txtLuong.DataBindings.Clear();
            txtLuong.DataBindings.Add("Text", dgvCustomer.DataSource, "Luong");
            txtUsername.DataBindings.Clear();
            txtUsername.DataBindings.Add("Text", dgvCustomer.DataSource, "username");
            txtPassword.DataBindings.Clear();
            txtPassword.DataBindings.Add("Text", dgvCustomer.DataSource, "password");

            txtMaCN.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtLuong.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtMaCN.Focus();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            movePanelSide(btnCustomer);
            string query = @"SELECT * FROM KhachHang";
            var dap = new SqlDataAdapter(query, cn);
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            movePanelSide(btnOwner);
            string query = @"SELECT * FROM ChuNha";
            var dap = new SqlDataAdapter(query, cn);
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM LoaiNha", cn);
            var table = new DataTable();
            dap.Fill(table);
            cbmLoaiNha.DisplayMember = "LoaiNha";
            cbmLoaiNha.ValueMember = "MaLoaiNha";
            cbmLoaiNha.DataSource = table;
            cbmLoaiNha.SelectedIndex = -1;

            txtTenDuong.DataBindings.Clear();
            txtTenDuong.DataBindings.Add("Text", dgvCustomer.DataSource, "TenDuong_Nha");
            txtTenDuong.Text = "";
            txtTenDuong.Focus();

            var dap1 = new SqlDataAdapter("SELECT * FROM ChiNhanh", cn);
            var table1 = new DataTable();
            dap1.Fill(table1);
            cbmChiNhanh.DisplayMember = "TenCN";
            cbmChiNhanh.ValueMember = "MaCN";
            cbmChiNhanh.DataSource = table1;
            cbmChiNhanh.SelectedIndex = -1;

            
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbmLoaiNha_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbmLoaiNha.SelectedValue);
            string sql = @"SELECT L.*, N.* 
                            FROM LoaiNha L, Nha N 
                            WHERE N.MaLoaiNha = L.MaLoaiNha AND L.MaLoaiNha = " + id + "";
            var dap = new SqlDataAdapter(sql, cn);
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;
        }

        private void cbmChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            int id = Convert.ToInt32(cbmChiNhanh.SelectedValue);
            var cmd = new SqlCommand("GetEmployeeByIDBranch", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MACN", SqlDbType.Int).Value = id;
            var dap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cn.Close();
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cn.Open();
            var cmd = new SqlCommand("SEARCH_HOUSE_BY_STREET", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@street", SqlDbType.Char).Value = txtTenDuong.Text;
            var dap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cn.Close();
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                var cmd = new SqlCommand("AddEmployee", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IDBranch", SqlDbType.Int).Value = txtMaCN.Text;
                cmd.Parameters.Add("@name", SqlDbType.Char).Value = txtTenNV.Text;
                cmd.Parameters.Add("@add", SqlDbType.Char).Value = txtDiaChi.Text;
                cmd.Parameters.Add("@sdt", SqlDbType.Char).Value = txtSDT.Text;
                cmd.Parameters.Add("@gender", SqlDbType.Bit).Value = txtGioiTinh.Text;
                cmd.Parameters.Add("@DoB", SqlDbType.Date).Value = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@salary", SqlDbType.Float).Value = txtLuong.Text;
                cmd.Parameters.Add("@flag", SqlDbType.Bit).Value = 1;
                cmd.Parameters.Add("@user", SqlDbType.Char).Value = txtUsername.Text;
                cmd.Parameters.Add("@pass", SqlDbType.Char).Value = txtPassword.Text;
                var dap = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                cn.Close();
                var table = new DataTable();
                dap.Fill(table);
                dgvCustomer.DataSource = table;
                MessageBox.Show("Successfully added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }
    }
}
