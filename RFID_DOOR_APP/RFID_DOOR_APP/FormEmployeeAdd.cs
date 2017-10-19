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
    public partial class FormEmployeeAdd : Form
    {
        string s;
        SQL _DB = new SQL();

        public FormEmployeeAdd()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string sql;

            sql = "insert into NHANVIEN(IDNV,TEN,DONVI,RFID) values('"+ID.Text+"','"+Ten.Text+"','"+Unit.Text+"','"+RFID.Text+"')";
            
            //_DB.cmd.Parameters.Add("@IDNV", ID.Text);
            //_DB.cmd.Parameters.Add("@TEN", Ten.Text);
            //_DB.cmd.Parameters.Add("@DONVI", Unit.Text);
            //_DB.cmd.Parameters.Add("@RFID", RFID.Text);
            _DB.Excute(sql);

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ID.Text = "";
            Ten.Text = "";
            Unit.Text = "";
            RFID.Text = "";
        }

        private void Read_RFID_Click(object sender, EventArgs e)
        {
            if (!Global.Sp.IsOpen)
            {
                MessageBox.Show("Check Connection ...");
            }
            else
            {
                Global.Sp.Write("OK+ID+3E2C4F5G*");
            }
        }

        private void FormEmployeeAdd_Load(object sender, EventArgs e)
        {
            Global.Sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SP_DataReceived);
            Time_Use_From.SelectedIndex = 0;
            Time_Use_To.SelectedIndex = 0;
            try
            {
                _DB.Connect();
                if (_DB.conn.State != ConnectionState.Open)
                {
                    _DB.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SP_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            char temp;
            temp = (char)Global.Sp.ReadChar();
            s += temp;
            //Invoke(new Action(new Action(() => RFID.Text = s)));
            if (s[s.Length-1] == '*')
            {
                if (s.IndexOf("OK+ID") >= 0)
                {
                    String ID = s.Substring(6, 8);
                    Invoke(new Action(new Action(() => RFID.Text = ID)));
                    //RFID.Text = ID;
                }
                else
                {
                    s = "";
                }
            }
        }

        private void Time_Use_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
