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

namespace StoreFlow
{
    public partial class Ayarlar : UserControl
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True");
        static SqlCommand scmd;

        private UserData _userData;

        public Ayarlar(UserData userData)
        {
            InitializeComponent();
            _userData = userData;
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            // Gerekirse burada _userData'dan kullanıcı bilgisi alınabilir
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

            if (NameBool && OldPasswdBool && NewPasswdBool)
            {
                MessageBox.Show("Lütfen boş alanları doldurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            else if (!NameBool && OldPasswdBool && NewPasswdBool)
            {
                MessageBox.Show("Lütfen güncel şifrenizi giriniz", "Hata");
                isValid = false;
            }
            else if (NameBool && !OldPasswdBool && !NewPasswdBool)
            {
                query = "update Users set passcode = @NEWPASSWD where Id = @ID and passcode = @OLDPASSWD";
            }
            else if (!NameBool && !OldPasswdBool && NewPasswdBool)
            {
                query = "update Users set username = @NAME where Id = @ID and passcode = @OLDPASSWD";
                _userData.kullaniciadi = textBox2.Text; // kullanıcı adını güncelle
            }
            else if (!NameBool && !OldPasswdBool && !NewPasswdBool)
            {
                query = "update Users set username = @NAME, passcode = @NEWPASSWD where Id = @ID and passcode = @OLDPASSWD";
                _userData.kullaniciadi = textBox2.Text; // kullanıcı adını güncelle
            }
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
                int affectedRows = 0;
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NAME", (object)Name ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@OLDPASSWD", (object)OldPasswd ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@NEWPASSWD", (object)NewPasswd ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@USER", _userData.kullaniciadi);
                        cmd.Parameters.AddWithValue("@ID", _userData.kullaniciId); // Parametre ekle
                        affectedRows = cmd.ExecuteNonQuery();
                    }
                }
                if (affectedRows > 0)
                {
                    MessageBox.Show("Güncelleme başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız: Şifreniz yanlış veya kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Lütfen güncel şifrenizi giriniz", "Hata");
                    return;
                }
                if (YesOrNo == DialogResult.Yes)
                {
                    string OldPasswd = textBox2.Text;
                    string query = "delete from Users where Id = @ID and passcode = @OLDPASSWD"; // Silme sorgusunda
                    int affectedRows = 0;
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@USER", _userData.kullaniciadi);
                            cmd.Parameters.AddWithValue("@OLDPASSWD", OldPasswd);
                            cmd.Parameters.AddWithValue("@ID", _userData.kullaniciId); // Parametre ekle
                            affectedRows = cmd.ExecuteNonQuery();
                        }
                    }
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Hesabınız silinmiştir", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (this.ParentForm != null)
                            this.ParentForm.Close();
                    }
                    else
                    {
                        MessageBox.Show("Şifre yanlış veya kullanıcı bulunamadı, silme işlemi başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (YesOrNo == DialogResult.No)
                {
                    MessageBox.Show("Hesabınız silinmemiştir", "İptal Edildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Bilinmeyen bir hata oluştu", "Hata");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
