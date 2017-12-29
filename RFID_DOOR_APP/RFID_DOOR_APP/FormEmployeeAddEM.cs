using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RFID_DOOR_APP
{
    public partial class FormEmployeeAddEM : Form
    {
        SQL _DB = new SQL();
        string s = "";
        public FormEmployeeAddEM()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string sql;
            /* Table NHANVIEN */
            sql = "insert into NHANVIEN(IDNV,TEN,DONVI,RFID) values('"+ID.Text+"','"+Ten.Text+"','"+Unit.Text+"','"+RFID.Text+"')";
            _DB.Excute(sql);
            

            DateTime LocalDate = DateTime.Now;
            sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "','added " + ID.Text + ", " + Ten.Text + ", " + Unit.Text + ", " + RFID.Text + "')";
            _DB.Excute(sql);
            MessageBox.Show("Successful!");
        }

        private void FormEmployeeAddEM_Load(object sender, EventArgs e)
        {
            Global.Sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SP_DataReceived);
            try
            {
                _DB.Connect();
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();
            }
            catch
            {

            }
        }

        private void SP_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            char temp;
            //temp = (char)Global.Sp.ReadChar();
            //s += (char)temp;
            //s = Global.Sp.ReadExisting();
            s = Global.data_read;
            //Invoke(new Action(new Action(() => RFID.Text = s)));
            if (s.IndexOf("*") >= 0)
            {
                if (s.IndexOf("OK+IDREAD") >= 0)
                {
                    String ID = s.Substring(10, 8);
                    Invoke(new Action(new Action(() => RFID.Text = ID)));
                    Invoke(new Action(new Action(() => Read_RFID.Text = "Read RFID")));
                }
                else
                {
                    s = "";
                }
            }
        }

        private void Read_RFID_Click(object sender, EventArgs e)
        {
            Global.OK = 0;
            if (Global.connection_use == 1)
            {
                Global.Sp.Write("AT+IDREAD*");
                Global.Sp.DiscardInBuffer();
                Read_RFID.Text = "Reading...";
            }
            else
            {
                Global.STW.Write("AT+IDREAD*");
                backgroundWorker1.RunWorkerAsync();
                Read_RFID.Text = "Reading...";
                Thread.Sleep(1000);
                s = Global.data_read;
                Invoke(new Action(new Action(() => RFID.Text = s)));
                if (s.IndexOf("*") >= 0)
                {
                    if (s.IndexOf("OK+IDREAD") >= 0)
                    {
                        String ID = s.Substring(10, 8);
                        Invoke(new Action(new Action(() => RFID.Text = ID)));
                        Invoke(new Action(new Action(() => Read_RFID.Text = "Read RFID")));
                    }
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Text = "";
            Ten.Text = "";
            Unit.Text = "";
            RFID.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            //while ((Global.data_read == null)) ;
            //while ((Global.data_read.IndexOf("OK+IDREAD") < 0)) ;
            //    if (Global.data_read.IndexOf("OK+IDREAD") >= 0)
            //    {
            //        String ID = Global.data_read.Substring(10, 8);
            //        Invoke(new Action(new Action(() => RFID.Text = ID)));
            //        Invoke(new Action(new Action(() => Read_RFID.Text = "Read RFID")));
            //    }
            
            //try
            //{
            //    byte[] data = new byte[1024];
            //    int length = Global.server.Receive(data);
            //    Global.data_read = Encoding.ASCII.GetString(data, 0, length);
            //    s = Global.data_read;
            //    //Invoke(new Action(new Action(() => RFID.Text = s)));
            //    if (s.IndexOf("*") >= 0)
            //    {
            //        if (s.IndexOf("OK+IDREAD") >= 0)
            //        {
            //            String ID = s.Substring(10, 8);
            //            Invoke(new Action(new Action(() => RFID.Text = ID)));
            //            Invoke(new Action(new Action(() => Read_RFID.Text = "Read RFID")));
            //        }
            //        else
            //        {
            //            s = "";
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
