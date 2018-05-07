namespace RFID_DOOR_APP
{
    partial class Form_Date_Template
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
            this.label4 = new System.Windows.Forms.Label();
            this.Delete_Btn = new System.Windows.Forms.PictureBox();
            this.list_template = new System.Windows.Forms.ListBox();
            this.Add_Btn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(325, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATE TEMPLATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "List Of Current Door";
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Image = global::RFID_DOOR_APP.Properties.Resources.garbage_delete;
            this.Delete_Btn.Location = new System.Drawing.Point(411, 263);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(36, 35);
            this.Delete_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Delete_Btn.TabIndex = 11;
            this.Delete_Btn.TabStop = false;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // list_template
            // 
            this.list_template.FormattingEnabled = true;
            this.list_template.Location = new System.Drawing.Point(411, 75);
            this.list_template.Name = "list_template";
            this.list_template.Size = new System.Drawing.Size(328, 160);
            this.list_template.TabIndex = 10;
            // 
            // Add_Btn
            // 
            this.Add_Btn.Image = global::RFID_DOOR_APP.Properties.Resources.Add_Icon;
            this.Add_Btn.Location = new System.Drawing.Point(141, 201);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(33, 34);
            this.Add_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add_Btn.TabIndex = 17;
            this.Add_Btn.TabStop = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Days of Week";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID";
            // 
            // Days
            // 
            this.Days.Location = new System.Drawing.Point(141, 122);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(138, 20);
            this.Days.TabIndex = 13;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(141, 75);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Example: 2 3 4 5 6 7 1 (1 = Sunday)";
            // 
            // Form_Date_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 433);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.list_template);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Date_Template";
            this.Text = "Form_Date_Template";
            this.Load += new System.EventHandler(this.Form_Date_Template_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Delete_Btn;
        private System.Windows.Forms.ListBox list_template;
        private System.Windows.Forms.PictureBox Add_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Days;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label5;
    }
}