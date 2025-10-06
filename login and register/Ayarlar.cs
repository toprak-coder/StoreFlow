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

namespace login_and_register
{
    public partial class Ayarlar : UserControl
    {

        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True");
        static SqlCommand scmd;

        public Ayarlar()
        {
            InitializeComponent();
        }

        public string kullaniciadi { get; set; }


        private void Ayarlar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string OldPasswd = textBox2.Text;
            string NewPasswd = textBox3.Text;
            bool NameBool = string.IsNullOrEmpty(Name);
            bool OldPasswdBool = string.IsNullOrEmpty(OldPasswd);
            bool NewPasswdBool = string.IsNullOrEmpty(NewPasswd);

            string query = "";
            bool isValid = true;

            // Tüm kutucuklar boşsa
            if (NameBool && OldPasswdBool && NewPasswdBool)
            {
                MessageBox.Show("Lütfen boş alanları doldurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            // Sadece isim doluysa, diğerleri boşsa
            else if (!NameBool && OldPasswdBool && NewPasswdBool)
            {
                MessageBox.Show("Lütfen güncel şifrenizi giriniz", "Hata");
                isValid = false;
            }
            // Sadece şifre değiştirmek isteniyorsa (isim boş, şifreler dolu)
            else if (NameBool && !OldPasswdBool && !NewPasswdBool)
            {
                query = "update Users set passcode = @NEWPASSWD where _name = @USER and passcode = @OLDPASSWD";
            }
            // Sadece isim değiştirmek isteniyorsa (isim dolu, eski şifre dolu, yeni şifre boş)
            else if (!NameBool && !OldPasswdBool && NewPasswdBool)
            {
                query = "update Users set username = @NAME where _name = @USER and passcode = @OLDPASSWD";
            }
            // Hem isim hem şifre değiştirmek isteniyorsa (hepsi dolu)
            else if (!NameBool && !OldPasswdBool && !NewPasswdBool)
            {
                query = "update Users set username = @NAME, passcode = @NEWPASSWD where _name = @USER and passcode = @OLDPASSWD";
            }
            // Sadece isim ve yeni şifre doluysa, eski şifre yoksa
            else if (!NameBool && OldPasswdBool && !NewPasswdBool)
            {
                MessageBox.Show("Lütfen şifrenizi ve isminizi değiştirmek için şu anki şifrenizi giriniz", "Hata");
                isValid = false;
            }
            else
            {
                MessageBox.Show("Bilinmeyen bir hata oluştu", "Hata");
                isValid = false;
            }

            if (!isValid || string.IsNullOrEmpty(query))
                return;

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NAME", (object)Name ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@OLDPASSWD", (object)OldPasswd ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@NEWPASSWD", (object)NewPasswd ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@USER", kullaniciadi);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Güncelleme başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var YesOrNo = MessageBox.Show("Hesabınız silinecektir, emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("lütfen güncel şifrenizi giriniz", "Hata");
                }
                else if (YesOrNo == DialogResult.Yes)
                {
                    MessageBox.Show("Hesabınız silinmiştir", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (YesOrNo == DialogResult.No)
                {
                    MessageBox.Show("Hesabınız silinmemiştir", "İptal Edildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("bilinemeyen bir hata oluştu", "hata");
                }
                string OldPasswd = textBox3.Text;
                string query = "delete from Users where passcode = @OLDPASSWD";
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@OLDPASSWD", OldPasswd);
                        cmd.ExecuteNonQuery();
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
