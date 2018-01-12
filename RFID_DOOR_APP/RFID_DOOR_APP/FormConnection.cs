using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

using System.Net;
using System.Net.Sockets;
using System.IO;

namespace RFID_DOOR_APP
{
    public partial class FormConnection : Form
    {
        public FormConnection()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    OWN_IP.Items.Add(address.ToString());
                }
            }
        }

        private void FormConnection_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            PORT.Items.AddRange(ports);
            //PORT.SelectedIndex = 0;
            BAUD_RATE.SelectedIndex = 1;
            Parity.SelectedIndex = 0;
            DATABITS.SelectedIndex = 2;
            STOPBITS.SelectedIndex = 1;
            //this.timer1.Start();

            //Ethernet
            Server.Text = "192.168.1.10";
            Eth_PORT.Text = "35";
        }

        private void Connect_Btn_Click(object sender, EventArgs e)
        {
            Global.Status = 0;
            Global.Sp.PortName = PORT.SelectedItem.ToString();
            Global.Sp.BaudRate = Int32.Parse(BAUD_RATE.SelectedItem.ToString());
            if (Parity.SelectedItem.ToString() == "NONE")
                Global.Sp.Parity = System.IO.Ports.Parity.None;
                

            Global.Sp.DataBits = Convert.ToInt16(DATABITS.SelectedItem.ToString());
            if (STOPBITS.SelectedItem.ToString() == "1")
                Global.Sp.StopBits = StopBits.One;

            Global.Sp.Handshake = Handshake.None;

            try
            {
                Global.Sp.Open();
                Global.Status = 1;
                Global.connection_use = 1;
                MessageBox.Show("Connect Successfully !!!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        /* connect to server */
        private void Ethernet_Click(object sender, EventArgs e)
        {
            Global.client = new TcpClient();
            Global.IP_End = new IPEndPoint(IPAddress.Parse(Server.Text), int.Parse(Eth_PORT.Text));
            Global.server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                Global.server.Connect(Global.IP_End);
                Global.client.Connect(Global.IP_End);
                if (Global.server.Connected)
                {
                    MessageBox.Show("Connected to Server!");

                    Global.STW = new StreamWriter(Global.client.GetStream());
                    Global.STR = new StreamReader(Global.client.GetStream());
                    Global.STW.AutoFlush = true;

                    Global.connection_use = 0;
                    Global.Status = 1;
                    this.Close();
                }
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Time Out!");
            }
        }

        /* receive data  */
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        /* send data */
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btn_CLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConnection_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
