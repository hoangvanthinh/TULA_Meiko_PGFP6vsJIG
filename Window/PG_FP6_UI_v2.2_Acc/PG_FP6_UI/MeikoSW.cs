using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;


namespace PG_FP6_UI
{
    class MeikoSW:SerialPort
    {
        public MeikoSW(string SerialPort, int baudrate, Parity parity, StopBits stopBits)
            : base(SerialPort) 
        {    
            this.BaudRate = baudrate;
            this.Parity = parity;
            this.StopBits = stopBits;
  
        }
        public void MeikoSW_Connect()
        {
            try
            {
                this.Open();
            }
            catch
            {
                MessageBox.Show("MeikoSW Disconnect!");
            }
        }
    }
}
