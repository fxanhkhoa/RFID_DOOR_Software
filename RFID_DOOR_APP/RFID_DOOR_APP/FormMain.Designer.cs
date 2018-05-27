namespace RFID_DOOR_APP
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Control_BTN = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.connectStatus_text = new System.Windows.Forms.Label();
            this.Connection_status = new System.Windows.Forms.ProgressBar();
            this.Title = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.picture_header = new System.Windows.Forms.PictureBox();
            this.User_Control = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Control_BTN.SuspendLayout();
            this.Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.Panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_header)).BeginInit();
            this.SuspendLayout();
            // 
            // Control_BTN
            // 
            this.Control_BTN.BackColor = System.Drawing.Color.White;
            this.Control_BTN.Controls.Add(this.label2);
            this.Control_BTN.Controls.Add(this.connectStatus_text);
            this.Control_BTN.Controls.Add(this.Connection_status);
            this.Control_BTN.Controls.Add(this.Title);
            this.Control_BTN.Controls.Add(this.pictureBox2);
            this.Control_BTN.Controls.Add(this.pictureBox3);
            this.Control_BTN.Controls.Add(this.pictureBox4);
            this.Control_BTN.Controls.Add(this.pictureBox6);
            this.Control_BTN.Controls.Add(this.pictureBox5);
            resources.ApplyResources(this.Control_BTN, "Control_BTN");
            this.Control_BTN.Name = "Control_BTN";
            this.Control_BTN.Resize += new System.EventHandler(this.Control_BTN_Resize);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // connectStatus_text
            // 
            resources.ApplyResources(this.connectStatus_text, "connectStatus_text");
            this.connectStatus_text.ForeColor = System.Drawing.Color.Maroon;
            this.connectStatus_text.Name = "connectStatus_text";
            // 
            // Connection_status
            // 
            resources.ApplyResources(this.Connection_status, "Connection_status");
            this.Connection_status.Name = "Connection_status";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Title.Controls.Add(this.pictureBox1);
            this.Title.Controls.Add(this.label1);
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RFID_DOOR_APP.Properties.Resources.REPORT_BUTTON_NORMAL;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RFID_DOOR_APP.Properties.Resources.EMPLOYEE_BUTTON_NORMAL;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RFID_DOOR_APP.Properties.Resources.CONTROL_BUTTON_NORMAL;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // pictureBox6
            // 
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Image = global::RFID_DOOR_APP.Properties.Resources.STATUS_BUTTON_NORMAL;
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.pictureBox6_MouseLeave);
            this.pictureBox6.MouseHover += new System.EventHandler(this.pictureBox6_MouseHover);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::RFID_DOOR_APP.Properties.Resources.CONNECT_BUTTON_NORMAL;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseHover += new System.EventHandler(this.pictureBox5_MouseHover);
            // 
            // Panel_Header
            // 
            this.Panel_Header.Controls.Add(this.picture_header);
            resources.ApplyResources(this.Panel_Header, "Panel_Header");
            this.Panel_Header.Name = "Panel_Header";
            // 
            // picture_header
            // 
            this.picture_header.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.picture_header, "picture_header");
            this.picture_header.Name = "picture_header";
            this.picture_header.TabStop = false;
            // 
            // User_Control
            // 
            resources.ApplyResources(this.User_Control, "User_Control");
            this.User_Control.Name = "User_Control";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.User_Control);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Control_BTN);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.FormMain_ResizeEnd);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.Control_BTN.ResumeLayout(false);
            this.Control_BTN.PerformLayout();
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.Panel_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_header)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Control_BTN;
        private System.Windows.Forms.Panel Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label connectStatus_text;
        private System.Windows.Forms.ProgressBar Connection_status;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.PictureBox picture_header;
        private System.Windows.Forms.Panel User_Control;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

