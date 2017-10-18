﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RFID_DOOR_APP
{
    public partial class FormConnection : Form
    {
        public FormConnection()
        {
            InitializeComponent();
        }

        private void FormConnection_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            PORT.Items.AddRange(ports);
            this.timer1.Start();
        }

        private void Connect_Btn_Click(object sender, EventArgs e)
        {
            Global.Status = 0;
            Global.COM = PORT.SelectedItem.ToString();
            Global.Sp.PortName = PORT.SelectedItem.ToString();
            Global.BAUD_RATE = Int32.Parse(BAUD_RATE.SelectedItem.ToString());
            Global.Sp.BaudRate = Int32.Parse(BAUD_RATE.SelectedItem.ToString());
            if (Parity.SelectedItem.ToString() == "NONE")
                Global.Sp.Parity = System.IO.Ports.Parity.None;
                

            Global.DATABIT = Convert.ToInt16(DATABITS.SelectedItem.ToString());
            if (STOPBITS.SelectedItem.ToString() == "1")
                Global.STOPBITS = StopBits.One;

            try
            {
                Global.Sp.Open();
                Global.Status = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
