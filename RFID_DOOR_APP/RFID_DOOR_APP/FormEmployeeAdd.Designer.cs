namespace RFID_DOOR_APP
{
    partial class FormEmployeeAdd
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
            this.Add = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Time_Use_From = new System.Windows.Forms.ComboBox();
            this.Time = new System.Windows.Forms.Label();
            this.DATE_USE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Time_Use_To = new System.Windows.Forms.ComboBox();
            this.Door = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.Add_Employ = new System.Windows.Forms.Button();
            this.Add_Door = new System.Windows.Forms.Button();
            this.RFID = new System.Windows.Forms.Label();
            this.Unit = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_List = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(95, 235);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(176, 235);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Time_Use_From
            // 
            this.Time_Use_From.FormattingEnabled = true;
            this.Time_Use_From.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "23:59"});
            this.Time_Use_From.Location = new System.Drawing.Point(95, 162);
            this.Time_Use_From.Name = "Time_Use_From";
            this.Time_Use_From.Size = new System.Drawing.Size(86, 21);
            this.Time_Use_From.TabIndex = 4;
            this.Time_Use_From.SelectedIndexChanged += new System.EventHandler(this.Time_Use_SelectedIndexChanged);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(187, 165);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(10, 13);
            this.Time.TabIndex = 5;
            this.Time.Text = "-";
            // 
            // DATE_USE
            // 
            this.DATE_USE.ForeColor = System.Drawing.Color.DarkGray;
            this.DATE_USE.Location = new System.Drawing.Point(95, 189);
            this.DATE_USE.Name = "DATE_USE";
            this.DATE_USE.Size = new System.Drawing.Size(225, 20);
            this.DATE_USE.TabIndex = 0;
            this.DATE_USE.Text = "Example: 234567cn";
            this.DATE_USE.Click += new System.EventHandler(this.DATE_USE_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Day";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "(2,3,4,5,6,7,cn)";
            // 
            // Time_Use_To
            // 
            this.Time_Use_To.FormattingEnabled = true;
            this.Time_Use_To.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "23:59"});
            this.Time_Use_To.Location = new System.Drawing.Point(203, 162);
            this.Time_Use_To.Name = "Time_Use_To";
            this.Time_Use_To.Size = new System.Drawing.Size(86, 21);
            this.Time_Use_To.TabIndex = 4;
            this.Time_Use_To.SelectedIndexChanged += new System.EventHandler(this.Time_Use_SelectedIndexChanged);
            // 
            // Door
            // 
            this.Door.FormattingEnabled = true;
            this.Door.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "24:00"});
            this.Door.Location = new System.Drawing.Point(95, 135);
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(86, 21);
            this.Door.TabIndex = 4;
            this.Door.SelectedIndexChanged += new System.EventHandler(this.Time_Use_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Door";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(257, 235);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(111, 23);
            this.Send.TabIndex = 6;
            this.Send.Text = "Send to Board";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Add_Employ
            // 
            this.Add_Employ.Location = new System.Drawing.Point(95, 297);
            this.Add_Employ.Name = "Add_Employ";
            this.Add_Employ.Size = new System.Drawing.Size(75, 23);
            this.Add_Employ.TabIndex = 7;
            this.Add_Employ.Text = "Add_Employee";
            this.Add_Employ.UseVisualStyleBackColor = true;
            this.Add_Employ.Click += new System.EventHandler(this.Add_Employ_Click);
            // 
            // Add_Door
            // 
            this.Add_Door.Location = new System.Drawing.Point(205, 297);
            this.Add_Door.Name = "Add_Door";
            this.Add_Door.Size = new System.Drawing.Size(75, 23);
            this.Add_Door.TabIndex = 7;
            this.Add_Door.Text = "Add_Door";
            this.Add_Door.UseVisualStyleBackColor = true;
            this.Add_Door.Click += new System.EventHandler(this.Add_Door_Click);
            // 
            // RFID
            // 
            this.RFID.AutoSize = true;
            this.RFID.Location = new System.Drawing.Point(95, 109);
            this.RFID.Name = "RFID";
            this.RFID.Size = new System.Drawing.Size(32, 13);
            this.RFID.TabIndex = 1;
            this.RFID.Text = "RFID";
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.Location = new System.Drawing.Point(95, 87);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(26, 13);
            this.Unit.TabIndex = 1;
            this.Unit.Text = "Unit";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(95, 64);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID ";
            // 
            // ID_List
            // 
            this.ID_List.FormattingEnabled = true;
            this.ID_List.Location = new System.Drawing.Point(95, 26);
            this.ID_List.Name = "ID_List";
            this.ID_List.Size = new System.Drawing.Size(121, 21);
            this.ID_List.TabIndex = 8;
            this.ID_List.SelectedIndexChanged += new System.EventHandler(this.ID_List_SelectedIndexChanged);
            // 
            // FormEmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 433);
            this.Controls.Add(this.ID_List);
            this.Controls.Add(this.Add_Door);
            this.Controls.Add(this.Add_Employ);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Time_Use_To);
            this.Controls.Add(this.Door);
            this.Controls.Add(this.Time_Use_From);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RFID);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DATE_USE);
            
            this.Text = "FormEmployeeAdd";
            this.Load += new System.EventHandler(this.FormEmployeeAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ComboBox Time_Use_From;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TextBox DATE_USE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Time_Use_To;
        private System.Windows.Forms.ComboBox Door;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Add_Employ;
        private System.Windows.Forms.Button Add_Door;
        private System.Windows.Forms.Label RFID;
        private System.Windows.Forms.Label Unit;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ID_List;
    }
}