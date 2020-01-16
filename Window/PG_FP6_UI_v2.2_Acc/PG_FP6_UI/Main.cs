using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using WMPLib;
using Excel = Microsoft.Office.Interop.Excel;

/*
 * http://csharp.net-informations.com/excel/csharp-create-excel.htm
 * http://csharp.net-informations.com/excel/csharp-excel-chart.htm
 * https://thanhkhoait.wordpress.com/2011/11/07/d%E1%BB%8Dc-ghi-file-excel-b%E1%BA%B1ng-c/
 * 
 */
namespace PG_FP6_UI
{
    public partial class Main : Form
    {
       //-----------KHAI BAO CAC CLASS ---------------------///
        Setup Setup = new Setup();
        Data Data;// = new Data(this);
        Autorun autorun = new Autorun();
        Logfile Logfile = new Logfile();

        ModbusRTU MB;
  
        PG_FP6_RS232 PG_FP6_command;
        WindowsMediaPlayer sound = new WindowsMediaPlayer();

        //static Excel._Application Tula_App_Xl = new Microsoft.Office.Interop.Excel.Application();
        //static Excel.Workbook Tula_Workbook = Tula_App_Xl.Workbooks.Add();
        //Excel.Worksheet Tula_Worksheet = (Excel.Worksheet)Tula_Workbook.Sheets.get_Item(1);
        //----------------------------------------------------
        static DateTime dt = DateTime.Now;
        static String dtn = dt.ToShortTimeString();

        string sound_Pass = @"PASS.mp3";
        string sound_NG = @"NG.mp3";
        //string file_path = @"F:\Project\Tula\Meiko\PG_FP6\Code\Window\Datalog";//+ dtn + ".xls");
        //------------------------------ truyen giua cac form ---------------------------------------
        public string strRx;
        public int Account = 0;
        int status_QRcode = 0;
        public Main()
        {
            InitializeComponent();
            Form.CheckForIllegalCrossThreadCalls = false;
            
        }
        public Main(string giatrinhan):this()
        {
            strRx = giatrinhan;
            CodeModel.Text = strRx;
        }
        internal void capnhat_codesetup()
        {
            CodeModel_setup.Text =  strRx;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Data = new Data(this);
            #region Table data struct File name - QR code
            
            Data.table.Columns.Add("CODE", typeof(string));// data type int
            Data.table.Columns.Add("T1", typeof(string));// datatype string
            Data.table.Columns.Add("T2", typeof(string));// data type int
            Data.table.Columns.Add("T3", typeof(string));// data type int


            Data.dataFilemodel.DataSource = Data.table;
            Data.dataFilemodel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            string line = "";
            using (StreamReader SR = new StreamReader("FileModel.txt"))
            {
                while ((line = SR.ReadLine()) != null)
                {
                    string kihieu, macode;
                    macode = line.Substring(0, line.IndexOf(" "));
                    kihieu = line.Substring(line.IndexOf(" ") + 1, line.Length - line.IndexOf(" ") - 1);
                    Data.table.Rows.Add(macode, kihieu);
                }
                Data.dataFilemodel.DataSource = Data.table;
            }
            #endregion

            #region Creat Excel File

            try
            {
                //string filepath =@"C:\Users\HP\Desktop\Logfile\t1.xls";
                string filepath = System.IO.Path.Combine(@"" + PG_FP6_UI.Properties.Settings.Default.pathLogfile, "PGFP6-" + DateTime.Now.ToString("MM-dd-yyyy") + ".xls");
                //MessageBox.Show(filepath.ToString());
                if (System.IO.File.Exists(filepath))
                {
                        MessageBox.Show("PGFP6-" + DateTime.Now.ToString("MM-dd-yyyy") + ".xls" +": Da ton tai");
                }
                else
                {                   
                    Logfile.createExcelfile(filepath);     
                }
                Logfile.openExcel(filepath);
               
            }
            catch
            {
                MessageBox.Show("Warring: Don't Creat Excel file!!");
            }
            #endregion
            // MessageBox.Show("Please setup Port!");

            Setup.ShowDialog();
        }
        private void Init()
        {
            //--------- MODBUS RTU - CPU TULA -------//
        //    MB = new ModbusRTU("COM44", 1, 19200, Parity.None, StopBits.One, 1000);
            try
            {
                MB = new ModbusRTU(Setup.M_com.SelectedItem.ToString(), 1, int.Parse(Setup.M_Baud.SelectedItem.ToString()), Parity.None, StopBits.One, 1000);
                MB.Start();


                //--------- -RS232 - PG - FP6---------- -//
                PG_FP6_command = new PG_FP6_RS232(Setup.P_com.SelectedItem.ToString(), int.Parse(Setup.P_Baud.SelectedItem.ToString()), Parity.None, StopBits.One);
                PG_FP6_command.RtsEnable = true;
                PG_FP6_command.DtrEnable = true;
                PG_FP6_command.ReadBufferSize = 4096;
                PG_FP6_command.ReadTimeout = 1000;
                PG_FP6_command.Start_RS232();


                PG_FP6_command.DataReceived += new SerialDataReceivedEventHandler(RS232_REV);


                //
                //Tula_Worksheet.Name = "Data1";

                //Tula_Worksheet.Cells[1, 1] = "Time";
                //Tula_Worksheet.Cells[1, 2] = "QR Code";
                //Tula_Worksheet.Cells[1, 2] = "Status";

                //--------------- check file name  and checksum file------------------------
                req_checkfilename();
                timer1.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Pleasa check setup port!");
            }
        }
        private void Stop_System()
        {
            MB.Disconnect();
            PG_FP6_command.Close();
            timer1.Enabled = false;

        }
        private void S_system_Click(object sender, EventArgs e)
        {
            if (S_system.ForeColor == Color.Red)
            {
                
                Init();
               if(timer1.Enabled)
                {
                    S_system.ForeColor = Color.Lime;
                    Mbus.Text = "Tula-MCU: " + MB.SerialPort + "-" + MB.Baudrate.ToString();
                    Pbus.Text = "PGFP6     : " + PG_FP6_command.PortName + "-" + PG_FP6_command.BaudRate.ToString();
                }
            }
            else
            {
                S_system.ForeColor = Color.Red;
                Stop_System();
                Mbus.Text = "";
                Pbus.Text = "";
            }


        }
        void AppendText_T(RichTextBox box, Color color, string text)
        {
            int start = box.TextLength;
            box.AppendText(text);
            int end = box.TextLength;

            // Textbox may transform chars, so (end-start) != text.Length
            box.Select(start, end - start);
            {
                box.SelectionColor = color;
                // could set box.SelectionBackColor, box.SelectionFont too.
            }
            box.SelectionLength = 0; // clear
        }
        private void RS232_REV(object sender, SerialDataReceivedEventArgs e)
        {
            //SerialPort sp = (SerialPort)sender;
            try
            {
                string line = PG_FP6_command.ReadExisting();
                
                AppendText_T(Command, Color.Yellow, line);
           
           
            }
            catch
            {

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Data = new Data(this);
            CodeModel_setup.Text = Data.Code_model.Text;


            if(LED_MCU.BackColor == Color.Red)
                LED_MCU.BackColor = Color.DodgerBlue;
            else
                LED_MCU.BackColor = Color.Red;

            if(ModbusRTU.Status_CONN == 1)
            {

            }
            if(ModbusRTU.Status_BUSY == 1)
            {
                Status_PGFP6.BackColor = Color.Yellow;
            }
            else if(ModbusRTU.Status_ERROR == 1)
            {
                Status_PGFP6.BackColor = Color.Red;
            }
            else if(ModbusRTU.Status_PASS == 1)
            {
                Status_PGFP6.BackColor = Color.Lime;
            }
            else
                Status_PGFP6.BackColor = Color.Black;
            //-----------------------------TRANG THAI JIG----------------------------
            if (ModbusRTU.Status_CTHT == 0)
            {
            
                jig_close.Visible = false;
            }
            else
            {
              
                jig_close.Visible = true;
            }

            //---------------------- CHECK FILENAME ------------------
            if (PG_FP6_RS232.Req_Filename > 0)
            {
                PG_FP6_RS232.Req_Filename++;
                if(PG_FP6_RS232.Req_Filename > 10)
                {
                    PG_FP6_RS232.Req_Filename = 0;
                    try
                    {
                        check_Filename();
                    }
                    catch
                    {
                        MessageBox.Show("Check filename error!");
                    }
                    
                    req_checksum_file();

                }
            }
            //--------------------- CHECKSHUM_FILE -------------------
            if (PG_FP6_RS232.Req_Filename == 0 && PG_FP6_RS232.Req_checksum_file > 0)
            {
                PG_FP6_RS232.Req_checksum_file++;
                if (PG_FP6_RS232.Req_checksum_file > 10)
                {
                    PG_FP6_RS232.Req_checksum_file = 0;
                    try
                    {
                        check_sum_file();
                        QR_code.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Checksum file error!!");
                    }

                    try
                    {
                        MB.WriteSingleRegister(ModbusRTU.ADD_CLR, 1);
                    }
                    catch
                    { }
                    Start.Enabled = true;
                    CLR.Enabled = true;
                }
            }      
            //-------------------- checksum MCU ----------------------
            if (PG_FP6_RS232.Req_checksum_MCU == 1 && (Status_PGFP6.Text == "PASS" || Status_PGFP6.Text == "ERROR"))
            {
                PG_FP6_RS232.Req_checksum_MCU = 0;
                if(Status_PGFP6.Text == "PASS")
                    checksum_MCU();
                if (Status_PGFP6.Text == "ERROR") // NG
                {
                    PG_FP6_RS232.num_ERROR++;
                    Box_NG.Text = PG_FP6_RS232.num_ERROR.ToString();
                }
                PG_FP6_RS232.num_Sum = PG_FP6_RS232.num_ERROR + PG_FP6_RS232.num_Pass;
                Box_Sum.Text = PG_FP6_RS232.num_Sum.ToString();
            
               
            }
            //--------------------------------------------------------------
            if (Status_PGFP6.Text == "BUSY")
                Start.Enabled = false;
            else
                Start.Enabled = true;

        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Setup.ShowDialog();
        }

        private void send_Click(object sender, EventArgs e)
        {
            Send_Command();
        }

        void Send_Command()
        {
            String data = Command_send.Text + "\r\n";
            PG_FP6_command.Write(data);
            AppendText_T(Command, Color.Red, "[" + dtn + "] " + "Sent: " + data);
        }
        void CheckFile_Exist()
        {
            string file_name1 = System.IO.Path.Combine(@"F:\Project\Tula\Meiko\PG_FP6\Code\Window\Datalog","Data-" + DateTime.Now.ToString("MM-dd-yyyy-hh-mm") + ".xls");
            if (!System.IO.File.Exists(file_name1))
           // if (!System.IO.File.Exists(@"F:\Project\Tula\Meiko\PG_FP6\Code\Window\Datalog\" + "[" + dtn + "]" + ".xls"))
            {
                MessageBox.Show("Data-" + DateTime.Now.ToString("MM-dd-yyyy-hh-mm") + ".xls" +":File chua tao");
            }
            else 
            {
                MessageBox.Show("Data-" + DateTime.Now.ToString("MM-dd-yyyy-hh-mm") + ".xls" +":File ton tai");
            }
        }
        //void Write_Excel()
        //{
            
        //    if (Tula_App_Xl == null)
        //    {
        //        MessageBox.Show("Excel is not properly installed!!");
        //        return;

        //    }
        //    else
        //    {
        //        try
        //        {

        //        string file_name2 = System.IO.Path.Combine(@"F:\Project\Tula\Meiko\PG_FP6\Code\Window\Datalog","Data-" + DateTime.Now.ToString("MM-dd-yyyy-hh-mm") + ".xls");
        //        //string file_name = string.Format("{0}-{1:ddMMMyyyy-HHmm}.xls", @"F:\Project\Tula\Meiko\PG_FP6\Code\Window\Datalog\Data", DateTime.Now);
        //        Tula_Workbook.SaveAs(file_name2, Excel.XlFileFormat.xlWorkbookNormal);

        //        }
        //        catch
        //        {

        //        }
        //        //Tula_Workbook.Close();
        //        //Tula_App_Xl.Quit();
        //        //System.Runtime.InteropServices.Marshal.FinalReleaseComObject(Tula_Worksheet);
        //        //System.Runtime.InteropServices.Marshal.FinalReleaseComObject(Tula_Workbook);
        //        //System.Runtime.InteropServices.Marshal.FinalReleaseComObject(Tula_App_Xl);

        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            CheckFile_Exist();
        }

        private void Command_TextChanged(object sender, EventArgs e)
        {
            Command.SelectionStart = Command.Text.Length;
            Command.ScrollToCaret();
        }



        private void Start_Click(object sender, EventArgs e)
        {
  
         //   Write_Excel();
          //  MB.WriteSingleRegister(ModbusRTU.ADD_CLR, 1);
            Start_dowload();
        }
        void Start_dowload()
        {
            if (S_system.ForeColor == Color.Lime)
            {
                if (QR_code.Text != "" && status_QRcode == 1)
                {
                    try
                    {
                        //Status_PGFP6.BackColor = Color.LightBlue;
                        Status_PGFP6.Text = "";
                        checksumMCU.Text = "";
                        checksumMCU.BackColor = Color.Black;
                        Dowload_MCU();
                        PG_FP6_RS232.Req_checksum_MCU = 1;
                    }
                    catch
                    {

                    }
                }
                else
                    MessageBox.Show("Please Scan QRcode!");
            }
            
        }
        private void Dowload_MCU()
        {
            //Command.Text = "";
            PG_FP6_command.Write("ep\r\n");
        }
        private void CLR_Click(object sender, EventArgs e)
        {
            //QR_code.Clear();
            try
            {
                MB.WriteSingleRegister(ModbusRTU.ADD_CLR, 1);

            }
            catch
            {

            }
        }

        private void Status_PGFP6_BackColorChanged(object sender, EventArgs e)
        {

            if (Status_PGFP6.BackColor == Color.Lime)
            {
                Status_PGFP6.Text = "PASS";
                sound.URL = sound_Pass;
                sound.controls.play();
            }
            if (Status_PGFP6.BackColor == Color.Yellow)
                Status_PGFP6.Text = "BUSY";
            if (Status_PGFP6.BackColor == Color.Red)
            {
                Status_PGFP6.Text = "ERROR";
                sound.URL = sound_NG;
                sound.controls.play();
            }
            if(Status_PGFP6.BackColor == Color.Black)
            {
                Status_PGFP6.Text = "";
            }
            #region LOGDATA to Excel File

            if(Status_PGFP6.Text == "PASS" || Status_PGFP6.Text =="ERROR")
            {
                Logfile.addDataToExcel(Logfile.Rownumber.ToString(),QR_code.Text, Status_PGFP6.Text, DateTime.Now.ToString("MM-dd-yyyy-HH:mm:ss"), " ");
                //WriteLogFile.WriteLogtxt("PGFP6-" + DateTime.Now.ToString("MM-dd-yyyy") + ".txt",
                //                        String.Format("{0}  {1}  {2}", QR_code.Text, Status_PGFP6.Text, DateTime.Now.ToString("MM-dd-yyyy-HH:mm:ss")));
 
                this.QR_code.TextChanged += new System.EventHandler(this.QR_code_TextChanged);
                QR_code.Focus();
            }

            #endregion 
        }

        private void Clear_command_Click(object sender, EventArgs e)
        {
            Command.Clear();
        }

        private void C_Files_Click(object sender, EventArgs e)
        {
            PG_FP6_command.Write("files\r\n");
        }

        private void C_sum_Click(object sender, EventArgs e)
        {
            PG_FP6_command.Write("sum\r\n");
        }

        private void C_Esr_Click(object sender, EventArgs e)
        {
            PG_FP6_command.Write("ers\r\n");
        }

        private void C_Selftest_Click(object sender, EventArgs e)
        {
            PG_FP6_command.Write("selftest\r\n");
        }

        private void C_ep_Click(object sender, EventArgs e)
        {
            Dowload_MCU();
        }


        private void check_Filename()
        {
            string temp, temp_name, temp_ver;
            int pStart, pEnd;
            temp = Command.Text;
            pStart = temp.IndexOf("*");

                temp = temp.Substring(pStart + 4);

                //--------------- Show File name ------------
                pEnd = temp.IndexOf(" ");
                temp_name = temp.Substring(0, pEnd);
                Filename.Text = temp_name;
                //--------------  Show version --------------
                pStart = temp.IndexOf(".");
                temp_ver = temp.Substring(pStart - 2, 8);
                Version_File.Text = temp_ver;
            


        }
        private void check_sum_file()
        {
            string temp;
            int pStart;
            temp = Command.Text;
            pStart = temp.LastIndexOf(":");
            temp = temp.Substring(pStart+2, 4);
           // textBox1.Text = pStart.ToString();
            File_Checksum.Text =  temp;//1234
        }

        private void req_checksum_file()
        {
            Command.Clear();
            PG_FP6_command.Write("fcks\r\n");
            PG_FP6_RS232.Req_checksum_file = 1;
        }
        private void req_checkfilename()
        {
            Command.Clear();
            try
            {
                PG_FP6_command.Write("files\r\n");
                PG_FP6_RS232.Req_Filename = 1;
            }
            catch
            {
                MessageBox.Show("PGFP6_Disconnect");
            }
        }

        private void checksum_MCU()
        {
            string temp;
            int pStart;
            temp = Command.Text;
            pStart = temp.LastIndexOf(":");
            temp = temp.Substring(pStart + 9, 4);
            // textBox1.Text = pStart.ToString();
            checksumMCU.Text =  temp;
            if (temp.Contains(File_Checksum.Text) == false)
            {
                checksumMCU.BackColor = Color.Red;
                MessageBox.Show("Total checksum ERROR!!!");
                PG_FP6_RS232.num_ERROR++;
                Box_NG.Text = PG_FP6_RS232.num_ERROR.ToString();

            }
            else
            {
                checksumMCU.BackColor = Color.Black;
                PG_FP6_RS232.num_Pass++;
                Box_Pass.Text = PG_FP6_RS232.num_Pass.ToString();
            }

        }

        private void fcks_Click(object sender, EventArgs e)
        {
            PG_FP6_command.Write("fcks\r\n");
        }

        private void Start_MouseUp(object sender, MouseEventArgs e)
        {
            Start.BackColor = Color.LightGray;
        }

        private void Start_MouseDown(object sender, MouseEventArgs e)
        {
            
            Start.BackColor = Color.Gray;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Data = new Data(this);
            //Data D = new Data(this);
            Data.ShowDialog();
            //D.Show();
        }

        private void QR_code_TextChanged(object sender, EventArgs e)
        {
            string kihieu_QR, codesetup;

            if (QR_code.Text.Length > 10)
            {
                kihieu_QR = QR_code.Text.Substring(0, 2);
                codesetup = CodeModel_setup.Text.Substring(0,2);

                if (String.Compare(kihieu_QR, codesetup)==0)
                {
                    //CodeModel.Text = Data.dataFilemodel.Rows[i].Cells[0].Value.ToString();
                    status_QRcode = 1;
           
                }
                else
                    status_QRcode = 0;
          
                if (status_QRcode == 0)
                {
                    QR_code.BackColor = Color.Red;
                    Start.Enabled = false;
                    CodeModel.Text = "";
                    //QR_code.Text = "";
                    MessageBox.Show("Error QR code! \nPlease check QR Code and try again!");
                }
                else
                {
                    Start.Enabled = true;
                    QR_code.BackColor = Color.Black;
                }
            }


        }



        private void autoRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autorun.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            textBox1.Text = Logfile.Rn().ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = System.IO.Path.Combine(@"C:\Users\HP\Desktop\Temp", "PGFP6-" + DateTime.Now.ToString("MM-dd-yyyy") + ".xls");
  
            Logfile.createExcelfile(filepath);
            Logfile.openExcel(filepath);

        }

  
   
        private void QR_code_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToInt32(Keys.Space))
            {
                Start_dowload();
            }
           
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Do you want Exit?", "PG-FP6 Application", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Logfile.closeExcel();
                        Application.Exit();
                    }
                    catch
                    {
                        MessageBox.Show("Logfile don't Exit!");
                    }

                }

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //WriteLogFile.WriteLogtxt("PGFP6-" + DateTime.Now.ToString("MM-dd-yyyy") + ".txt",
            //                   String.Format("{0}  {1}  {2}", "1286414 - aaaaaaa", "OK", DateTime.Now.ToString("MM-dd-yyyy-HH:mm:ss")));
 
            Logfile.addDataToExcel(Logfile.Rownumber.ToString(), "1286414-aaaaaaa", "OK", DateTime.Now.ToString("MM-dd-yyyy"), "___");
        }

        private void ClearQR_Click(object sender, EventArgs e)
        {
            QR_code.BackColor = Color.Black;
            QR_code.Clear();
            CodeModel.Clear();
            QR_code.Focus();
        }

        //private void status_CTHT_TextChanged(object sender, EventArgs e)
        //{
        //    if(status_CTHT.Text == "D")
        //    {
        //        Start_dowload();

        //    }
        //    else if(status_CTHT.Text == "T")
        //    {
        //        QR_code.Clear();
        //        CodeModel.Clear();
        //        MB.WriteSingleRegister(ModbusRTU.ADD_CLR, 1);
                

        //    }
        //}

        private void t1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User(this);
            user.Show();
        }

        private void jig_close_VisibleChanged(object sender, EventArgs e)
        {
            if (jig_close.Visible == true)
            {
                jig_open.Visible = false;
                Start_dowload();
            }
            else
            {

                try
                {
                    jig_open.Visible = true;
                    QR_code.Clear();
                    CodeModel.Clear();
                    MB.WriteSingleRegister(ModbusRTU.ADD_CLR, 1);

                }
                catch
                {

                }
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Account = 0;
            Logout.Visible = false;
            Command.Text = "";
            Command.Text = "--->LOGOUT";
        }

        private void Logout_VisibleChanged(object sender, EventArgs e)
        {
            if (Logout.Visible == true)
            {
                fileToolStripMenuItem.Enabled = true;

            }
            else
                fileToolStripMenuItem.Enabled = false;
        }

        private void jig_close_Click(object sender, EventArgs e)
        {

        }
             
    }
    //class WriteLogFile
    //{
    //    public static bool WriteLogtxt(string strFileName, string strMessage)
    //    {
    //        try
    //        {
    //            string filepath = string.Format("{0}\\{1}", @"" + PG_FP6_UI.Properties.Settings.Default.pathLogfile, strFileName);
    //            FileStream objFilestream = new FileStream(filepath, FileMode.Append, FileAccess.Write);
    //            StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
      
    //            objStreamWriter.WriteLine(strMessage);
    //            objStreamWriter.Close();
    //            objFilestream.Close();
    //            return true;
    //        }
    //        catch (Exception ex)
    //        {
    //            return false;
    //        }
    //    }
    //}
}
