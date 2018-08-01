using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_DOOR_APP
{
    class DataProtocol
    {
        public Byte ID;
        public Byte command;
        public Byte[] RFID1 = new Byte[1];
        public Byte[] RFID2 = new Byte[1];
        public Byte[] RFID3 = new Byte[1];
        public Byte[] RFID4 = new Byte[1];
        public Byte door;
        public Byte day;
        public Byte hourFrom;
        public Byte minuteFrom;
        public Byte hourTo;
        public Byte minuteTo;

        public const Byte
            NONE = 0,
            IDCHECK = 1,
            IDADD = 2,
            IDDEL = 3,
            SETDS1307 = 4,
            DS1307 = 5,
            OPEN = 6,
            CLEARALL = 7,
            STOREOK = 8,
            GETINFO = 9,
            SETINFO = 10,
            GETALLRFID = 11;

        public DataProtocol()
        {

        }

        public Byte[] GetBlockData()
        {
            Byte[] outPut = new Byte[12];
            try
            {
                outPut[0] = ID;
                outPut[1] = command;
                outPut[2] = RFID1[0];
                outPut[3] = RFID2[0];
                outPut[4] = RFID3[0];
                outPut[5] = RFID4[0];
                outPut[6] = door;
                outPut[7] = day;
                outPut[8] = hourFrom;
                outPut[9] = minuteFrom;
                outPut[10] = hourTo;
                outPut[11] = minuteTo;
                return outPut;
            }
            catch (Exception ex)
            {

            }
            return outPut;
        }
    }
}
