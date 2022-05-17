namespace SmartTrade
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CaptchaImage = new System.Windows.Forms.PictureBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.CaptchaCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری:";
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.Location = new System.Drawing.Point(12, 17);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(180, 23);
            this.Username.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Location = new System.Drawing.Point(12, 50);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(180, 23);
            this.Password.TabIndex = 2;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 53);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "رمز عبور:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 87);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "کد امنیتی:";
            // 
            // CaptchaImage
            // 
            this.CaptchaImage.BackColor = System.Drawing.SystemColors.Window;
            this.CaptchaImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CaptchaImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CaptchaImage.Location = new System.Drawing.Point(12, 114);
            this.CaptchaImage.Name = "CaptchaImage";
            this.CaptchaImage.Size = new System.Drawing.Size(180, 48);
            this.CaptchaImage.TabIndex = 6;
            this.CaptchaImage.TabStop = false;
            this.CaptchaImage.Click += new System.EventHandler(this.CaptchaImage_Click);
            // 
            // SignIn
            // 
            this.SignIn.Location = new System.Drawing.Point(12, 199);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(247, 48);
            this.SignIn.TabIndex = 4;
            this.SignIn.Text = "ورود";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // CaptchaCode
            // 
            this.CaptchaCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CaptchaCode.Location = new System.Drawing.Point(12, 85);
            this.CaptchaCode.Name = "CaptchaCode";
            this.CaptchaCode.Size = new System.Drawing.Size(180, 23);
            this.CaptchaCode.TabIndex = 3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 333);
            this.Controls.Add(this.CaptchaCode);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.CaptchaImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Shown += new System.EventHandler(this.Login_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Username;
        private TextBox Password;
        private Label label2;
        private Label label3;
        private PictureBox CaptchaImage;
        private Button SignIn;
        private TextBox CaptchaCode;
    }
}