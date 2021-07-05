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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=LONGCA;Initial Catalog=QUANLYTHUEBANNHA_N15;Integrated Security=True");


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
                if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
                {
                    FormAdmin ad = new FormAdmin();
                    ad.ShowDialog();
                }
                else
                {
                    var userEmp = new List<string>();
                    var passEmp = new List<string>();
                    cn.Open();
                    using (SqlCommand sql1 = new SqlCommand("SELECT [username] FROM [dbo].[NhanVien]", cn))
                    {
                        using (var reader = sql1.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                    userEmp.Add(reader[0].ToString());
                            }
                        }
                    }

                    using (SqlCommand sql2 = new SqlCommand("SELECT [password] FROM [dbo].[NhanVien]", cn))
                    {
                        using (var reader = sql2.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                    passEmp.Add(reader[0].ToString());
                            }
                        }
                    }
                    bool flag = false;
                    foreach (string user in userEmp)
                    {
                        foreach (string pass in passEmp)
                        {
                            if (txtPassword.Text == pass && txtUsername.Text == user)
                            {
                                Global.loginname = txtUsername.Text;
                                Global.password = txtPassword.Text;
                                FormEmployee emp = new FormEmployee();
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
                        MessageBox.Show("User and Password is invalid", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                    cn.Close();
                }
            }         
        }
    }
}

