namespace StoreFlow
{
    partial class LoginForm
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
            UserNameTxtBox = new ReaLTaiizor.Controls.DreamTextBox();
            PasswordTextBox = new ReaLTaiizor.Controls.DreamTextBox();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            LoginButton = new ReaLTaiizor.Controls.DreamButton();
            RegisterButton = new ReaLTaiizor.Controls.DreamButton();
            SuspendLayout();
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.BackColor = Color.FromArgb(41, 41, 41);
            UserNameTxtBox.BorderStyle = BorderStyle.FixedSingle;
            UserNameTxtBox.ColorA = Color.FromArgb(31, 31, 31);
            UserNameTxtBox.ColorB = Color.FromArgb(41, 41, 41);
            UserNameTxtBox.ColorC = Color.FromArgb(51, 51, 51);
            UserNameTxtBox.ColorD = Color.FromArgb(0, 0, 0, 0);
            UserNameTxtBox.ColorE = Color.FromArgb(25, 255, 255, 255);
            UserNameTxtBox.ColorF = Color.Black;
            UserNameTxtBox.ForeColor = Color.FromArgb(40, 218, 255);
            UserNameTxtBox.Location = new Point(163, 63);
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.Size = new Size(166, 23);
            UserNameTxtBox.TabIndex = 0;
            UserNameTxtBox.TextChanged += UserNameTxtBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.FromArgb(41, 41, 41);
            PasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordTextBox.ColorA = Color.FromArgb(31, 31, 31);
            PasswordTextBox.ColorB = Color.FromArgb(41, 41, 41);
            PasswordTextBox.ColorC = Color.FromArgb(51, 51, 51);
            PasswordTextBox.ColorD = Color.FromArgb(0, 0, 0, 0);
            PasswordTextBox.ColorE = Color.FromArgb(25, 255, 255, 255);
            PasswordTextBox.ColorF = Color.Black;
            PasswordTextBox.ForeColor = Color.FromArgb(40, 218, 255);
            PasswordTextBox.Location = new Point(163, 125);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(166, 23);
            PasswordTextBox.TabIndex = 1;
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel1.ForeColor = Color.FromArgb(42, 157, 143);
            foxLabel1.Location = new Point(92, 63);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(65, 19);
            foxLabel1.TabIndex = 2;
            foxLabel1.Text = "Username";
            // 
            // foxLabel2
            // 
            foxLabel2.BackColor = Color.Transparent;
            foxLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel2.ForeColor = Color.FromArgb(42, 157, 143);
            foxLabel2.Location = new Point(92, 125);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(65, 19);
            foxLabel2.TabIndex = 3;
            foxLabel2.Text = "Password";
            // 
            // LoginButton
            // 
            LoginButton.ColorA = Color.FromArgb(31, 31, 31);
            LoginButton.ColorB = Color.FromArgb(41, 41, 41);
            LoginButton.ColorC = Color.FromArgb(51, 51, 51);
            LoginButton.ColorD = Color.FromArgb(0, 0, 0, 0);
            LoginButton.ColorE = Color.FromArgb(25, 255, 255, 255);
            LoginButton.ForeColor = Color.FromArgb(40, 218, 255);
            LoginButton.Location = new Point(263, 187);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(90, 32);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.ColorA = Color.FromArgb(31, 31, 31);
            RegisterButton.ColorB = Color.FromArgb(41, 41, 41);
            RegisterButton.ColorC = Color.FromArgb(51, 51, 51);
            RegisterButton.ColorD = Color.FromArgb(0, 0, 0, 0);
            RegisterButton.ColorE = Color.FromArgb(25, 255, 255, 255);
            RegisterButton.ForeColor = Color.FromArgb(40, 218, 255);
            RegisterButton.Location = new Point(150, 187);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(90, 32);
            RegisterButton.TabIndex = 5;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 33, 61);
            ClientSize = new Size(460, 258);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            Controls.Add(foxLabel2);
            Controls.Add(foxLabel1);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTxtBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DreamTextBox UserNameTxtBox;
        private ReaLTaiizor.Controls.DreamTextBox PasswordTextBox;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.DreamButton LoginButton;
        private ReaLTaiizor.Controls.DreamButton RegisterButton;
    }
}