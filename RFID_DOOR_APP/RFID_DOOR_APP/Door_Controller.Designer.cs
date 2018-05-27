namespace RFID_DOOR_APP
{
    partial class Door_Controller
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Door_Name = new System.Windows.Forms.Label();
            this.Text_Status = new System.Windows.Forms.Label();
            this.Door_Status = new System.Windows.Forms.PictureBox();
            this.Open_Btn = new System.Windows.Forms.Button();
            this.Close_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Door_Status)).BeginInit();
            this.SuspendLayout();
            // 
            // Door_Name
            // 
            this.Door_Name.AutoSize = true;
            this.Door_Name.Font = new System.Drawing.Font("LED BOARD REVERSED", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Door_Name.ForeColor = System.Drawing.Color.Green;
            this.Door_Name.Location = new System.Drawing.Point(23, 18);
            this.Door_Name.Name = "Door_Name";
            this.Door_Name.Size = new System.Drawing.Size(105, 19);
            this.Door_Name.TabIndex = 5;
            this.Door_Name.Text = "label1";
            // 
            // Text_Status
            // 
            this.Text_Status.AutoSize = true;
            this.Text_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Text_Status.Location = new System.Drawing.Point(33, 126);
            this.Text_Status.Name = "Text_Status";
            this.Text_Status.Size = new System.Drawing.Size(35, 13);
            this.Text_Status.TabIndex = 6;
            this.Text_Status.Text = "label1";
            // 
            // Door_Status
            // 
            this.Door_Status.Image = global::RFID_DOOR_APP.Properties.Resources.Door_Close;
            this.Door_Status.Location = new System.Drawing.Point(17, 58);
            this.Door_Status.Name = "Door_Status";
            this.Door_Status.Size = new System.Drawing.Size(60, 56);
            this.Door_Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Door_Status.TabIndex = 8;
            this.Door_Status.TabStop = false;
            // 
            // Open_Btn
            // 
            this.Open_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Open_Btn.FlatAppearance.BorderSize = 0;
            this.Open_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Open_Btn.ForeColor = System.Drawing.Color.White;
            this.Open_Btn.Location = new System.Drawing.Point(83, 58);
            this.Open_Btn.Name = "Open_Btn";
            this.Open_Btn.Size = new System.Drawing.Size(50, 23);
            this.Open_Btn.TabIndex = 9;
            this.Open_Btn.Text = "Open";
            this.Open_Btn.UseVisualStyleBackColor = false;
            this.Open_Btn.Click += new System.EventHandler(this.Open_Btn_Click);
            // 
            // Close_Btn
            // 
            this.Close_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close_Btn.FlatAppearance.BorderSize = 0;
            this.Close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close_Btn.ForeColor = System.Drawing.Color.White;
            this.Close_Btn.Location = new System.Drawing.Point(83, 91);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(50, 23);
            this.Close_Btn.TabIndex = 10;
            this.Close_Btn.Text = "Close";
            this.Close_Btn.UseVisualStyleBackColor = false;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // Door_Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Close_Btn);
            this.Controls.Add(this.Open_Btn);
            this.Controls.Add(this.Door_Status);
            this.Controls.Add(this.Text_Status);
            this.Controls.Add(this.Door_Name);
            this.Name = "Door_Controller";
            ((System.ComponentModel.ISupportInitialize)(this.Door_Status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Door_Name;
        private System.Windows.Forms.Label Text_Status;
        private System.Windows.Forms.PictureBox Door_Status;
        private System.Windows.Forms.Button Open_Btn;
        private System.Windows.Forms.Button Close_Btn;
    }
}
