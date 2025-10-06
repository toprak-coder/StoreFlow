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
            string OldPasswd = textBox2.Text;
            string NewPasswd = textBox3.Text;
            Boolean NameBool = string.IsNullOrEmpty(textBox1.Text); //eğer içi doluysa false döner
            Boolean OldPasswdBool = string.IsNullOrEmpty(textBox2.Text);
            Boolean NewPasswdBool = string.IsNullOrEmpty(textBox3.Text);

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
            }
            else if (!NameBool && !OldPasswdBool && NewPasswdBool) //İsim dolu, old pass dolu ama new pass boşsa
            {
                //ismi değiştir eski şifreyi where olarak kullan
            }
            else if (!NameBool && OldPasswdBool && !NewPasswdBool) //İsim dolu, old pass boş ama new pass doluysa
            {
                // message box show yap lütfen şifrenizi ve isminizi değiştirmek için şuanki şifrenizi giriniz
                MessageBox.Show("lütfen şifrenizi ve isminizi değiştirmek için şuanki şifrenizi giriniz", "Hata");
            }
            else if (!NameBool && !OldPasswdBool && !NewPasswdBool) // hepsi doluysa 
            {
                //ismi ve şifreyi değiştir where old passwd
            }
            else
            {
                MessageBox.Show("bilinemeyen bir hata oluştu", "hata");
            }
        }
    }
}
