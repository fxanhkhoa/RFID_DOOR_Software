using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.ComponentModel;
using System.Net.Sockets;
using System.Windows.Forms;

namespace RFID_DOOR_APP
{
    public class Data_Board 
    {
        SerialPort _Sp = new SerialPort();
        BackgroundWorker BK_data;
        string read_data;
        byte[] bytes = new byte[1024];
        int new_data = 0;

        public Data_Board()
        {
            Init();
        }

        private void Init()
        {
            new_data = 0;
            if (Global.connection_use == 1)
            {
                _Sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SP_Received);
            }
            else
            {
                //MessageBox.Show("LAN");
                BK_data = new BackgroundWorker();
                BK_data.DoWork += new DoWorkEventHandler(BK_data_DOWORK);
                BK_data.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BK_data_RunWorkerCompleted);
                BK_data.RunWorkerAsync();
            }
        }

        private void SP_Received(Object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            read_data = _Sp.ReadLine();
        }

        /**********
        * 1 Thread liên tục kiểm tra và đọc dữ liệu từ cổng Lan
        * 
        **********/
        private void BK_data_DOWORK(Object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                read_data = null;
                new_data = 0;
                NetworkStream stream = Global.client.GetStream();
                int i;
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    read_data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Global.data_read = read_data;
                    new_data = 1;
                }
            }
        }

        private void BK_data_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BK_data.RunWorkerAsync();
        }

        /**********
        * Hàm Get dữ liệu cho Class Data
        * 
        **********/
        public string get()
        {
            return read_data;
        }

        /**********
        * Hàm set dữ liệu cho Class Data
        * 
        **********/
        public void set(string s)
        {
            read_data = s;
        }

        /**********
        * Hàm kiểm tra xem có dữ liệu nhận vào hay không (1/0 : Có/Không)
        * Chỉ sử dụng khi dùng cổng LAN
        **********/
        public int isreceived()
        {
            if (new_data == 1) return 1;
            return 0;
        }

        public void Clear_Received()
        {
            new_data = 0;
        }
    }
}
