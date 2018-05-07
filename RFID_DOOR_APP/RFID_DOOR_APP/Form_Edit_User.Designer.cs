﻿namespace RFID_DOOR_APP
{
    partial class Form_Edit_User
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
            this.label5 = new System.Windows.Forms.Label();
            this.Read_RFID = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Employee_RFID = new System.Windows.Forms.TextBox();
            this.Employee_Unit = new System.Windows.Forms.TextBox();
            this.Employee_Name = new System.Windows.Forms.TextBox();
            this.Employee_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.List_Usage_ID = new System.Windows.Forms.ComboBox();
            this.Time = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Usage_RFID = new System.Windows.Forms.Label();
            this.Usage_Unit = new System.Windows.Forms.Label();
            this.Usage_Name = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.List_Usage_Door = new System.Windows.Forms.ComboBox();
            this.List_Usage_Time = new System.Windows.Forms.ComboBox();
            this.List_Usage_Day = new System.Windows.Forms.ComboBox();
            this.Add_Employee = new System.Windows.Forms.PictureBox();
            this.Delete_Employee = new System.Windows.Forms.PictureBox();
            this.List_Template = new System.Windows.Forms.ListBox();
            this.Add_Usage = new System.Windows.Forms.PictureBox();
            this.List_Usage = new System.Windows.Forms.ListBox();
            this.Delete_Usage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Usage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Usage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(298, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER EDIT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LED BOARD REVERSED", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(67, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "ADD EMPLOYEE";
            // 
            // Read_RFID
            // 
            this.Read_RFID.Location = new System.Drawing.Point(302, 184);
            this.Read_RFID.Name = "Read_RFID";
            this.Read_RFID.Size = new System.Drawing.Size(75, 23);
            this.Read_RFID.TabIndex = 18;
            this.Read_RFID.Text = "Read RFID";
            this.Read_RFID.UseVisualStyleBackColor = true;
            this.Read_RFID.Click += new System.EventHandler(this.Read_RFID_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "RFID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "ID ";
            // 
            // Employee_RFID
            // 
            this.Employee_RFID.Location = new System.Drawing.Point(71, 184);
            this.Employee_RFID.Name = "Employee_RFID";
            this.Employee_RFID.Size = new System.Drawing.Size(225, 20);
            this.Employee_RFID.TabIndex = 17;
            // 
            // Employee_Unit
            // 
            this.Employee_Unit.Location = new System.Drawing.Point(71, 160);
            this.Employee_Unit.Name = "Employee_Unit";
            this.Employee_Unit.Size = new System.Drawing.Size(225, 20);
            this.Employee_Unit.TabIndex = 16;
            // 
            // Employee_Name
            // 
            this.Employee_Name.Location = new System.Drawing.Point(71, 134);
            this.Employee_Name.Name = "Employee_Name";
            this.Employee_Name.Size = new System.Drawing.Size(225, 20);
            this.Employee_Name.TabIndex = 15;
            // 
            // Employee_ID
            // 
            this.Employee_ID.Location = new System.Drawing.Point(71, 108);
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.Size = new System.Drawing.Size(225, 20);
            this.Employee_ID.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LED BOARD REVERSED", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(456, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 22);
            this.label7.TabIndex = 45;
            this.label7.Text = "ADD USAGE";
            // 
            // List_Usage_ID
            // 
            this.List_Usage_ID.FormattingEnabled = true;
            this.List_Usage_ID.Location = new System.Drawing.Point(475, 103);
            this.List_Usage_ID.Name = "List_Usage_ID";
            this.List_Usage_ID.Size = new System.Drawing.Size(121, 21);
            this.List_Usage_ID.TabIndex = 44;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(737, 133);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(10, 13);
            this.Time.TabIndex = 39;
            this.Time.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(608, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Door";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(608, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Day";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(608, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Time";
            // 
            // Usage_RFID
            // 
            this.Usage_RFID.AutoSize = true;
            this.Usage_RFID.Location = new System.Drawing.Point(501, 186);
            this.Usage_RFID.Name = "Usage_RFID";
            this.Usage_RFID.Size = new System.Drawing.Size(32, 13);
            this.Usage_RFID.TabIndex = 29;
            this.Usage_RFID.Text = "RFID";
            // 
            // Usage_Unit
            // 
            this.Usage_Unit.AutoSize = true;
            this.Usage_Unit.Location = new System.Drawing.Point(501, 164);
            this.Usage_Unit.Name = "Usage_Unit";
            this.Usage_Unit.Size = new System.Drawing.Size(26, 13);
            this.Usage_Unit.TabIndex = 28;
            this.Usage_Unit.Text = "Unit";
            // 
            // Usage_Name
            // 
            this.Usage_Name.AutoSize = true;
            this.Usage_Name.Location = new System.Drawing.Point(501, 141);
            this.Usage_Name.Name = "Usage_Name";
            this.Usage_Name.Size = new System.Drawing.Size(35, 13);
            this.Usage_Name.TabIndex = 27;
            this.Usage_Name.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(438, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "ID ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "RFID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(438, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Unit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(438, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Name";
            // 
            // List_Usage_Door
            // 
            this.List_Usage_Door.FormattingEnabled = true;
            this.List_Usage_Door.Location = new System.Drawing.Point(645, 103);
            this.List_Usage_Door.Name = "List_Usage_Door";
            this.List_Usage_Door.Size = new System.Drawing.Size(121, 21);
            this.List_Usage_Door.TabIndex = 49;
            // 
            // List_Usage_Time
            // 
            this.List_Usage_Time.FormattingEnabled = true;
            this.List_Usage_Time.Location = new System.Drawing.Point(644, 133);
            this.List_Usage_Time.Name = "List_Usage_Time";
            this.List_Usage_Time.Size = new System.Drawing.Size(121, 21);
            this.List_Usage_Time.TabIndex = 50;
            // 
            // List_Usage_Day
            // 
            this.List_Usage_Day.FormattingEnabled = true;
            this.List_Usage_Day.Location = new System.Drawing.Point(644, 160);
            this.List_Usage_Day.Name = "List_Usage_Day";
            this.List_Usage_Day.Size = new System.Drawing.Size(121, 21);
            this.List_Usage_Day.TabIndex = 51;
            // 
            // Add_Employee
            // 
            this.Add_Employee.Image = global::RFID_DOOR_APP.Properties.Resources.Add_Icon;
            this.Add_Employee.Location = new System.Drawing.Point(302, 108);
            this.Add_Employee.Name = "Add_Employee";
            this.Add_Employee.Size = new System.Drawing.Size(33, 34);
            this.Add_Employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add_Employee.TabIndex = 53;
            this.Add_Employee.TabStop = false;
            this.Add_Employee.Click += new System.EventHandler(this.Add_Employee_Click);
            // 
            // Delete_Employee
            // 
            this.Delete_Employee.Image = global::RFID_DOOR_APP.Properties.Resources.garbage_delete;
            this.Delete_Employee.Location = new System.Drawing.Point(302, 233);
            this.Delete_Employee.Name = "Delete_Employee";
            this.Delete_Employee.Size = new System.Drawing.Size(36, 35);
            this.Delete_Employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Delete_Employee.TabIndex = 52;
            this.Delete_Employee.TabStop = false;
            this.Delete_Employee.Click += new System.EventHandler(this.Delete_Employee_Click);
            // 
            // List_Template
            // 
            this.List_Template.FormattingEnabled = true;
            this.List_Template.Location = new System.Drawing.Point(28, 233);
            this.List_Template.Name = "List_Template";
            this.List_Template.Size = new System.Drawing.Size(268, 160);
            this.List_Template.TabIndex = 54;
            // 
            // Add_Usage
            // 
            this.Add_Usage.Image = global::RFID_DOOR_APP.Properties.Resources.Add_Icon;
            this.Add_Usage.Location = new System.Drawing.Point(611, 186);
            this.Add_Usage.Name = "Add_Usage";
            this.Add_Usage.Size = new System.Drawing.Size(33, 34);
            this.Add_Usage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add_Usage.TabIndex = 56;
            this.Add_Usage.TabStop = false;
            this.Add_Usage.Click += new System.EventHandler(this.Add_Usage_Click);
            // 
            // List_Usage
            // 
            this.List_Usage.FormattingEnabled = true;
            this.List_Usage.Location = new System.Drawing.Point(441, 233);
            this.List_Usage.Name = "List_Usage";
            this.List_Usage.Size = new System.Drawing.Size(268, 160);
            this.List_Usage.TabIndex = 57;
            // 
            // Delete_Usage
            // 
            this.Delete_Usage.Image = global::RFID_DOOR_APP.Properties.Resources.garbage_delete;
            this.Delete_Usage.Location = new System.Drawing.Point(715, 233);
            this.Delete_Usage.Name = "Delete_Usage";
            this.Delete_Usage.Size = new System.Drawing.Size(36, 35);
            this.Delete_Usage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Delete_Usage.TabIndex = 58;
            this.Delete_Usage.TabStop = false;
            this.Delete_Usage.Click += new System.EventHandler(this.Delete_Usage_Click);
            // 
            // Form_Edit_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 433);
            this.Controls.Add(this.Delete_Usage);
            this.Controls.Add(this.List_Usage);
            this.Controls.Add(this.Add_Usage);
            this.Controls.Add(this.List_Template);
            this.Controls.Add(this.Add_Employee);
            this.Controls.Add(this.Delete_Employee);
            this.Controls.Add(this.List_Usage_Day);
            this.Controls.Add(this.List_Usage_Time);
            this.Controls.Add(this.List_Usage_Door);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.List_Usage_ID);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Usage_RFID);
            this.Controls.Add(this.Usage_Unit);
            this.Controls.Add(this.Usage_Name);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Read_RFID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Employee_RFID);
            this.Controls.Add(this.Employee_Unit);
            this.Controls.Add(this.Employee_Name);
            this.Controls.Add(this.Employee_ID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Edit_User";
            this.Text = "Form_Edit_User";
            this.Load += new System.EventHandler(this.Form_Edit_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Add_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Usage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Usage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Read_RFID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Employee_RFID;
        private System.Windows.Forms.TextBox Employee_Unit;
        private System.Windows.Forms.TextBox Employee_Name;
        private System.Windows.Forms.TextBox Employee_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox List_Usage_ID;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Usage_RFID;
        private System.Windows.Forms.Label Usage_Unit;
        private System.Windows.Forms.Label Usage_Name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox List_Usage_Door;
        private System.Windows.Forms.ComboBox List_Usage_Time;
        private System.Windows.Forms.ComboBox List_Usage_Day;
        private System.Windows.Forms.PictureBox Add_Employee;
        private System.Windows.Forms.PictureBox Delete_Employee;
        private System.Windows.Forms.ListBox List_Template;
        private System.Windows.Forms.PictureBox Add_Usage;
        private System.Windows.Forms.ListBox List_Usage;
        private System.Windows.Forms.PictureBox Delete_Usage;
    }
}