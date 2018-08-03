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
    public partial class Form_View_Employee : Form
    {
        /************ Variables ***********************
        *
        *
        **********************************************/
        SQL _DB = new SQL();
        string sql;
        public Form_View_Employee()
        {
            InitializeComponent();
        }

        private void Form_View_Employee_Load(object sender, EventArgs e)
        {
            _DB.Connect();

            reload();
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
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {

                string sql;
                sql = "select B.TEN, C.NAME, B.CARD_ID, A.MODE, B.PIN, D.IDDOOR, F.Start_Time, F.End_Time, E.DAY"
                    + " from USAGE A, NHANVIEN B, DEPARTMENT C, DOORTEMPLATE D, Date_Template E, Time_Template F "
                    + " where A.IDNV = B.IDNV AND C.ID = B.DEPART AND A.IDDOOR = D.IDDOOR AND A.IDDATE = E.ID"
                    + " AND A.IDTIME = F.Id";

                _DB.Excute(sql);
                employee_data.DataSource = _DB.ds.Tables[0];
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void employee_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
