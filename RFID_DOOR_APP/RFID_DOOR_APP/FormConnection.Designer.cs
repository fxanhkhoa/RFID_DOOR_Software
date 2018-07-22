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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Server = new System.Windows.Forms.TextBox();
            this.Eth_PORT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Ethernet = new System.Windows.Forms.Button();
            this.OWN_IP = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Connect_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PORT
            // 
            this.PORT.BackColor = System.Drawing.Color.White;
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
            this.BAUD_RATE.BackColor = System.Drawing.Color.White;
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
            this.Parity.BackColor = System.Drawing.Color.White;
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
            this.DATABITS.BackColor = System.Drawing.Color.White;
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
            this.STOPBITS.BackColor = System.Drawing.Color.White;
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
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(103, 327);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(188, 20);
            this.Server.TabIndex = 4;
            this.Server.Visible = false;
            // 
            // Eth_PORT
            // 
            this.Eth_PORT.Location = new System.Drawing.Point(103, 363);
            this.Eth_PORT.Name = "Eth_PORT";
            this.Eth_PORT.Size = new System.Drawing.Size(188, 20);
            this.Eth_PORT.TabIndex = 5;
            this.Eth_PORT.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(16, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "OWN_IP";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(16, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "BOARD IP";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(16, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "PORT";
            this.label8.Visible = false;
            // 
            // Ethernet
            // 
            this.Ethernet.BackColor = System.Drawing.Color.White;
            this.Ethernet.Location = new System.Drawing.Point(423, 40);
            this.Ethernet.Name = "Ethernet";
            this.Ethernet.Size = new System.Drawing.Size(202, 23);
            this.Ethernet.TabIndex = 7;
            this.Ethernet.Text = "Start Server";
            this.Ethernet.UseVisualStyleBackColor = false;
            this.Ethernet.Click += new System.EventHandler(this.Ethernet_Click);
            // 
            // OWN_IP
            // 
            this.OWN_IP.FormattingEnabled = true;
            this.OWN_IP.Location = new System.Drawing.Point(103, 290);
            this.OWN_IP.Name = "OWN_IP";
            this.OWN_IP.Size = new System.Drawing.Size(188, 21);
            this.OWN_IP.TabIndex = 8;
            this.OWN_IP.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Connect_Btn
            // 
            this.Connect_Btn.BackColor = System.Drawing.Color.White;
            this.Connect_Btn.Location = new System.Drawing.Point(103, 239);
            this.Connect_Btn.Name = "Connect_Btn";
            this.Connect_Btn.Size = new System.Drawing.Size(75, 23);
            this.Connect_Btn.TabIndex = 7;
            this.Connect_Btn.Text = "Connect";
            this.Connect_Btn.UseVisualStyleBackColor = false;
            this.Connect_Btn.Click += new System.EventHandler(this.Ethernet_Click);
            // 
            // FormConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(698, 433);
            this.Controls.Add(this.OWN_IP);
            this.Controls.Add(this.Connect_Btn);
            this.Controls.Add(this.Ethernet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Eth_PORT);
            this.Controls.Add(this.Server);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConnection";
            this.Text = "FormConnection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConnection_FormClosing);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.TextBox Eth_PORT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Ethernet;
        private System.Windows.Forms.ComboBox OWN_IP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button Connect_Btn;
    }
}