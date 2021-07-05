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
    public partial class FormCustomer_Requirement : Form
    {
        public FormCustomer_Requirement()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=MIRINDACOCA;Initial Catalog=QUANLYTHUENHA;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormCustomer_Requirement_Load(object sender, EventArgs e)
        {
            int cusid = Convert.ToInt32(Global.idCus);
            string sql = @"SELECT KH.*, YC.*
                           FROM KhachHang KH, YeuCauKhachHang YC
                           WHERE KH.MaKH = YC.MaKH AND KH.MaKH = " + cusid + "";
            var dap = new SqlDataAdapter(sql, cn);
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomerRequirement.DataSource = table;
        }

        private void btnSavePrice_Click(object sender, EventArgs e)
        {
            cn.Open();
            var cmd = new SqlCommand("CYCLE_DL_02", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAKH", SqlDbType.Int).Value = Convert.ToInt32(Global.idCus);
            cmd.Parameters.Add("@MAPHIEU", SqlDbType.Int).Value = txtMaPhieu.Text;
            cmd.Parameters.Add("@DIACHI", SqlDbType.Char).Value = txtDiaChi.Text;
            cmd.Parameters.Add("@TIEUCHI", SqlDbType.Char).Value = txtTieuChi.Text;
            var dap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cn.Close();
            FormCustomer_Requirement_Load(sender, e);
        }
    }
}
