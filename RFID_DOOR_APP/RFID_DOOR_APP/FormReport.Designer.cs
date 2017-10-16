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
            this.report_data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.report_data)).BeginInit();
            this.SuspendLayout();
            // 
            // report_data
            // 
            this.report_data.BackgroundColor = System.Drawing.Color.White;
            this.report_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.report_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report_data.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.report_data.Location = new System.Drawing.Point(0, 0);
            this.report_data.Name = "report_data";
            this.report_data.Size = new System.Drawing.Size(569, 384);
            this.report_data.TabIndex = 0;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(569, 384);
            this.Controls.Add(this.report_data);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView report_data;
    }
}