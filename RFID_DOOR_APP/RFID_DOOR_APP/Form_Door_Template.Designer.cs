namespace RFID_DOOR_APP
{
    partial class Form_Door_Template
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.Add_Btn = new System.Windows.Forms.PictureBox();
            this.Delete_Btn = new System.Windows.Forms.PictureBox();
            this.list_template = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Depart_Delete_Btn = new System.Windows.Forms.PictureBox();
            this.List_Department = new System.Windows.Forms.ListBox();
            this.Depart_Add_Btn = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Name_Department = new System.Windows.Forms.TextBox();
            this.ID_Department = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depart_Delete_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depart_Add_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOOR TEMPLATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "LOCATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID DOOR";
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(126, 110);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(100, 20);
            this.location.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(126, 63);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 3;
            // 
            // Add_Btn
            // 
            this.Add_Btn.Image = global::RFID_DOOR_APP.Properties.Resources.Add_Icon;
            this.Add_Btn.Location = new System.Drawing.Point(126, 153);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(33, 34);
            this.Add_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add_Btn.TabIndex = 6;
            this.Add_Btn.TabStop = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Image = global::RFID_DOOR_APP.Properties.Resources.garbage_delete;
            this.Delete_Btn.Location = new System.Drawing.Point(696, 66);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(36, 35);
            this.Delete_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Delete_Btn.TabIndex = 8;
            this.Delete_Btn.TabStop = false;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // list_template
            // 
            this.list_template.FormattingEnabled = true;
            this.list_template.Location = new System.Drawing.Point(362, 63);
            this.list_template.Name = "list_template";
            this.list_template.Size = new System.Drawing.Size(328, 121);
            this.list_template.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "List Of Door";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "List Of Department";
            // 
            // Depart_Delete_Btn
            // 
            this.Depart_Delete_Btn.Image = global::RFID_DOOR_APP.Properties.Resources.garbage_delete;
            this.Depart_Delete_Btn.Location = new System.Drawing.Point(696, 253);
            this.Depart_Delete_Btn.Name = "Depart_Delete_Btn";
            this.Depart_Delete_Btn.Size = new System.Drawing.Size(36, 35);
            this.Depart_Delete_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Depart_Delete_Btn.TabIndex = 17;
            this.Depart_Delete_Btn.TabStop = false;
            this.Depart_Delete_Btn.Click += new System.EventHandler(this.Depart_Delete_Btn_Click);
            // 
            // List_Department
            // 
            this.List_Department.FormattingEnabled = true;
            this.List_Department.Location = new System.Drawing.Point(362, 250);
            this.List_Department.Name = "List_Department";
            this.List_Department.Size = new System.Drawing.Size(328, 121);
            this.List_Department.TabIndex = 16;
            // 
            // Depart_Add_Btn
            // 
            this.Depart_Add_Btn.Image = global::RFID_DOOR_APP.Properties.Resources.Add_Icon;
            this.Depart_Add_Btn.Location = new System.Drawing.Point(126, 340);
            this.Depart_Add_Btn.Name = "Depart_Add_Btn";
            this.Depart_Add_Btn.Size = new System.Drawing.Size(33, 34);
            this.Depart_Add_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Depart_Add_Btn.TabIndex = 15;
            this.Depart_Add_Btn.TabStop = false;
            this.Depart_Add_Btn.Click += new System.EventHandler(this.Depart_Add_Btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "NAME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID DEPARTMENT";
            // 
            // Name_Department
            // 
            this.Name_Department.Location = new System.Drawing.Point(126, 297);
            this.Name_Department.Name = "Name_Department";
            this.Name_Department.Size = new System.Drawing.Size(100, 20);
            this.Name_Department.TabIndex = 11;
            // 
            // ID_Department
            // 
            this.ID_Department.Location = new System.Drawing.Point(126, 250);
            this.ID_Department.Name = "ID_Department";
            this.ID_Department.Size = new System.Drawing.Size(100, 20);
            this.ID_Department.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(252, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(314, 26);
            this.label8.TabIndex = 10;
            this.label8.Text = "DEPARTMENT TEMPLATE";
            // 
            // Form_Door_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 433);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Depart_Delete_Btn);
            this.Controls.Add(this.List_Department);
            this.Controls.Add(this.Depart_Add_Btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Name_Department);
            this.Controls.Add(this.ID_Department);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.list_template);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.location);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Door_Template";
            this.Text = "Form_Door_Template";
            this.Load += new System.EventHandler(this.Form_Door_Template_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Add_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depart_Delete_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depart_Add_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.PictureBox Add_Btn;
        private System.Windows.Forms.PictureBox Delete_Btn;
        private System.Windows.Forms.ListBox list_template;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Depart_Delete_Btn;
        private System.Windows.Forms.ListBox List_Department;
        private System.Windows.Forms.PictureBox Depart_Add_Btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Name_Department;
        private System.Windows.Forms.TextBox ID_Department;
        private System.Windows.Forms.Label label8;
    }
}