using System;
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
    public partial class Dashboard : UserControl
    {
        public appform MainForm { get; set; } // appform referansı
        public string kullaniciadi { get; set; } //kullanıcı adı 

        public Dashboard()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            foxBigLabel1.Text = "Hoşgeldin, " + kullaniciadi;
            using (Graphics g = foxBigLabel1.CreateGraphics())
            {
                // Yazının boyutunu ölç
                SizeF textSize = g.MeasureString(foxBigLabel1.Text, foxBigLabel1.Font);

                // Label genişliğini ayarla
                foxBigLabel1.Width = (int)textSize.Width + 10; // +10 px boşluk
            }
        }

        private void nightButton3_Click(object sender, EventArgs e)
        {
            //ayarlar 
            if (MainForm != null)
            {
                MainForm.UserControlName = "Ayarlar";
                MainForm.LoadUserControlByName();
            }
        }

        private void nightButton2_Click(object sender, EventArgs e)
        {
            //kategori ekle sil
            if (MainForm != null)
            {
                MainForm.UserControlName = "Kategori Ekle-Sil";
                MainForm.LoadUserControlByName();
            }
        }

        private void nightButton1_Click(object sender, EventArgs e)
        {
            //ürün ekle
            if (MainForm != null)
            {
                MainForm.UserControlName = "Ürün Ekle";
                MainForm.LoadUserControlByName();
            }
        }

        private void nightButton4_Click(object sender, EventArgs e)
        {
            //ürün sil
            if (MainForm != null)
            {
                MainForm.UserControlName = "Ürün Sil";
                MainForm.LoadUserControlByName();
            }
        }

        private void nightButton5_Click(object sender, EventArgs e)
        {
            //ürün düzenle
            if (MainForm != null)
            {
                MainForm.UserControlName = "Ürün Düzenle";
                MainForm.LoadUserControlByName();
            }
        }

        private void nightButton6_Click(object sender, EventArgs e)
        {
            //ürün detayları
            if (MainForm != null)
            {
                MainForm.UserControlName = "Ürün Detayları";
                MainForm.LoadUserControlByName();
            }
        }
    }
}
