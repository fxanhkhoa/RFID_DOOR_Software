namespace RFID_DOOR_APP
{
    partial class Door_Environment
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
            this.Temperature = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Door_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Temperature.Location = new System.Drawing.Point(83, 64);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(35, 13);
            this.Temperature.TabIndex = 2;
            this.Temperature.Text = "label1";
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Humidity.Location = new System.Drawing.Point(83, 107);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(35, 13);
            this.Humidity.TabIndex = 3;
            this.Humidity.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RFID_DOOR_APP.Properties.Resources.Humidity_icon;
            this.pictureBox2.Location = new System.Drawing.Point(19, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFID_DOOR_APP.Properties.Resources.Temperature_icon;
            this.pictureBox1.Location = new System.Drawing.Point(19, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Door_Name
            // 
            this.Door_Name.AutoSize = true;
            this.Door_Name.Font = new System.Drawing.Font("LED BOARD REVERSED", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Door_Name.ForeColor = System.Drawing.Color.Green;
            this.Door_Name.Location = new System.Drawing.Point(15, 18);
            this.Door_Name.Name = "Door_Name";
            this.Door_Name.Size = new System.Drawing.Size(105, 19);
            this.Door_Name.TabIndex = 4;
            this.Door_Name.Text = "label1";
            // 
            // Door_Environment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.Door_Name);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Door_Environment";
            this.Size = new System.Drawing.Size(146, 146);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.Label Door_Name;
    }
}
