using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_1.Form_Layer
{
    public partial class Form_log_in : Form
    {
        public Form_log_in()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (user.Text == "admin" && pwd.Text == "admin")
            {
                Form_logged fl = new Form_logged();
                fl.ShowDialog();
                Close();
            }
            else
            {
                Form_not_logged fnl = new Form_not_logged();
                fnl.ShowDialog();
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
