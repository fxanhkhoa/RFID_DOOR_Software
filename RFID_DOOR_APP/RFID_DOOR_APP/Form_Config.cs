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
        DataProtocol dP = new DataProtocol();
        private byte[] _IP;
        private string _Port;

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

        public string Port
        {
            get { return _Port; }
            set { _Port = value; portTextBox.Text = value; }
        }

        public Form_Config()
        {
            InitializeComponent();
        }

        private void Form_Config_Load(object sender, EventArgs e)
        {
            GetLocalIPAddress();
            myIPAddressTextBox.Enabled = false;
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
            }
            catch (Exception ex)
            {

            }
        }
    }
}
