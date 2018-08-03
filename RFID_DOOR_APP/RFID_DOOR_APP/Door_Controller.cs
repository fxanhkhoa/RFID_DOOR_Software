using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RFID_DOOR_APP
{
    public partial class Door_Controller : UserControl
    {
        SQL _DB = new SQL();
        int IDBOARD;
        string IDDOOR;
        public Door_Controller()
        {
            InitializeComponent();
        }

        public Door_Controller(int IDBOARD, string IDDOOR)
        {
            _DB.Connect();
            InitializeComponent();
            this.IDBOARD = IDBOARD;
            this.IDDOOR = IDDOOR;
            SetName(IDDOOR);
        }

        private void SetName(string Name)
        {
            Door_Name.Text = Name;
        }

        private void Open_Btn_Click(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            Door_Status.Image = Properties.Resources.door_open;
            Text_Status.ForeColor = Color.Green;
            Text_Status.Text = "Opening";

            try
            {
                string sql = "SELECT INDEXNUM FROM DOORTEMPLATE WHERE IDBOARD = " + IDBOARD + " AND IDDOOR = '" + IDDOOR + "'";
                _DB.Excute(sql);

                Byte[] k = new Byte[1];
                k[0] = 99;
                DataProtocol dP = new DataProtocol();
                dP.ID = (Byte)IDBOARD;
                dP.command = DataProtocol.OPEN;
                dP.RFID1 = k;
                dP.RFID2 = k;
                dP.RFID3 = k;
                dP.RFID4 = k;
                dP.door = Convert.ToByte(_DB.kq.Rows[0][0].ToString());

                Global.dataBoard.Send(dP.GetBlockData());
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();

            //Thread.Sleep(2000);
            //Close_Btn.PerformClick();
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            Door_Status.Image = Properties.Resources.Door_Close;
            Text_Status.ForeColor = Color.Red;
            Text_Status.Text = "Closing";
        }
    }
}
