namespace RFID_DOOR_APP
{
    partial class FormDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Employee_list = new System.Windows.Forms.ComboBox();
            this.Usage_Delete = new System.Windows.Forms.Button();
            this.Employee_Delete = new System.Windows.Forms.Button();
            this.Usage_data_grid = new System.Windows.Forms.DataGridView();
            this.SEND = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Usage_data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee";
            // 
            // Employee_list
            // 
            this.Employee_list.FormattingEnabled = true;
            this.Employee_list.Location = new System.Drawing.Point(549, 60);
            this.Employee_list.Name = "Employee_list";
            this.Employee_list.Size = new System.Drawing.Size(121, 21);
            this.Employee_list.TabIndex = 2;
            // 
            // Usage_Delete
            // 
            this.Usage_Delete.Location = new System.Drawing.Point(25, 297);
            this.Usage_Delete.Name = "Usage_Delete";
            this.Usage_Delete.Size = new System.Drawing.Size(75, 23);
            this.Usage_Delete.TabIndex = 3;
            this.Usage_Delete.Text = "Delete";
            this.Usage_Delete.UseVisualStyleBackColor = true;
            this.Usage_Delete.Click += new System.EventHandler(this.Usage_Delete_Click);
            // 
            // Employee_Delete
            // 
            this.Employee_Delete.Location = new System.Drawing.Point(549, 101);
            this.Employee_Delete.Name = "Employee_Delete";
            this.Employee_Delete.Size = new System.Drawing.Size(75, 23);
            this.Employee_Delete.TabIndex = 3;
            this.Employee_Delete.Text = "Delete";
            this.Employee_Delete.UseVisualStyleBackColor = true;
            this.Employee_Delete.Click += new System.EventHandler(this.Employee_Delete_Click);
            // 
            // Usage_data_grid
            // 
            this.Usage_data_grid.BackgroundColor = System.Drawing.Color.White;
            this.Usage_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Usage_data_grid.Location = new System.Drawing.Point(25, 46);
            this.Usage_data_grid.Name = "Usage_data_grid";
            this.Usage_data_grid.Size = new System.Drawing.Size(435, 236);
            this.Usage_data_grid.TabIndex = 4;
            // 
            // SEND
            // 
            this.SEND.Location = new System.Drawing.Point(180, 297);
            this.SEND.Name = "SEND";
            this.SEND.Size = new System.Drawing.Size(107, 23);
            this.SEND.TabIndex = 5;
            this.SEND.Text = "Send to board";
            this.SEND.UseVisualStyleBackColor = true;
            this.SEND.Click += new System.EventHandler(this.SEND_Click);
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 537);
            this.Controls.Add(this.SEND);
            this.Controls.Add(this.Usage_data_grid);
            this.Controls.Add(this.Employee_Delete);
            this.Controls.Add(this.Usage_Delete);
            this.Controls.Add(this.Employee_list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1231, 716);
            this.Name = "FormDelete";
            this.RightToLeftLayout = true;
            this.Text = "FormDelete";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Usage_data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Employee_list;
        private System.Windows.Forms.Button Usage_Delete;
        private System.Windows.Forms.Button Employee_Delete;
        private System.Windows.Forms.DataGridView Usage_data_grid;
        private System.Windows.Forms.Button SEND;
    }
}