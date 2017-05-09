namespace Uilayer
{
    partial class SIGNIN
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
            this.usernameTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.USERNAME = new MetroFramework.Controls.MetroLabel();
            this.PASSWORD = new MetroFramework.Controls.MetroLabel();
            this.CANCEL = new MetroFramework.Controls.MetroButton();
            this.LOGIN = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextBox1
            // 
            this.usernameTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.usernameTextBox1.CustomButton.Image = null;
            this.usernameTextBox1.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.usernameTextBox1.CustomButton.Name = "";
            this.usernameTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usernameTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameTextBox1.CustomButton.TabIndex = 1;
            this.usernameTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameTextBox1.CustomButton.UseSelectable = true;
            this.usernameTextBox1.CustomButton.Visible = false;
            this.usernameTextBox1.Lines = new string[0];
            this.usernameTextBox1.Location = new System.Drawing.Point(261, 199);
            this.usernameTextBox1.MaxLength = 32767;
            this.usernameTextBox1.Name = "usernameTextBox1";
            this.usernameTextBox1.PasswordChar = '\0';
            this.usernameTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameTextBox1.SelectedText = "";
            this.usernameTextBox1.SelectionLength = 0;
            this.usernameTextBox1.SelectionStart = 0;
            this.usernameTextBox1.Size = new System.Drawing.Size(152, 23);
            this.usernameTextBox1.TabIndex = 5;
            this.usernameTextBox1.UseSelectable = true;
            this.usernameTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.usernameTextBox1.Click += new System.EventHandler(this.usernameTextBox1_Click);
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.passwordTextBox2.CustomButton.Image = null;
            this.passwordTextBox2.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.passwordTextBox2.CustomButton.Name = "";
            this.passwordTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox2.CustomButton.TabIndex = 1;
            this.passwordTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox2.CustomButton.UseSelectable = true;
            this.passwordTextBox2.CustomButton.Visible = false;
            this.passwordTextBox2.Lines = new string[0];
            this.passwordTextBox2.Location = new System.Drawing.Point(261, 253);
            this.passwordTextBox2.MaxLength = 32767;
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '\0';
            this.passwordTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox2.SelectedText = "";
            this.passwordTextBox2.SelectionLength = 0;
            this.passwordTextBox2.SelectionStart = 0;
            this.passwordTextBox2.Size = new System.Drawing.Size(152, 23);
            this.passwordTextBox2.TabIndex = 6;
            this.passwordTextBox2.UseSelectable = true;
            this.passwordTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // USERNAME
            // 
            this.USERNAME.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.USERNAME.AutoSize = true;
            this.USERNAME.Location = new System.Drawing.Point(113, 199);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(78, 19);
            this.USERNAME.TabIndex = 7;
            this.USERNAME.Text = "USERNAME";
            // 
            // PASSWORD
            // 
            this.PASSWORD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PASSWORD.AutoSize = true;
            this.PASSWORD.Location = new System.Drawing.Point(113, 257);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(79, 19);
            this.PASSWORD.TabIndex = 8;
            this.PASSWORD.Text = "PASSWORD";
            // 
            // CANCEL
            // 
            this.CANCEL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CANCEL.Location = new System.Drawing.Point(183, 332);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(75, 23);
            this.CANCEL.TabIndex = 9;
            this.CANCEL.Text = "cancel";
            this.CANCEL.UseSelectable = true;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click_1);
            // 
            // LOGIN
            // 
            this.LOGIN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LOGIN.Location = new System.Drawing.Point(324, 332);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(75, 23);
            this.LOGIN.TabIndex = 10;
            this.LOGIN.Text = "login";
            this.LOGIN.UseSelectable = true;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Uilayer.Properties.Resources.plainicon_com_39365_256px;
            this.pictureBox1.Location = new System.Drawing.Point(183, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SIGNIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 394);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.usernameTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "SIGNIN";
            this.Text = "SIGN IN";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox usernameTextBox1;
        private MetroFramework.Controls.MetroTextBox passwordTextBox2;
        private MetroFramework.Controls.MetroLabel USERNAME;
        private MetroFramework.Controls.MetroLabel PASSWORD;
        private MetroFramework.Controls.MetroButton CANCEL;
        private MetroFramework.Controls.MetroButton LOGIN;
        private System.Windows.Forms.PictureBox pictureBox1;


    }
}

