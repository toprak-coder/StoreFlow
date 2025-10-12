namespace StoreFlow
{
    partial class UrunSil
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
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
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
            nightLabel3.Location = new Point(180, 266);
            nightLabel3.Name = "nightLabel3";
            nightLabel3.Size = new Size(115, 25);
            nightLabel3.TabIndex = 17;
            nightLabel3.Text = "Ürünün ismi";
            // 
            // nightLabel2
            // 
            nightLabel2.AutoSize = true;
            nightLabel2.BackColor = Color.Transparent;
            nightLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nightLabel2.ForeColor = Color.FromArgb(114, 118, 127);
            nightLabel2.Location = new Point(45, 161);
            nightLabel2.Name = "nightLabel2";
            nightLabel2.Size = new Size(250, 25);
            nightLabel2.TabIndex = 15;
            nightLabel2.Text = "Ürünlerin id aralığı yada idsi";
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
            button1.Location = new Point(303, 414);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(120, 40);
            button1.TabIndex = 19;
            button1.Text = "Sil";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(320, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 23);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(320, 266);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 23);
            textBox2.TabIndex = 21;
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel1.ForeColor = Color.FromArgb(76, 88, 100);
            foxLabel1.Location = new Point(180, 218);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(65, 19);
            foxLabel1.TabIndex = 22;
            foxLabel1.Text = "Veya";
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
            nightHeaderLabel1.Size = new Size(118, 40);
            nightHeaderLabel1.TabIndex = 1;
            nightHeaderLabel1.Text = "Ürün Sil";
            nightHeaderLabel1.TextAlign = ContentAlignment.MiddleCenter;
            nightHeaderLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            nightHeaderLabel1.UseCompatibleTextRendering = true;
            // 
            // UrunSil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 48, 32);
            Controls.Add(panel1);
            Controls.Add(foxLabel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(nightLabel3);
            Controls.Add(nightLabel2);
            Name = "UrunSil";
            Size = new Size(741, 528);
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
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private Panel panel1;
        private ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel1;
    }
}
