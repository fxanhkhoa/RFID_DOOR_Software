namespace RFID_DOOR_APP
{
    partial class Form_Config
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
            this.boardIPTextBox1 = new System.Windows.Forms.TextBox();
            this.IDBOARDComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.myIPAddressTextBox = new System.Windows.Forms.TextBox();
            this.getButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.boardIPTextBox2 = new System.Windows.Forms.TextBox();
            this.boardIPTextBox3 = new System.Windows.Forms.TextBox();
            this.boardIPTextBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IDBOARDTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IDBOARDChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // boardIPTextBox1
            // 
            this.boardIPTextBox1.Location = new System.Drawing.Point(367, 194);
            this.boardIPTextBox1.Name = "boardIPTextBox1";
            this.boardIPTextBox1.Size = new System.Drawing.Size(40, 20);
            this.boardIPTextBox1.TabIndex = 2;
            // 
            // IDBOARDComboBox
            // 
            this.IDBOARDComboBox.FormattingEnabled = true;
            this.IDBOARDComboBox.Location = new System.Drawing.Point(123, 194);
            this.IDBOARDComboBox.Name = "IDBOARDComboBox";
            this.IDBOARDComboBox.Size = new System.Drawing.Size(121, 21);
            this.IDBOARDComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IDBOARD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(367, 229);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(121, 20);
            this.portTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "My IP Address";
            // 
            // myIPAddressTextBox
            // 
            this.myIPAddressTextBox.Location = new System.Drawing.Point(367, 81);
            this.myIPAddressTextBox.Multiline = true;
            this.myIPAddressTextBox.Name = "myIPAddressTextBox";
            this.myIPAddressTextBox.Size = new System.Drawing.Size(153, 98);
            this.myIPAddressTextBox.TabIndex = 8;
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(123, 232);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(75, 23);
            this.getButton.TabIndex = 1;
            this.getButton.Text = "GET";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(367, 302);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 7;
            this.setButton.Text = "SET";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // boardIPTextBox2
            // 
            this.boardIPTextBox2.Location = new System.Drawing.Point(413, 195);
            this.boardIPTextBox2.Name = "boardIPTextBox2";
            this.boardIPTextBox2.Size = new System.Drawing.Size(40, 20);
            this.boardIPTextBox2.TabIndex = 3;
            // 
            // boardIPTextBox3
            // 
            this.boardIPTextBox3.Location = new System.Drawing.Point(459, 194);
            this.boardIPTextBox3.Name = "boardIPTextBox3";
            this.boardIPTextBox3.Size = new System.Drawing.Size(40, 20);
            this.boardIPTextBox3.TabIndex = 4;
            // 
            // boardIPTextBox4
            // 
            this.boardIPTextBox4.Location = new System.Drawing.Point(505, 194);
            this.boardIPTextBox4.Name = "boardIPTextBox4";
            this.boardIPTextBox4.Size = new System.Drawing.Size(40, 20);
            this.boardIPTextBox4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(551, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "IP Address that board is storing to connect to";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(501, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "PORT that board is storing to connect to";
            // 
            // IDBOARDTextBox
            // 
            this.IDBOARDTextBox.Location = new System.Drawing.Point(367, 260);
            this.IDBOARDTextBox.Name = "IDBOARDTextBox";
            this.IDBOARDTextBox.Size = new System.Drawing.Size(121, 20);
            this.IDBOARDTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "IDBOARD";
            // 
            // IDBOARDChangeCheckBox
            // 
            this.IDBOARDChangeCheckBox.AutoSize = true;
            this.IDBOARDChangeCheckBox.Location = new System.Drawing.Point(505, 262);
            this.IDBOARDChangeCheckBox.Name = "IDBOARDChangeCheckBox";
            this.IDBOARDChangeCheckBox.Size = new System.Drawing.Size(95, 17);
            this.IDBOARDChangeCheckBox.TabIndex = 13;
            this.IDBOARDChangeCheckBox.Text = "Change or Not";
            this.IDBOARDChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 613);
            this.Controls.Add(this.IDBOARDChangeCheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IDBOARDTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boardIPTextBox4);
            this.Controls.Add(this.boardIPTextBox3);
            this.Controls.Add(this.boardIPTextBox2);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.myIPAddressTextBox);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDBOARDComboBox);
            this.Controls.Add(this.boardIPTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Config";
            this.Text = "Form_Config";
            this.Load += new System.EventHandler(this.Form_Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boardIPTextBox1;
        private System.Windows.Forms.ComboBox IDBOARDComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox myIPAddressTextBox;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.TextBox boardIPTextBox2;
        private System.Windows.Forms.TextBox boardIPTextBox3;
        private System.Windows.Forms.TextBox boardIPTextBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IDBOARDTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox IDBOARDChangeCheckBox;
    }
}