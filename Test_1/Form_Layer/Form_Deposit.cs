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
    public partial class Form_Deposit : Form
    {
        public string stats1;
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        public Form_Deposit()
        {
            InitializeComponent();
            try
            {
                system_cob.DataSource = acc.GET_NAME_system();
                system_cob.DisplayMember = "NAME_system";
                system_cob.ValueMember = "ID_system";
            }
            catch
            {
                Form_contact FC = new Form_contact();
                FC.ShowDialog();
            } 
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            BALANCE_tx.Text = "";
            for_on_tx.Text = "";
            text_tx.Text = "";
            Close();
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            Form_logged fl = new Form_logged();
            Form_not_logged fn = new Form_not_logged();

            if (system_cob.Text != string.Empty && BALANCE_tx.Text != string.Empty && for_on_tx.Text != string.Empty)
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string time = DateTime.Now.ToString("hh:mm:ss tt");

                if (stats1 == "for")
                {
                    acc.ADD_FOR_deposit(Convert.ToDateTime(date), time, int.Parse(for_on_tx.Text), text_tx.Text, Convert.ToInt32(system_cob.SelectedValue));
                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else if(stats1 == "on")
                {
                    acc.ADD_NO_deposit_direct(Convert.ToDateTime(date), time, int.Parse(for_on_tx.Text), text_tx.Text, Convert.ToInt32(system_cob.SelectedValue));
                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }     
            }
            else
            {
                fn.label1.Text = "فشلت العملية";
                fn.ShowDialog();
            }
            BALANCE_tx.Text = "";
            for_on_tx.Text = "";
            text_tx.Text = "";
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FOR_deposit = Convert.ToString(acc.SUM_FOR_deposit(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
            string ON_deposit = Convert.ToString(acc.SUN_ON_deposit(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
            string BALANCE_deposi = Convert.ToString(acc.SUM_BALANCE_deposit().Rows[0][0]);

            if (FOR_deposit == string.Empty)
                FOR_deposit = "0";
            if (ON_deposit == string.Empty)
                ON_deposit = "0";
            if (BALANCE_deposi == string.Empty)
                BALANCE_deposi = "0";

            BALANCE_tx.Text = Convert.ToString((int.Parse(BALANCE_deposi) + int.Parse(FOR_deposit)) - int.Parse(ON_deposit));
        }
    }
}
