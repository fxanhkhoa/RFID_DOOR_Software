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
    public partial class FormViewEmployee : Form
    {
        /************ Variables ***********************
        *
        *
        **********************************************/
        SQL _DB = new SQL();
        string sql;
        public FormViewEmployee()
        {
            InitializeComponent();
        }

        private void FormViewEmployee_Load(object sender, EventArgs e)
        {
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

        private void reload()
        {
            string sql;
            sql = "select TEN,VITRI,TIME_USE,DATE_USE from DOOR,NHANVIEN,SUDUNG where DOOR.IDDOOR = SUDUNG.IDDOOR and NHANVIEN.IDNV = SUDUNG.IDNV";

            _DB.Excute(sql);
            employee_data.DataSource = _DB.ds.Tables[0];
        }
    }
}
