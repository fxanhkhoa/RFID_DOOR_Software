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
    public partial class FormEmployee : Form
    {
        FormEmployeeAdd MyFormEmployeeAdd = new FormEmployeeAdd();
        FormDelete MyFormDelete = new FormDelete();
        FormViewEmployee MyFormViewEmployee = new FormViewEmployee();
        FormEmployeeAddEM MyFormEmployeeAddEM = new FormEmployeeAddEM();
        public FormEmployee()
        {
            InitializeComponent();
        }
        /************ Variables ***********************
        *
        *
        **********************************************/
        SQL _DB = new SQL();

        private void Add_Btn_MouseHover(object sender, EventArgs e)
        {
            Add_Btn.Image = Properties.Resources.ADD_BTN_HOVER;
        }

        private void fix_btn_MouseHover(object sender, EventArgs e)
        {
            fix_btn.Image = Properties.Resources.FIX_BTN_HOVER;
        }

        private void Delete_Btn_MouseHover(object sender, EventArgs e)
        {
            Delete_Btn.Image = Properties.Resources.DELETE_BTN_HOVER;
        }

        private void view_btn_MouseHover(object sender, EventArgs e)
        {
            view_btn.Image = Properties.Resources.VIEW_BTN_HOVER;
        }

        private void Add_Btn_MouseLeave(object sender, EventArgs e)
        {
            Add_Btn.Image = Properties.Resources.ADD_BTN;
        }

        private void fix_btn_MouseLeave(object sender, EventArgs e)
        {
            fix_btn.Image = Properties.Resources.FIX_BTN;
        }

        private void Delete_Btn_MouseLeave(object sender, EventArgs e)
        {
            Delete_Btn.Image = Properties.Resources.DELETE_BTN;
        }

        private void view_btn_MouseLeave(object sender, EventArgs e)
        {
            view_btn.Image = Properties.Resources.VIEW_BTN;
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            MyFormEmployeeAdd.FormClosed += ADD_Closed;

            //MyFormEmployeeAdd = new FormEmployeeAdd();

            MyFormDelete.Hide();
            MyFormViewEmployee.Hide();
            MyFormEmployeeAdd.Show();
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            MyFormDelete.FormClosed += DELETE_Closed;

            MyFormDelete = new FormDelete();

            MyFormDelete.TopLevel = false;
            MyFormDelete.AutoScroll = true;
            MyFormDelete.MaximizeBox = true;

            panel2.Controls.Add(MyFormDelete);

            MyFormEmployeeAdd.Hide();
            MyFormViewEmployee.Hide();
            MyFormDelete.Show();
        }

        private void fix_btn_Click(object sender, EventArgs e)
        {

        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            MyFormEmployeeAdd.Hide();
            MyFormDelete.Hide();

            //MyFormViewEmployee = new FormViewEmployee();
            MyFormViewEmployee.Show();

            MyFormViewEmployee.reload_style();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            string sql;

            MyFormEmployeeAdd.TopLevel = false;
            MyFormEmployeeAdd.AutoScroll = true;
            MyFormDelete.TopLevel = false;
            MyFormDelete.AutoScroll = true;
            MyFormViewEmployee.TopLevel = false;
            MyFormViewEmployee.AutoScroll = true;

            panel2.Controls.Add(MyFormEmployeeAdd);
            panel2.Controls.Add(MyFormDelete);
            panel2.Controls.Add(MyFormViewEmployee);

            _DB.Connect();

            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();
        }

        
        private void ADD_Closed(object sender, FormClosedEventArgs e)
        {
            //reload();
            MyFormEmployeeAddEM = new FormEmployeeAddEM();

            MyFormEmployeeAddEM.TopLevel = false;
            MyFormEmployeeAddEM.AutoScroll = true;

            panel2.Controls.Add(MyFormEmployeeAddEM);

            MyFormEmployeeAddEM.FormClosed += MyFormEmployeeAddEM_Closed;

            MyFormEmployeeAddEM.Show();
        }

        private void MyFormEmployeeAddEM_Closed(object sender, FormClosedEventArgs e)
        {
            MyFormEmployeeAdd = new FormEmployeeAdd();

            MyFormEmployeeAdd.TopLevel = false;
            MyFormEmployeeAdd.AutoScroll = true;

            panel2.Controls.Add(MyFormEmployeeAdd);

            MyFormEmployeeAdd.Show();
        }

        private void DELETE_Closed(object sender, FormClosedEventArgs e)
        {
            reload();
            
        }

        private void reload()
        {

        }
    }
}
