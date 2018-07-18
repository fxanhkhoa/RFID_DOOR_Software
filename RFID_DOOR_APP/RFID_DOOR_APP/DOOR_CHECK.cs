using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_DOOR_APP
{
    public class DOOR_CHECK : SQL
    {
        SQL _DB = new SQL();
        const int
            NONE = 0,
            DOOR_OPENED = 1,
            ID_CHECK = 2,
            ID_READ = 3,
            OK_OPENED = 4;

        public DOOR_CHECK()
        {
            _DB.Connect();
            if (_DB.conn.State != System.Data.ConnectionState.Open)
                _DB.Open();
        }

        /************************************
        * Check AT Command from Board
        * Input: string command
        * Output: Mode
        ************************************/
        public int AT_Check(Byte[] buffer)
        {
            switch (buffer[1])
            {
                default:
                    return NONE;
            };
            return 0;
        }

        /************************************
        * Do Each Command in each mode
        * Input: mode (int), string (if use)
        * Output: None
        ************************************/
        public void Mode_Process(int mode, Byte[] buffer)
        {
            if (_DB.conn.State != System.Data.ConnectionState.Open)
                _DB.Open();

            try
            {
                switch (mode)
                {
                    case DataProtocol.OPEN:

                        Byte door_num = buffer[6];
                        DateTime LocalDate = DateTime.Now;

                        //Get Name of Room

                        string sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "','DOOR " + door_num.ToString() + " OPENED')";
                        _DB.Excute(sql);

                        break;
                }
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != System.Data.ConnectionState.Closed)
                _DB.Close();
        }

        private void ID_CHECK_OPEN(string s)
        {
            if (_DB.conn.State != System.Data.ConnectionState.Open)
                _DB.Open();

            try
            {

                string ID = s.Substring(10, 4);
                string DOOR = s.Substring(14, 1);
                DateTime LocalDateTime = DateTime.Now;
                string sql;

                sql = "select B.TEN,C.VITRI from SUDUNG A,NHANVIEN B,DOOR C where C.IDDOOR = A.IDDOOR and A.IDNV = B.IDNV and B.RFID ='" + ID + "' and A.IDDOOR ='" + DOOR + "'";

                _DB.Excute(sql);
                if (_DB.kq.Rows.Count > 0)
                {
                    //MessageBox.Show("GOTIT " + DOOR);
                    sql = @"insert into REPORT values('" + LocalDateTime.ToString() + "','" + _DB.kq.Rows[0][0].ToString() + " Opened DOOR " + _DB.kq.Rows[0][1].ToString() + "')";
                    //MessageBox.Show(sql);
                    _DB.Excute(sql);

                    sql = "DELETE n1 FROM REPORT n1, REPORT n2 WHERE n1.TimeDo = n2.TimeDo AND n1.ID > n2.ID";
                    _DB.Excute(sql);
                    if (DOOR == "1") Global.Sp.Write("AT+OPEN1*");
                    else if (DOOR == "2") Global.Sp.Write("AT+OPEN2*");
                    else if (DOOR == "3") Global.Sp.Write("AT+OPEN3*");
                    else if (DOOR == "4") Global.Sp.Write("AT+OPEN4*");
                }
                else
                {
                    sql = "INSERT into NEWCARD values(' "+ ID + "')";
                    _DB.Excute(sql);
                }
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != System.Data.ConnectionState.Closed)
                _DB.Close();
        }

        /************************************************
        * Put info into database of report which door is opened and who opened
        * Input: String
        * Output: None
        ************************************************/
        private void REPORT_OPEN(string s)
        {
            if (_DB.conn.State != System.Data.ConnectionState.Open)
                _DB.Open();

            try
            {
                string ID = s.Substring(8, 8);
                string DOOR = s.Substring(16, 1);
                DateTime LocalDateTime = DateTime.Now;
                string sql;
                sql = "select B.TEN,C.VITRI from SUDUNG A,NHANVIEN B,DOOR C where C.IDDOOR = A.IDDOOR and A.IDNV = B.IDNV and B.RFID ='" + ID + "' and A.IDDOOR ='" + DOOR + "'";
                //MessageBox.Show(sql);
                _DB.Excute(sql);

                if (_DB.kq.Rows.Count > 0)
                {
                    //MessageBox.Show("GOTIT " + DOOR);
                    sql = @"insert into REPORT values('" + LocalDateTime.ToString() + "','" + _DB.kq.Rows[0][0].ToString() + " Opened DOOR " + _DB.kq.Rows[0][1].ToString() + "')";
                    //MessageBox.Show(sql);
                    _DB.Excute(sql);

                    sql = "DELETE n1 FROM REPORT n1, REPORT n2 WHERE n1.TimeDo = n2.TimeDo AND n1.ID > n2.ID";
                    _DB.Excute(sql);
                }
                else // Add New Card
                {
                    sql = "Insert Into ";
                }
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != System.Data.ConnectionState.Closed)
                _DB.Close();
        }
    }
}
