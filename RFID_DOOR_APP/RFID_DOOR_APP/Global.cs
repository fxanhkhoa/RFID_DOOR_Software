using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

using System.Net;
using System.Net.Sockets;
using System.IO;

namespace RFID_DOOR_APP
{
    class Global
    {
        private static string _COM;
        private static int _BAUD_RATE;
        private static Parity _PARITY;
        private static int _DATABIT;
        private static StopBits _STOPBITS;
        private static SerialPort _sp = new SerialPort();
        private static int _Status;
        private static string _data_read;
        private static int _OK;
        private static TcpClient _client;
        private static StreamReader _STR;
        private static StreamWriter _STW;
        private static string _receive;
        private static string _text_to_send;
        private static int _connection_use;
        private static Socket _server;
        private static IPEndPoint _IP_End;

        public static IPEndPoint IP_End
        {
            get { return _IP_End; }
            set { _IP_End = value; }
        }

        public static Socket server
        {
            get { return _server; }
            set { _server = value; }
        }

        public static int connection_use
        {
            get { return _connection_use; }
            set { _connection_use = value; }
        }

        public static TcpClient client
        {
            get { return _client; }
            set { _client = value; }
        }
        public static StreamReader STR
        {
            get { return _STR; }
            set { _STR = value; }
        }
        public static StreamWriter STW
        {
            get { return _STW; }
            set { _STW = value; }
        }
        public static string receive
        {
            get { return _receive; }
            set { _receive = value; }
        }
        public static string text_to_send
        {
            get { return _text_to_send; }
            set { _text_to_send = value; }
        }

        public static int OK
        {
            get { return _OK; }
            set { _OK = value; }
        }

        public static string data_read
        {
            get { return _data_read; }
            set { _data_read = value; }
        }

        public static int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public static SerialPort Sp
        {
            get { return _sp; }
            set { _sp = value; }
        }

        public static string COM
        {
            get { return _COM; }
            set { _COM = value; }
        }

        public static int BAUD_RATE
        {
            get { return _BAUD_RATE; }
            set { _BAUD_RATE = value; }
        }

        public static Parity PARITY
        {
            get { return _PARITY; }
            set { _PARITY = value; }
        }

        public static int DATABIT
        {
            get { return _DATABIT; }
            set { _DATABIT = value; }
        }

        public static StopBits STOPBITS
        {
            get { return _STOPBITS; }
            set { _STOPBITS = value; }
        }

        /*private static string _globalVar = "";

        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }*/
    }
}
