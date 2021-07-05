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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=MIRINDACOCA;Initial Catalog=QUANLYTHUENHA;Integrated Security=True");


        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void movePanelSide(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            movePanelSide(btnHome);
            cn.Open();
            var cmd = new SqlCommand("SEE_ALL_CONTRACT_SOLVE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAKH", SqlDbType.Int).Value = Convert.ToInt32(Global.idCus);
            var dap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cn.Close();
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM LoaiNha", cn);
            var table = new DataTable();
            dap.Fill(table);
            cbmLoaiNha.DisplayMember = "LoaiNha";
            cbmLoaiNha.ValueMember = "MaLoaiNha";
            cbmLoaiNha.DataSource = table;
            cbmLoaiNha.SelectedIndex = -1;

            txtMaNha.DataBindings.Clear();
            txtMaNha.DataBindings.Add("Text", dgvCustomer.DataSource, "MaNha");

            var dap1 = new SqlDataAdapter("SELECT * FROM ChiNhanh", cn);
            var table1 = new DataTable();
            dap1.Fill(table1);
            comboChiNhanh.DisplayMember = "TenCN";
            comboChiNhanh.ValueMember = "MaCN";
            comboChiNhanh.DataSource = table1;
            comboChiNhanh.SelectedIndex = -1;
        }

        private void btnMe_Click(object sender, EventArgs e)
        {
            movePanelSide(btnMe);
            FormCustomer_Me frm = new FormCustomer_Me();
            frm.ShowDialog();
        }

        private void btnXemTinhTrangNha_Click(object sender, EventArgs e)
        {
            movePanelSide(btnXemTinhTrangNha);
        }

        private void btnXemGiaNB_Click(object sender, EventArgs e)
        {
            movePanelSide(btnXemGiaNB);
           
            cn.Open();
            var cmd = new SqlCommand("CHECK_PRICE_SOLVE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MANHA", SqlDbType.Int).Value = txtMaNha.Text;
            var dap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cn.Close();
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;
        }

        private void btnCapNhatYC_Click(object sender, EventArgs e)
        {
            movePanelSide(btnCapNhatYC);
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

            txtTenDuong.DataBindings.Clear();
            txtTenDuong.DataBindings.Add("Text", dgvCustomer.DataSource, "TenDuong_Nha");
            txtTenDuong.Text = "";
            txtTenDuong.Focus();

            txtStreet.DataBindings.Clear();
            txtStreet.DataBindings.Add("Text", dgvCustomer.DataSource, "TenDuong_Nha");
            txtStatus.DataBindings.Clear();
            txtStatus.DataBindings.Add("Text", dgvCustomer.DataSource, "TinhTrang");
            txtStreet.Text = "";
            txtStatus.Text = "";
            txtStreet.Focus();

            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dgvCustomer.DataSource, "GiaBan");
            txtGia.Text = "";
            txtGia.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            cn.Open();
            var cmd = new SqlCommand("FIND_HOUSE_BY_STREET_SOLVE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TENDUONG_NHA", SqlDbType.Char).Value = txtStreet.Text;
            cmd.Parameters.Add("@TINHTRANG", SqlDbType.Char).Value = txtStatus.Text;
            var dap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cn.Close();
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;
        }

        private void txtTenDuong_TextChanged(object sender, EventArgs e)
        {

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

        private void comboChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            int id = Convert.ToInt32(comboChiNhanh.SelectedValue);
            var cmd = new SqlCommand("GetEmployeeByIDBranch_Solve", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MACN", SqlDbType.Int).Value = id;
            var dap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cn.Close();
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;
        }

        private void btnXemDSNhaBan_Click(object sender, EventArgs e)
        {
            movePanelSide(btnXemDSNhaBan);
            cn.Open();
            var cmd = new SqlCommand("SEE_HOUSE_FOR_SELL_SOLVE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            var dap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cn.Close();
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;
        }

        private void btnCapNhatYC_Click_1(object sender, EventArgs e)
        {
            movePanelSide(btnCapNhatYC);
            cn.Open();
            var cmd = new SqlCommand("SEE_CONTRACT_SOLVE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAHOPDONG", SqlDbType.Int).Value = txtMHD.Text;
            cmd.Parameters.Add("@MANHA", SqlDbType.Int).Value = txtNha.Text;
            cmd.Parameters.Add("@MAKH", SqlDbType.Int).Value = Convert.ToInt32(Global.idCus);
            var dap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cn.Close();
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;
        }

        private void btnSearchByPrice_Click(object sender, EventArgs e)
        {
            cn.Open();
            var cmd = new SqlCommand("FIND_HOUSE_WITH_PRICE_SOLVE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PRICE", SqlDbType.Float).Value = txtGia.Text;
            var dap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cn.Close();
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;
        }

        private void btnYeuCauKH_Click(object sender, EventArgs e)
        {
            movePanelSide(btnYeuCauKH);
            FormCustomer_Requirement cus = new FormCustomer_Requirement();
            cus.ShowDialog();
        }
    }
}
