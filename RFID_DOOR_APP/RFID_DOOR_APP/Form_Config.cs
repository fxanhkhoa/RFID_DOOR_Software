using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_DOOR_APP
{
    public partial class Form_Config : Form
    {
        SQL _DB = new SQL();
        DataProtocol dP = new DataProtocol();
        private Byte[] _IP;
        private Byte _Port;
        private Byte _idBoard;

        public byte[] IP
        {
            get { return _IP; }
            set
            {
                _IP = value;
                boardIPTextBox1.Text = value[0].ToString();
                boardIPTextBox2.Text = value[1].ToString();
                boardIPTextBox3.Text = value[2].ToString();
                boardIPTextBox4.Text = value[3].ToString();
            }
        }

        public Byte Port
        {
            get { return _Port; }
            set { _Port = value; portTextBox.Text = value.ToString(); }
        }

        public Byte idBoard
        {
            get { return _idBoard; }
            set { _idBoard = value; IDBOARDTextBox.Text = value.ToString(); }
        }

        public Form_Config()
        {
            InitializeComponent();
        }

        private void Form_Config_Load(object sender, EventArgs e)
        {
            _DB.Connect();
            reload();
            GetLocalIPAddress();
            myIPAddressTextBox.Enabled = false;
        }

        private void reload()
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string sql = "SELECT DISTINCT IDBOARD FROM USAGE";
                _DB.Excute(sql);

                IDBOARDComboBox.Items.Clear();
                IDBOARDComboBox.DisplayMember = "IDBOARD";
                IDBOARDComboBox.ValueMember = "IDBOARD";
                IDBOARDComboBox.DataSource = _DB.kq;
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }
        private void GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    myIPAddressTextBox.AppendText(ip.ToString());
                    myIPAddressTextBox.AppendText(Environment.NewLine);
                }
            }
            //throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            dP.ID = Convert.ToByte(IDBOARDComboBox.Text);
            dP.command = DataProtocol.GETINFO;

            Global.dataBoard.Send(dP.GetBlockData());
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            string data = boardIPTextBox1.Text;
            try
            {
                dP.ID = Convert.ToByte(IDBOARDComboBox.Text);
                dP.command = DataProtocol.SETINFO;
                dP.RFID1[0] = (Byte)Convert.ToInt16(boardIPTextBox1.Text);
                dP.RFID2[0] = (Byte)Convert.ToInt16(boardIPTextBox2.Text);
                dP.RFID3[0] = (Byte)Convert.ToInt16(boardIPTextBox3.Text);
                dP.RFID4[0] = (Byte)Convert.ToInt16(boardIPTextBox4.Text);
                dP.door = (Byte)Convert.ToInt16(portTextBox.Text);
                if (IDBOARDChangeCheckBox.Checked == true)
                    dP.day = (Byte)Convert.ToInt16(IDBOARDTextBox.Text);
                else
                    dP.day = dP.ID;
                Global.dataBoard.Send(dP.GetBlockData());
            }
            catch (Exception ex)
            {

            }
        }
    }
}
