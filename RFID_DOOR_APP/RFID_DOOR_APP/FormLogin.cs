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
    public partial class FormLogin : Form
    {
        FormMain myMain;
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private const int cGrip = 16; // Grip size
        private const int cCaption = 32; // Caption bar height
        public FormLogin()
        {
            InitializeComponent();
            /************ Handler ***********************
            *
            *
            **********************************************/
            
        }
        /************ Variables ***********************
        *
        *
        **********************************************/
        SQL _DB = new SQL();
        Form_SignUp MyFormSignUp = new Form_SignUp();

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Username_Field.Select();
            Password_Field.PasswordChar = '*';
            //Login_BTN.Image = Image.FromFile("../pics/door.png");
          
            try
            {
                _DB.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Mail_Picture_Click(object sender, EventArgs e)
        {

        }

        private void Key_Picture_Click(object sender, EventArgs e)
        {

        }

        private void Login_BTN_Click(object sender, EventArgs e)
        {
            string sql;
            if (_DB.conn.State != ConnectionState.Open)
            {
                _DB.Open();
            }
            sql = "select COUNT(*) from USR where ID = '"+Username_Field.Text+"' and PASS ='"+Password_Field.Text+"'";
            _DB.Excute(sql);
            if ((Username_Field.Text == "" ) || (Password_Field.Text == ""))
            {
                MessageBox.Show("Username or Password is empty!");
            }
            else if (Convert.ToInt32(_DB.kq.Rows[0][0]) > 0)
            {
                //FormMain.ActiveForm.Refresh();
                MessageBox.Show(Username_Field.Text+" Login successful");

                // Open Main Form
                RunMainForm();

                DateTime localDate = DateTime.Now;

                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();



                sql = @"insert into REPORT values('" + localDate.ToString() + "','Login as " + Username_Field.Text + "')";
                //MessageBox.Show(sql);
                _DB.Excute(sql);

                sql = "DELETE n1 FROM REPORT n1, REPORT n2 WHERE n1.TimeDo = n2.TimeDo AND n1.ID > n2.ID";
                _DB.Excute(sql);

                //Set global Username
                Global.Username = Username_Field.Text;

                if (_DB.conn.State != ConnectionState.Closed)
                    _DB.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!");
                Username_Field.Text = "";
                Password_Field.Text = "";
            }
        }

        private void RunMainForm()
        {
            myMain = new FormMain();
            myMain.Show();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Password_Field_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login_BTN.PerformClick();
            }
        }

        private void SignUp_Btn_Click(object sender, EventArgs e)
        {
            MyFormSignUp.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
    }
}
