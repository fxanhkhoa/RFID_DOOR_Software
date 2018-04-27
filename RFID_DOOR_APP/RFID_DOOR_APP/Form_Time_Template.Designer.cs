namespace RFID_DOOR_APP
{
    partial class Form_Time_Template
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
            this.Start_Time = new System.Windows.Forms.DateTimePicker();
            this.End_Time = new System.Windows.Forms.DateTimePicker();
            this.list_template = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_Btn = new System.Windows.Forms.PictureBox();
            this.Delete_Btn = new System.Windows.Forms.PictureBox();
            this.ID_Template = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(332, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Template";
            // 
            // Start_Time
            // 
            this.Start_Time.CustomFormat = "HH:mm";
            this.Start_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Start_Time.Location = new System.Drawing.Point(50, 90);
            this.Start_Time.Name = "Start_Time";
            this.Start_Time.Size = new System.Drawing.Size(251, 20);
            this.Start_Time.TabIndex = 1;
            // 
            // End_Time
            // 
            this.End_Time.CustomFormat = "HH:mm";
            this.End_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.End_Time.Location = new System.Drawing.Point(336, 90);
            this.End_Time.Name = "End_Time";
            this.End_Time.Size = new System.Drawing.Size(251, 20);
            this.End_Time.TabIndex = 1;
            // 
            // list_template
            // 
            this.list_template.FormattingEnabled = true;
            this.list_template.Location = new System.Drawing.Point(50, 178);
            this.list_template.Name = "list_template";
            this.list_template.Size = new System.Drawing.Size(219, 160);
            this.list_template.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "----";
            // 
            // Add_Btn
            // 
            this.Add_Btn.Image = global::RFID_DOOR_APP.Properties.Resources.Add_Icon;
            this.Add_Btn.Location = new System.Drawing.Point(209, 116);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(33, 34);
            this.Add_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add_Btn.TabIndex = 5;
            this.Add_Btn.TabStop = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Image = global::RFID_DOOR_APP.Properties.Resources.garbage_delete;
            this.Delete_Btn.Location = new System.Drawing.Point(291, 178);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(36, 35);
            this.Delete_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Delete_Btn.TabIndex = 3;
            this.Delete_Btn.TabStop = false;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // ID_Template
            // 
            this.ID_Template.Location = new System.Drawing.Point(103, 130);
            this.ID_Template.Name = "ID_Template";
            this.ID_Template.Size = new System.Drawing.Size(100, 20);
            this.ID_Template.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // Form_Time_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 433);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID_Template);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.list_template);
            this.Controls.Add(this.End_Time);
            this.Controls.Add(this.Start_Time);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Time_Template";
            this.Text = "Form_Time_Template";
            this.Load += new System.EventHandler(this.Form_Time_Template_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Add_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Start_Time;
        private System.Windows.Forms.DateTimePicker End_Time;
        private System.Windows.Forms.ListBox list_template;
        private System.Windows.Forms.PictureBox Delete_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Add_Btn;
        private System.Windows.Forms.TextBox ID_Template;
        private System.Windows.Forms.Label label3;
    }
}