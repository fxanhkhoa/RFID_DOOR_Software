using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.ComponentModel;

namespace RFID_DOOR_APP
{
    class Data 
    {
        SerialPort _Sp = new SerialPort();
        string read_data;

        private void Init()
        {
            _Sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SP_Received);
            BackgroundWorker BK_data = new BackgroundWorker();
        }

        private void SP_Received(Object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            read_data = _Sp.ReadLine();
        }

        private void BK_data_DOWORK(Object sender, DoWorkEventArgs e)
        {

        }

        private string get()
        {
            return read_data;
        }

        private void set(string s)
        {
            read_data = s;
        }
    }
}
