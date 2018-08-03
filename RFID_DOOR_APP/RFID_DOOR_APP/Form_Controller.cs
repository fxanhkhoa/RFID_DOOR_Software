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
    public partial class Form_Controller : Form
    {
        SQL _DB = new SQL();
        Door_Controller[] _Door_Controller = new Door_Controller[100];
        public Form_Controller()
        {
            InitializeComponent();
        }

        private void Form_Controller_Load(object sender, EventArgs e)
        {
            _DB.Connect();
            reload();
        }

        private void reload()
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string sql = "select IDBOARD, IDDOOR from DOORTEMPLATE";
                _DB.Excute(sql);

                for (int i = 0; i < _DB.kq.Rows.Count; i++)
                {
                    _Door_Controller[i] = new Door_Controller((int)_DB.kq.Rows[i][0], _DB.kq.Rows[i][1].ToString());
                    Controller_Panel.Controls.Add(_Door_Controller[i]);
                }
            }
            catch
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }
    }
}
