namespace RFID_DOOR_APP
{
    partial class FormViewEmployee
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
            this.employee_data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.employee_data)).BeginInit();
            this.SuspendLayout();
            // 
            // employee_data
            // 
            this.employee_data.BackgroundColor = System.Drawing.Color.White;
            this.employee_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employee_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employee_data.Location = new System.Drawing.Point(0, 0);
            this.employee_data.Name = "employee_data";
            this.employee_data.Size = new System.Drawing.Size(392, 345);
            this.employee_data.TabIndex = 3;
            // 
            // FormViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 345);
            this.Controls.Add(this.employee_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewEmployee";
            this.Text = "FormViewEmployee";
            this.Load += new System.EventHandler(this.FormViewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employee_data;
    }
}