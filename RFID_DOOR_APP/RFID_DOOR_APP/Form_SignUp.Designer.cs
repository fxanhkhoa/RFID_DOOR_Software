namespace RFID_DOOR_APP
{
    partial class Form_SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SignUp));
            this.label1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Location_panel = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.PictureBox();
            this.SignUp_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Name = "label1";
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.Gray;
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.UserName, "UserName");
            this.UserName.Name = "UserName";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            this.UserName.Enter += new System.EventHandler(this.UserName_Enter);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Gray;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Password, "Password");
            this.Password.Name = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            this.Password.Validated += new System.EventHandler(this.Password_Validated);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // Location_panel
            // 
            this.Location_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            resources.ApplyResources(this.Location_panel, "Location_panel");
            this.Location_panel.Name = "Location_panel";
            // 
            // Close_Btn
            // 
            resources.ApplyResources(this.Close_Btn, "Close_Btn");
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.TabStop = false;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // SignUp_Btn
            // 
            this.SignUp_Btn.BackColor = System.Drawing.Color.DimGray;
            this.SignUp_Btn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.SignUp_Btn, "SignUp_Btn");
            this.SignUp_Btn.Name = "SignUp_Btn";
            this.SignUp_Btn.UseVisualStyleBackColor = false;
            this.SignUp_Btn.Click += new System.EventHandler(this.SignUp_Btn_Click);
            // 
            // Form_SignUp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.SignUp_Btn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Close_Btn);
            this.Controls.Add(this.Location_panel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SignUp";
            this.Load += new System.EventHandler(this.Form_SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Close_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Location_panel;
        private System.Windows.Forms.PictureBox Close_Btn;
        private System.Windows.Forms.Button SignUp_Btn;
    }
}