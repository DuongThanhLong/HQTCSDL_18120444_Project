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
    public partial class FormOwner : Form
    {
        public FormOwner()
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
            FormOwner_Me frm = new FormOwner_Me();
            frm.ShowDialog();
        }

        private void btnCapNhatTinhTrangNha_Click(object sender, EventArgs e)
        {
            movePanelSide(btnCapNhatTinhTrangNha);
            cn.Open();
            var cmd = new SqlCommand("VIEW_RENTAL_HOUSE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MACN", SqlDbType.Int).Value = Global.idCus;
            var dap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cn.Close();
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;
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
        }

        private void FormOwner_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM LoaiNha", cn);
            var table = new DataTable();
            dap.Fill(table);
            cbmLoaiNha.DisplayMember = "LoaiNha";
            cbmLoaiNha.ValueMember = "MaLoaiNha";
            cbmLoaiNha.DataSource = table;
            cbmLoaiNha.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            var cmd = new SqlCommand("ViewRentals", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MACN", SqlDbType.Int).Value = Global.idCus;
            cmd.Parameters.Add("@MANHA", SqlDbType.Int).Value = txtNha.Text;
            var dap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cn.Close();
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomer.DataSource = table;
        }
    }
}
