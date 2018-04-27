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
    public partial class Form_Time_Template : Form
    {
        SQL _DB = new SQL();
        public Form_Time_Template()
        {
            InitializeComponent();
        }

        private void Form_Time_Template_Load(object sender, EventArgs e)
        {
            Start_Time.CustomFormat = "HH:mm";
            Start_Time.ShowUpDown = true;

            End_Time.CustomFormat = "HH:mm";
            End_Time.ShowUpDown = true;

            /************** Connect DB  ****************/
            try
            {
                _DB.Connect();
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();

                // Put current data to List
                string sql = "select Id, Start_Time, End_Time from Time_Template order by Start_Time ASC";
                _DB.Excute(sql);

                list_template.Items.Clear();

                for (int i = 0; i < _DB.kq.Rows.Count; i++)
                {
                    string result = "";
                    result = _DB.kq.Rows[i][0].ToString() + " . ";
                    result = result + _DB.kq.Rows[i][1].ToString() + "--";
                    result = result + _DB.kq.Rows[i][2];
                    list_template.Items.Add(result);
                }

                //MessageBox.Show("Success");
            }
            catch (Exception ex)
            {

            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            //Get Start time
            string Start_time_text = Start_Time.Value.ToString("HH:mm");
                       
            //Get End time
            string End_time_text = End_Time.Value.ToString("HH:mm");

            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            string sql = "insert into Time_Template values('" + ID_Template.Text + "','" + Start_time_text + "','" + End_time_text + "')";
            try
            {
                _DB.Excute(sql);
                //MessageBox.Show("work");
            }
            catch (Exception ex)
            {

            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
            reload();
        }

        void reload()
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();
            // Put current data to List
            string sql = "select Id, Start_Time, End_Time from Time_Template order by Start_Time ASC";
            _DB.Excute(sql);

            list_template.Items.Clear();

            for (int i = 0; i < _DB.kq.Rows.Count; i++)
            {
                string result = "";
                result = _DB.kq.Rows[i][0].ToString() + " . ";
                result = result + _DB.kq.Rows[i][1].ToString() + "--";
                result = result + _DB.kq.Rows[i][2];
                list_template.Items.Add(result);
            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }
    }
}
