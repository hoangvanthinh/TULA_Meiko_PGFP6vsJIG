using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
namespace PG_FP6_UI
{
    class PG_FP6_RS232: SerialPort
    {
        public static int flag = 10;
        public static int Req_Filename = 0, Req_checksum_file = 0, Req_checksum_MCU = 0;
        public static int num_Pass = 0, num_ERROR = 0, num_Sum = 0;
        public PG_FP6_RS232(string SerialPort, int baudrate, Parity parity, StopBits stopBits)
            : base(SerialPort) 
        {    
            this.BaudRate = baudrate;
            this.Parity = parity;
            this.StopBits = stopBits;
        //    this.PortName = "COM15";
      
        }
        public void Start_RS232()
        {
            try
            {
                this.Open();
            }
            catch
            {
                MessageBox.Show("PG_FP6 Disconnect!");
            }
        }

       
    }
}
