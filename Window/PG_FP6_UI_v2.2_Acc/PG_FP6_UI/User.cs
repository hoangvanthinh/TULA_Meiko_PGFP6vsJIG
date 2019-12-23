using System;
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
    public partial class User : Form
    {
        Main main;
        password password;
        public User(Main Inmain)
        {
            InitializeComponent();
            main = Inmain;
        }

        private void save_Click(object sender, EventArgs e)
        {
            checkpass();
        }
        void checkpass()
        {
            if (Password.Text == PG_FP6_UI.Properties.Settings.Default.password)
            {

                main.Command.Text = "";
       
                main.Command.Text = "--->>LOGIN";
                main.Account = 1;
                main.Logout.Visible = true;
                this.Close();
            }
            else
            {
                main.Logout.Visible = false;
                main.Command.Text = "";
                main.Command.Text = "--------Password incorrect!!!-------";
                main.Account = 0;
               // MessageBox.Show("Password incorrect!!!");
            }
        }


        private void Password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToInt32(Keys.Enter))
            {
                checkpass();
            }
        }

        private void changepass_Click(object sender, EventArgs e)
        {
            password = new password();
            password.ShowDialog();

        }
    }
}
