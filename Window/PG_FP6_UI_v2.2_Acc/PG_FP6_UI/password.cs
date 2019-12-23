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
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
        }

        private void changepassword_Click(object sender, EventArgs e)
        {
            PG_FP6_UI.Properties.Settings.Default.password = t_verifypass.Text;
            PG_FP6_UI.Properties.Settings.Default.Save();
            this.Close();
        }

        private void t_oldpass_TextChanged(object sender, EventArgs e)
        {
            if (t_oldpass.Text == PG_FP6_UI.Properties.Settings.Default.password)
            {
                L_oldpass.Visible = false;
            }
            else
                L_oldpass.Visible = true;
                  
        }

        private void t_verifypass_TextChanged(object sender, EventArgs e)
        {
            if(t_verifypass.Text == t_newpass.Text)
            {
                L_newpass.Visible = true;
            }
            else
            {
                L_newpass.Visible = false;
            }
        }


    }
}
