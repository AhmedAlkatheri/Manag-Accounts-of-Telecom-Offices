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
    public partial class Form_Alarmcs : Form
    {
        public Form_Alarmcs()
        {
            InitializeComponent();
        }

        private void pay_bt_Click(object sender, EventArgs e)
        {
            Form_Deposit FD = new Form_Deposit();
            FD.stats1 = "for";
            this.Close();
            FD.ShowDialog();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Alarm_status = 0;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
