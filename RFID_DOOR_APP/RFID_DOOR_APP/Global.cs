using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

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
