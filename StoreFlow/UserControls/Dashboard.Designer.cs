namespace StoreFlow
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            foxBigLabel1 = new ReaLTaiizor.Controls.FoxBigLabel();
            foxBigLabel2 = new ReaLTaiizor.Controls.FoxBigLabel();
            nightButton1 = new ReaLTaiizor.Controls.NightButton();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            nightButton2 = new ReaLTaiizor.Controls.NightButton();
            nightButton3 = new ReaLTaiizor.Controls.NightButton();
            nightButton4 = new ReaLTaiizor.Controls.NightButton();
            nightButton5 = new ReaLTaiizor.Controls.NightButton();
            nightButton6 = new ReaLTaiizor.Controls.NightButton();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            parrotPictureBox2 = new ReaLTaiizor.Controls.ParrotPictureBox();
            SuspendLayout();
            // 
            // foxBigLabel1
            // 
            foxBigLabel1.BackColor = Color.Transparent;
            foxBigLabel1.Font = new Font("Segoe UI Semibold", 20F);
            foxBigLabel1.ForeColor = Color.FromArgb(76, 88, 100);
            foxBigLabel1.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            foxBigLabel1.LineColor = Color.FromArgb(200, 200, 200);
            foxBigLabel1.Location = new Point(22, 13);
            foxBigLabel1.Name = "foxBigLabel1";
            foxBigLabel1.Size = new Size(240, 41);
            foxBigLabel1.TabIndex = 1;
            foxBigLabel1.Text = "Hoş Geldin $Name";
            // 
            // foxBigLabel2
            // 
            foxBigLabel2.BackColor = Color.Transparent;
            foxBigLabel2.Font = new Font("Segoe UI Semibold", 20F);
            foxBigLabel2.ForeColor = Color.FromArgb(76, 88, 100);
            foxBigLabel2.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            foxBigLabel2.LineColor = Color.FromArgb(200, 200, 200);
            foxBigLabel2.Location = new Point(505, 13);
            foxBigLabel2.Name = "foxBigLabel2";
            foxBigLabel2.Size = new Size(151, 41);
            foxBigLabel2.TabIndex = 2;
            foxBigLabel2.Text = "Saat $Time";
            foxBigLabel2.Click += foxBigLabel2_Click;
            // 
            // nightButton1
            // 
            nightButton1.BackColor = Color.Transparent;
            nightButton1.DialogResult = DialogResult.None;
            nightButton1.Font = new Font("Segoe UI", 10F);
            nightButton1.ForeColor = Color.FromArgb(242, 93, 89);
            nightButton1.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            nightButton1.HoverForeColor = Color.White;
            nightButton1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightButton1.Location = new Point(552, 179);
            nightButton1.MinimumSize = new Size(144, 47);
            nightButton1.Name = "nightButton1";
            nightButton1.NormalBackColor = Color.FromArgb(242, 93, 89);
            nightButton1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightButton1.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            nightButton1.PressedForeColor = Color.White;
            nightButton1.Radius = 20;
            nightButton1.Size = new Size(144, 47);
            nightButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton1.TabIndex = 6;
            nightButton1.Text = "Ürün Ekle";
            nightButton1.Click += nightButton1_Click;
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            skyLabel1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            skyLabel1.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel1.Location = new Point(197, 109);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(357, 25);
            skyLabel1.TabIndex = 12;
            skyLabel1.Text = "Yapabileceğiniz Bazı İşlemler";
            // 
            // nightButton2
            // 
            nightButton2.BackColor = Color.Transparent;
            nightButton2.DialogResult = DialogResult.None;
            nightButton2.Font = new Font("Segoe UI", 10F);
            nightButton2.ForeColor = Color.FromArgb(242, 93, 89);
            nightButton2.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            nightButton2.HoverForeColor = Color.White;
            nightButton2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightButton2.Location = new Point(324, 179);
            nightButton2.MinimumSize = new Size(144, 47);
            nightButton2.Name = "nightButton2";
            nightButton2.NormalBackColor = Color.FromArgb(242, 93, 89);
            nightButton2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightButton2.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            nightButton2.PressedForeColor = Color.White;
            nightButton2.Radius = 20;
            nightButton2.Size = new Size(144, 47);
            nightButton2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton2.TabIndex = 13;
            nightButton2.Text = "Kategori Ekle-Sil";
            nightButton2.Click += nightButton2_Click;
            // 
            // nightButton3
            // 
            nightButton3.BackColor = Color.Transparent;
            nightButton3.DialogResult = DialogResult.None;
            nightButton3.Font = new Font("Segoe UI", 10F);
            nightButton3.ForeColor = Color.FromArgb(242, 93, 89);
            nightButton3.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            nightButton3.HoverForeColor = Color.White;
            nightButton3.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightButton3.Location = new Point(70, 179);
            nightButton3.MinimumSize = new Size(144, 47);
            nightButton3.Name = "nightButton3";
            nightButton3.NormalBackColor = Color.FromArgb(242, 93, 89);
            nightButton3.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightButton3.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            nightButton3.PressedForeColor = Color.White;
            nightButton3.Radius = 20;
            nightButton3.Size = new Size(144, 47);
            nightButton3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton3.TabIndex = 14;
            nightButton3.Text = "Ayarları Görüntüle";
            nightButton3.Click += nightButton3_Click;
            // 
            // nightButton4
            // 
            nightButton4.BackColor = Color.Transparent;
            nightButton4.DialogResult = DialogResult.None;
            nightButton4.Font = new Font("Segoe UI", 10F);
            nightButton4.ForeColor = Color.FromArgb(242, 93, 89);
            nightButton4.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            nightButton4.HoverForeColor = Color.White;
            nightButton4.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightButton4.Location = new Point(70, 306);
            nightButton4.MinimumSize = new Size(144, 47);
            nightButton4.Name = "nightButton4";
            nightButton4.NormalBackColor = Color.FromArgb(242, 93, 89);
            nightButton4.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightButton4.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            nightButton4.PressedForeColor = Color.White;
            nightButton4.Radius = 20;
            nightButton4.Size = new Size(144, 47);
            nightButton4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton4.TabIndex = 15;
            nightButton4.Text = "Ürün Sil";
            nightButton4.Click += nightButton4_Click;
            // 
            // nightButton5
            // 
            nightButton5.BackColor = Color.Transparent;
            nightButton5.DialogResult = DialogResult.None;
            nightButton5.Font = new Font("Segoe UI", 10F);
            nightButton5.ForeColor = Color.FromArgb(242, 93, 89);
            nightButton5.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            nightButton5.HoverForeColor = Color.White;
            nightButton5.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightButton5.Location = new Point(324, 306);
            nightButton5.MinimumSize = new Size(144, 47);
            nightButton5.Name = "nightButton5";
            nightButton5.NormalBackColor = Color.FromArgb(242, 93, 89);
            nightButton5.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightButton5.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            nightButton5.PressedForeColor = Color.White;
            nightButton5.Radius = 20;
            nightButton5.Size = new Size(144, 47);
            nightButton5.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton5.TabIndex = 16;
            nightButton5.Text = "Ürün Düzenle";
            nightButton5.Click += nightButton5_Click;
            // 
            // nightButton6
            // 
            nightButton6.BackColor = Color.Transparent;
            nightButton6.DialogResult = DialogResult.None;
            nightButton6.Font = new Font("Segoe UI", 10F);
            nightButton6.ForeColor = Color.FromArgb(242, 93, 89);
            nightButton6.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            nightButton6.HoverForeColor = Color.White;
            nightButton6.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightButton6.Location = new Point(559, 306);
            nightButton6.MinimumSize = new Size(144, 47);
            nightButton6.Name = "nightButton6";
            nightButton6.NormalBackColor = Color.FromArgb(242, 93, 89);
            nightButton6.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightButton6.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            nightButton6.PressedForeColor = Color.White;
            nightButton6.Radius = 20;
            nightButton6.Size = new Size(144, 47);
            nightButton6.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton6.TabIndex = 17;
            nightButton6.Text = "Ürün Detaylarını Görüntüle";
            nightButton6.Click += nightButton6_Click;
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.BackgroundImage = (Image)resources.GetObject("parrotPictureBox1.BackgroundImage");
            parrotPictureBox1.ColorLeft = Color.DodgerBlue;
            parrotPictureBox1.ColorRight = Color.DodgerBlue;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.Cursor = Cursors.Hand;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = true;
            parrotPictureBox1.Image = null;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = false;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(292, 459);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(54, 54);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 21;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotPictureBox1.Click += parrotPictureBox1_Click;
            // 
            // parrotPictureBox2
            // 
            parrotPictureBox2.BackgroundImage = (Image)resources.GetObject("parrotPictureBox2.BackgroundImage");
            parrotPictureBox2.ColorLeft = Color.DodgerBlue;
            parrotPictureBox2.ColorRight = Color.DodgerBlue;
            parrotPictureBox2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox2.Cursor = Cursors.Hand;
            parrotPictureBox2.FilterAlpha = 200;
            parrotPictureBox2.FilterEnabled = true;
            parrotPictureBox2.Image = null;
            parrotPictureBox2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox2.IsElipse = false;
            parrotPictureBox2.IsParallax = false;
            parrotPictureBox2.Location = new Point(367, 459);
            parrotPictureBox2.Name = "parrotPictureBox2";
            parrotPictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox2.Size = new Size(54, 54);
            parrotPictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox2.TabIndex = 22;
            parrotPictureBox2.Text = "parrotPictureBox2";
            parrotPictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotPictureBox2.Click += parrotPictureBox2_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 48, 32);
            Controls.Add(parrotPictureBox2);
            Controls.Add(parrotPictureBox1);
            Controls.Add(nightButton6);
            Controls.Add(nightButton5);
            Controls.Add(nightButton4);
            Controls.Add(nightButton3);
            Controls.Add(nightButton2);
            Controls.Add(skyLabel1);
            Controls.Add(nightButton1);
            Controls.Add(foxBigLabel2);
            Controls.Add(foxBigLabel1);
            Name = "Dashboard";
            Size = new Size(741, 528);
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel1;
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel2;
        private ReaLTaiizor.Controls.NightButton nightButton1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.NightButton nightButton2;
        private ReaLTaiizor.Controls.NightButton nightButton3;
        private ReaLTaiizor.Controls.NightButton nightButton4;
        private ReaLTaiizor.Controls.NightButton nightButton5;
        private ReaLTaiizor.Controls.NightButton nightButton6;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox2;
    }
}
