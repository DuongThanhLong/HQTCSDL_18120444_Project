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
    public partial class Owner_Signup : Form
    {
        public Owner_Signup()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=MIRINDACOCA;Initial Catalog=QUANLYTHUENHA;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Owner_Signup_Load(object sender, EventArgs e)
        {
            txtOwnerName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cn.Open();
            var cmd = new SqlCommand("SignUp_Owner", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", SqlDbType.Char).Value = txtOwnerName.Text;
            cmd.Parameters.Add("@add", SqlDbType.Char).Value = txtOwnerAddress.Text;
            cmd.Parameters.Add("@phone", SqlDbType.Char).Value = txtOwnerPhone.Text;
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUsername.Text;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text;
            var dap = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
