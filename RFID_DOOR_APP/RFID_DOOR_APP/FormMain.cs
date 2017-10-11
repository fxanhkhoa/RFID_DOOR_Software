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
        }

        /************ Variables ***********************
        *
        *
        **********************************************/
        SQL sql = new SQL(); 

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin myFormLogin = new FormLogin();
            myFormLogin.TopLevel = false;
            myFormLogin.AutoScroll = true;

            User_Control.Controls.Add(myFormLogin);
            myFormLogin.Show();

            Control_BTN.BackColor = Color.Gray;
            Header.BackColor = Color.Gray;
            try
            {
                sql.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
