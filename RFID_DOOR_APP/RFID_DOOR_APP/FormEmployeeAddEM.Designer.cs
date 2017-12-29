namespace RFID_DOOR_APP
{
    partial class FormEmployeeAddEM
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
            this.Read_RFID = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RFID = new System.Windows.Forms.TextBox();
            this.Unit = new System.Windows.Forms.TextBox();
            this.Ten = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Read_RFID
            // 
            this.Read_RFID.Location = new System.Drawing.Point(377, 146);
            this.Read_RFID.Name = "Read_RFID";
            this.Read_RFID.Size = new System.Drawing.Size(75, 23);
            this.Read_RFID.TabIndex = 5;
            this.Read_RFID.Text = "Read RFID";
            this.Read_RFID.UseVisualStyleBackColor = true;
            this.Read_RFID.Click += new System.EventHandler(this.Read_RFID_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "RFID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID ";
            // 
            // RFID
            // 
            this.RFID.Location = new System.Drawing.Point(126, 148);
            this.RFID.Name = "RFID";
            this.RFID.Size = new System.Drawing.Size(225, 20);
            this.RFID.TabIndex = 4;
            // 
            // Unit
            // 
            this.Unit.Location = new System.Drawing.Point(126, 122);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(225, 20);
            this.Unit.TabIndex = 3;
            // 
            // Ten
            // 
            this.Ten.Location = new System.Drawing.Point(126, 96);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(225, 20);
            this.Ten.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(126, 70);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(225, 20);
            this.ID.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(126, 205);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LED BOARD REVERSED", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(140, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "ADD EMPLOYEE";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(222, 205);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Red;
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(507, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(19, 19);
            this.Close.TabIndex = 14;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // FormEmployeeAddEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 433);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Read_RFID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RFID);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployeeAddEM";
            this.Text = "FormEmployeeAddEM";
            this.Load += new System.EventHandler(this.FormEmployeeAddEM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Read_RFID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RFID;
        private System.Windows.Forms.TextBox Unit;
        private System.Windows.Forms.TextBox Ten;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Clear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Close;
    }
}