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
    public partial class FormCustomer_Me : Form
    {
        public FormCustomer_Me()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=MIRINDACOCA;Initial Catalog=QUANLYTHUENHA;Integrated Security=True");


        private void FormCustomer_Me_Load(object sender, EventArgs e)
        {
            cn.Open();
            var cmd = new SqlCommand("GetCustomerInf", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = Global.loginname;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = Global.password;
            var dap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cn.Close();
            var table = new DataTable();
            dap.Fill(table);
            dgvCustomerMe.DataSource = table;

            Global.idCus = dgvCustomerMe.Rows[0].Cells[0].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
