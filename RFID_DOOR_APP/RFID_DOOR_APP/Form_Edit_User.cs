﻿using System;
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
                string sql = "insert into NHANVIEN values('" + Employee_ID.Text + "','" + Employee_Name.Text + "','" + Employee_Unit.Text + "','" + Employee_RFID + "')";
                _DB.Excute(sql);

                string data = Employee_ID.Text + Employee_Name.Text + Employee_Unit.Text + Employee_RFID.Text;

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
                string IDNV = List_Usage_ID.SelectedValue.ToString();
                string IDDOOR = List_Usage_Door.SelectedValue.ToString();
                string IDTIME = List_Usage_Time.SelectedValue.ToString();
                string IDDATE = List_Usage_Day.SelectedValue.ToString();
                string sql = "insert into USAGE values('" + IDNV + "','" + IDDOOR + "','" + IDTIME + "','" + IDDATE + "')";

                _DB.Excute(sql);

                string data = IDNV + " " + IDDOOR + " " + IDTIME + " " + IDDATE;

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

                    List_Usage.Items.Add(data);
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

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }
    }
}
