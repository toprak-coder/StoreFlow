namespace StoreFlow
{
    partial class UrunleriGoruntule
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            foreverButton1 = new ReaLTaiizor.Controls.ForeverButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            nightHeaderLabel1.Size = new Size(192, 40);
            nightHeaderLabel1.TabIndex = 1;
            nightHeaderLabel1.Text = "Ürün Kayıtları";
            nightHeaderLabel1.TextAlign = ContentAlignment.MiddleCenter;
            nightHeaderLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            nightHeaderLabel1.UseCompatibleTextRendering = true;
            nightHeaderLabel1.Click += nightHeaderLabel1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(741, 445);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 33, 61);
            panel1.Controls.Add(foreverButton1);
            panel1.Controls.Add(nightHeaderLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 82);
            panel1.TabIndex = 4;
            // 
            // foreverButton1
            // 
            foreverButton1.BackColor = Color.Transparent;
            foreverButton1.BaseColor = Color.FromArgb(35, 168, 109);
            foreverButton1.Font = new Font("Segoe UI", 12F);
            foreverButton1.Location = new Point(595, 18);
            foreverButton1.Name = "foreverButton1";
            foreverButton1.Rounded = false;
            foreverButton1.Size = new Size(120, 40);
            foreverButton1.TabIndex = 2;
            foreverButton1.Text = "Excel'e Aktar";
            foreverButton1.TextColor = Color.FromArgb(243, 243, 243);
            foreverButton1.Click += foreverButton1_Click;
            // 
            // UrunleriGoruntule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 48, 32);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "UrunleriGoruntule";
            Size = new Size(741, 528);
            Load += UrunleriGoruntule_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private ReaLTaiizor.Controls.ForeverButton foreverButton1;
    }
}
