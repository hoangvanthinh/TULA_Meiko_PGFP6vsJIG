using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace PG_FP6_UI
{
    public partial class Setup : Form
    {

        public Setup()
        {
            InitializeComponent();
            
        }


        private void Setup_Load(object sender, EventArgs e)
        {
            string[] portnames = SerialPort.GetPortNames();
            try
            {
                M_com.Items.Clear();
                P_com.Items.Clear();
                MKCom.Items.Clear();
                foreach (var p in portnames)
                {
                    M_com.Items.Add(p);
                    P_com.Items.Add(p);
                    MKCom.Items.Add(p);
                }
                M_com.SelectedItem = "COM44";
                M_Baud.SelectedItem = "19200";
                M_Databit.SelectedItem = "8";
                M_Parity.SelectedItem = "None";
                M_Stopbit.SelectedItem = "1";

                P_com.SelectedItem = "COM43";
                P_Baud.SelectedItem = "9600";
                P_Databit.SelectedItem = "8";
                P_Parity.SelectedItem = "None";
                P_Stopbit.SelectedItem = "1";

                MKCom.SelectedItem = "COM10";
                MKBaud.SelectedItem = "9600";
                MKData.SelectedItem = "8";
                MKParity.SelectedItem = "None";
                MKStopbit.SelectedItem = "1";
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // PG_FP6_RS232.flag = int.Parse(textBox1.Text);
        
        }



  


    }
}
