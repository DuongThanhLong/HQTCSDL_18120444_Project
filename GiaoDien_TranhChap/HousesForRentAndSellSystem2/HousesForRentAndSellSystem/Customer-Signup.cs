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
    public partial class Customer_Signup : Form
    {
        public Customer_Signup()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=MIRINDACOCA;Initial Catalog=QUANLYTHUENHA;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                cn.Open();
                int id = Convert.ToInt32(cbmNVQL.SelectedValue);
                var cmd = new SqlCommand("SignUp_Customer", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@name", SqlDbType.Char).Value = txtCustomerName.Text;
                cmd.Parameters.Add("@phone", SqlDbType.Char).Value = txtCustomerPhone.Text;
                cmd.Parameters.Add("@add", SqlDbType.Char).Value = txtCustomerAddress.Text;
                cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUsername.Text;
                cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text;
                cmd.Parameters.Add("@nvql", SqlDbType.Int).Value = id;
                var dap = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Successfully sign-up", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed sign-up", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbmNVQL_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbmNVQL.SelectedValue);
            string sql = @"SELECT * FROM NhanVien";
            var dap = new SqlDataAdapter(sql, cn);
            //var table = new DataTable();
            //dap.Fill(table);
            //dgvCustomer.DataSource = table;
        }

        private void Customer_Signup_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM NhanVien", cn);
            var table = new DataTable();
            dap.Fill(table);
            cbmNVQL.DisplayMember = "TenNV";
            cbmNVQL.ValueMember = "MaNV";
            cbmNVQL.DataSource = table;
            cbmNVQL.SelectedIndex = -1;
        }
    }
}
