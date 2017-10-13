using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_DOOR_APP
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            /************ Handler ***********************
            *
            *
            **********************************************/
        }

        void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*********************************
            *
            *
            *********************************/
            Title.Visible = true;
            Control_BTN.Visible = true;
            Control_BTN.BackColor = Color.FromArgb(255, 255, 192);
            //User_Control.BackColor = Color.FromArgb(129, 221, 22); // 129, 221, 22 :green
        }

        /************ Variables ***********************
        *
        *
        **********************************************/
        SQL _DB = new SQL();
        int report_btn_status, employee_btn_status, time_btn_status, connect_btn_status = 0;
               

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            FormLogin myFormLogin = new FormLogin();
            myFormLogin.TopLevel = false;
            myFormLogin.AutoScroll = true;

            myFormLogin.FormClosed += FormLogin_FormClosed;

            User_Control.Controls.Add(myFormLogin);
            myFormLogin.Show();

            Control_BTN.Visible = false;
            Title.Visible = false;
            try
            {
                _DB.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            if (report_btn_status == 0)
            pictureBox2.Image = Image.FromFile("../pics/report_button_Hover.png");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (report_btn_status == 0)
            pictureBox2.Image = Image.FromFile("../pics/report_button_normal.png");
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maximize_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("../pics/report_button_clicked.png");
            Pic_Normal_All(1);
            report_btn_status = 1;

            FormReport MyformReport = new FormReport();
            MyformReport.TopLevel = false;
            MyformReport.AutoScroll = true;

            MyformReport.FormClosed += FormReport_Formclosed;

            User_Control.Controls.Add(MyformReport);
            MyformReport.Show();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            if (employee_btn_status == 0)
                pictureBox3.Image = Image.FromFile("../pics/employee_button_Hover.png");
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            if (employee_btn_status == 0)
                pictureBox3.Image = Image.FromFile("../pics/employee_button_normal.png");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile("../pics/employee_button_clicked.png");
            employee_btn_status = 1;
            Pic_Normal_All(2);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            if (time_btn_status == 0)
                pictureBox4.Image = Image.FromFile("../pics/Time_button_Hover.png");
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            if (time_btn_status == 0)
                pictureBox4.Image = Image.FromFile("../pics/Time_button_normal.png");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Pic_Normal_All(3);
                pictureBox4.Image = Image.FromFile("../pics/Time_button_clicked.png");
            time_btn_status = 1;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Pic_Normal_All(4);
                pictureBox5.Image = Image.FromFile("../pics/connection_button_clicked.png");
            connect_btn_status = 1;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            if (connect_btn_status == 0)
                pictureBox5.Image = Image.FromFile("../pics/connection_button_Hover.png");
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            if (connect_btn_status == 0)
                pictureBox5.Image = Image.FromFile("../pics/connection_button_normal.png");
        }

        private void Pic_Normal_All(int a)
        {
            switch (a)
            {
                case 1:
                    employee_btn_status = 0;
                    time_btn_status = 0;
                    connect_btn_status = 0;
                    pictureBox3.Image = Image.FromFile("../pics/employee_button_normal.png");
                    pictureBox4.Image = Image.FromFile("../pics/Time_button_normal.png");
                    pictureBox5.Image = Image.FromFile("../pics/connection_button_normal.png");
                    break;
                case 2:
                    report_btn_status = 0;
                    time_btn_status = 0;
                    connect_btn_status = 0;
                    pictureBox2.Image = Image.FromFile("../pics/report_button_normal.png");
                    pictureBox4.Image = Image.FromFile("../pics/Time_button_normal.png");
                    pictureBox5.Image = Image.FromFile("../pics/connection_button_normal.png");
                    break;
                case 3:
                    report_btn_status = 0;
                    employee_btn_status = 0;
                    connect_btn_status = 0;
                    pictureBox2.Image = Image.FromFile("../pics/report_button_normal.png");
                    pictureBox3.Image = Image.FromFile("../pics/employee_button_normal.png");
                    pictureBox5.Image = Image.FromFile("../pics/connection_button_normal.png");
                    break;
                case 4:
                    report_btn_status = 0;
                    employee_btn_status = 0;
                    time_btn_status = 0;
                    pictureBox2.Image = Image.FromFile("../pics/report_button_normal.png");
                    pictureBox3.Image = Image.FromFile("../pics/employee_button_normal.png");
                    pictureBox4.Image = Image.FromFile("../pics/Time_button_normal.png");
                    break;
            };
        }

        private void form_close_all(int i)
        {

        }

        private void FormReport_Formclosed(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("../pics/report_button_normal.png");
        }
    }
}
