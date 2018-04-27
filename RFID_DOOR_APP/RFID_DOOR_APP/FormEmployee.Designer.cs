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
            this.Time_Btn = new System.Windows.Forms.PictureBox();
            this.view_btn = new System.Windows.Forms.PictureBox();
            this.Edit_btn = new System.Windows.Forms.PictureBox();
            this.Door_Btn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Date_btn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Time_Btn);
            this.panel1.Controls.Add(this.Date_btn);
            this.panel1.Controls.Add(this.view_btn);
            this.panel1.Controls.Add(this.Edit_btn);
            this.panel1.Controls.Add(this.Door_Btn);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Time_Btn
            // 
            this.Time_Btn.Image = global::RFID_DOOR_APP.Properties.Resources.TIME_BUTTON_NORMAL;
            resources.ApplyResources(this.Time_Btn, "Time_Btn");
            this.Time_Btn.Name = "Time_Btn";
            this.Time_Btn.TabStop = false;
            this.Time_Btn.Click += new System.EventHandler(this.Time_Btn_Click);
            this.Time_Btn.MouseLeave += new System.EventHandler(this.Time_Btn_MouseLeave);
            this.Time_Btn.MouseHover += new System.EventHandler(this.Time_Btn_MouseHover);
            // 
            // view_btn
            // 
            this.view_btn.Image = global::RFID_DOOR_APP.Properties.Resources.VIEW_BUTTON_NORMAL;
            resources.ApplyResources(this.view_btn, "view_btn");
            this.view_btn.Name = "view_btn";
            this.view_btn.TabStop = false;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            this.view_btn.MouseLeave += new System.EventHandler(this.view_btn_MouseLeave);
            this.view_btn.MouseHover += new System.EventHandler(this.view_btn_MouseHover);
            // 
            // Edit_btn
            // 
            this.Edit_btn.Image = global::RFID_DOOR_APP.Properties.Resources.EDIT_BUTTON_NORMAL;
            resources.ApplyResources(this.Edit_btn, "Edit_btn");
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.TabStop = false;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            this.Edit_btn.MouseLeave += new System.EventHandler(this.Edit_btn_MouseLeave);
            this.Edit_btn.MouseHover += new System.EventHandler(this.Edit_btn_MouseHover);
            // 
            // Door_Btn
            // 
            this.Door_Btn.Image = global::RFID_DOOR_APP.Properties.Resources.DOOR_BUTTON_NORMAL;
            resources.ApplyResources(this.Door_Btn, "Door_Btn");
            this.Door_Btn.Name = "Door_Btn";
            this.Door_Btn.TabStop = false;
            this.Door_Btn.Click += new System.EventHandler(this.Door_Btn_Click);
            this.Door_Btn.MouseLeave += new System.EventHandler(this.Door_Btn_MouseLeave);
            this.Door_Btn.MouseHover += new System.EventHandler(this.Door_Btn_MouseHover);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // Date_btn
            // 
            this.Date_btn.Image = global::RFID_DOOR_APP.Properties.Resources.DATE_BUTTON_NORMAL;
            resources.ApplyResources(this.Date_btn, "Date_btn");
            this.Date_btn.Name = "Date_btn";
            this.Date_btn.TabStop = false;
            this.Date_btn.Click += new System.EventHandler(this.Date_btn_Click);
            this.Date_btn.MouseLeave += new System.EventHandler(this.Date_btn_MouseLeave);
            this.Date_btn.MouseHover += new System.EventHandler(this.Date_btn_MouseHover);
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
            ((System.ComponentModel.ISupportInitialize)(this.Time_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Time_Btn;
        private System.Windows.Forms.PictureBox Door_Btn;
        private System.Windows.Forms.PictureBox Edit_btn;
        private System.Windows.Forms.PictureBox view_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Date_btn;
    }
}