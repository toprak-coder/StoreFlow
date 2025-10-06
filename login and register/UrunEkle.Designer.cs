namespace login_and_register
{
    partial class UrunEkle
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new ReaLTaiizor.Controls.Button();
            nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            nightLabel3 = new ReaLTaiizor.Controls.NightLabel();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            nightHeaderLabel1 = new ReaLTaiizor.Controls.NightHeaderLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BorderColor = Color.FromArgb(32, 34, 37);
            button2.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button2.EnteredColor = Color.FromArgb(32, 34, 37);
            button2.Font = new Font("Microsoft Sans Serif", 12F);
            button2.Image = null;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.InactiveColor = Color.FromArgb(32, 34, 37);
            button2.Location = new Point(303, 441);
            button2.Name = "button2";
            button2.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button2.PressedColor = Color.FromArgb(165, 37, 37);
            button2.Size = new Size(120, 40);
            button2.TabIndex = 9;
            button2.Text = "Kaydet";
            button2.TextAlignment = StringAlignment.Center;
            button2.Click += button2_Click;
            // 
            // nightLabel1
            // 
            nightLabel1.AutoSize = true;
            nightLabel1.BackColor = Color.Transparent;
            nightLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nightLabel1.ForeColor = Color.FromArgb(114, 118, 127);
            nightLabel1.Location = new Point(144, 114);
            nightLabel1.Name = "nightLabel1";
            nightLabel1.Size = new Size(119, 25);
            nightLabel1.TabIndex = 8;
            nightLabel1.Text = "Ürünün ismi:";
            // 
            // nightLabel2
            // 
            nightLabel2.AutoSize = true;
            nightLabel2.BackColor = Color.Transparent;
            nightLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nightLabel2.ForeColor = Color.FromArgb(114, 118, 127);
            nightLabel2.Location = new Point(105, 223);
            nightLabel2.Name = "nightLabel2";
            nightLabel2.Size = new Size(158, 25);
            nightLabel2.TabIndex = 11;
            nightLabel2.Text = "Ürünün detayları:";
            // 
            // nightLabel3
            // 
            nightLabel3.AutoSize = true;
            nightLabel3.BackColor = Color.Transparent;
            nightLabel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nightLabel3.ForeColor = Color.FromArgb(114, 118, 127);
            nightLabel3.Location = new Point(96, 360);
            nightLabel3.Name = "nightLabel3";
            nightLabel3.Size = new Size(167, 25);
            nightLabel3.TabIndex = 13;
            nightLabel3.Text = "Ürünün kategorisi:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(269, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 23);
            textBox1.TabIndex = 14;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(269, 194);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(259, 115);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(269, 365);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(259, 23);
            comboBox1.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 33, 61);
            panel1.Controls.Add(nightHeaderLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 82);
            panel1.TabIndex = 30;
            // 
            // nightHeaderLabel1
            // 
            nightHeaderLabel1.AutoSize = true;
            nightHeaderLabel1.BackColor = Color.Transparent;
            nightHeaderLabel1.Font = new Font("Microsoft Sans Serif", 22F);
            nightHeaderLabel1.ForeColor = Color.FromArgb(250, 250, 250);
            nightHeaderLabel1.LeftSideForeColor = Color.FromArgb(250, 250, 250);
            nightHeaderLabel1.Location = new Point(15, 18);
            nightHeaderLabel1.Name = "nightHeaderLabel1";
            nightHeaderLabel1.RightSideForeColor = Color.FromArgb(170, 171, 176);
            nightHeaderLabel1.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            nightHeaderLabel1.Size = new Size(143, 40);
            nightHeaderLabel1.TabIndex = 1;
            nightHeaderLabel1.Text = "Ürün Ekle";
            nightHeaderLabel1.TextAlign = ContentAlignment.MiddleCenter;
            nightHeaderLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            nightHeaderLabel1.UseCompatibleTextRendering = true;
            // 
            // UrunEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 48, 32);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(nightLabel3);
            Controls.Add(nightLabel2);
            Controls.Add(button2);
            Controls.Add(nightLabel1);
            Name = "UrunEkle";
            Size = new Size(741, 528);
            Load += UrunEkle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.Button button2;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
        private ReaLTaiizor.Controls.NightLabel nightLabel3;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private Panel panel1;
        private ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel1;
    }
}
