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
        Form_View_Employee MyFormViewEmployee = new Form_View_Employee();
        FormEmployeeAddEM MyFormEmployeeAddEM = new FormEmployeeAddEM();
        Form_Time_Template MyFormTimeTemplate = new Form_Time_Template();
        Form_Door_Template MyFormDoorTemplate = new Form_Door_Template();
        Form_Date_Template MyFormDateTemplate = new Form_Date_Template();
        Form_Edit_User MyFormEditUser = new Form_Edit_User();
        bool time_btn_status, door_btn_status, date_btn_status, view_btn_status, edit_btn_status;
        const int
            TIME = 1,
            DOOR = 2,
            DATE = 3,
            VIEW = 4,
            EDIT = 5;
        public FormEmployee()
        {
            InitializeComponent();
        }
        /************ Variables ***********************
        *
        *
        **********************************************/
        SQL _DB = new SQL();

        private void Time_Btn_MouseHover(object sender, EventArgs e)
        {
            if (time_btn_status == false)
                Time_Btn.Image = Properties.Resources.TIME_BUTTON_HOVER;
        }

        private void Edit_btn_MouseHover(object sender, EventArgs e)
        {
            if (edit_btn_status == false)
                Edit_btn.Image = Properties.Resources.EDIT_BUTTON_HOVER;
        }

        private void Door_Btn_MouseHover(object sender, EventArgs e)
        {
            if (door_btn_status == false)
                Door_Btn.Image = Properties.Resources.DOOR_BUTTON_HOVER;
        }

        private void view_btn_MouseHover(object sender, EventArgs e)
        {
            if (view_btn_status == false)
                view_btn.Image = Properties.Resources.VIEW_BUTTON_HOVER;
        }

        private void Time_Btn_MouseLeave(object sender, EventArgs e)
        {
            if (time_btn_status == false)
                Time_Btn.Image = Properties.Resources.TIME_BUTTON_NORMAL;
        }

        private void Edit_btn_MouseLeave(object sender, EventArgs e)
        {
            if (edit_btn_status == false)
                Edit_btn.Image = Properties.Resources.EDIT_BUTTON_NORMAL;
        }

        private void Door_Btn_MouseLeave(object sender, EventArgs e)
        {
            if (door_btn_status == false)
                Door_Btn.Image = Properties.Resources.DOOR_BUTTON_NORMAL;
        }

        private void view_btn_MouseLeave(object sender, EventArgs e)
        {
            if (view_btn_status == false)
                view_btn.Image = Properties.Resources.VIEW_BUTTON_NORMAL;
        }

        private void Time_Btn_Click(object sender, EventArgs e)
        {
            MyFormEmployeeAdd.FormClosed += ADD_Closed;
            
            SetNormal(TIME);
            Time_Btn.Image = Properties.Resources.TIME_BUTTON_CLICKED;
            time_btn_status = true;
            //MyFormEmployeeAdd = new FormEmployeeAdd();

            MyFormTimeTemplate.Show();
            MyFormDateTemplate.Hide();
            MyFormDoorTemplate.Hide();
            MyFormViewEmployee.Hide();
            MyFormEditUser.Hide();
        }

        private void Door_Btn_Click(object sender, EventArgs e)
        {
            //MyFormDelete.FormClosed += DELETE_Closed;

            SetNormal(DOOR);
            Door_Btn.Image = Properties.Resources.DOOR_BUTTON_CLICKED;
            door_btn_status = true;

            MyFormDoorTemplate = new Form_Door_Template();

            MyFormDoorTemplate.TopLevel = false;
            MyFormDoorTemplate.AutoScroll = true;
            MyFormDoorTemplate.MaximizeBox = true;

            panel2.Controls.Add(MyFormDoorTemplate);

            MyFormTimeTemplate.Hide();
            MyFormDateTemplate.Hide();
            MyFormDoorTemplate.Show();
            MyFormViewEmployee.Hide();
            MyFormEditUser.Hide();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            SetNormal(EDIT);
            edit_btn_status = true;
            Edit_btn.Image = Properties.Resources.EDIT_BUTTON_CLICKED;

            MyFormEditUser = new Form_Edit_User();

            MyFormEditUser.TopLevel = false;
            MyFormEditUser.AutoScroll = true;
            MyFormEditUser.MaximizeBox = true;

            panel2.Controls.Add(MyFormEditUser);
            MyFormTimeTemplate.Hide();
            MyFormDateTemplate.Hide();
            MyFormDoorTemplate.Hide();
            MyFormViewEmployee.Hide();
            MyFormEditUser.Show();
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            SetNormal(VIEW);
            view_btn_status = true;
            view_btn.Image = Properties.Resources.VIEW_BUTTON_CLICKED;

            MyFormEmployeeAdd.Hide();
            MyFormDelete.Hide();

            //MyFormViewEmployee = new FormViewEmployee();
            MyFormViewEmployee.Show();

            MyFormViewEmployee.reload_style();
        }

        private void Date_btn_Click(object sender, EventArgs e)
        {
            SetNormal(DATE);
            Date_btn.Image = Properties.Resources.DATE_BUTTON_CLICKED;
            date_btn_status = true;

            MyFormDateTemplate = new Form_Date_Template();

            MyFormDateTemplate.TopLevel = false;
            MyFormDateTemplate.AutoScroll = true;
            MyFormDateTemplate.MaximizeBox = true;

            panel2.Controls.Add(MyFormDateTemplate);

            MyFormTimeTemplate.Hide();
            MyFormDoorTemplate.Hide();
            MyFormDateTemplate.Show();
            MyFormViewEmployee.Hide();
            MyFormEditUser.Hide();
        }

        private void Date_btn_MouseHover(object sender, EventArgs e)
        {
            if (date_btn_status == false)
                Date_btn.Image = Properties.Resources.DATE_BUTTON_HOVER;
        }

        private void Date_btn_MouseLeave(object sender, EventArgs e)
        {
            if (date_btn_status == false)
                Date_btn.Image = Properties.Resources.DATE_BUTTON_NORMAL;
        }


        void SetNormal(int i)
        {
            switch (i)
            {
                case TIME:
                    Door_Btn.Image = Properties.Resources.DOOR_BUTTON_NORMAL;
                    Date_btn.Image = Properties.Resources.DATE_BUTTON_NORMAL;
                    view_btn.Image = Properties.Resources.VIEW_BUTTON_NORMAL;
                    Edit_btn.Image = Properties.Resources.EDIT_BUTTON_NORMAL;
                    break;
                case DOOR:
                    Time_Btn.Image = Properties.Resources.TIME_BUTTON_NORMAL;
                    Date_btn.Image = Properties.Resources.DATE_BUTTON_NORMAL;
                    view_btn.Image = Properties.Resources.VIEW_BUTTON_NORMAL;
                    Edit_btn.Image = Properties.Resources.EDIT_BUTTON_NORMAL;
                    break;
                case DATE:
                    Door_Btn.Image = Properties.Resources.DOOR_BUTTON_NORMAL;
                    Time_Btn.Image = Properties.Resources.TIME_BUTTON_NORMAL;
                    view_btn.Image = Properties.Resources.VIEW_BUTTON_NORMAL;
                    Edit_btn.Image = Properties.Resources.EDIT_BUTTON_NORMAL;
                    break;
                case VIEW:
                    Door_Btn.Image = Properties.Resources.DOOR_BUTTON_NORMAL;
                    Time_Btn.Image = Properties.Resources.TIME_BUTTON_NORMAL;
                    Edit_btn.Image = Properties.Resources.EDIT_BUTTON_NORMAL;
                    Date_btn.Image = Properties.Resources.DATE_BUTTON_NORMAL;
                    break;
                case EDIT:
                    Door_Btn.Image = Properties.Resources.DOOR_BUTTON_NORMAL;
                    Time_Btn.Image = Properties.Resources.TIME_BUTTON_NORMAL;
                    view_btn.Image = Properties.Resources.VIEW_BUTTON_NORMAL;
                    Date_btn.Image = Properties.Resources.DATE_BUTTON_NORMAL;
                    break;
            };
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
            MyFormTimeTemplate.TopLevel = false;
            MyFormTimeTemplate.AutoScroll = true;
            MyFormDoorTemplate.TopLevel = false;
            MyFormDoorTemplate.AutoScroll = true;

            panel2.Controls.Add(MyFormEmployeeAdd);
            panel2.Controls.Add(MyFormDelete);
            panel2.Controls.Add(MyFormViewEmployee);
            panel2.Controls.Add(MyFormTimeTemplate);
            panel2.Controls.Add(MyFormDoorTemplate);

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
