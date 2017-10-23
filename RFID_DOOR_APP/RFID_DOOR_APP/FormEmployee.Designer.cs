namespace RFID_DOOR_APP
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.fix_btn = new System.Windows.Forms.PictureBox();
            this.view_btn = new System.Windows.Forms.PictureBox();
            this.Delete_Btn = new System.Windows.Forms.PictureBox();
            this.Add_Btn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employee_data = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fix_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Btn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_data)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fix_btn
            // 
            this.fix_btn.Image = global::RFID_DOOR_APP.Properties.Resources.FIX_BTN;
            this.fix_btn.Location = new System.Drawing.Point(3, 130);
            this.fix_btn.Name = "fix_btn";
            this.fix_btn.Size = new System.Drawing.Size(149, 53);
            this.fix_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fix_btn.TabIndex = 0;
            this.fix_btn.TabStop = false;
            this.fix_btn.Click += new System.EventHandler(this.fix_btn_Click);
            this.fix_btn.MouseLeave += new System.EventHandler(this.fix_btn_MouseLeave);
            this.fix_btn.MouseHover += new System.EventHandler(this.fix_btn_MouseHover);
            // 
            // view_btn
            // 
            this.view_btn.Image = global::RFID_DOOR_APP.Properties.Resources.VIEW_BTN;
            this.view_btn.Location = new System.Drawing.Point(3, 189);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(149, 53);
            this.view_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.view_btn.TabIndex = 0;
            this.view_btn.TabStop = false;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            this.view_btn.MouseLeave += new System.EventHandler(this.view_btn_MouseLeave);
            this.view_btn.MouseHover += new System.EventHandler(this.view_btn_MouseHover);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Btn.Image")));
            this.Delete_Btn.Location = new System.Drawing.Point(3, 71);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(149, 53);
            this.Delete_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Delete_Btn.TabIndex = 0;
            this.Delete_Btn.TabStop = false;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            this.Delete_Btn.MouseLeave += new System.EventHandler(this.Delete_Btn_MouseLeave);
            this.Delete_Btn.MouseHover += new System.EventHandler(this.Delete_Btn_MouseHover);
            // 
            // Add_Btn
            // 
            this.Add_Btn.Image = global::RFID_DOOR_APP.Properties.Resources.ADD_BTN;
            this.Add_Btn.Location = new System.Drawing.Point(3, 12);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(149, 53);
            this.Add_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Add_Btn.TabIndex = 0;
            this.Add_Btn.TabStop = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            this.Add_Btn.MouseLeave += new System.EventHandler(this.Add_Btn_MouseLeave);
            this.Add_Btn.MouseHover += new System.EventHandler(this.Add_Btn_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Add_Btn);
            this.panel1.Controls.Add(this.view_btn);
            this.panel1.Controls.Add(this.fix_btn);
            this.panel1.Controls.Add(this.Delete_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 345);
            this.panel1.TabIndex = 1;
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
            this.employee_data.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.employee_data);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(161, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 345);
            this.panel2.TabIndex = 3;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 345);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1231, 716);
            this.Name = "FormEmployee";
            this.Text = "Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fix_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Btn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_data)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Add_Btn;
        private System.Windows.Forms.PictureBox Delete_Btn;
        private System.Windows.Forms.PictureBox fix_btn;
        private System.Windows.Forms.PictureBox view_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView employee_data;
        private System.Windows.Forms.Panel panel2;
    }
}