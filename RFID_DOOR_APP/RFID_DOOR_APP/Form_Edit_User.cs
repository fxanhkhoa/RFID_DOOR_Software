using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
                string IDNV = Employee_ID.Text;
                string Name = Employee_Name.Text;
                string Department = Employee_Depart_List.Text;
                string Duty = Employee_Duty.Text;
                string Birthday = Employee_Birthday.Value.ToShortDateString();
                string VISA_ID = Employee_VisaID.Text;
                string Gender = Gender_List.Text;
                string Email = Employee_Email.Text;
                string Tel = Employee_Tel.Text;
                string Address = Employee_Address.Text;
                string Pin = Employee_Pin.Text;
                
                string ID_RFID = Employee_RFID_ComboBox.Text;       
                ID_RFID = ID_RFID.Substring(0, ID_RFID.IndexOf(" "));

                // Get ID of DEPARTMENT
                string sql = "select ID from DEPARTMENT where NAME ='" + Department + "'";
                _DB.Excute(sql);

                Department = _DB.kq.Rows[0][0].ToString();

                sql = "insert into NHANVIEN values('" 
                    + IDNV + "','" 
                    + Name + "','" 
                    + Department + "','"
                    + ID_RFID + "','" 
                    + Pin + "','"
                    + Duty + "','"
                    + Birthday + "','"
                    + VISA_ID + "','"
                    + Gender + "','"
                    + Email + "','"
                    + Tel + "','"
                    + Address
                    + "')";
                _DB.Excute(sql);

                string data = Employee_ID.Text + Employee_Name.Text + Employee_Duty.Text + ID_RFID;

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() 
                    + "',' added Employee " + data + "')";
                _DB.Excute(sql);

                sql = "DELETE n1 FROM REPORT n1, REPORT n2 WHERE n1.TimeDo = n2.TimeDo AND n1.ID > n2.ID";
                _DB.Excute(sql);
                reload();
                Clear_Field();
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
                string IDNV = List_Usage_ID.Text;
                string IDDOOR = List_Usage_Door.Text;
                string IDTIME = List_Usage_Time.Text;
                string IDDATE = List_Usage_Day.Text;
                string MODE = Employee_Mode_ComboBox.Text;
                MODE = MODE.Substring(0, MODE.IndexOf("."));
                
                string sql = "insert into USAGE values('" + IDNV + "','" + IDDOOR + "','" + IDTIME + "','" + IDDATE + "','" + MODE + "')";
                //MessageBox.Show(sql);
                _DB.Excute(sql);

                string data = IDNV + " " + IDDOOR + " " + IDTIME + " " + IDDATE + " " + MODE;

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "',' Added Usage " + data + "')";
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
            List_Usage_ID.SelectedIndexChanged -= new EventHandler(this.List_Usage_ID_SelectedIndexChanged);
            _DB.Connect();
            reload();
            ShowList();
            Read_RFID.Visible = false;
            //Read_RFID.Enabled = false;
            List_Usage_ID.SelectedIndexChanged += new EventHandler(this.List_Usage_ID_SelectedIndexChanged);
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
                //List_Usage_ID.SelectedIndex = 0;

                sql = "select * from DOOR";
                _DB.Excute(sql);

                List_Usage_Door.DisplayMember = "IDDOOR";
                List_Usage_Door.ValueMember = "IDDOOR";
                List_Usage_Door.DataSource = _DB.kq;
                //List_Usage_Door.SelectedIndex = 0;

                sql = "select * from Time_Template";
                _DB.Excute(sql);

                List_Usage_Time.DisplayMember = "Id";
                List_Usage_Time.ValueMember = "Id";
                List_Usage_Time.DataSource = _DB.kq;
                //List_Usage_Time.SelectedIndex = 0;

                sql = "select * from Date_Template";
                _DB.Excute(sql);

                List_Usage_Day.DisplayMember = "ID";
                List_Usage_Day.ValueMember = "ID";
                List_Usage_Day.DataSource = _DB.kq;
                //List_Usage_Day.SelectedIndex = 0;

                sql = "select * from DEPARTMENT";
                _DB.Excute(sql);

                Employee_Depart_List.DisplayMember = "NAME";
                Employee_Depart_List.ValueMember = "NAME";
                Employee_Depart_List.DataSource = _DB.kq;
                Employee_Depart_List.SelectedIndex = 0;

                //Employee_Mode_ComboBox.SelectedIndex = 0;
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

        private void Clear_Field()
        {
            Employee_ID.Text = "";
            Employee_Name.Text = "";
            Employee_Depart_List.Text = "";
            Employee_Duty.Text = "";
            Employee_Birthday.Value = DateTime.Now;
            Employee_VisaID.Text = "";
            Gender_List.Text = "";
            Employee_Email.Text = "";
            Employee_Tel.Text = "";
            Employee_Address.Text = "";
            Employee_RFID_ComboBox.Text = "";
            Employee_Pin.Text = "";
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
                while (ID[ID.Length - 1] == ' ')
                    ID = ID.Remove(ID.Length - 1);

                string IDTIME = ID.Substring(ID.LastIndexOf(" ") + 1, ID.Length - ID.LastIndexOf(" ") - 1);
                ID = ID.Remove(ID.LastIndexOf(" "));
                while (ID[ID.Length - 1] == ' ')
                    ID = ID.Remove(ID.Length - 1);

                string IDDOOR = ID.Substring(ID.LastIndexOf(" ") + 1, ID.Length - ID.LastIndexOf(" ") - 1);
                ID = ID.Remove(ID.LastIndexOf(" "));
                while (ID[ID.Length - 1] == ' ')
                    ID = ID.Remove(ID.Length - 1);

                string IDNV = ID;
                //MessageBox.Show(DATE + TIME + DOOR + IDNV);

                string sql = "delete from USAGE where IDNV = '" + IDNV + "' and IDDATE ='" + IDDATE + "' and IDTIME = '" 
                    + IDTIME + "' and IDDOOR = '" + IDDOOR + "'";
                //MessageBox.Show(sql);
                _DB.Excute(sql);

                string data = IDNV + " " + IDDOOR + " " + IDTIME + " " + IDDATE;

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "',' Delete Usage " + data + "')";
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

        private void Employee_RFID_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Duty_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fix_Employee_Click(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string IDNV = Employee_ID.Text;
                string Name = Employee_Name.Text;
                string Department = Employee_Depart_List.Text;
                string Duty = Employee_Duty.Text;
                string Birthday = Employee_Birthday.Value.ToShortDateString();
                string VISA_ID = Employee_VisaID.Text;
                string Gender = Gender_List.Text;
                string Email = Employee_Email.Text;
                string Tel = Employee_Tel.Text;
                string Address = Employee_Address.Text;
                string Pin = Employee_Pin.Text;

                string ID_RFID = Employee_RFID_ComboBox.Text;
                ID_RFID = ID_RFID.Substring(0, ID_RFID.IndexOf(" "));

                string sql = "select ID from DEPARTMENT where NAME ='" + Department +"'";
                _DB.Excute(sql);
                Department = _DB.kq.Rows[0][0].ToString();

                sql = "UPDATE NHANVIEN SET "
                    + "TEN = '" + Name + "', "
                    + "DEPART ='" + Department + "', "
                    + "CARD_ID ='" + ID_RFID + "', "
                    + "PIN = '" + Pin + "', "
                    + "DUTY = '" + Duty + "', "
                    + "BIRTHDAY = '" + Birthday + "', "
                    + "VISA_ID = '" + VISA_ID + "', "
                    + "GENDER ='" + Gender + "', "
                    + "EMAIL ='" + Email + "', "
                    + "TEL = '" + Tel + "', "
                    + "ADDRESS = '" + Address + "' "
                    + "WHERE IDNV = '" + IDNV + "'";

                _DB.Excute(sql);

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "',' Update Info Employee " + IDNV + "')";
                _DB.Excute(sql);

                sql = "DELETE n1 FROM REPORT n1, REPORT n2 WHERE n1.TimeDo = n2.TimeDo AND n1.ID > n2.ID";
                _DB.Excute(sql);

                reload();
                Clear_Field();
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void List_Template_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string ID = List_Template.SelectedItem.ToString();
                ID = ID.Substring(0, ID.IndexOf("."));

                string sql = "select IDNV,TEN,B.NAME,CARD_ID,PIN,DUTY,BIRTHDAY,VISA_ID,GENDER,EMAIL,TEL,ADDRESS "
                    + "from NHANVIEN A, DEPARTMENT B where IDNV = '" + ID + "' and A.DEPART = B.ID";
                _DB.Excute(sql);

                Employee_ID.Text = _DB.kq.Rows[0][0].ToString();
                Employee_Name.Text = _DB.kq.Rows[0][1].ToString();
                Employee_Depart_List.Text = _DB.kq.Rows[0][2].ToString();

                // Get RFID Index
                for (int i = 0; i < Employee_RFID_ComboBox.Items.Count; i++)
                {
                    string id_text = Employee_RFID_ComboBox.GetItemText(Employee_RFID_ComboBox.Items[i]);
                    id_text = id_text.Substring(0, id_text.IndexOf(" "));

                    if (id_text == _DB.kq.Rows[0][3].ToString())
                    {
                        Employee_RFID_ComboBox.SelectedIndex = i;
                        break;
                    }
                }

                Employee_Pin.Text = _DB.kq.Rows[0][4].ToString();
                Employee_Duty.Text = _DB.kq.Rows[0][5].ToString();
                
                //Get Date Off Birth
                DateTime date;
                DateTime.TryParse(_DB.kq.Rows[0][6].ToString(),out date);
                Employee_Birthday.Value = date;

                Employee_VisaID.Text = _DB.kq.Rows[0][7].ToString();
                Gender_List.Text = _DB.kq.Rows[0][8].ToString();
                Employee_Email.Text = _DB.kq.Rows[0][9].ToString();
                Employee_Tel.Text = _DB.kq.Rows[0][10].ToString();
                Employee_Address.Text = _DB.kq.Rows[0][11].ToString();
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void List_Usage_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string IDNV = List_Usage_ID.Text;
                string sql = "select A.TEN, B.NAME, C.ID"
                    + " FROM NHANVIEN A, DEPARTMENT B, ID_CARD C" 
                    + " WHERE A.DEPART = B.ID AND A.CARD_ID = C.ID AND IDNV = '" + IDNV +"'";
                _DB.Excute(sql);

                Usage_Name.Text = _DB.kq.Rows[0][0].ToString();
                Usage_Depart.Text = _DB.kq.Rows[0][1].ToString();
                Usage_Card_ID.Text = _DB.kq.Rows[0][2].ToString();
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            Clear_Field();
        }
    }
}
