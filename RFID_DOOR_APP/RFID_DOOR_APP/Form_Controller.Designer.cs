namespace RFID_DOOR_APP
{
    partial class Form_Controller
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
            this.Controller_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Controller_Panel
            // 
            this.Controller_Panel.AutoScroll = true;
            this.Controller_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controller_Panel.Location = new System.Drawing.Point(0, 0);
            this.Controller_Panel.Name = "Controller_Panel";
            this.Controller_Panel.Size = new System.Drawing.Size(904, 537);
            this.Controller_Panel.TabIndex = 0;
            // 
            // Form_Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 537);
            this.Controls.Add(this.Controller_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Controller";
            this.Text = "Form_Controller";
            this.Load += new System.EventHandler(this.Form_Controller_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Controller_Panel;
    }
}