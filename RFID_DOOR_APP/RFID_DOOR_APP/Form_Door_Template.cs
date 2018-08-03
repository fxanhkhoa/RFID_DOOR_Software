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
    public partial class Form_Door_Template : Form
    {
        SQL _DB = new SQL();
        public Form_Door_Template()
        {
            InitializeComponent();
        }

        private void Form_Door_Template_Load(object sender, EventArgs e)
        {
            _DB.Connect();
            reload();
            notiLabel.Text = "";
        }

        private void reload()
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            string sql = "select IDBOARD, IDDOOR, INDEXNUM from DOORTEMPLATE";
            try
            {
                list_template.Items.Clear();

                _DB.Excute(sql);
                list_template.Items.Add("IDBOARD --- IDDOOR --- INDEX NUMBER");
                for (int i = 0; i < _DB.kq.Rows.Count; i ++)
                {
                    string output_text = _DB.kq.Rows[i][0].ToString() + ". ";
                    output_text += _DB.kq.Rows[i][1].ToString();
                    output_text += "-" + _DB.kq.Rows[i][2].ToString();
                    list_template.Items.Add(output_text);
                }

                List_Department.Items.Clear();

                sql = "select * from DEPARTMENT";
                _DB.Excute(sql);

                for (int i = 0; i < _DB.kq.Rows.Count; i++)
                {
                    string output_text = _DB.kq.Rows[i][0].ToString() + ". ";
                    output_text += _DB.kq.Rows[i][1];
                    List_Department.Items.Add(output_text);
                }

            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();
            try {
                string sql;
                sql = "insert into DOORTEMPLATE values(" + IDBOARDTextBox.Text + ",N'" + ID.Text + "', " + indexComboBox.Text 
                    + ",'0','0'" + ")";
                _DB.Excute(sql);

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "',' Added Door" + IDBOARDTextBox.Text
                    + ", " + ID.Text + ", " + indexComboBox.Text + "')";
                _DB.Excute(sql);

                sql = "DELETE n1 FROM REPORT n1, REPORT n2 WHERE n1.TimeDo = n2.TimeDo AND n1.ID > n2.ID";
                _DB.Excute(sql);
                reload();
            }
            catch (Exception ex)
            {

            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string ID = list_template.SelectedItem.ToString();
                ID = ID.Substring(0, ID.IndexOf("."));
                string sql = "delete from DOOR where IDDOOR = '" + ID + "'";
                _DB.Excute(sql);

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "',' Delete Door" + ID + "')";
                _DB.Excute(sql);
                reload();

                sql = "DELETE n1 FROM REPORT n1, REPORT n2 WHERE n1.TimeDo = n2.TimeDo AND n1.ID > n2.ID";
                _DB.Excute(sql);
            }
            catch (Exception ex)
            {
                
            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void Depart_Add_Btn_Click(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();
            try
            {
                string sql;
                sql = "insert into DEPARTMENT values(N'" + ID_Department.Text + "',N'" + Name_Department.Text + "')";
                _DB.Excute(sql);

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "',' Added Department" + ID_Department.Text + ", " + Name_Department.Text + "')";
                _DB.Excute(sql);

                sql = "DELETE n1 FROM REPORT n1, REPORT n2 WHERE n1.TimeDo = n2.TimeDo AND n1.ID > n2.ID";
                _DB.Excute(sql);
                reload();
            }
            catch (Exception ex)
            {

            }
            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void Depart_Delete_Btn_Click(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string ID = List_Department.SelectedItem.ToString();
                ID = ID.Substring(0, ID.IndexOf("."));
                string sql = "delete from DEPARTMENT where ID = '" + ID + "'";
                _DB.Excute(sql);

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "',' Delete Department" + ID + "')";
                _DB.Excute(sql);
                reload();

                sql = "DELETE n1 FROM REPORT n1, REPORT n2 WHERE n1.TimeDo = n2.TimeDo AND n1.ID > n2.ID";
                _DB.Excute(sql);
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void IDBOARDTextBox_Enter(object sender, EventArgs e)
        {
            if (IDBOARDTextBox.Text == "Fill this 1st")
            {
                IDBOARDTextBox.Text = "";
                IDBOARDTextBox.ForeColor = Color.Black;
                indexComboBox.Enabled = true;
            }
        }

        private void IDBOARDTextBox_Leave(object sender, EventArgs e)
        {
            if (IDBOARDTextBox.Text == "")
            {
                IDBOARDTextBox.Text = "Fill this 1st";
                IDBOARDTextBox.ForeColor = Color.Gray;
                indexComboBox.Enabled = false;
            }
        }

        private void IDBOARDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                indexComboBox.Items.Clear();
                List<int> indexNumber = new List<int>() { 1, 2, 3, 4 };

                string sql = "select INDEXNUM from DOORTEMPLATE where IDBOARD = " + Convert.ToInt16(IDBOARDTextBox.Text);
                _DB.Excute(sql);

                for (int i = 0; i < _DB.kq.Rows.Count; i++)
                {
                    indexNumber.Remove(Convert.ToInt16(_DB.kq.Rows[i][0]));
                }
                if (indexNumber.Count == 0)
                {
                    notiLabel.ForeColor = Color.Red;
                    notiLabel.Text = "Full";
                }
                else
                {
                    notiLabel.Text = "";
                }
                foreach (int single in indexNumber)
                {
                    indexComboBox.Items.Add(single.ToString());
                }

                indexComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }
    }
}
