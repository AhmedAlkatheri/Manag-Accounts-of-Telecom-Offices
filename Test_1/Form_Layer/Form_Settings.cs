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
    public partial class Form_Settings : Form
    {
        public Form_Settings()
        {
            InitializeComponent();

            //if (system_bt.Text == "نظام")
            //    user_system1.BringToFront();
            //else if (telecom_bt.Text == "اتصالات")
            //    user_Telecom1.BringToFront();
            //{
            //    MessageBox.Show("ggg");
            //}
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            Hide();


        }

        private void telecom_bt_Click(object sender, EventArgs e)
        {
            user_Telecom1.BringToFront();
        }

        private void system_bt_Click(object sender, EventArgs e)
        {
            user_system1.BringToFront();
        }

        private void bunch_bt_Click(object sender, EventArgs e)
        {
            user_bunch1.BringToFront();
        }

        private void category_bt_Click(object sender, EventArgs e)
        {
            user_category1.BringToFront();
        }

        private void Form_Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void slice_bt_Click(object sender, EventArgs e)
        {
            user_slice1.BringToFront();
        }

        private void deposit_bt_Click(object sender, EventArgs e)
        {
            user_deposit_settings1.BringToFront();
        }

        private void telephone_bt_Click(object sender, EventArgs e)
        {
            user_telephone1.BringToFront();
        }

        private void WandE_Click(object sender, EventArgs e)
        {
            user_WendE1.BringToFront();
        }
    }
}
