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
    public partial class Form_SignUp : Form
    {
        SQL _DB = new SQL();
        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {
            _DB.Connect();
        }

        private void UserName_Click(object sender, EventArgs e)
        {
            Location_panel.Height = UserName.Height;
            Location_panel.Top = UserName.Top;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Location_panel.Height = Password.Height;
            Location_panel.Top = Password.Top;
        }

        private void SignUp_Btn_Click(object sender, EventArgs e)
        {
            if ((UserName.Text == "") || (Password.Text == ""))
            {
                MessageBox.Show("Error");
                return;
            }
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string sql = "Insert into USR values('" + UserName.Text + "','" + Password.Text + "')";
                _DB.Excute(sql);

                MessageBox.Show("Successful!");

                DateTime localDate = DateTime.Now;
                sql = @"insert into REPORT values('" + localDate.ToString() + "','Sign Up " + UserName.Text + "')";
                _DB.Excute(sql);

                sql = "DELETE n1 FROM REPORT n1, REPORT n2 WHERE n1.TimeDo = n2.TimeDo AND n1.ID > n2.ID";
                _DB.Excute(sql);
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
            {

            }
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SignUp_Btn.PerformClick();
            }
        }

        private void Password_Validated(object sender, EventArgs e)
        {
            
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            Location_panel.Height = Password.Height;
            Location_panel.Top = Password.Top;
        }

        private void UserName_Enter(object sender, EventArgs e)
        {
            Location_panel.Height = UserName.Height;
            Location_panel.Top = UserName.Top;
        }
    }
}
