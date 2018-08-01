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
        //int report_btn_status, employee_btn_status, control_btn_status, status_btn_status, connect_btn_status = 0;
        FormReport MyformReport = new FormReport();
        FormEmployee MyFormEmployee = new FormEmployee();
        FormConnection MyFormConnection = new FormConnection();
        FormEmployeeAddEM MyFormAddEM = new FormEmployeeAddEM();
        Form_Environment MyFormEnvironment = new Form_Environment();
        Form_Controller MyFormController = new Form_Controller();
        public Form_Config MyFormConfig = new Form_Config();

        Global _global = new Global();
        string s;

        //Data_Board _data_connection;
        DOOR_CHECK _door_check = new DOOR_CHECK();

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private bool resizing = false;
        private Point last = new Point(0, 0);

        private const int cGrip = 16; // Grip size
        private const int cCaption = 32; // Caption bar height

        const int
            NONE = 0,
            DOOR_OPENED = 1,
            ID_CHECK = 2,
            ID_READ = 3,
            OK_OPENED = 4;
        public FormMain()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void moveBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 400;
                mouseY = MousePosition.Y - 20;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void moveBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void moveBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin myFormLogin = new FormLogin();
            myFormLogin.TopLevel = false;
            myFormLogin.AutoScroll = true;
            MyFormConnection.TopLevel = false;
            MyFormConnection.AutoScroll = true;
            MyformReport.TopLevel = false;
            MyformReport.AutoScroll = true;
            MyFormEmployee.TopLevel = false;
            MyFormEmployee.AutoScroll = true;

            try
            {
                _DB.Connect();
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();

                Global.Sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SP_DataReceived);
                label2.MaximumSize = new Size(100, 0);
                label2.AutoSize = true;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            reportButton.PerformClick();
        }

        /*
            Function Name:
            Description: Serial Port receive handler (interrupt)
        */
        private void SP_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //char temp;
            //temp = (Char) Global.Sp.ReadChar();
            s = Global.Sp.ReadExisting();
            Invoke(new Action(new Action(() => label2.Text = s)));
            Global.data_read = s;
            if (s.IndexOf("*") >= 0)
            {
                //int mode = _door_check.AT_Check(s);
                //_door_check.Mode_Process(mode, s);
                //if (mode == DOOR_OPENED)
                //{
                //    char door_num = s[12];
                //    DateTime LocalDate = DateTime.Now;
                //    string sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "','DOOR" + door_num + "OPENED')";
                //    _DB.Excute(sql);
                //}
                //else if (mode == ID_CHECK)
                //{
                //    //MessageBox.Show("IN");
                //    ID_CHECK_OPEN();
                //}
                //else if (mode == ID_READ)
                //{
                //    Global.OK = 1;
                //}
                //else if (mode == OK_OPENED)
                //{
                //    REPORT_OPEN(s);
                //}
            }
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (!resizing) // handle cursor type
            {
                bool resize_x = e.X > (this.Width - 8);
                bool resize_y = e.Y > (this.Height - 8);

                if (resize_x && resize_y)
                    this.Cursor = Cursors.SizeNWSE;
                else if (resize_x)
                    this.Cursor = Cursors.SizeWE;
                else if (resize_y)
                    this.Cursor = Cursors.SizeNS;
                else this.Cursor = Cursors.Default;
            }
            else // handle resize
            {
                int w = this.Size.Width;
                int h = this.Size.Height;

                if (this.Cursor.Equals(Cursors.SizeNWSE))
                    this.Size = new Size(w + (e.Location.X - this.last.X), h + (e.Location.Y - this.last.Y));
                else if (this.Cursor.Equals(Cursors.SizeWE))
                    this.Size = new Size(w + (e.Location.X - this.last.X), h);
                else if (this.Cursor.Equals(Cursors.SizeNS))
                    this.Size = new Size(w, h + (e.Location.Y - this.last.Y));

                this.last = e.Location;
            }
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            this.resizing = true;
            this.last = e.Location;
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            this.resizing = false;
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            // UI
            titleBox.Text = "REPORT";
            selectingBar.Height = reportButton.Height;
            selectingBar.Top = reportButton.Top;

            //Back-end
            form_close_all(1); // Hide others form

            MyformReport.Close();
            MyformReport = new FormReport();
            MyformReport.TopLevel = false;
            MyformReport.AutoScroll = true;

            userControl.Controls.Add(MyformReport);

            MyformReport.Show();

            MyformReport.reload_style();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            // UI
            titleBox.Text = "USER";
            selectingBar.Height = userButton.Height;
            selectingBar.Top = userButton.Top;

            //Back-end
            form_close_all(2);

            MyFormEmployee.Close();
            MyFormEmployee = new FormEmployee();

            MyFormEmployee.TopLevel = false;
            MyFormEmployee.AutoScroll = true;

            userControl.Controls.Add(MyFormEmployee);

            MyFormEmployee.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            // UI
            titleBox.Text = "CONTROl";
            selectingBar.Height = controlButton.Height;
            selectingBar.Top = controlButton.Top;

            //Back-end
            form_close_all(3);

            MyFormController.Close();
            MyFormController = new Form_Controller();

            MyFormController.TopLevel = false;
            MyFormController.AutoScroll = true;

            userControl.Controls.Add(MyFormController);

            MyFormController.Show();
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            // UI
            titleBox.Text = "STATUS";
            selectingBar.Height = statusButton.Height;
            selectingBar.Top = statusButton.Top;

            //Back-end
            form_close_all(4);

            MyFormEnvironment.Close();
            MyFormEnvironment = new Form_Environment();

            MyFormEnvironment.TopLevel = false;
            MyFormEnvironment.AutoScroll = true;

            userControl.Controls.Add(MyFormEnvironment);

            MyFormEnvironment.Show();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            // UI
            titleBox.Text = "CONNECTION";
            selectingBar.Height = connectButton.Height;
            selectingBar.Top = connectButton.Top;

            //Back-end
            form_close_all(5);

            MyFormConnection.Close();
            MyFormConnection = new FormConnection();

            MyFormConnection.TopLevel = false;
            MyFormConnection.AutoScroll = true;

            userControl.Controls.Add(MyFormConnection);

            MyFormConnection.Show();

            MyFormConnection.FormClosed += MyFormConnection_Closed;
            MyFormConnection.FormClosing += MyFormConnection_Closing;

        }

        private void configButton_Click(object sender, EventArgs e)
        {
            // UI
            titleBox.Text = "CONFIG";
            selectingBar.Height = configButton.Height;
            selectingBar.Top = configButton.Top;

            //Back-end
            form_close_all(6);

            MyFormConfig.Close();
            MyFormConfig = new Form_Config();

            MyFormConfig.TopLevel = false;
            MyFormConfig.AutoScroll = true;

            userControl.Controls.Add(MyFormConfig);

            MyFormConfig.Show();
        }

        private void MyFormConnection_Closing(object sender, EventArgs e)
        {
            try
            {
                //_data_connection = new Data_Board();
            }
            catch (Exception ex)
            {

            }
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
            }
        }


















        private void form_close_all(int i)
        {
            switch (i)
            {
                case 1:
                    MyFormEmployee.Visible = false;
                    MyFormController.Visible = false;
                    MyFormConnection.Visible = false;
                    MyFormEnvironment.Visible = false;
                    MyFormConfig.Visible = false;
                    break;
                case 2:
                    MyformReport.Visible = false;
                    MyFormController.Visible = false;
                    MyFormConnection.Visible = false;
                    MyFormEnvironment.Visible = false;
                    MyFormConfig.Visible = false;
                    break;
                case 3:
                    MyformReport.Visible = false;
                    MyFormEmployee.Visible = false;
                    MyFormConnection.Visible = false;
                    MyFormEnvironment.Visible = false;
                    MyFormConfig.Visible = false;
                    break;
                case 4:
                    MyformReport.Visible = false;
                    MyFormEmployee.Visible = false;
                    MyFormController.Visible = false;
                    MyFormConnection.Visible = false;
                    MyFormConfig.Visible = false;
                    break;
                case 5:
                    MyformReport.Visible = false;
                    MyFormEmployee.Visible = false;
                    MyFormController.Visible = false;
                    MyFormEnvironment.Visible = false;
                    MyFormConfig.Visible = false;
                    break;
                case 6:
                    MyformReport.Visible = false;
                    MyFormEmployee.Visible = false;
                    MyFormController.Visible = false;
                    MyFormEnvironment.Visible = false;
                    MyFormConnection.Visible = false;
                    break;
            };
        }

        private string _data;

        public string data
        {
            get { return _data; }
            set { _data = value; label2.Text = value; }
        }
    }
}
