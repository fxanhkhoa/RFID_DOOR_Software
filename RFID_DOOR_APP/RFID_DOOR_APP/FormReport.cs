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
            reload();
            report_data.DataSource = _DB.ds.Tables[0];
            this.report_data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.report_data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //timer1.Start();
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
            string sql;
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();
            try
            {
                sql = "select TimeDo as Time,Task  from REPORT ORDER BY ID DESC";
                _DB.Excute(sql);
            }
            catch (Exception ex)
            {

            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
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

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                // renew ID
                string sql = "";

                sql = "delete from REPORT where TimeDo < '" + DateTimePick.Value.ToString() +"'";
                _DB.Excute(sql);

                DateTime localDate = DateTime.Now;
                sql = @"insert into REPORT values('" + localDate.ToString() + "','Delete Report from " + DateTimePick.Value.ToString() + "')";
                _DB.Excute(sql);

                sql = "DELETE n1 FROM REPORT n1, REPORT n2 WHERE n1.TimeDo = n2.TimeDo AND n1.ID > n2.ID";
                _DB.Excute(sql);

                reload();
            }
            catch(Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }
    }
}
