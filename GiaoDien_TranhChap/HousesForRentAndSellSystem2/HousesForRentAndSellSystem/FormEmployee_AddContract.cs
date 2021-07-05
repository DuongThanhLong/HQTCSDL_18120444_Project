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
    public partial class FormEmployee_AddContract : Form
    {
        public FormEmployee_AddContract()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=MIRINDACOCA;Initial Catalog=QUANLYTHUENHA;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormEmployee_AddContract_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM HopDongThue", cn);
            var table = new DataTable();
            dap.Fill(table);
            dgvContract.DataSource = table;

            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dgvContract.DataSource, "MaKH");
            txtMaNha.DataBindings.Clear();
            txtMaNha.DataBindings.Add("Text", dgvContract.DataSource, "MaNha");
            //txtNgayBD.DataBindings.Clear();
            //txtNgayBD.DataBindings.Add("Text", dgvContract.DataSource, "NgayBatDau");
            //txtNgayKT.DataBindings.Clear();
            //txtNgayKT.DataBindings.Add("Text", dgvContract.DataSource, "NgayKetThuc");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtMaNha.Text = "";
            //txtNgayBD.Text = "";
            //txtNgayKT.Text = "";
            txtMaKH.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                var cmd = new SqlCommand("ADD_CONTRACT", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANHA", SqlDbType.Int).Value = txtMaNha.Text;
                cmd.Parameters.Add("@MAKH", SqlDbType.Int).Value = txtMaKH.Text;
                cmd.Parameters.Add("@DATEBEGIN", SqlDbType.DateTime).Value = dtpNgayBD.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@DATEEND", SqlDbType.DateTime).Value = dtpNgayKT.Value.ToString("yyyy-MM-dd");
                var dap = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                cn.Close();
                var table = new DataTable();
                dap.Fill(table);
                dgvContract.DataSource = table;
                MessageBox.Show("Successfully added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
