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
    public partial class FormDelete : Form
    {
        SQL _DB = new SQL();
        string[] ID_SEND = new string[20];
        int count;
        public FormDelete()
        {
            InitializeComponent();
        }

        private void FormDelete_Load(object sender, EventArgs e)
        {
            string sql;
            count = 0;
            try
            {
                _DB.Connect();
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();

                sql = "select * from NHANVIEN";
                _DB.Excute(sql);
                Employee_list.DisplayMember = "TEN";
                Employee_list.ValueMember = "IDNV";
                Employee_list.DataSource = _DB.kq;

                sql = "select * from SUDUNG";
                _DB.Excute(sql);
                Usage_data_grid.DataSource = _DB.ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Usage_Delete_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                //MessageBox.Show(Usage_data_grid.SelectedRows[0].Cells[0].Value.ToString());
                sql = "delete from SUDUNG where IDNV = '" + Usage_data_grid.SelectedRows[0].Cells[0].Value.ToString() + "'";
                _DB.Excute(sql);
                
                MessageBox.Show("Deleted!");
                reload();
            }
            catch
            {
                MessageBox.Show("Please, choose full row!!");
            }

            sql = "delete from SUDUNG where ";
        }

        private void Employee_Delete_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                sql = "delete from NHANVIEN where IDNV = '"+ Employee_list.SelectedValue.ToString() +"'";
                _DB.Excute(sql);
                MessageBox.Show("Deleted!");
                ID_SEND[count] = Employee_list.SelectedValue.ToString();
                count++;
                reload();
            }
            catch
            {
                MessageBox.Show("Must delete in Usage first!");
            }
        }

        private void reload()
        {
            string sql;
            sql = "select * from NHANVIEN";
            _DB.Excute(sql);
            Employee_list.DisplayMember = "TEN";
            Employee_list.ValueMember = "IDNV";
            Employee_list.DataSource = _DB.kq;

            sql = "select * from SUDUNG";
            _DB.Excute(sql);
            Usage_data_grid.DataSource = _DB.ds.Tables[0];
        }

        private void SEND_Click(object sender, EventArgs e)
        {
            if (!(Global.Sp.IsOpen))
            {
                MessageBox.Show("Check Connection again ...");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Global.Sp.Write("AT+IDDEL+" + ID_SEND[i] + "*");
                }
            }
        }
    }
}
