using ReaLTaiizor.Controls;
using System;
using System.Collections;
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
    public partial class UrunDuzenleWinform : Form
    {
        // UrunDuzenle'den verileri alır ve tanımlar
        public string GelenVeriName { get; set; }
        public int GelenVeriId { get; set; }

        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True");
        static SqlCommand scmd;

        public UrunDuzenleWinform()
        {
            InitializeComponent();
        }

        private void nightLabel1_Click(object sender, EventArgs e)
        {
        }

        private void UrunDuzenleWinform_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();

                    // Kategorileri combobox'a yükle
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT Category FROM Products", con))
                    {
                        SqlDataReader readcategory = cmd.ExecuteReader();
                        comboBox1.Items.Clear();
                        comboBox1.Text = "";
                        while (readcategory.Read())
                        {
                            comboBox1.Items.Add(readcategory.GetValue(0).ToString());
                        }
                        readcategory.Close();
                    }

                    // Eğer ID doluysa ID üzerinden getir
                    if (GelenVeriId > 0)
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT Name, ProductData, Category FROM Products WHERE ProductID = @ForWhere", con))
                        {
                            cmd.Parameters.AddWithValue("@ForWhere", GelenVeriId);
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                textBox1.Text = reader["Name"].ToString();
                                richTextBox1.Text = reader["ProductData"].ToString();
                                comboBox1.Text = reader["Category"].ToString();
                            }
                            reader.Close();
                        }
                    }
                    // Yoksa Name üzerinden getir
                    else if (!string.IsNullOrEmpty(GelenVeriName))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT Name, ProductData, Category FROM Products WHERE Name = @ForWhere", con))
                        {
                            cmd.Parameters.AddWithValue("@ForWhere", GelenVeriName);
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                textBox1.Text = reader["Name"].ToString();
                                richTextBox1.Text = reader["ProductData"].ToString();
                                comboBox1.Text = reader["Category"].ToString();
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata:\n" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string ProductDatas = richTextBox1.Text;
            string CategoryName = comboBox1.Text;

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();

                    string query = "";

                    if (GelenVeriId > 0)
                    {
                        // ID üzerinden güncelle
                        query = @"UPDATE Products 
                          SET Name = @Name, 
                              ProductData = @ProductData, 
                              Category = @Category, 
                              UpdatedDate = GETDATE()
                          WHERE ProductID = @ForWhere";
                    }
                    else if (!string.IsNullOrEmpty(GelenVeriName))
                    {
                        // Name üzerinden güncelle
                        query = @"UPDATE Products 
                          SET Name = @Name, 
                              ProductData = @ProductData, 
                              Category = @Category,                               UpdatedDate = GETDATE()
                          WHERE Name = @ForWhere";
                    }
                    else
                    {
                        MessageBox.Show("Hangi ürünün güncelleneceği belirlenemedi.");
                        return;
                    }

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductData", ProductDatas);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Category", CategoryName);

                        if (GelenVeriId > 0)
                            cmd.Parameters.AddWithValue("@ForWhere", GelenVeriId);
                        else
                            cmd.Parameters.AddWithValue("@ForWhere", GelenVeriName);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Ürün Başarıyla Düzenlendi", "Ürün Düzenlendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata: \n" + ex);
            }
        }

        private void skyButton1_Click(object sender, EventArgs e)
        {
            //CLEAR
            richTextBox1.Text = "";
            textBox1.Text = "";
            comboBox1.Text = "";
        }
    }
}
