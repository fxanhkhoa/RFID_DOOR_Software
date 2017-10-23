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
    public partial class FormAddDoor : Form
    {
        SQL _DB = new SQL();
        public FormAddDoor()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "insert into DOOR values(N'" + ID.Text + "',N'" + location.Text + "','DONG')";
            _DB.Excute(sql);
            MessageBox.Show("Successful!");
        }

        private void FormAddDoor_Load(object sender, EventArgs e)
        {
            try
            {
                _DB.Connect();
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();
            }
            catch
            {

            }
        }
    }
}
