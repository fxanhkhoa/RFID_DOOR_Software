namespace RFID_DOOR_APP
{
    partial class FormReport
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
            this.report_data = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DateTimePick = new System.Windows.Forms.DateTimePicker();
            this.Clear_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.report_data)).BeginInit();
            this.SuspendLayout();
            // 
            // report_data
            // 
            this.report_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.report_data.BackgroundColor = System.Drawing.Color.White;
            this.report_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.report_data.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.report_data.Location = new System.Drawing.Point(0, 30);
            this.report_data.Name = "report_data";
            this.report_data.ReadOnly = true;
            this.report_data.Size = new System.Drawing.Size(569, 538);
            this.report_data.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // DateTimePick
            // 
            this.DateTimePick.Location = new System.Drawing.Point(12, 4);
            this.DateTimePick.Name = "DateTimePick";
            this.DateTimePick.Size = new System.Drawing.Size(200, 20);
            this.DateTimePick.TabIndex = 1;
            // 
            // Clear_Btn
            // 
            this.Clear_Btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Clear_Btn.FlatAppearance.BorderSize = 0;
            this.Clear_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Btn.Location = new System.Drawing.Point(218, 1);
            this.Clear_Btn.Name = "Clear_Btn";
            this.Clear_Btn.Size = new System.Drawing.Size(75, 23);
            this.Clear_Btn.TabIndex = 2;
            this.Clear_Btn.Text = "Clear";
            this.Clear_Btn.UseVisualStyleBackColor = false;
            this.Clear_Btn.Click += new System.EventHandler(this.Clear_Btn_Click);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(569, 568);
            this.Controls.Add(this.Clear_Btn);
            this.Controls.Add(this.DateTimePick);
            this.Controls.Add(this.report_data);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1231, 716);
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FormReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView report_data;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker DateTimePick;
        private System.Windows.Forms.Button Clear_Btn;
    }
}