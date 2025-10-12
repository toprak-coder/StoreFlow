using Microsoft.Data.SqlClient;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreFlow
{
    public partial class UrunleriGoruntule : UserControl
    {
        // string query = "SELECT Name,Category,ProductData FROM Products where Name=@Name and ProductID=@ProductID and Category=@Category";
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True");
        static SqlCommand scmd;
        public UrunleriGoruntule()
        {
            InitializeComponent();
        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void UrunleriGoruntule_Load(object sender, EventArgs e)
        {

            // Düz kenarlar ve arka plan
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 47);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(50, 50, 70);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Header stili
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 70);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 40;

            // Satır stili
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(225, 225, 235);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Genel ayarlar
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;


            using (SqlConnection con = new SqlConnection(
                @"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;
                  Initial Catalog=ImLazy;
                  Integrated Security=True;
                  Trust Server Certificate=True"))
            {
                string query = "SELECT * FROM Products";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nightHeaderLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
