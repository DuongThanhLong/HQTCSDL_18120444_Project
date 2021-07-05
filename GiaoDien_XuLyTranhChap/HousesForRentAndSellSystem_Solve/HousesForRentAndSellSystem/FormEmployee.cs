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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
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

        private void btnMe_Click(object sender, EventArgs e)
        {
            movePanelSide(btnMe);
            //string query = @"SELECT * FROM ChiNhanh";
            //var dap = new SqlDataAdapter(query, cn);
            //var table = new DataTable();
            //dap.Fill(table);
            //dgvCustomer.DataSource = table;
        }

        private void btnAddHD_Click(object sender, EventArgs e)
        {
            movePanelSide(btnAddHD);
            FormEmployee_AddContract frm = new FormEmployee_AddContract();
            frm.ShowDialog();
        }

        private void btnXemTinhTrangNha_Click(object sender, EventArgs e)
        {
            movePanelSide(btnCapNhatTinhTrangNha);
            txtTinhTrang.Text = "";
            txtTinhTrang.Focus();
        }

        private void btnCapNhatGiaNB_Click(object sender, EventArgs e)
        {
            movePanelSide(btnCapNhatGiaNB);
            txtGiaMoi.Text = "";
            txtGiaMoi.Focus();
        }

        private void btnCapNhatYC_Click(object sender, EventArgs e)
        {
            movePanelSide(btnCapNhatYC);
            txtTinhTrangDL.Text = "";
            txtTinhTrangDL.Focus();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM LoaiNha", cn);
            var table = new DataTable();
            dap.Fill(table);
            cbmLoaiNha.DisplayMember = "LoaiNha";
            cbmLoaiNha.ValueMember = "MaLoaiNha";
            cbmLoaiNha.DataSource = table;
            cbmLoaiNha.SelectedIndex = -1;
        }

        private void cbmLoaiNha_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbmLoaiNha.SelectedValue);
            string sql = @"SELECT L.*, NB.*, N.*
                            FROM LoaiNha L, Nha N, NhaBan NB
                            WHERE L.MaLoaiNha = " + id + " AND N.MaLoaiNha = L.MaLoaiNha AND N.MaNha = NB.MaNha";
            var dap = new SqlDataAdapter(sql, cn);
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;

            txtMaNha.DataBindings.Clear();
            txtMaNha.DataBindings.Add("Text", dgvCustomer.DataSource, "MaNha");
            txtGiaMoi.DataBindings.Clear();
            txtGiaMoi.DataBindings.Add("Text", dgvCustomer.DataSource, "GiaBan");

            txtHouseId.DataBindings.Clear();
            txtHouseId.DataBindings.Add("Text", dgvCustomer.DataSource, "MaNha");
            txtTinhTrang.DataBindings.Clear();
            txtTinhTrang.DataBindings.Add("Text", dgvCustomer.DataSource, "TinhTrang");

            txtNha.DataBindings.Clear();
            txtNha.DataBindings.Add("Text", dgvCustomer.DataSource, "MaNha");
            txtTinhTrangDL.DataBindings.Clear();
            txtTinhTrangDL.DataBindings.Add("Text", dgvCustomer.DataSource, "TinhTrang");

            txtStreet.DataBindings.Clear();
            txtStreet.DataBindings.Add("Text", dgvCustomer.DataSource, "TenDuong_Nha");
            txtStatus.DataBindings.Clear();
            txtStatus.DataBindings.Add("Text", dgvCustomer.DataSource, "TinhTrang");

            txtTenDuong.DataBindings.Clear();
            txtTenDuong.DataBindings.Add("Text", dgvCustomer.DataSource, "TenDuong_Nha");
            txtTenDuong.Text = "";
            txtTenDuong.Focus();
        }

        private void btnSavePrice_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                var cmd = new SqlCommand("UPDATE_PRICE_SOLVE", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANHA", SqlDbType.Int).Value = txtMaNha.Text;
                cmd.Parameters.Add("@GIABAN", SqlDbType.Float).Value = txtGiaMoi.Text;
                var dap = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                cn.Close();
                var table = new DataTable();
                dap.Fill(table);
                dgvCustomer.DataSource = table;
                MessageBox.Show("Successfully updated price", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed updated price", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveStatus_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                var cmd = new SqlCommand("UPDATE_STATUS_02_SOLVE", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANHA", SqlDbType.Int).Value = txtMaNha.Text;
                cmd.Parameters.Add("@STATUS", SqlDbType.Char).Value = txtTinhTrang.Text;
                var dap = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                cn.Close();
                var table = new DataTable();
                dap.Fill(table);
                dgvCustomer.DataSource = table;
                MessageBox.Show("Successfully updated status", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed updated status", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhatTinhTrangTheoTenDuong_Click(object sender, EventArgs e)
        {
            movePanelSide(btnCapNhatTinhTrangTheoTenDuong);
            txtStatus.Text = "";
            txtStatus.Focus();
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

        private void btnSaveTinhTrang_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                var cmd = new SqlCommand("UPDATE_STATUS_BY_STREET_SOLVE", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TINHTRANG", SqlDbType.Char).Value = txtStatus.Text;
                cmd.Parameters.Add("@TENDUONG_NHA", SqlDbType.Char).Value = txtStreet.Text;
                var dap = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                cn.Close();
                var table = new DataTable();
                dap.Fill(table);
                dgvCustomer.DataSource = table;
                MessageBox.Show("Successfully updated status", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed updated status", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveStatusDeadlock_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                var cmd = new SqlCommand("UPDATE_STATUS_02_CONVERSION_DL_SOLVE", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANHA", SqlDbType.Int).Value = txtNha.Text;
                cmd.Parameters.Add("@STATUS", SqlDbType.Char).Value = txtTinhTrangDL.Text;
                var dap = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                cn.Close();
                var table = new DataTable();
                dap.Fill(table);
                dgvCustomer.DataSource = table;
                MessageBox.Show("Successfully updated status", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed updated status", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
