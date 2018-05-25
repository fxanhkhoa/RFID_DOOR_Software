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
        }

        private void reload()
        {
            if (_DB.conn.State != ConnectionState.Open)
                _DB.Open();

            string sql = "select IDDOOR, VITRI from DOOR";
            try
            {
                list_template.Items.Clear();

                _DB.Excute(sql);
                for (int i = 0; i < _DB.kq.Rows.Count; i ++)
                {
                    string output_text = _DB.kq.Rows[i][0].ToString() + ". ";
                    output_text += _DB.kq.Rows[i][1].ToString();
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
                sql = "insert into DOOR values(N'" + ID.Text + "',N'" + location.Text + "','DONG')";
                _DB.Excute(sql);

                DateTime LocalDate = DateTime.Now;
                sql = @"insert into REPORT(TimeDo,Task) values('" + LocalDate.ToString() + "',' Added Door" + ID.Text + ", " + location.Text + "')";
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
    }
}
