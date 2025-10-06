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
    public partial class KategoriEkle : UserControl
    {
        string query = "INSERT INTO Products (Category,Name) VALUES (@Category,@Name)";
        string DeleteQuery = "DELETE FROM Products where Category = @Category";
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True");
        static SqlCommand scmd;

        public KategoriEkle()
        {
            InitializeComponent();
        }


        private void nightHeaderLabel1_Click(object sender, EventArgs e)
        {

        }

        private void foxTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nightHeaderLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string KategoriIsmı = textBox1.Text;
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Category", KategoriIsmı);
                        cmd.Parameters.AddWithValue("@Name", "");
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kategori Başarıyla Eklendi", "Kategori Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("Select Category from Products", con))
                        {
                            SqlDataReader readcategory = cmd.ExecuteReader();
                            while (readcategory.Read())
                            {
                                aloneComboBox1.Items.Add(readcategory.GetValue(0).ToString());
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
            catch (Exception ex)
            {

                MessageBox.Show("Hata: \n" + ex);
            }
        }

        private void foxTextBox1_Enter(object sender, EventArgs e)
        {
            //foxTextBox1.Text = "";
        }

        private void KategoriEkle_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Select Category from Products", con))
                    {
                        SqlDataReader readcategory = cmd.ExecuteReader();
                        aloneComboBox1.Items.Clear();
                        aloneComboBox1.Text = "";
                        while (readcategory.Read())
                        {
                            aloneComboBox1.Items.Add(readcategory.GetValue(0).ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string KategoriIsmı2 =  aloneComboBox1.SelectedItem.ToString();
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(DeleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Category", KategoriIsmı2);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kategori Başarıyla silindi", "Kategori silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("Select Category from Products", con))
                        {
                            SqlDataReader readcategory = cmd.ExecuteReader();
                            aloneComboBox1.Items.Clear();
                            aloneComboBox1.Text = "";
                            while (readcategory.Read())
                            {
                                aloneComboBox1.Items.Add(readcategory.GetValue(0).ToString());
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
            catch (Exception ex)
            {
                MessageBox.Show("hata: \n" + ex);
                con.Close();
            }
        }

        private void aloneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
