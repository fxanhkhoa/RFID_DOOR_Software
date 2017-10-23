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
            this.SuspendLayout();
            // 
            // Read_RFID
            // 
            this.Read_RFID.Location = new System.Drawing.Point(364, 104);
            this.Read_RFID.Name = "Read_RFID";
            this.Read_RFID.Size = new System.Drawing.Size(75, 23);
            this.Read_RFID.TabIndex = 11;
            this.Read_RFID.Text = "Read RFID";
            this.Read_RFID.UseVisualStyleBackColor = true;
            this.Read_RFID.Click += new System.EventHandler(this.Read_RFID_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "RFID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID ";
            // 
            // RFID
            // 
            this.RFID.Location = new System.Drawing.Point(113, 106);
            this.RFID.Name = "RFID";
            this.RFID.Size = new System.Drawing.Size(225, 20);
            this.RFID.TabIndex = 3;
            // 
            // Unit
            // 
            this.Unit.Location = new System.Drawing.Point(113, 80);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(225, 20);
            this.Unit.TabIndex = 4;
            // 
            // Ten
            // 
            this.Ten.Location = new System.Drawing.Point(113, 54);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(225, 20);
            this.Ten.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(113, 28);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(225, 20);
            this.ID.TabIndex = 6;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(113, 163);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // FormEmployeeAddEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 433);
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
    }
}