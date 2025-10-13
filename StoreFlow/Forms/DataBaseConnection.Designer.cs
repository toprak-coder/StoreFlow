namespace StoreFlow.Forms
{
    partial class DataBaseConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseConnection));
            dreamTextBox1 = new ReaLTaiizor.Controls.DreamTextBox();
            metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            lostButton1 = new ReaLTaiizor.Controls.LostButton();
            lostButton2 = new ReaLTaiizor.Controls.LostButton();
            nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            SuspendLayout();
            // 
            // dreamTextBox1
            // 
            dreamTextBox1.BackColor = Color.FromArgb(41, 41, 41);
            dreamTextBox1.BorderStyle = BorderStyle.FixedSingle;
            dreamTextBox1.ColorA = Color.FromArgb(31, 31, 31);
            dreamTextBox1.ColorB = Color.FromArgb(41, 41, 41);
            dreamTextBox1.ColorC = Color.FromArgb(51, 51, 51);
            dreamTextBox1.ColorD = Color.FromArgb(0, 0, 0, 0);
            dreamTextBox1.ColorE = Color.FromArgb(25, 255, 255, 255);
            dreamTextBox1.ColorF = Color.Black;
            dreamTextBox1.ForeColor = Color.FromArgb(40, 218, 255);
            dreamTextBox1.Location = new Point(177, 50);
            dreamTextBox1.Name = "dreamTextBox1";
            dreamTextBox1.Size = new Size(184, 23);
            dreamTextBox1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            metroLabel1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            metroLabel1.IsDerivedStyle = true;
            metroLabel1.Location = new Point(49, 50);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(122, 23);
            metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 1;
            metroLabel1.Text = "Sunucu İsmi:";
            metroLabel1.ThemeAuthor = "Taiizor";
            metroLabel1.ThemeName = "MetroLight";
            // 
            // lostButton1
            // 
            lostButton1.BackColor = Color.FromArgb(45, 45, 48);
            lostButton1.Font = new Font("Segoe UI", 9F);
            lostButton1.ForeColor = Color.White;
            lostButton1.HoverColor = Color.DodgerBlue;
            lostButton1.Image = null;
            lostButton1.Location = new Point(178, 116);
            lostButton1.Name = "lostButton1";
            lostButton1.Size = new Size(104, 33);
            lostButton1.TabIndex = 7;
            lostButton1.Text = "Kaydet";
            lostButton1.Click += lostButton1_Click;
            // 
            // lostButton2
            // 
            lostButton2.BackColor = Color.FromArgb(45, 45, 48);
            lostButton2.Font = new Font("Segoe UI", 9F);
            lostButton2.ForeColor = Color.Orange;
            lostButton2.HoverColor = Color.DodgerBlue;
            lostButton2.Image = null;
            lostButton2.Location = new Point(99, 177);
            lostButton2.Name = "lostButton2";
            lostButton2.Size = new Size(292, 36);
            lostButton2.TabIndex = 8;
            lostButton2.Text = "Bağlantıyı Test Et";
            lostButton2.Click += lostButton2_Click;
            // 
            // nightLabel1
            // 
            nightLabel1.AutoSize = true;
            nightLabel1.BackColor = Color.Transparent;
            nightLabel1.Cursor = Cursors.Hand;
            nightLabel1.Font = new Font("Segoe UI", 9F);
            nightLabel1.ForeColor = Color.FromArgb(114, 118, 127);
            nightLabel1.Location = new Point(12, 261);
            nightLabel1.Name = "nightLabel1";
            nightLabel1.Size = new Size(466, 15);
            nightLabel1.TabIndex = 9;
            nightLabel1.Text = "Eğer Detaylı Sql Bağlantısı Yapmak İstiyorsan Bu Yazıya Tıkla (ileri seviye kullanıcılar için)";
            nightLabel1.Click += nightLabel1_Click;
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
            parrotPictureBox1.Location = new Point(418, 8);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(60, 65);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 10;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotPictureBox1.Click += parrotPictureBox1_Click;
            // 
            // DataBaseConnection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 33, 61);
            ClientSize = new Size(484, 285);
            Controls.Add(parrotPictureBox1);
            Controls.Add(nightLabel1);
            Controls.Add(lostButton2);
            Controls.Add(lostButton1);
            Controls.Add(metroLabel1);
            Controls.Add(dreamTextBox1);
            Name = "DataBaseConnection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataBaseConnection";
            Load += DataBaseConnection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DreamTextBox dreamTextBox1;
        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private ReaLTaiizor.Controls.LostButton lostButton1;
        private ReaLTaiizor.Controls.LostButton lostButton2;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
    }
}