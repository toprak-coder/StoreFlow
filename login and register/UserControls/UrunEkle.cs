using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_and_register
{
    public partial class UrunEkle : UserControl
    {
        string query = "INSERT INTO Products (Name,ProductData,Category) VALUES (@Name,@ProductData,@Category)";
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True");
        static SqlCommand scmd;
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void foxTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aloneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string ProductDatas = richTextBox1.Text;
            string CategoryName = comboBox1.SelectedItem.ToString();

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductData", ProductDatas);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Category", CategoryName);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("ürün Başarıyla Eklendi", "ürün Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata: \n" + ex);
            }
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Clear();
                comboBox1.Text = "";

                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Select Category from Products", con))
                    {
                        SqlDataReader readcategory = cmd.ExecuteReader();
                        while (readcategory.Read())
                        {
                            comboBox1.Items.Add(readcategory.GetValue(0).ToString());
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("hata:\n" + ex);
            }
        }
    }
}
