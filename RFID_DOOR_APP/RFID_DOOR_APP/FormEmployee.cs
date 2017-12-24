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

            MyFormEmployeeAdd = new FormEmployeeAdd();

            MyFormDelete.Hide();
            MyFormEmployeeAdd.Show();
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            MyFormDelete.FormClosed += DELETE_Closed;

            MyFormDelete = new FormDelete();
            MyFormEmployeeAdd.Hide();
            MyFormDelete.Show();
        }

        private void fix_btn_Click(object sender, EventArgs e)
        {

        }

        private void view_btn_Click(object sender, EventArgs e)
        {

        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            string sql;

            MyFormEmployeeAdd.TopLevel = false;
            MyFormEmployeeAdd.AutoScroll = true;
            MyFormDelete.TopLevel = false;
            MyFormDelete.AutoScroll = true;

            employee_data.Controls.Add(MyFormEmployeeAdd);
            employee_data.Controls.Add(MyFormDelete);

            _DB.Connect();

            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                sql = "select TEN,RFID,VITRI,TIME_USE,DATE_USE from DOOR,NHANVIEN,SUDUNG where DOOR.IDDOOR = SUDUNG.IDDOOR and NHANVIEN.IDNV = SUDUNG.IDNV";

                _DB.Excute(sql);
                employee_data.DataSource = _DB.ds.Tables[0];
                employee_data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                employee_data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                employee_data.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                employee_data.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {

            }
        }

        public void reload_style()
        {
            //this.report_data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.report_data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.WindowState = FormWindowState.Maximized;

            for (int i = 0; i < employee_data.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    //MessageBox.Show(i.ToString());
                    this.employee_data.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(210, 249, 209);
                }
                else
                {

                }
            }
        }
        private void ADD_Closed(object sender, FormClosedEventArgs e)
        {
            reload();
           
        }

        private void DELETE_Closed(object sender, FormClosedEventArgs e)
        {
            reload();
            
        }

        private void reload()
        {
            string sql;
            sql = "select TEN,VITRI,TIME_USE,DATE_USE from DOOR,NHANVIEN,SUDUNG where DOOR.IDDOOR = SUDUNG.IDDOOR and NHANVIEN.IDNV = SUDUNG.IDNV";

            _DB.Excute(sql);
            employee_data.DataSource = _DB.ds.Tables[0];
        }
    }
}
