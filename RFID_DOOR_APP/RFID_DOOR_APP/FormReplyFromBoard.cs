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
    public partial class FormReplyFromBoard : Form
    {
        private string _data;

        public string data
        {
            get { return _data; }
            set { _data = value; txtContent.Text += value; }
        }
        public FormReplyFromBoard()
        {
            InitializeComponent();
        }

        private void FormReplyFromBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
