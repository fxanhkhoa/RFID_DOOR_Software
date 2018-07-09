﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.ComponentModel;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net;

namespace RFID_DOOR_APP
{
    public class Data_Board 
    {
        SerialPort _Sp = new SerialPort();
        BackgroundWorker BK_data;
        string read_data;
        int new_data = 0;

        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 35;
        private byte[] _buffer = new byte[1024];
        
        List<string> _names = new List<string>();
        Socket socket;

        FormMain fMain;

        DOOR_CHECK DC = new DOOR_CHECK();
        /* public variables */
        //string outputText;

        public Data_Board()
        {
            Init();
        }

        private void Init()
        {
            Global.__ClientSockets = new List<SocketT2h>();
            new_data = 0;
            fMain = (FormMain)Application.OpenForms["FormMain"];
            if (Global.connection_use == 1)
            {
                _Sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SP_Received);
            }
            else
            {
                /* For Client mode */
                ////MessageBox.Show("LAN");
                //BK_data = new BackgroundWorker();
                //BK_data.DoWork += new DoWorkEventHandler(BK_data_Client_DOWORK);
                //BK_data.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BK_data_Client_RunWorkerCompleted);
                //BK_data.RunWorkerAsync();

                /* For Server Mode */
                try
                {
                    Global._serverSocket.Bind(new IPEndPoint(IPAddress.Any, 35));
                    Global._serverSocket.Listen(1);
                    Global._serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
                }
                catch (Exception ex)
                {

                }
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
        private void BK_data_Client_DOWORK(Object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                    read_data = null;
                    new_data = 0;
                    NetworkStream stream = Global.client.GetStream();
                    int i;
                    while ((i = stream.Read(_buffer, 0, _buffer.Length)) != 0)
                    {
                        read_data = System.Text.Encoding.ASCII.GetString(_buffer, 0, i);
                        Global.data_read = read_data;
                        new_data = 1;
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void BK_data_Client_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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

        public void Send(string content)
        {
            byte[] data = Encoding.ASCII.GetBytes(content);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
            Global._serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        private void SendCallback(IAsyncResult AR)
        {
            socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }

        private void AppceptCallback(IAsyncResult ar)
        {
            Socket socket = Global._serverSocket.EndAccept(ar);
            Global.__ClientSockets.Add(new SocketT2h(socket));
            //list_Client.Items.Add(socket.RemoteEndPoint.ToString());

            //lb_soluong.Text = "Số client đang kết nối: " + __ClientSockets.Count.ToString();
            //lb_stt.Text = "Client connected. . .";

            //txtContent.Invoke(new Action(() => txtContent.Text += socket.RemoteEndPoint.ToString() + " " + __ClientSockets.Count.ToString()));
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            Global._serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        private void ReceiveCallback(IAsyncResult ar)
        {

            socket = (Socket)ar.AsyncState;
            if (socket.Connected)
            {
                int received;
                try
                {
                    received = socket.EndReceive(ar);
                }
                catch (Exception)
                {
                    // Client Close socket
                    for (int i = 0; i < Global.__ClientSockets.Count; i++)
                    {
                        if (Global.__ClientSockets[i]._Socket.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            Global.__ClientSockets.RemoveAt(i);
                            //lb_soluong.Text = "Số client đang kết nối: " + __ClientSockets.Count.ToString();
                        }
                    }
                    // xóa trong list
                    return;
                }
                if (received != 0)
                {
                    byte[] dataBuf = new byte[received];
                    Array.Copy(_buffer, dataBuf, received);
                    string text = Encoding.UTF8.GetString(dataBuf);
                    //lb_stt.Text = "Text received: " + text;
                    read_data = text;
                    fMain.Invoke(new Action(() => fMain.data = read_data));

                    /* Process command here */
                    DC.Mode_Process(DC.AT_Check(read_data), read_data);
                                        

                    string reponse = string.Empty;
                    //if (text.Contains("@@"))
                    //{
                    //    for (int i = 0; i < list_Client.Items.Count; i++)
                    //    {
                    //        if (socket.RemoteEndPoint.ToString().Equals(__ClientSockets[i]._Socket.RemoteEndPoint.ToString()))
                    //        {
                    //            list_Client.Items.RemoveAt(i);
                    //            list_Client.Items.Insert(i, text.Substring(1, text.Length - 1));
                    //            __ClientSockets[i]._Name = text;
                    //            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
                    //            return;
                    //        }
                    //    }
                    //}

                    for (int i = 0; i < Global.__ClientSockets.Count; i++)
                    {
                        if (socket.RemoteEndPoint.ToString().Equals(Global.__ClientSockets[i]._Socket.RemoteEndPoint.ToString()))
                        {
                            //rich_Text.AppendText("\n" + __ClientSockets[i]._Name + ": " + text);
                            //txtContent.Invoke(new Action(() => txtContent.Text += __ClientSockets[i]._Name + text + "\n"));
                            //read_data = Global.__ClientSockets[i]._Name + ": " + text;
                            //fMain.Text = read_data;
                        }
                    }



                    if (text == "bye")
                    {
                        return;
                    }
                    //reponse = "server da nhan " + text;
                    //s += "kkk" + '\u0005';
                    //reponse = s;
                    //Sendata(socket, reponse);
                }
                else
                {
                    for (int i = 0; i < Global.__ClientSockets.Count; i++)
                    {
                        if (Global.__ClientSockets[i]._Socket.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            Global.__ClientSockets.RemoveAt(i);
                            //lb_soluong.Text = "Số client đang kết nối: " + __ClientSockets.Count.ToString();
                        }
                    }
                }
            }
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
        }
    }
}
