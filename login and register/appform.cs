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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace login_and_register
{
    public partial class appform : Form
    {

        public appform()
        {
            InitializeComponent();
        }

        public string kullaniciadi { get; set; }  //kullanıcı adını tutacak değişken
        public int kullaniciId { get; set; } // ID için property ekle

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

        }

        private void foxButton6_Click(object sender, EventArgs e)
        {
            var ayarlar = new Ayarlar();
            ayarlar.kullaniciadi = this.kullaniciadi;
            ayarlar.kullaniciId = this.kullaniciId; // ID'yi aktar
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
            labelEdit1.Text = kullaniciadi; // Kullanıcı adını labelEdit1'e ata

        }
    }
}
