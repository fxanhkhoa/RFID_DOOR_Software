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
        /************ Variables ***********************
        *
        *
        **********************************************/
        SQL _DB = new SQL();
        int report_btn_status, employee_btn_status, time_btn_status, connect_btn_status = 0;
        FormReport MyformReport = new FormReport();
        FormEmployee MyFormEmployee = new FormEmployee();
        FormConnection MyFormConnection = new FormConnection();
        FormEmployeeAddEM MyFormAddEM = new FormEmployeeAddEM();

        Global _global = new Global();
        string s;

        const int
            NONE = 0,
            DOOR_OPENED = 1,
            ID_CHECK = 2,
            ID_READ = 3,
            OK_OPENED = 4;

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
            this.WindowState = FormWindowState.Maximized;

            Title.Visible = true;
            Control_BTN.Visible = true;
            Panel_Header.Visible = true;
            picture_header.Visible = true;
            Control_BTN.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            FormLogin myFormLogin = new FormLogin();
            myFormLogin.TopLevel = false;
            myFormLogin.AutoScroll = true;
            MyFormConnection.TopLevel = false;
            MyFormConnection.AutoScroll = true;
            MyformReport.TopLevel = false;
            MyformReport.AutoScroll = true;
            MyFormEmployee.TopLevel = false;
            MyFormEmployee.AutoScroll = true;
                        
            
            MyFormEmployee.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;


            MyformReport.TopMost = true;
            MyformReport.Dock = DockStyle.Fill;

            myFormLogin.FormClosed += FormLogin_FormClosed;
            MyformReport.FormClosed += FormReport_Formclosed;
            MyFormEmployee.FormClosed += FormEmployee_Formclosed;


            User_Control.Controls.Add(myFormLogin);
            User_Control.Controls.Add(MyFormConnection);
            User_Control.Controls.Add(MyformReport);
            User_Control.Controls.Add(MyFormEmployee);

            myFormLogin.Show();

            Control_BTN.Visible = false;
            Title.Visible = false;
            Panel_Header.Visible = false;
            picture_header.Visible = false;
            try
            {
                _DB.Connect();
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MyformReport.Show();
            MyformReport.Hide();

            MyFormEmployee.Show();
            MyFormEmployee.Hide();

            Global.Sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SP_DataReceived);
        }

        private void SP_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //char temp;
            //temp = (Char) Global.Sp.ReadChar();
            s = Global.Sp.ReadExisting();
            Invoke(new Action(new Action(() => label2.Text = s)));
            Global.data_read = s;
            if (s.IndexOf("*") >= 0)
            {
                int mode = AT_Check(s);
                if (mode == DOOR_OPENED)
                {
                    char door_num = s[12];
                    DateTime LocalDate = DateTime.Now;
                    string sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "','DOOR" + door_num + "OPENED')";
                    _DB.Excute(sql);
                }
                else if (mode == ID_CHECK)
                {
                    //MessageBox.Show("IN");
                    ID_CHECK_OPEN();
                }
                else if (mode == ID_READ)
                {
                    Global.OK = 1;
                }
                else if (mode == OK_OPENED)
                {
                    REPORT_OPEN(s);
                }
            }
        }

        private void REPORT_OPEN(string s)
        {
            string ID = s.Substring(8, 8);
            string DOOR = s.Substring(16, 1);
            DateTime LocalDateTime = DateTime.Now;
            string sql;
            sql = "select B.TEN,C.VITRI from SUDUNG A,NHANVIEN B,DOOR C where C.IDDOOR = A.IDDOOR and A.IDNV = B.IDNV and B.RFID ='" + ID + "' and A.IDDOOR ='" + DOOR + "'";
            //MessageBox.Show(sql);
            _DB.Excute(sql);

            if (_DB.kq.Rows.Count > 0)
            {
                //MessageBox.Show("GOTIT " + DOOR);
                sql = @"insert into REPORT values('" + LocalDateTime.ToString() + "','" + _DB.kq.Rows[0][0].ToString() + " Opened DOOR " + _DB.kq.Rows[0][1].ToString() + "')";
                //MessageBox.Show(sql);
                _DB.Excute(sql);

                sql = "DELETE n1 FROM REPORT n1, REPORT n2 WHERE n1.TimeDo = n2.TimeDo AND n1.ID > n2.ID";
                _DB.Excute(sql);
                
            }
        }

        private void ID_CHECK_OPEN()
        {
            string ID = s.Substring(10, 8);
            string DOOR = s.Substring(18, 1);
            DateTime LocalDateTime = DateTime.Now;
            string sql;

            sql = "select B.TEN,C.VITRI from SUDUNG A,NHANVIEN B,DOOR C where C.IDDOOR = A.IDDOOR and A.IDNV = B.IDNV and B.RFID ='"+ ID + "' and A.IDDOOR ='" + DOOR +"'";
          
            _DB.Excute(sql);

            //MessageBox.Show(_DB.kq.Rows.Count.ToString());

            if (_DB.kq.Rows.Count > 0)
            {
                //MessageBox.Show("GOTIT " + DOOR);
                sql = @"insert into REPORT values('" + LocalDateTime.ToString() + "','" + _DB.kq.Rows[0][0].ToString() + " Opened DOOR " + _DB.kq.Rows[0][1].ToString() + "')";
                //MessageBox.Show(sql);
                _DB.Excute(sql);

                sql = "DELETE n1 FROM REPORT n1, REPORT n2 WHERE n1.TimeDo = n2.TimeDo AND n1.ID > n2.ID";
                _DB.Excute(sql);
                if (DOOR == "1") Global.Sp.Write("AT+OPEN1*");        
                else if (DOOR == "2") Global.Sp.Write("AT+OPEN2*");
                else if (DOOR == "3") Global.Sp.Write("AT+OPEN3*");
                else if (DOOR == "4") Global.Sp.Write("AT+OPEN4*");
            }
        }

        private int AT_Check(string s)
        {
            if (s.IndexOf("OK+DOOROPEN") >= 0)
                return DOOR_OPENED;
            else if (s.IndexOf("AT+IDCHECK") >= 0)
                return ID_CHECK;
            else if (s.IndexOf("OK+IDREAD") >= 0)
                return ID_READ;
            else if (s.IndexOf("OK+OPEN") >= 0)
                return OK_OPENED;
            return 0;
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
            picture_header.Image = Properties.Resources.header_REPORT_A;
            Pic_Normal_All(1);
            form_close_all(1);
            report_btn_status = 1;

           

            MyformReport.Show();

            MyformReport.reload_style();
            
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
            picture_header.Image = Properties.Resources.header_EMPLOYEE;
            employee_btn_status = 1;
            Pic_Normal_All(2);
            form_close_all(2);

            
            MyFormEmployee.Show();

            MyFormEmployee.reload_style();
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
            MyFormConnection.Show();

            MyFormConnection.FormClosed += MyFormConnection_Closed;
            
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            if (connect_btn_status == 0)
                pictureBox5.Image = Image.FromFile("../pics/connection_button_Hover.png");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            byte[] data = new byte[1024];
            int length = Global.server.Receive(data);
            while (length == 0) length = Global.server.Receive(data);
            Global.data_read = Encoding.ASCII.GetString(data, 0, length);
            Invoke(new Action(new Action(() => label2.Text = Global.data_read)));
            s = Global.data_read;
            if (s.IndexOf("*") >= 0)
            {
                int mode = AT_Check(s);
                if (mode == DOOR_OPENED)
                {
                    char door_num = s[12];
                    DateTime LocalDate = DateTime.Now;
                    string sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "','DOOR" + door_num + "OPENED')";
                    _DB.Excute(sql);
                }
                else if (mode == ID_CHECK)
                {
                    //MessageBox.Show("IN");
                    ID_CHECK_OPEN();
                }
                else if (mode == ID_READ)
                {
                    Global.OK = 1;
                }
                else if (mode == OK_OPENED)
                {
                    REPORT_OPEN(s);
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            if (connect_btn_status == 0)
                pictureBox5.Image = Image.FromFile("../pics/connection_button_normal.png");
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            User_Control.Size = new Size(Convert.ToInt16(this.Size.Width), Convert.ToInt16(this.Size.Height));
            MyformReport.reload_style();
            
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
            switch (i)
            {
                case 1:
                    MyFormEmployee.Visible = false;
                    break;
                case 2:
                    MyformReport.Visible = false;
                    break;
                case 3:
                    break;
                case 4:
                    break;
            };
        }

        private void FormReport_Formclosed(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("../pics/report_button_normal.png");
        }

        private void FormEmployee_Formclosed(object sender, EventArgs e)
        {

        }

        private void MyFormConnection_Closed(object sender, EventArgs e)
        {
           MyFormConnection = new FormConnection();
            if (Global.connection_use == 1)
            {
                if (Global.Status == 1)
                {
                    Connection_status.Value = 100;
                    connectStatus_text.Text = "Connecting";
                    connectStatus_text.ForeColor = Color.Green;
                }
            }
            else
            {
                if (Global.Status == 1)
                {
                    Connection_status.Value = 100;
                    connectStatus_text.Text = "Connecting";
                    connectStatus_text.ForeColor = Color.Green;
                }
                backgroundWorker1.RunWorkerAsync(); // Start receiving data in background
                //backgroundWorker2.WorkerSupportsCancellation = true; // Ability to cancel this thread
            }
                pictureBox5.Image = Properties.Resources.connection_button_normal;
        }
    }
}
