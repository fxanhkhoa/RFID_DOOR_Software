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
            this.panel1 = new System.Windows.Forms.Panel();
            this.connectStatus_text = new System.Windows.Forms.Label();
            this.Connection_status = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.selectingBar = new System.Windows.Forms.Panel();
            this.moveBar = new System.Windows.Forms.Panel();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.userControl = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.closeButton = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.statusButton = new System.Windows.Forms.Button();
            this.controlButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.moveBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.configButton);
            this.panel1.Controls.Add(this.connectStatus_text);
            this.panel1.Controls.Add(this.Connection_status);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.statusButton);
            this.panel1.Controls.Add(this.controlButton);
            this.panel1.Controls.Add(this.userButton);
            this.panel1.Controls.Add(this.selectingBar);
            this.panel1.Controls.Add(this.reportButton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // selectingBar
            // 
            this.selectingBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(18)))), ((int)(((byte)(57)))));
            this.selectingBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.selectingBar, "selectingBar");
            this.selectingBar.Name = "selectingBar";
            // 
            // moveBar
            // 
            this.moveBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.moveBar.Controls.Add(this.titleBox);
            this.moveBar.Controls.Add(this.closeButton);
            resources.ApplyResources(this.moveBar, "moveBar");
            this.moveBar.Name = "moveBar";
            this.moveBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveBar_MouseDown);
            this.moveBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveBar_MouseMove);
            this.moveBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveBar_MouseUp);
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.titleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.titleBox, "titleBox");
            this.titleBox.ForeColor = System.Drawing.Color.White;
            this.titleBox.Name = "titleBox";
            // 
            // userControl
            // 
            resources.ApplyResources(this.userControl, "userControl");
            this.userControl.Name = "userControl";
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // configButton
            // 
            this.configButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.configButton, "configButton");
            this.configButton.Name = "configButton";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.connectButton, "connectButton");
            this.connectButton.Name = "connectButton";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // statusButton
            // 
            this.statusButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.statusButton, "statusButton");
            this.statusButton.Name = "statusButton";
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.statusButton_Click);
            // 
            // controlButton
            // 
            this.controlButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.controlButton, "controlButton");
            this.controlButton.Name = "controlButton";
            this.controlButton.UseVisualStyleBackColor = true;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // userButton
            // 
            this.userButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.userButton, "userButton");
            this.userButton.Name = "userButton";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.reportButton, "reportButton");
            this.reportButton.Name = "reportButton";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.userControl);
            this.Controls.Add(this.moveBar);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.moveBar.ResumeLayout(false);
            this.moveBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Panel moveBar;
        private System.Windows.Forms.Panel selectingBar;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel userControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar Connection_status;
        private System.Windows.Forms.Label connectStatus_text;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button configButton;
    }
}