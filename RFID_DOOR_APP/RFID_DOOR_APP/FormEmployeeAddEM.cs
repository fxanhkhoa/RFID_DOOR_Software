using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            s = Global.Sp.ReadExisting();
            //Invoke(new Action(new Action(() => RFID.Text = s)));
            if (s.IndexOf("*") >= 0)
            {
                if (s.IndexOf("K+IDREAD") >= 0)
                {
                    String ID = s.Substring(9, 8);
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
            Global.Sp.Write("AT+IDREAD*");
            Global.Sp.DiscardInBuffer();
            Read_RFID.Text = "Reading...";
        }
    }
}
