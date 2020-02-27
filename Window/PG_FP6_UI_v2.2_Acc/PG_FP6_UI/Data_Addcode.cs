using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG_FP6_UI
{
    public partial class Data_Addcode : Form
    {
        Data Data;// = new Data();
        
        public Data_Addcode(Data Dataout)
        {
            InitializeComponent();
            Data = Dataout;
        }

        private void Save_Code_Click(object sender, EventArgs e)
        {

            Data.KiHieu = Khieu.Text;
            Data.macode = Code.Text;
            Data.Fw = fwname.Text;

            Data.Capnhatcaidat();
            //File.AppendAllText("FileModel.txt", Data.KiHieu + "  " + Data.macode + Environment.NewLine);
            this.Close();
        }

        private void Data_Addcode_Load(object sender, EventArgs e)
        {
            this.Code.Focus();
        }


    }
}
