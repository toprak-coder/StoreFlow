using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreFlow.Models;
using StoreFlow.Forms;

namespace StoreFlow
{
    public partial class LoginForm : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True");
        static SqlCommand scmd;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!authenticate())
            {
                MessageBox.Show("alanları boş bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isUserOk = false, ispassok = false;

            // Kullanıcı var mı kontrol
            string query = "SELECT * FROM Users WHERE username=@USER";
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                using (SqlCommand scmd = new SqlCommand(query, con))
                {
                    scmd.Parameters.Add("@USER", SqlDbType.VarChar).Value = UserNameTxtBox.Text;

                    using (SqlDataReader sda = scmd.ExecuteReader())
                    {
                        if (sda.HasRows)
                            isUserOk = true;
                    }
                }

                // Şifre doğru mu kontrol
                query = "SELECT * FROM Users WHERE username=@USER AND passcode=@PASS";
                using (SqlCommand scmd = new SqlCommand(query, con))
                {
                    scmd.Parameters.Add("@USER", SqlDbType.VarChar).Value = UserNameTxtBox.Text;
                    scmd.Parameters.Add("@PASS", SqlDbType.VarChar).Value = PasswordTextBox.Text;

                    using (SqlDataReader sda = scmd.ExecuteReader())
                    {
                        if (sda.HasRows)
                            ispassok = true;
                    }
                }
            }

            if (!isUserOk)
            {
                MessageBox.Show("kullanıcı kayıtlı değil");
            }
            else if (isUserOk && !ispassok)
            {
                MessageBox.Show("şifreniz hatalı");
            }
            else if (isUserOk && ispassok)
            {
                // Login işlemi başarılıysa:
                int userId = 0;
                string query2 = "SELECT Id FROM Users WHERE username=@USER";
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();
                    using (SqlCommand scmd = new SqlCommand(query2, con))
                    {
                        scmd.Parameters.Add("@USER", SqlDbType.VarChar).Value = UserNameTxtBox.Text;
                        using (SqlDataReader sda = scmd.ExecuteReader())
                        {
                            if (sda.Read())
                                userId = sda.GetInt32(0);
                        }
                    }
                }
                Hide();
                var userData = new UserData { kullaniciadi = UserNameTxtBox.Text, kullaniciId = userId };
                appform app = new appform(userData);
                app.ShowDialog();
                Close();
            }
        }

        bool authenticate()
        {// alanlara boş yada space ilemi doldurulmuş diye bakar eğer boş veya doldurulmamış alanlar varsa false döner yoksa true döner
            if (string.IsNullOrWhiteSpace(UserNameTxtBox.Text) || (string.IsNullOrWhiteSpace(PasswordTextBox.Text))) return false;
            else return true;
        }

        private void UserNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dreamButton1_Click(object sender, EventArgs e)
        {
            DataBaseConnection DbTestBaglanti = new DataBaseConnection();
            DbTestBaglanti.ShowDialog();
        }
    }
}
