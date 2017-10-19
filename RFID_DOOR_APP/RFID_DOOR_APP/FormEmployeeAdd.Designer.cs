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
            this.ID = new System.Windows.Forms.TextBox();
            this.Ten = new System.Windows.Forms.TextBox();
            this.Unit = new System.Windows.Forms.TextBox();
            this.RFID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Read_RFID = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Time_Use_From = new System.Windows.Forms.ComboBox();
            this.Time = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Time_Use_To = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(97, 26);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(225, 20);
            this.ID.TabIndex = 0;
            // 
            // Ten
            // 
            this.Ten.Location = new System.Drawing.Point(97, 52);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(225, 20);
            this.Ten.TabIndex = 0;
            // 
            // Unit
            // 
            this.Unit.Location = new System.Drawing.Point(97, 78);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(225, 20);
            this.Unit.TabIndex = 0;
            // 
            // RFID
            // 
            this.RFID.Location = new System.Drawing.Point(97, 104);
            this.RFID.Name = "RFID";
            this.RFID.Size = new System.Drawing.Size(225, 20);
            this.RFID.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "RFID";
            // 
            // Read_RFID
            // 
            this.Read_RFID.Location = new System.Drawing.Point(348, 102);
            this.Read_RFID.Name = "Read_RFID";
            this.Read_RFID.Size = new System.Drawing.Size(75, 23);
            this.Read_RFID.TabIndex = 2;
            this.Read_RFID.Text = "Read RFID";
            this.Read_RFID.UseVisualStyleBackColor = true;
            this.Read_RFID.Click += new System.EventHandler(this.Read_RFID_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(97, 200);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(178, 200);
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
            "24:00"});
            this.Time_Use_From.Location = new System.Drawing.Point(97, 130);
            this.Time_Use_From.Name = "Time_Use_From";
            this.Time_Use_From.Size = new System.Drawing.Size(86, 21);
            this.Time_Use_From.TabIndex = 4;
            this.Time_Use_From.SelectedIndexChanged += new System.EventHandler(this.Time_Use_SelectedIndexChanged);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(189, 133);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(10, 13);
            this.Time.TabIndex = 5;
            this.Time.Text = ":";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(97, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Example: 234567cn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Day";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 160);
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
            "24:00"});
            this.Time_Use_To.Location = new System.Drawing.Point(205, 130);
            this.Time_Use_To.Name = "Time_Use_To";
            this.Time_Use_To.Size = new System.Drawing.Size(86, 21);
            this.Time_Use_To.TabIndex = 4;
            this.Time_Use_To.SelectedIndexChanged += new System.EventHandler(this.Time_Use_SelectedIndexChanged);
            // 
            // FormEmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 433);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Time_Use_To);
            this.Controls.Add(this.Time_Use_From);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Read_RFID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RFID);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.ID);
            this.Name = "FormEmployeeAdd";
            this.Text = "FormEmployeeAdd";
            this.Load += new System.EventHandler(this.FormEmployeeAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Ten;
        private System.Windows.Forms.TextBox Unit;
        private System.Windows.Forms.TextBox RFID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Read_RFID;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ComboBox Time_Use_From;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Time_Use_To;
    }
}