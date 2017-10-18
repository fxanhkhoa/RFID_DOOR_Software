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

        public FormEmployeeAdd()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }

        private void Read_RFID_Click(object sender, EventArgs e)
        {
            if (!Global.Sp.IsOpen)
            {
                MessageBox.Show("Check Connection ...");
            }
            else
            {
                
            }
        }

        private void FormEmployeeAdd_Load(object sender, EventArgs e)
        {
            Global.Sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SP_DataReceived);
        }

        private void SP_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            char temp;
            temp = (char)Global.Sp.ReadChar();
            s += temp;
        }
    }
}
