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
    public partial class Door_Environment : UserControl
    {
        private int _Temperature_Data;
        private int _Humidity_Data;

        public Door_Environment()
        {
            InitializeComponent();
        }

        public Door_Environment(string Name)
        {
            InitializeComponent();
            SetName(Name);
        }

        private void SetName(string Name)
        {
            Door_Name.Text = Name; 
        }

        public int Temperature_Data
        {
            get { return _Temperature_Data; }
            set { _Temperature_Data = value; OnTemperature_Data_Changed(); }
        }

        public int Humidity_Data
        {
            get { return _Humidity_Data; }
            set { _Humidity_Data = value; OnHumidity_Data_Changed(); }
        }

        private void OnTemperature_Data_Changed()
        {
            Temperature.Text = _Temperature_Data.ToString();
        }

        private void OnHumidity_Data_Changed()
        {
            Humidity.Text = _Humidity_Data.ToString();
        }
    }
}
