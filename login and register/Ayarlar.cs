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

        private void Ayarlar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string query = "";
            string OldPasswd = textBox2.Text;
            string NewPasswd = textBox3.Text;
            Boolean NameBool = string.IsNullOrEmpty(textBox1.Text); //eğer içi doluysa false döner
            Boolean OldPasswdBool = string.IsNullOrEmpty(textBox2.Text);
            Boolean NewPasswdBool = string.IsNullOrEmpty(textBox3.Text);

            //EĞER AYNI ŞİFRELİ KİŞİLER VARSA BUSSİNES LOGİC HATASI OLUYOR DÜZELT BETA VERSİYONUNDA


            /*eğer bütün kutucuklar boş ise*/
            if (NameBool&&OldPasswdBool&&NewPasswdBool)
            {
                MessageBox.Show("Lütfen boş alanları doldurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!NameBool && OldPasswdBool && NewPasswdBool) //Sadece isim doluysa, ama diğer ikisi boşsa
            {
                // eski şifreyi iste
                MessageBox.Show("lütfen güncel şifrenizi giriniz", "Hata");
            }
            else if (NameBool && !OldPasswdBool && !NewPasswdBool) //İsim boş ama diğer ikisi doluysa
            {
                //şifre değiştir old passwdyi new passswd yap

                //Alt tarafda parametre alırsın ve sorguyu çalıştırırsın
                 query = "update Users set passcode = @NEWPASSWD where passcode = @OLDPASSWD";
            }
            else if (!NameBool && !OldPasswdBool && NewPasswdBool) //İsim dolu, old pass dolu ama new pass boşsa
            {
                //ismi değiştir eski şifreyi where olarak kullan

                 query = "update Users set username = @NAME where passcode = @OLDPASSWD";
            }
            else if (!NameBool && OldPasswdBool && !NewPasswdBool) //İsim dolu, old pass boş ama new pass doluysa
            {
                // message box show yap lütfen şifrenizi ve isminizi değiştirmek için şuanki şifrenizi giriniz
                MessageBox.Show("lütfen şifrenizi ve isminizi değiştirmek için şuanki şifrenizi giriniz", "Hata");
            }
            else if (!NameBool && !OldPasswdBool && !NewPasswdBool) // hepsi doluysa 
            {
                //ismi ve şifreyi değiştir where old passwd
                query = "update Users set username = @NAME, passcode = @NEWPASSWD where passcode = @OLDPASSWD";
            }
            else
            {
                MessageBox.Show("bilinemeyen bir hata oluştu", "hata");
            }


            // sql connectionda şunlar alınacak @NAME, @OLDPASSWD, @NEWPASSWD

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NAME", Name);
                        cmd.Parameters.AddWithValue("@OLDPASSWD", OldPasswd);
                        cmd.Parameters.AddWithValue("@NEWPASSWD", NewPasswd);
                        cmd.ExecuteNonQuery();
                    }
                }
                con.Close();
                MessageBox.Show("Güncelleme başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}
