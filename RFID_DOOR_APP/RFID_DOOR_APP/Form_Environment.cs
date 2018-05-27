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
    public partial class Form_Environment : Form
    {
        SQL _DB = new SQL();
        public Form_Environment()
        {
            InitializeComponent();
        }

        // 
        Door_Environment[] Door = new Door_Environment[100];

        private void Form_Environment_Load(object sender, EventArgs e)
        {
            _DB.Connect();
            reload();
            Timer Data_Update = new Timer();
            Data_Update.Interval = 3000;
            Data_Update.Tick += Data_Update_Tick;
            Data_Update.Start();
        }

        private void reload()
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string sql = "select IDDOOR, TEMPERATURE, HUMIDITY from DOOR";
                _DB.Excute(sql);

                for (int i = 0; i < _DB.kq.Rows.Count; i++)
                {
                    Door[i] = new Door_Environment(_DB.kq.Rows[i][0].ToString());
                    Environment_Panel.Controls.Add(Door[i]);
                }
            }
            catch
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void Data_Update_Tick(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string sql = "select IDDOOR, TEMPERATURE, HUMIDITY from DOOR";
                _DB.Excute(sql);

                for (int i = 0; i < _DB.kq.Rows.Count; i++)
                {
                    Door[i].Temperature_Data = Convert.ToInt16(_DB.kq.Rows[i][1]);
                    Door[i].Humidity_Data = Convert.ToInt16(_DB.kq.Rows[i][2]);
                }
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }
    }
}
