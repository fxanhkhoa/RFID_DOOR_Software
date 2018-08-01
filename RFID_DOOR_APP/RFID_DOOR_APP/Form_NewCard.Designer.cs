namespace RFID_DOOR_APP
{
    partial class Form_NewCard
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
            this.RFID_ComboBox = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_BTN = new System.Windows.Forms.Button();
            this.List_RFID = new System.Windows.Forms.ListBox();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.getNewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RFID_ComboBox
            // 
            this.RFID_ComboBox.FormattingEnabled = true;
            this.RFID_ComboBox.Location = new System.Drawing.Point(99, 66);
            this.RFID_ComboBox.Name = "RFID_ComboBox";
            this.RFID_ComboBox.Size = new System.Drawing.Size(120, 21);
            this.RFID_ComboBox.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(99, 40);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(120, 20);
            this.ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RFID";
            // 
            // Add_BTN
            // 
            this.Add_BTN.Location = new System.Drawing.Point(99, 93);
            this.Add_BTN.Name = "Add_BTN";
            this.Add_BTN.Size = new System.Drawing.Size(75, 23);
            this.Add_BTN.TabIndex = 4;
            this.Add_BTN.Text = "Add";
            this.Add_BTN.UseVisualStyleBackColor = true;
            this.Add_BTN.Click += new System.EventHandler(this.Add_BTN_Click);
            // 
            // List_RFID
            // 
            this.List_RFID.FormattingEnabled = true;
            this.List_RFID.Location = new System.Drawing.Point(33, 134);
            this.List_RFID.Name = "List_RFID";
            this.List_RFID.Size = new System.Drawing.Size(186, 95);
            this.List_RFID.TabIndex = 5;
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(33, 235);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_Btn.TabIndex = 6;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // getNewBtn
            // 
            this.getNewBtn.Location = new System.Drawing.Point(180, 93);
            this.getNewBtn.Name = "getNewBtn";
            this.getNewBtn.Size = new System.Drawing.Size(75, 23);
            this.getNewBtn.TabIndex = 7;
            this.getNewBtn.Text = "Get New";
            this.getNewBtn.UseVisualStyleBackColor = true;
            this.getNewBtn.Click += new System.EventHandler(this.getNewBtn_Click);
            // 
            // Form_NewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 286);
            this.Controls.Add(this.getNewBtn);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.List_RFID);
            this.Controls.Add(this.Add_BTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.RFID_ComboBox);
            this.Name = "Form_NewCard";
            this.Text = "Form_NewCard";
            this.Load += new System.EventHandler(this.Form_NewCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RFID_ComboBox;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_BTN;
        private System.Windows.Forms.ListBox List_RFID;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Button getNewBtn;
    }
}