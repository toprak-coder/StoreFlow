namespace login_and_register
{
    partial class KategoriEkle
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
            nightHeaderLabel1 = new ReaLTaiizor.Controls.NightHeaderLabel();
            nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            button1 = new ReaLTaiizor.Controls.Button();
            nightHeaderLabel2 = new ReaLTaiizor.Controls.NightHeaderLabel();
            button2 = new ReaLTaiizor.Controls.Button();
            textBox1 = new TextBox();
            aloneComboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // nightHeaderLabel1
            // 
            nightHeaderLabel1.AutoSize = true;
            nightHeaderLabel1.BackColor = Color.Transparent;
            nightHeaderLabel1.Font = new Font("Microsoft Sans Serif", 22F);
            nightHeaderLabel1.ForeColor = Color.FromArgb(250, 250, 250);
            nightHeaderLabel1.LeftSideForeColor = Color.FromArgb(250, 250, 250);
            nightHeaderLabel1.Location = new Point(261, 21);
            nightHeaderLabel1.Name = "nightHeaderLabel1";
            nightHeaderLabel1.RightSideForeColor = Color.FromArgb(170, 171, 176);
            nightHeaderLabel1.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            nightHeaderLabel1.Size = new Size(190, 40);
            nightHeaderLabel1.TabIndex = 0;
            nightHeaderLabel1.Text = "Kategori Ekle";
            nightHeaderLabel1.TextAlign = ContentAlignment.MiddleCenter;
            nightHeaderLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            nightHeaderLabel1.UseCompatibleTextRendering = true;
            nightHeaderLabel1.Click += nightHeaderLabel1_Click;
            // 
            // nightLabel1
            // 
            nightLabel1.AutoSize = true;
            nightLabel1.BackColor = Color.Transparent;
            nightLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nightLabel1.ForeColor = Color.FromArgb(114, 118, 127);
            nightLabel1.Location = new Point(142, 88);
            nightLabel1.Name = "nightLabel1";
            nightLabel1.Size = new Size(153, 25);
            nightLabel1.TabIndex = 3;
            nightLabel1.Text = "Kategorinin ismi:";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(32, 34, 37);
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(32, 34, 37);
            button1.Location = new Point(301, 426);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(120, 40);
            button1.TabIndex = 4;
            button1.Text = "Kaydet";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
            // 
            // nightHeaderLabel2
            // 
            nightHeaderLabel2.AutoSize = true;
            nightHeaderLabel2.BackColor = Color.Transparent;
            nightHeaderLabel2.Font = new Font("Microsoft Sans Serif", 22F);
            nightHeaderLabel2.ForeColor = Color.FromArgb(250, 250, 250);
            nightHeaderLabel2.LeftSideForeColor = Color.FromArgb(250, 250, 250);
            nightHeaderLabel2.Location = new Point(270, 259);
            nightHeaderLabel2.Name = "nightHeaderLabel2";
            nightHeaderLabel2.RightSideForeColor = Color.FromArgb(170, 171, 176);
            nightHeaderLabel2.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            nightHeaderLabel2.Size = new Size(160, 40);
            nightHeaderLabel2.TabIndex = 5;
            nightHeaderLabel2.Text = "Kategori sil";
            nightHeaderLabel2.TextAlign = ContentAlignment.MiddleCenter;
            nightHeaderLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            nightHeaderLabel2.UseCompatibleTextRendering = true;
            nightHeaderLabel2.Click += nightHeaderLabel2_Click;
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
            button2.Location = new Point(310, 158);
            button2.Name = "button2";
            button2.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button2.PressedColor = Color.FromArgb(165, 37, 37);
            button2.Size = new Size(120, 40);
            button2.TabIndex = 6;
            button2.Text = "Kaydet";
            button2.TextAlignment = StringAlignment.Center;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 8;
            // 
            // aloneComboBox1
            // 
            aloneComboBox1.FormattingEnabled = true;
            aloneComboBox1.Location = new Point(300, 346);
            aloneComboBox1.Name = "aloneComboBox1";
            aloneComboBox1.Size = new Size(121, 23);
            aloneComboBox1.TabIndex = 9;
            // 
            // KategoriEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 48, 32);
            Controls.Add(aloneComboBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(nightHeaderLabel2);
            Controls.Add(button1);
            Controls.Add(nightLabel1);
            Controls.Add(nightHeaderLabel1);
            Name = "KategoriEkle";
            Size = new Size(741, 528);
            Load += KategoriEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel1;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel2;
        private ReaLTaiizor.Controls.Button button2;
        private TextBox textBox1;
        private ComboBox aloneComboBox1;
    }
}
