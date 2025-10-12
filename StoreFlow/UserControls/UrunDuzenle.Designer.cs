namespace StoreFlow
{
    partial class UrunDuzenle
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
            nightLabel3 = new ReaLTaiizor.Controls.NightLabel();
            nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            button1 = new ReaLTaiizor.Controls.Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            panel1 = new Panel();
            nightHeaderLabel1 = new ReaLTaiizor.Controls.NightHeaderLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nightLabel3
            // 
            nightLabel3.AutoSize = true;
            nightLabel3.BackColor = Color.Transparent;
            nightLabel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nightLabel3.ForeColor = Color.FromArgb(114, 118, 127);
            nightLabel3.Location = new Point(110, 227);
            nightLabel3.Name = "nightLabel3";
            nightLabel3.Size = new Size(236, 25);
            nightLabel3.TabIndex = 17;
            nightLabel3.Text = "düzenlenecek Ürünün ismi";
            // 
            // nightLabel2
            // 
            nightLabel2.AutoSize = true;
            nightLabel2.BackColor = Color.Transparent;
            nightLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nightLabel2.ForeColor = Color.FromArgb(114, 118, 127);
            nightLabel2.Location = new Point(110, 112);
            nightLabel2.Name = "nightLabel2";
            nightLabel2.Size = new Size(233, 25);
            nightLabel2.TabIndex = 15;
            nightLabel2.Text = "düzenlenecek ürünün id'si";
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
            button1.Location = new Point(298, 377);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(120, 40);
            button1.TabIndex = 18;
            button1.Text = "Düzenle";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(381, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 20;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(381, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 23);
            textBox2.TabIndex = 21;
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            skyLabel1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            skyLabel1.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel1.Location = new Point(193, 174);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(63, 23);
            skyLabel1.TabIndex = 22;
            skyLabel1.Text = "Veya";
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
            nightHeaderLabel1.Size = new Size(195, 40);
            nightHeaderLabel1.TabIndex = 1;
            nightHeaderLabel1.Text = "Ürün Düzenle";
            nightHeaderLabel1.TextAlign = ContentAlignment.MiddleCenter;
            nightHeaderLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            nightHeaderLabel1.UseCompatibleTextRendering = true;
            // 
            // UrunDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 48, 32);
            Controls.Add(panel1);
            Controls.Add(skyLabel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(nightLabel3);
            Controls.Add(nightLabel2);
            Name = "UrunDuzenle";
            Size = new Size(741, 528);
            Load += UrunDuzenle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.NightLabel nightLabel3;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
        private ReaLTaiizor.Controls.Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private Panel panel1;
        private ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel1;
    }
}
