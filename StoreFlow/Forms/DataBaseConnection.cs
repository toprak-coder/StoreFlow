using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreFlow.Forms
{
    public partial class DataBaseConnection : Form
    {
        public DataBaseConnection()
        {
            InitializeComponent();
        }

        private void DataBaseConnection_Load(object sender, EventArgs e)
        {

        }

        private void nightLabel1_Click(object sender, EventArgs e)
        {
            DatabaseConnectionDetailed DbConnectionDetailed = new DatabaseConnectionDetailed();
            DbConnectionDetailed.ShowDialog();
        }

        string DbServerName;
        string connectionString;

        private void lostButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DbServerName = dreamTextBox1.Text;
                connectionString = $"Data Source={DbServerName};Initial Catalog=master;Integrated Security=True;Trust Server Certificate=True";
                MessageBox.Show("Kaydedildi", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: \n" + ex, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lostButton2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open(); // 🔹 Bağlantı açmayı dener
                    MessageBox.Show("✅ Bağlantı başarılı!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Bağlantı hatası: " + ex.Message);
                }
            }
        }

        private void parrotPictureBox1_Click(object sender, EventArgs e)
        {
            OpenLink("https://github.com/toprak-coder/StoreFlow/");
        }

        private void OpenLink(string url)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // tarayıcıda açmak için şart
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Link açılamadı: " + ex.Message);
            }
        }
    }
}
