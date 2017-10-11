namespace RFID_DOOR_APP
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.Username_Field = new System.Windows.Forms.TextBox();
            this.Password_Field = new System.Windows.Forms.TextBox();
            this.Mail_Picture = new System.Windows.Forms.PictureBox();
            this.Key_Picture = new System.Windows.Forms.PictureBox();
            this.Login_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Mail_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_Field
            // 
            this.Username_Field.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username_Field.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Username_Field.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username_Field.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Field.Location = new System.Drawing.Point(243, 273);
            this.Username_Field.Multiline = true;
            this.Username_Field.Name = "Username_Field";
            this.Username_Field.Size = new System.Drawing.Size(195, 26);
            this.Username_Field.TabIndex = 1;
            this.Username_Field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password_Field
            // 
            this.Password_Field.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password_Field.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Password_Field.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_Field.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Field.Location = new System.Drawing.Point(243, 334);
            this.Password_Field.Multiline = true;
            this.Password_Field.Name = "Password_Field";
            this.Password_Field.Size = new System.Drawing.Size(195, 26);
            this.Password_Field.TabIndex = 2;
            this.Password_Field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Mail_Picture
            // 
            this.Mail_Picture.Image = ((System.Drawing.Image)(resources.GetObject("Mail_Picture.Image")));
            this.Mail_Picture.Location = new System.Drawing.Point(64, 179);
            this.Mail_Picture.Name = "Mail_Picture";
            this.Mail_Picture.Size = new System.Drawing.Size(45, 47);
            this.Mail_Picture.TabIndex = 3;
            this.Mail_Picture.TabStop = false;
            // 
            // Key_Picture
            // 
            this.Key_Picture.Image = ((System.Drawing.Image)(resources.GetObject("Key_Picture.Image")));
            this.Key_Picture.Location = new System.Drawing.Point(64, 242);
            this.Key_Picture.Name = "Key_Picture";
            this.Key_Picture.Size = new System.Drawing.Size(45, 47);
            this.Key_Picture.TabIndex = 3;
            this.Key_Picture.TabStop = false;
            // 
            // Login_BTN
            // 
            this.Login_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Login_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Login_BTN.Image")));
            this.Login_BTN.Location = new System.Drawing.Point(345, 386);
            this.Login_BTN.Name = "Login_BTN";
            this.Login_BTN.Size = new System.Drawing.Size(98, 32);
            this.Login_BTN.TabIndex = 0;
            this.Login_BTN.Text = "LOGIN >";
            this.Login_BTN.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(581, 568);
            this.Controls.Add(this.Key_Picture);
            this.Controls.Add(this.Mail_Picture);
            this.Controls.Add(this.Password_Field);
            this.Controls.Add(this.Username_Field);
            this.Controls.Add(this.Login_BTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mail_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Username_Field;
        private System.Windows.Forms.TextBox Password_Field;
        private System.Windows.Forms.PictureBox Mail_Picture;
        private System.Windows.Forms.PictureBox Key_Picture;
        private System.Windows.Forms.Button Login_BTN;
    }
}