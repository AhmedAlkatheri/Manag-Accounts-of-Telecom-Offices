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
    public partial class Form_you_pay_part : Form
    {
        public string sta = "pay";
        Form_Accounts fa = new Form_Accounts();
        public Form_you_pay_part()
        {
            InitializeComponent();
            totel_tx.Text = fa.ss;
            pay_tx.Text = "0";
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            sta = "on pay";
            Close();
        }

        private void pay_bt_Click(object sender, EventArgs e)
        {
            if(pay_tx.Text == string.Empty)
                pay_tx.Text = "0";

            sta = "pay";
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pay_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
