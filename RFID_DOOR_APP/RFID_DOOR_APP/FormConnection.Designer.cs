namespace RFID_DOOR_APP
{
    partial class FormConnection
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
            this.components = new System.ComponentModel.Container();
            this.PORT = new System.Windows.Forms.ComboBox();
            this.BAUD_RATE = new System.Windows.Forms.ComboBox();
            this.Parity = new System.Windows.Forms.ComboBox();
            this.DATABITS = new System.Windows.Forms.ComboBox();
            this.STOPBITS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Connect_Btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PORT
            // 
            this.PORT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PORT.FormattingEnabled = true;
            this.PORT.Location = new System.Drawing.Point(103, 40);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(121, 21);
            this.PORT.TabIndex = 0;
            this.PORT.Tag = "";
            // 
            // BAUD_RATE
            // 
            this.BAUD_RATE.AutoCompleteCustomSource.AddRange(new string[] {
            "9600",
            "115200"});
            this.BAUD_RATE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BAUD_RATE.FormattingEnabled = true;
            this.BAUD_RATE.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.BAUD_RATE.Location = new System.Drawing.Point(103, 76);
            this.BAUD_RATE.Name = "BAUD_RATE";
            this.BAUD_RATE.Size = new System.Drawing.Size(121, 21);
            this.BAUD_RATE.TabIndex = 0;
            this.BAUD_RATE.Tag = "";
            // 
            // Parity
            // 
            this.Parity.AutoCompleteCustomSource.AddRange(new string[] {
            "NONE"});
            this.Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Parity.FormattingEnabled = true;
            this.Parity.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN"});
            this.Parity.Location = new System.Drawing.Point(103, 112);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(121, 21);
            this.Parity.TabIndex = 0;
            // 
            // DATABITS
            // 
            this.DATABITS.AutoCompleteCustomSource.AddRange(new string[] {
            "8"});
            this.DATABITS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DATABITS.FormattingEnabled = true;
            this.DATABITS.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.DATABITS.Location = new System.Drawing.Point(103, 151);
            this.DATABITS.Name = "DATABITS";
            this.DATABITS.Size = new System.Drawing.Size(121, 21);
            this.DATABITS.TabIndex = 0;
            // 
            // STOPBITS
            // 
            this.STOPBITS.AutoCompleteCustomSource.AddRange(new string[] {
            "1"});
            this.STOPBITS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.STOPBITS.FormattingEnabled = true;
            this.STOPBITS.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.STOPBITS.Location = new System.Drawing.Point(103, 188);
            this.STOPBITS.Name = "STOPBITS";
            this.STOPBITS.Size = new System.Drawing.Size(121, 21);
            this.STOPBITS.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAUD_RATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "PARITY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "DATABITS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "STOPBITS";
            // 
            // Connect_Btn
            // 
            this.Connect_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Connect_Btn.Location = new System.Drawing.Point(103, 239);
            this.Connect_Btn.Name = "Connect_Btn";
            this.Connect_Btn.Size = new System.Drawing.Size(75, 23);
            this.Connect_Btn.TabIndex = 2;
            this.Connect_Btn.Text = "Connect";
            this.Connect_Btn.UseVisualStyleBackColor = true;
            this.Connect_Btn.Click += new System.EventHandler(this.Connect_Btn_Click);
            // 
            // FormConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 433);
            this.Controls.Add(this.Connect_Btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.STOPBITS);
            this.Controls.Add(this.DATABITS);
            this.Controls.Add(this.Parity);
            this.Controls.Add(this.BAUD_RATE);
            this.Controls.Add(this.PORT);
            this.Name = "FormConnection";
            this.Text = "FormConnection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConnection_FormClosed);
            this.Load += new System.EventHandler(this.FormConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PORT;
        private System.Windows.Forms.ComboBox BAUD_RATE;
        private System.Windows.Forms.ComboBox Parity;
        private System.Windows.Forms.ComboBox DATABITS;
        private System.Windows.Forms.ComboBox STOPBITS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Connect_Btn;
        private System.Windows.Forms.Timer timer1;
    }
}