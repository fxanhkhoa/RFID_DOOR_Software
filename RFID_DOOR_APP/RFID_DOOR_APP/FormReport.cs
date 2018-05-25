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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        /************ Variables ***********************
        *
        *
        **********************************************/
        SQL _DB = new SQL();

        private void FormReport_Load(object sender, EventArgs e)
        {
            //FormReport.DockPaddingEdges 
            _DB.Connect();

            string sql;
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();
            sql = "select TimeDo as Time,Task  from REPORT ORDER BY ID DESC";
            _DB.Excute(sql);
            report_data.DataSource = _DB.ds.Tables[0];
            this.report_data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.report_data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string sql;
            sql = "select TimeDo as Time,Task  from REPORT ORDER BY ID DESC";
            _DB.Excute(sql);
            report_data.DataSource = _DB.ds.Tables[0];
            this.report_data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.report_data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reload_style();
        }

        private void reload()
        {

        }

        public void reload_style()
        {
            //this.report_data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.report_data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.WindowState = FormWindowState.Maximized;
          
            for (int i = 0; i < report_data.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    //MessageBox.Show(i.ToString());
                    this.report_data.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(210, 249, 209);
                }
                else
                {

                }
            }
        }
    }
}
