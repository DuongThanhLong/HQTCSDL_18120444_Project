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
    public partial class FormLogin1 : Form
    {
        public FormLogin1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=MIRINDACOCA;Initial Catalog=QUANLYTHUENHA;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool isFormValid()
        {
            if (txtUsername.Text.ToString().Trim() == string.Empty || txtPassword.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Required fields must not empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                var userOwner = new List<string>();
                var passOwner = new List<string>();
                cn.Open();
                using (SqlCommand sql1 = new SqlCommand("SELECT [username] FROM [dbo].[ChuNha]", cn))
                {
                    using (var reader = sql1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                                userOwner.Add(reader[0].ToString());
                        }
                    }
                }

                using (SqlCommand sql2 = new SqlCommand("SELECT [password] FROM [dbo].[ChuNha]", cn))
                {
                    using (var reader = sql2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                                passOwner.Add(reader[0].ToString());
                        }
                    }
                }

                var userCus = new List<string>();
                var passCus = new List<string>();
                //cn.Open();
                using (SqlCommand sql1 = new SqlCommand("SELECT [username] FROM [dbo].[KhachHang]", cn))
                {
                    using (var reader = sql1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                                userCus.Add(reader[0].ToString());
                        }
                    }
                }

                using (SqlCommand sql2 = new SqlCommand("SELECT [password] FROM [dbo].[KhachHang]", cn))
                {
                    using (var reader = sql2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                                passCus.Add(reader[0].ToString());
                        }
                    }
                }

                bool flag = false;
                foreach (string user in userOwner)
                {
                    foreach (string pass in passOwner)
                    {
                        if (txtPassword.Text == pass && txtUsername.Text == user)
                        {
                            Global.loginname = txtUsername.Text;
                            Global.password = txtPassword.Text;
                            FormOwner emp = new FormOwner();
                            emp.ShowDialog();
                            flag = true;
                        }

                        if (flag == true)
                        {
                            break;
                        }
                    }
                }
                if (flag == false)
                {                   
                    //bool flag = false;
                    foreach (string user in userCus)
                    {
                        foreach (string pass in passCus)
                        {
                            if (txtPassword.Text == pass && txtUsername.Text == user)
                            {
                                Global.loginname = txtUsername.Text;
                                Global.password = txtPassword.Text;
                                FormCustomer emp = new FormCustomer();
                                emp.ShowDialog();
                                flag = true;
                            }

                            if (flag == true)
                            {
                                break;
                            }
                        }
                    }
                }
                if (flag == false)
                    MessageBox.Show("User and Password is invalid", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Global.loginname = txtUsername.Text;
                Global.password = txtPassword.Text;
                cn.Close();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer_Signup cus = new Customer_Signup();
            cus.ShowDialog();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            Owner_Signup owner = new Owner_Signup();
            owner.ShowDialog();
        }
    }
}
