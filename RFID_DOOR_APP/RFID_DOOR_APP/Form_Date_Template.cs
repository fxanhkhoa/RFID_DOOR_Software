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
    public partial class Form_Date_Template : Form
    {
        SQL _DB = new SQL();
        public Form_Date_Template()
        {
            InitializeComponent();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string sql = "insert into Date_Template values('"+ ID.Text + "','" + Days.Text + "')";
                _DB.Excute(sql);

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "',' added " + ID.Text + ", " + label2.Text + "')";
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
                string ID = list_template.Text.Substring(0, list_template.Text.IndexOf("."));
                string sql = "delete from Date_Template where ID = '" + ID + "'";

                _DB.Excute(sql);

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "',' delete " + ID +"')";
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

        private void Form_Date_Template_Load(object sender, EventArgs e)
        {
            _DB.Connect();
            reload();
        }

        private void reload()
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            try
            {
                string sql = "Select * from Date_Template";
                _DB.Excute(sql);

                list_template.Items.Clear();
                for (int i = 0; i < _DB.kq.Rows.Count; i++)
                {
                    string output_text = _DB.kq.Rows[i][0].ToString() + ". ";
                    output_text += _DB.kq.Rows[i][1].ToString();
                    list_template.Items.Add(output_text);
                }
            }
            catch (Exception ex)
            {

            }

            if (_DB.conn.State != ConnectionState.Closed)
                _DB.Close();
        }
    }
}
