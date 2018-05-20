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
    public partial class Form_Edit_User : Form
    {
        SQL _DB = new SQL();
        public Form_Edit_User()
        {
            InitializeComponent();
        }

        private void Delete_Employee_Click(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string ID = List_Template.SelectedItem.ToString();
                ID = ID.Substring(0, ID.IndexOf("."));
                string sql = "delete from NHANVIEN where IDNV = '" + ID + "'";

                _DB.Excute(sql);

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "',' delete " + ID + "')";
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

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string ID_RFID = Employee_RFID_ComboBox.GetItemText(Employee_RFID_ComboBox.SelectedItem);       
                ID_RFID = ID_RFID.Substring(0, ID_RFID.IndexOf(" "));

                string sql = "insert into NHANVIEN values('" + Employee_ID.Text + "','" + Employee_Name.Text + "','" + Employee_Unit.Text + "','" + ID_RFID + "','" + Employee_Pin.Text + "')";
                //MessageBox.Show(ID_RFID);
                //MessageBox.Show(sql);
                _DB.Excute(sql);

                string data = Employee_ID.Text + Employee_Name.Text + Employee_Unit.Text + ID_RFID;

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "',' added Employee " + data + "')";
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

        private void Add_Usage_Click(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string IDNV = List_Usage_ID.GetItemText(List_Usage_ID.SelectedItem);
                string IDDOOR = List_Usage_Door.GetItemText(List_Usage_Door.SelectedItem);
                string IDTIME = List_Usage_Time.GetItemText(List_Usage_Time.SelectedItem);
                string IDDATE = List_Usage_Day.GetItemText(List_Usage_Day.SelectedItem);
                string MODE = Employee_Mode_ComboBox.GetItemText(Employee_Mode_ComboBox.SelectedItem);
                MODE = MODE.Substring(0, MODE.IndexOf("."));
                
                string sql = "insert into USAGE values('" + IDNV + "','" + IDDOOR + "','" + IDTIME + "','" + IDDATE + "','" + MODE + "')";
                //MessageBox.Show(sql);
                _DB.Excute(sql);

                string data = IDNV + " " + IDDOOR + " " + IDTIME + " " + IDDATE + " " + MODE;

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "',' added Usage " + data + "')";
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

        private void Form_Edit_User_Load(object sender, EventArgs e)
        {
            _DB.Connect();
            reload();
            ShowList();
            Read_RFID.Visible = false;
            //Read_RFID.Enabled = false;
        }

        private void ShowList()
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string sql = "select * from NHANVIEN";
                _DB.Excute(sql);

                List_Usage_ID.DisplayMember = "IDNV";
                List_Usage_ID.ValueMember = "IDNV";
                List_Usage_ID.DataSource = _DB.kq;
                List_Usage_ID.SelectedIndex = 0;

                sql = "select * from DOOR";
                _DB.Excute(sql);

                List_Usage_Door.DisplayMember = "IDDOOR";
                List_Usage_Door.ValueMember = "IDDOOR";
                List_Usage_Door.DataSource = _DB.kq;
                List_Usage_Door.SelectedIndex = 0;

                sql = "select * from Time_Template";
                _DB.Excute(sql);

                List_Usage_Time.DisplayMember = "Id";
                List_Usage_Time.ValueMember = "Id";
                List_Usage_Time.DataSource = _DB.kq;

                sql = "select * from Date_Template";
                _DB.Excute(sql);

                List_Usage_Day.DisplayMember = "ID";
                List_Usage_Day.ValueMember = "ID";
                List_Usage_Day.DataSource = _DB.kq;

                Employee_Mode_ComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void reload()
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                // Get all NHANVIEN
                string sql = "select * from NHANVIEN";
                _DB.Excute(sql);

                List_Template.Items.Clear();

                for (int i = 0; i < _DB.kq.Rows.Count; i++)
                {
                    string data = _DB.kq.Rows[i][0].ToString() + ". ";
                    data += _DB.kq.Rows[i][1].ToString() + " ";
                    data += _DB.kq.Rows[i][2].ToString() + " ";
                    data += _DB.kq.Rows[i][3].ToString();

                    List_Template.Items.Add(data);
                }

                //Get all USAGE
                sql = "select * from USAGE";
                _DB.Excute(sql);

                List_Usage.Items.Clear();

                for (int i = 0; i < _DB.kq.Rows.Count; i++)
                {
                    string data = _DB.kq.Rows[i][0].ToString() + " ";
                    data += _DB.kq.Rows[i][1].ToString() + " ";
                    data += _DB.kq.Rows[i][2].ToString() + " ";
                    data += _DB.kq.Rows[i][3].ToString() + " ";
                    data += _DB.kq.Rows[i][4].ToString();

                    List_Usage.Items.Add(data);
                }

                //Get All RFID Information
                sql = "select * from ID_CARD";
                _DB.Excute(sql);

                Employee_RFID_ComboBox.Items.Clear();

                for (int i = 0; i < _DB.kq.Rows.Count; i++)
                {
                    string data = _DB.kq.Rows[i][0].ToString() + " ";
                    data += _DB.kq.Rows[i][1].ToString();

                    Employee_RFID_ComboBox.Items.Add(data);
                }
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void Read_RFID_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Usage_Click(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string ID = List_Usage.GetItemText(List_Usage.SelectedItem);
                while (ID[ID.Length - 1] == ' ')
                    ID = ID.Remove(ID.Length - 1);
                ID = ID.Remove(ID.Length - 2);
                string IDDATE = ID.Substring(ID.LastIndexOf(" ") + 1, ID.Length - ID.LastIndexOf(" ") - 1);
                ID = ID.Remove(ID.LastIndexOf(" "));

                string IDTIME = ID.Substring(ID.LastIndexOf(" ") + 1, ID.Length - ID.LastIndexOf(" ") - 1);
                ID = ID.Remove(ID.LastIndexOf(" "));
                while (ID[ID.Length - 1] == ' ')
                    ID = ID.Remove(ID.Length - 1);

                string IDDOOR = ID.Substring(ID.LastIndexOf(" ") + 1, ID.Length - ID.LastIndexOf(" ") - 1);
                ID = ID.Remove(ID.LastIndexOf(" "));

                string IDNV = ID.Remove(ID.Length - 1);
                //MessageBox.Show(DATE + TIME + DOOR + IDNV);

                string sql = "delete from USAGE where IDNV = '" + IDNV + "' and IDDATE ='" + IDDATE + "' and IDTIME = '" 
                    + IDTIME + "' and IDDOOR = '" + IDDOOR + "'";
                //MessageBox.Show(sql);
                _DB.Excute(sql);

                reload();
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }
    }
}
