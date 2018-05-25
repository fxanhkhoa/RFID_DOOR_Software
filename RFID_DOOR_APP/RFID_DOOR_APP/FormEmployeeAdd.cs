using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RFID_DOOR_APP
{
    public partial class FormEmployeeAdd : Form
    {
        string s;
        string[] ID_SEND = new string[20], DOOR_SEND = new string[20], TIME_SEND = new string[20];
        int i, Current_Quantity;
        SQL _DB = new SQL();
        FormEmployeeAddEM myform_1 = new FormEmployeeAddEM();
        FormAddDoor myform_2 = new FormAddDoor();

        public FormEmployeeAdd()
        {
            InitializeComponent();
        }

        public void Eth_read()
        {
            try
            {
                byte[] data = new byte[1024];
                int length = Global.server.Receive(data);
                Global.data_read = Encoding.ASCII.GetString(data, 0, length);
                s = Global.data_read;
                //Invoke(new Action(new Action(() => RFID.Text = s)));
                Invoke(new Action(new Action(() => Noti.Text += s)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string sql;
            /* Table NHANVIEN */
            //sql = "insert into NHANVIEN(IDNV,TEN,DONVI,RFID) values('"+ID.Text+"','"+Ten.Text+"','"+Unit.Text+"','"+RFID.Text+"')";
            
            //_DB.cmd.Parameters.Add("@IDNV", ID.Text);
            //_DB.cmd.Parameters.Add("@TEN", Ten.Text);
            //_DB.cmd.Parameters.Add("@DONVI", Unit.Text);
            //_DB.cmd.Parameters.Add("@RFID", RFID.Text);
            //_DB.Excute(sql);

            /* Table TIME */
            string temp = Time_Use_From.Text + "-" + Time_Use_To.Text;
            sql = "insert into SUDUNG(IDNV,IDDOOR,TIME_USE,DATE_USE) values('"+ID_List.SelectedValue.ToString()+"','"+Door.SelectedValue.ToString()+"','"+temp+"','"+DATE_USE.Text+"')";
            //MessageBox.Show(sql);
            //DATE_USE.Text = sql;
            _DB.Excute(sql);
            ID_SEND[i] = RFID.Text;
            DOOR_SEND[i] = Door.SelectedValue.ToString();
            TIME_SEND[i] = Time_Use_From.SelectedItem.ToString() + "-" + Time_Use_To.SelectedItem.ToString();
            //MessageBox.Show(TIME_SEND[0] + " " + DOOR_SEND[0] + " " + ID_SEND[i]);
            //i++;
            
            DateTime LocalDate = DateTime.Now;
            sql = @"insert into REPORT(Tim/eDo,Task) values('" + LocalDate.ToString() + "','" + "added " + ID_SEND[i] + ", " + DOOR_SEND[i] + ", " + TIME_SEND[i] + "')";
            _DB.Excute(sql);

            MessageBox.Show("Successful!");
        }

        private void Reset_Click(object sender, EventArgs e)
        {
          
        }

        private void Read_RFID_Click(object sender, EventArgs e)
        {
            if (!Global.Sp.IsOpen)
            {
                MessageBox.Show("Check Connection ...");
            }
            else
            {
                Global.Sp.Write("");
            }
        }

        private void FormEmployeeAdd_Load(object sender, EventArgs e)
        {
            string sql;
            i = 0;
            if (Global.Status == 1)
            {
                if ((Global.connection_use == 0))
                {
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker1.WorkerSupportsCancellation = true;
                }

                Global.Sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SP_DataReceived);
            }
            Time_Use_From.SelectedIndex = 0;
            Time_Use_To.SelectedIndex = 0;
            try
            {
                _DB.Connect();
                if (_DB.conn.State != ConnectionState.Open)
                    _DB.Open();
                sql = "select * from DOOR";
                _DB.Excute(sql);
                Door.DisplayMember = "VITRI";
                Door.ValueMember = "IDDOOR";
                Door.DataSource = _DB.kq;
                Door.SelectedIndex = 0;
                //MessageBox.Show(Door.SelectedValue.ToString());

                sql = "select * from NHANVIEN";
                _DB.Excute(sql);
                ID_List.DisplayMember = "IDNV";
                ID_List.ValueMember = "IDNV";
                ID_List.DataSource = _DB.kq;

                ID_List.SelectedIndex = 0;

                sql = "select NHANVIEN.RFID,DOOR.IDDOOR,TIME_USE,DATE_USE from DOOR,NHANVIEN,SUDUNG where DOOR.IDDOOR = SUDUNG.IDDOOR and NHANVIEN.IDNV = SUDUNG.IDNV";
                _DB.Excute(sql);

                Current_Quantity = _DB.kq.Rows.Count;
                //MessageBox.Show(Current_Quantity.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SP_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //char temp;
            //temp = (char)Global.Sp.ReadChar();
            s = Global.data_read;
            Invoke(new Action(new Action(() => Noti.Text += s)));
            if (s.IndexOf("*") >= 0)
            {
                //Invoke(new Action(new Action(() => RFID.Text = s)));
            }
        }

        private void Time_Use_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DATE_USE_Click(object sender, EventArgs e)
        {
            DATE_USE.ForeColor = Color.Black;
            DATE_USE.Text = "";
        }

        private void Send_Click(object sender, EventArgs e)
        {
            //backgroundWorker1.RunWorkerAsync();
            if (Global.connection_use == 1)
            {
                if (!Global.Sp.IsOpen)
                {
                    MessageBox.Show("Check Connection ...");
                }
            }
            else
            {
                
            }
            
                string sql = "select NHANVIEN.RFID,TIME_USE,DOOR.IDDOOR,DATE_USE from DOOR,NHANVIEN,SUDUNG where DOOR.IDDOOR = SUDUNG.IDDOOR and NHANVIEN.IDNV = SUDUNG.IDNV";
                _DB.Excute(sql);
                //MessageBox.Show( _DB.kq.Rows.Count.ToString());
                if (Current_Quantity == _DB.kq.Rows.Count)
                {
                    MessageBox.Show("Nothing to send!!!");
                    return;
                }
                for (int i = 0; i < _DB.kq.Rows.Count - Current_Quantity; i++)
                {
                    //string temp = _DB.kq.Rows[i][0].ToString() + _DB.kq.Rows[i][1].ToString() + _DB.kq.Rows[i][2].ToString() + _DB.kq.Rows[i][3].ToString();
                    if (Global.connection_use == 1)
                    {
                        string temp = ID_SEND[i] + TIME_SEND[i] + DOOR_SEND[i];
                        Global.Sp.Write("AT+IDADD+" + temp + "*");
                        Thread.Sleep(200);
                    }
                    else
                    {
                        string temp = ID_SEND[i] + TIME_SEND[i] + DOOR_SEND[i];
                        //Global.STW.Write("AT+IDADD+" + temp + "*");
                        Global.server.Send(Encoding.ASCII.GetBytes("AT+IDADD+" + temp + "*"));
                        byte[] data = new byte[1024];
                        int length = Global.server.Receive(data);
                        while (length == 0) length = Global.server.Receive(data);
                        Global.data_read = Encoding.ASCII.GetString(data, 0, length);
                        Noti.Text += Global.data_read;
                    }
                }
            
        }

        private void ID_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            string temp = ID_List.SelectedValue.ToString();
            
            sql = "select * from NHANVIEN where IDNV = '" + temp + "'";
            _DB.Excute(sql);
            try
            {
                Name.Text = _DB.kq.Rows[0][1].ToString();
                Unit.Text = _DB.kq.Rows[0][2].ToString();
                RFID.Text = _DB.kq.Rows[0][3].ToString();
            }
            catch
            {

            }
        }

        private void Add_Employ_Click(object sender, EventArgs e)
        {
            //myform_1.Show();
            //myform_1.FormClosed += myform_1_Closed;
            this.Close();
        }

        private void Add_Door_Click(object sender, EventArgs e)
        {
            myform_2.Show();
            myform_2.FormClosed += myform_2_Closed;
        }

        private void myform_1_Closed(object sender, FormClosedEventArgs e)
        {
            myform_1 = new FormEmployeeAddEM();
            reload();
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Global.connection_use == 0)
            {
                byte[] data = new byte[1024];
                int length = Global.server.Receive(data);
                Global.data_read = Encoding.ASCII.GetString(data, 0, length);
                s = Global.data_read;
                //Invoke(new Action(new Action(() => RFID.Text = s)));
                //Invoke(new Action(new Action(() => Noti.Text += s)));
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void FormEmployeeAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Global.Status == 1)
            {
                if (Global.connection_use == 0)
                    backgroundWorker1.CancelAsync();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.backgroundWorker1.RunWorkerAsync();
            if (Global.connection_use == 1)
            {
                Global.Sp.Write("AT+CLEARALL*");
                Thread.Sleep(300);
            }
            else
            {
                //MessageBox.Show("AT+CLEARALL");
                //Global.STW.Write("AT+CLEARALL*");
                Global.server.Send(Encoding.ASCII.GetBytes("AT+CLEARALL*"));
                Thread.Sleep(200);
                //byte[] data = new byte[1024];
                //int length = Global.server.Receive(data);
                //while (length == 0) length = Global.server.Receive(data);
                //Global.data_read = Encoding.ASCII.GetString(data, 0, length);
                //Noti.Text += Global.data_read;
            }
            
            string sql;
            sql = "select NHANVIEN.RFID,TIME_USE,DOOR.IDDOOR,DATE_USE from DOOR,NHANVIEN,SUDUNG where DOOR.IDDOOR = SUDUNG.IDDOOR and NHANVIEN.IDNV = SUDUNG.IDNV";

            _DB.Excute(sql);
            for (int i = 0; i < _DB.kq.Rows.Count; i++)
            {
                if (Global.connection_use == 1)
                {
                    string temp = _DB.kq.Rows[i][0].ToString() + _DB.kq.Rows[i][1].ToString() + _DB.kq.Rows[i][2].ToString() + _DB.kq.Rows[i][3].ToString();
                    Global.Sp.Write("AT+IDADD+" + temp + "*");
                    Thread.Sleep(1000);
                    //MessageBox.Show(temp);
                }
                else
                {
                    ////MessageBox.Show(i.ToString());
                    //string temp = _DB.kq.Rows[i][0].ToString() + _DB.kq.Rows[i][1].ToString() + _DB.kq.Rows[i][2].ToString() + _DB.kq.Rows[i][3].ToString();
                    ////Global.STW.Write("AT+IDADD+" + temp + "*");
                    //Global.server.Send(Encoding.ASCII.GetBytes("AT+IDADD+" + temp + "*"));
                    //byte[] data = new byte[1024];
                    //int length = Global.server.Receive(data);
                    //while (length == 0) length = Global.server.Receive(data);
                    //Global.data_read = Encoding.ASCII.GetString(data, 0, length);
                    //Noti.Text += Global.data_read;
                    ////Thread.Sleep(1000);
                    ////MessageBox.Show(temp);
                }
            }
        }

        private void myform_2_Closed(object sender, FormClosedEventArgs e)
        {
            myform_2 = new FormAddDoor();
            reload();
        }

        private void reload()
        {
            string sql;
            sql = "select * from DOOR";
            _DB.Excute(sql);
            Door.DisplayMember = "VITRI";
            Door.ValueMember = "IDDOOR";
            Door.DataSource = _DB.kq;
            Door.SelectedIndex = 0;
            //MessageBox.Show(Door.SelectedValue.ToString());

            sql = "select * from NHANVIEN";
            _DB.Excute(sql);
            ID_List.DisplayMember = "IDNV";
            ID_List.ValueMember = "IDNV";
            ID_List.DataSource = _DB.kq;

            ID_List.SelectedIndex = 0;
        }
    }
}
