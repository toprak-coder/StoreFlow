using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_and_register
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (!authenticate())
            {
                MessageBox.Show("Alanları boş bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Users (username, passcode, _name, gender, dob) VALUES (@USER,@PASS,@NAME,@GENDER,@DOB)";

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;TrustServerCertificate=True;
"))
                {
                    con.Open();
                    using (SqlCommand scmd = new SqlCommand(query, con))
                    {
                        scmd.Parameters.AddWithValue("@USER", UserNameTxtBox.Text);
                        scmd.Parameters.AddWithValue("@PASS", PasswordTextBox.Text);
                        scmd.Parameters.AddWithValue("@NAME", FullNameTextBox.Text);
                        scmd.Parameters.AddWithValue("@GENDER", GenderComboBox.Text);
                        scmd.Parameters.AddWithValue("@DOB", BirthdayDateTime.Value);

                        scmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Hesabınız kaydedildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }



        bool authenticate()
        {// alanlara boş yada space ilemi doldurulmuş diye bakar eğer boş veya doldurulmamış alanlar varsa false döner yoksa true döner
            if (string.IsNullOrWhiteSpace(UserNameTxtBox.Text) || (string.IsNullOrWhiteSpace(FullNameTextBox.Text) || (string.IsNullOrWhiteSpace(PasswordTextBox.Text)))) return false;
            else return true;
        }
    }
}
