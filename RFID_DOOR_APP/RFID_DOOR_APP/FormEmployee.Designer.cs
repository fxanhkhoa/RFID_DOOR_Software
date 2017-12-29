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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Add_Btn = new System.Windows.Forms.PictureBox();
            this.view_btn = new System.Windows.Forms.PictureBox();
            this.fix_btn = new System.Windows.Forms.PictureBox();
            this.Delete_Btn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fix_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Add_Btn);
            this.panel1.Controls.Add(this.view_btn);
            this.panel1.Controls.Add(this.fix_btn);
            this.panel1.Controls.Add(this.Delete_Btn);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // Add_Btn
            // 
            this.Add_Btn.Image = global::RFID_DOOR_APP.Properties.Resources.ADD_BTN;
            resources.ApplyResources(this.Add_Btn, "Add_Btn");
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.TabStop = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            this.Add_Btn.MouseLeave += new System.EventHandler(this.Add_Btn_MouseLeave);
            this.Add_Btn.MouseHover += new System.EventHandler(this.Add_Btn_MouseHover);
            // 
            // view_btn
            // 
            this.view_btn.Image = global::RFID_DOOR_APP.Properties.Resources.VIEW_BTN;
            resources.ApplyResources(this.view_btn, "view_btn");
            this.view_btn.Name = "view_btn";
            this.view_btn.TabStop = false;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            this.view_btn.MouseLeave += new System.EventHandler(this.view_btn_MouseLeave);
            this.view_btn.MouseHover += new System.EventHandler(this.view_btn_MouseHover);
            // 
            // fix_btn
            // 
            this.fix_btn.Image = global::RFID_DOOR_APP.Properties.Resources.FIX_BTN;
            resources.ApplyResources(this.fix_btn, "fix_btn");
            this.fix_btn.Name = "fix_btn";
            this.fix_btn.TabStop = false;
            this.fix_btn.Click += new System.EventHandler(this.fix_btn_Click);
            this.fix_btn.MouseLeave += new System.EventHandler(this.fix_btn_MouseLeave);
            this.fix_btn.MouseHover += new System.EventHandler(this.fix_btn_MouseHover);
            // 
            // Delete_Btn
            // 
            resources.ApplyResources(this.Delete_Btn, "Delete_Btn");
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.TabStop = false;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            this.Delete_Btn.MouseLeave += new System.EventHandler(this.Delete_Btn_MouseLeave);
            this.Delete_Btn.MouseHover += new System.EventHandler(this.Delete_Btn_MouseHover);
            // 
            // FormEmployee
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fix_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Add_Btn;
        private System.Windows.Forms.PictureBox Delete_Btn;
        private System.Windows.Forms.PictureBox fix_btn;
        private System.Windows.Forms.PictureBox view_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}