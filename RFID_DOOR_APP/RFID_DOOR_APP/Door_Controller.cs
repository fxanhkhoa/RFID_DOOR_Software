using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_DOOR_APP
{
    public partial class Door_Controller : UserControl
    {
        public Door_Controller()
        {
            InitializeComponent();
        }

        public Door_Controller(string Name)
        {
            InitializeComponent();
            SetName(Name);
        }

        private void SetName(string Name)
        {
            Door_Name.Text = Name;
        }

        private void Open_Btn_Click(object sender, EventArgs e)
        {
            Door_Status.Image = Properties.Resources.door_open;
            Text_Status.ForeColor = Color.Green;
            Text_Status.Text = "Opening";
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            Door_Status.Image = Properties.Resources.Door_Close;
            Text_Status.ForeColor = Color.Red;
            Text_Status.Text = "Closing";
        }
    }
}
