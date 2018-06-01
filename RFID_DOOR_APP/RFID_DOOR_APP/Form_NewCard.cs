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
    public partial class Form_NewCard : Form
    {
        SQL _DB = new SQL();
        public Form_NewCard()
        {
            InitializeComponent();
        }

        private void Form_NewCard_Load(object sender, EventArgs e)
        {
            _DB.Connect();
            show_list();
            reload();
        }

        private void show_list()
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string sql = "select * from NEWCARD";
                _DB.Excute(sql);

                RFID_ComboBox.DisplayMember = "RFID";
                RFID_ComboBox.ValueMember = "RFID";
                RFID_ComboBox.DataSource = _DB.kq;

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
                string sql = "select * from ID_CARD";
                _DB.Excute(sql);

                List_RFID.Items.Clear();
                for (int i = 0; i < _DB.kq.Rows.Count; i++)
                {
                    string data = "";
                    data += _DB.kq.Rows[i][0].ToString() + " ";
                    data += _DB.kq.Rows[i][1].ToString();
                    List_RFID.Items.Add(data);
                }
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }

        private void Add_BTN_Click(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string sql = "insert into ID_CARD values('" + ID.Text + "','" + RFID_ComboBox.Text + "')";
                _DB.Excute(sql);

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "',' Added NewCard " + ID.Text + " " + RFID_ComboBox.Text + "')";
                _DB.Excute(sql);

                sql = "DELETE n1 FROM REPORT n1, REPORT n2 WHERE n1.TimeDo = n2.TimeDo AND n1.ID > n2.ID";
                _DB.Excute(sql);

                sql = "DELETE FROM NEWCARD where RFID = '" + RFID_ComboBox.Text +"'";
                _DB.Excute(sql);

                ID.Text = "";
                reload();
                show_list();
                List_RFID.Text = "";
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
                string ID = List_RFID.GetItemText(List_RFID.SelectedItem);
                string RFID = ID.Substring(ID.IndexOf(" ") + 1, ID.Length - ID.IndexOf(" ") - 1);
                ID = ID.Substring(0, ID.IndexOf(" "));

                string sql = "delete from ID_CARD where ID ='" + ID +"'";
                _DB.Excute(sql);

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "',' Delete Card " + List_RFID.GetItemText(List_RFID.SelectedItem) + "')";
                _DB.Excute(sql);

                sql = "DELETE n1 FROM REPORT n1, REPORT n2 WHERE n1.TimeDo = n2.TimeDo AND n1.ID > n2.ID";
                _DB.Excute(sql);

                sql = "INSERT INTO NEWCARD values('" + RFID +"')";
                _DB.Excute(sql);

                reload();
                show_list();
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
            {
                
            }
        }
    }
}
