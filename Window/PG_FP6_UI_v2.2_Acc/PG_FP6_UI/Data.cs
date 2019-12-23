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
    public partial class Data : Form
    {
        public DataTable table = new DataTable();
        Main main;// = new Main();

        public string KiHieu, macode;
        public Data(Main Inmain)
        {

            InitializeComponent();
            main = Inmain;

          
        }
        //public Data(Main Inmain)
        //{
        //    main = Inmain;
        //}
        private void Add_model_Click(object sender, EventArgs e)
        {
            Data_Addcode Addcode = new Data_Addcode(this);
            Addcode.Show();
        }

        internal void Capnhatcaidat()
        {

            table.Rows.Add(macode, KiHieu);
            dataFilemodel.DataSource = table;
        }
        //File.AppendAllText("FileModel.txt", Data.KiHieu + "  " + Data.macode + Environment.NewLine);

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("FileModel.txt", string.Empty);
            for (int i = 0; i < dataFilemodel.RowCount - 1;i++)
            {
                File.AppendAllText("FileModel.txt", dataFilemodel.Rows[i].Cells[0].Value.ToString() + " " + dataFilemodel.Rows[i].Cells[1].Value.ToString() + Environment.NewLine);
            }
        
                this.Close();
        }

        private void Data_Load(object sender, EventArgs e)
        {
            table.Clear();
            dataFilemodel.DataSource = null;

            //table.Columns.Add("CODE", typeof(string));// data type int
            //table.Columns.Add("T1", typeof(string));// datatype string
            //table.Columns.Add("T2", typeof(string));// data type int
            //table.Columns.Add("T3", typeof(string));// data type int

            
            //dataFilemodel.DataSource = table;
            //dataFilemodel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //============== DOC DATA TU FILEMODEL RA  -=============================
            string line = "";
            using(StreamReader SR = new StreamReader("FileModel.txt"))
            {
                while((line = SR.ReadLine())  != null)
                {
                    string kihieu, macode;
                    macode = line.Substring(0, line.IndexOf(" "));
                    kihieu  = line.Substring(line.IndexOf(" ") + 1, line.Length - line.IndexOf(" ") - 1);
                    table.Rows.Add(macode, kihieu);
                }
                dataFilemodel.DataSource = table;
            }
           // Model_list.Items.AddRange(dataFilemodel.);
            Model_list.Items.Clear();
            for (int i = 0; i < dataFilemodel.RowCount - 1; i++)
            {
                Model_list.Items.Add(dataFilemodel.Rows[i].Cells[0].Value.ToString());// + ":" + dataFilemodel.Rows[i].Cells[0].Value.ToString());
            }
            Folder.Text = PG_FP6_UI.Properties.Settings.Default.pathLogfile;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Browsefile_Click(object sender, EventArgs e)
        {
            
            if(folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Folder.Text = folderBrowserDialog1.SelectedPath;

                PG_FP6_UI.Properties.Settings.Default.pathLogfile = Folder.Text;
                PG_FP6_UI.Properties.Settings.Default.Save();

            }
        }

        private void Model_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Code_model.Text = Model_list.SelectedItem.ToString();
            main.strRx = Code_model.Text;
            main.capnhat_codesetup();

            //load to main
           // main.CodeModel_setup.Text = Code_model.Text;
        }
    }
}
