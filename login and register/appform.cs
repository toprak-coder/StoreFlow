using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using login_and_register.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace login_and_register
{
    public partial class appform : Form
    {
        public UserData UserData { get; set; } // Kullanıcı bilgilerini tutan OOP nesnesi
        public string UserControlName { get; set; } // Dashboard'dan user control alıp yüklemek için

        public appform(UserData userData)
        {
            InitializeComponent();
            UserData = userData;
        }

        private void LoadUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;        // Tam ekran kaplasın
            panel1.Controls.Clear(); // Öncekini sil
            panel1.Controls.Add(uc); // Yeniyi ekle
        }

        private void hopePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void foxButton3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UrunDuzenle());
        }

        private void foxButton4_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UrunleriGoruntule());
        }

        private void foxButton1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UrunEkle());
        }

        private void nightPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void foxButton2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UrunSil());
        }

        private void foxButton7_Click(object sender, EventArgs e)
        {
            var dashboard = new Dashboard(UserData);
            dashboard.MainForm = this;
            LoadUserControl(dashboard);
        }

        private void foxButton6_Click(object sender, EventArgs e)
        {
            var ayarlar = new Ayarlar(UserData);
            LoadUserControl(ayarlar);
        }

        private void foxButton5_Click(object sender, EventArgs e)
        {
            LoadUserControl(new KategoriEkle());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void appform_Load(object sender, EventArgs e)
        {
            labelEdit1.Text = UserData.kullaniciadi; // Kullanıcı adını labelEdit1'e ata
        }
        public void LoadUserControlByName()
        {
            if (string.IsNullOrEmpty(UserControlName))
                return;
            else if (UserControlName == "Ayarlar")
            {
                var ayarlar = new Ayarlar(UserData);
                LoadUserControl(ayarlar);
            }
            else if (UserControlName == "Kategori Ekle-Sil")
            {
                LoadUserControl(new KategoriEkle());
            }
            else if (UserControlName == "Ürün Ekle")
            {
                LoadUserControl(new UrunEkle());
            }
            else if (UserControlName == "Ürün Sil")
            {
                LoadUserControl(new UrunSil());
            }
            else if (UserControlName == "Ürün Düzenle")
            {
                LoadUserControl(new UrunDuzenle());
            }
            else if (UserControlName == "Ürün Detayları")
            {
                LoadUserControl(new UrunleriGoruntule());
            }
            UserControlName = "";
        }

        private void labelEdit1_Click(object sender, EventArgs e)
        {

        }
    }
}
