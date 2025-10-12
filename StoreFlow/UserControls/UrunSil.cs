using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StoreFlow
{
    public partial class UrunSil : UserControl
    {
        
        private string connectionString = @"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;TrustServerCertificate=True";
        string DeleteQuery = "DELETE FROM Products where Name = @ProductName";
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True");
        static SqlCommand scmd;

        public UrunSil()
        {
            InitializeComponent();
        }



        private List<int> Ayrıştırıcı(string inputText)
        {
            List<int> idListesi = new List<int>();
            inputText = inputText.Trim();

            if (string.IsNullOrEmpty(inputText)) return idListesi;

            try
            {
                
                if (inputText.Contains("-"))
                {
                    string[] parcalar = inputText.Split('-');
                    if (parcalar.Length == 2 && int.TryParse(parcalar[0].Trim(), out int baslangic) && int.TryParse(parcalar[1].Trim(), out int bitis) && baslangic <= bitis)
                    {
                        for (int i = baslangic; i <= bitis; i++)
                        {
                            idListesi.Add(i);
                        }
                    }
                }
               
                else if (inputText.Contains(","))
                {
                    string[] parcalar = inputText.Split(',');
                    foreach (string parca in parcalar)
                    {
                        if (int.TryParse(parca.Trim(), out int id))
                        {
                            idListesi.Add(id);
                        }
                    }
                }
               
                else
                {
                    if (int.TryParse(inputText, out int id))
                    {
                        idListesi.Add(id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID'ler ayrıştırılırken bir hata oluştu: " + ex.Message);
                return new List<int>(); 
            }

            
            return idListesi.Distinct().ToList();
        }


        public void KayıtlarıSil(List<int> silinecekIdler)
        {
            if (silinecekIdler == null || silinecekIdler.Count == 0)
            {
                MessageBox.Show("Silinecek geçerli bir ID bulunamadı. Lütfen '12', '12-16' veya '12,13,14' formatında bir ID girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var parametreler = new string[silinecekIdler.Count];
            for (int i = 0; i < silinecekIdler.Count; i++)
            {
                parametreler[i] = $"@p{i}";
            }

            string sqlSorgusu = $"DELETE FROM Products WHERE ProductID IN ({string.Join(", ", parametreler)})";

            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlSorgusu, con))
                    {
                        
                        for (int i = 0; i < silinecekIdler.Count; i++)
                        {
                            cmd.Parameters.AddWithValue(parametreler[i], silinecekIdler[i]);
                        }

                        int etkilenenSatir = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{etkilenenSatir} adet kayıt başarıyla silindi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string kullaniciGirdisi = textBox1.Text;

                if (string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrEmpty(textBox2.Text))
                {
                    //MessageBox.Show("1. textbox boş 2.cisi dolu");
                    //isim olan textbox için
                    string UrunIsmı = textBox2.Text;

                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHN04NV\SQLEXPRESS;Initial Catalog=ImLazy;Integrated Security=True;Trust Server Certificate=True"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(DeleteQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@ProductName", UrunIsmı);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("ürün Başarıyla silindi", "ürün silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                else if (!string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                {
                    //MessageBox.Show("1. textbox dolu 2.cisi boş");
                    // id olan textbox için 

                    List<int> silinecekIdListesi = Ayrıştırıcı(kullaniciGirdisi);
                    KayıtlarıSil(silinecekIdListesi);
                }
                else
                {
                    MessageBox.Show("hata");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: \n" + ex);
            }

            
            
        }
    }
}