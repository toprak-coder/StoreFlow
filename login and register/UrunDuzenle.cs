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
    public partial class UrunDuzenle : UserControl
    {

        public UrunDuzenle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // verileri UrunDuzenleWinform'a gönderir (if else eklenecek)
            UrunDuzenleWinform duzenleWinform = new UrunDuzenleWinform();


            if (string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrEmpty(textBox2.Text))
            {
                //MessageBox.Show("1. textbox boş 2.cisi dolu");
                //id olan textbox için

                duzenleWinform.GelenVeriId = Convert.ToInt16(textBox1.Text);

            }
            else if (!string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                //MessageBox.Show("1. textbox dolu 2.cisi boş");
                // isim olan textbox için 
                duzenleWinform.GelenVeriName = textBox2.Text;
            }
            else
            {
                MessageBox.Show("hata");
            }

            //duzenleWinform.GelenVeriName = textBox1.Text;
            //duzenleWinform.GelenVeriId = Convert.ToInt16(textBox2.Text);
            duzenleWinform.Show();

        }

        private void UrunDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
