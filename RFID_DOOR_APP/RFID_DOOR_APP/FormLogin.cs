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

        private void FormLogin_Load(object sender, EventArgs e)
        {
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
            
            if (Convert.ToInt32(_DB.kq.Rows[0][0]) > 0)
            {
                //FormMain.ActiveForm.Refresh();
                MessageBox.Show(Username_Field.Text+" Login successful");
                this.Close();
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
