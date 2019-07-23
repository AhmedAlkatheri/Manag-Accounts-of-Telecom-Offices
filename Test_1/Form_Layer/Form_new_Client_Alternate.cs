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
    public partial class Form_new_Client_Alternate : Form
    {
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        Business_Layer.Client c = new Business_Layer.Client();
        public string stats1 = "";
        Form_not_logged fn = new Form_not_logged();
        DataTable Dt;

        public Form_new_Client_Alternate()
        {
            InitializeComponent();
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            Form_logged fl = new Form_logged();
            Form_not_logged fn = new Form_not_logged();
            string ID_client, BALANCE="0";
            string date = DateTime.Now.ToString("MM-dd-yyyy");
            string time = DateTime.Now.ToString("hh:mm:ss tt");

            Dt = c.VERIFY_NAME_client(acc_tx.Text);
            if (Dt.Rows.Count > 0)
            {
                fn.label1.Text = "الاسم موجود مسبقا";
                fn.ShowDialog();
                acc_tx.Focus();
                return;
            }

            if (stats1 == "Client")
            {
                if (for_tx.Text == string.Empty)
                    for_tx.Text = "0";
                if (on_tx.Text == string.Empty)
                    on_tx.Text = "0";

                BALANCE = Convert.ToString(int.Parse(on_tx.Text) - int.Parse(for_tx.Text));

                if (acc_tx.Text != string.Empty)
                {
                    acc.ADD_NEW_client_Table(acc_tx.Text, MOBILE_tx.Text, TELEPHONE_tx.Text, ADRESS_tx.Text, EMAIL_tx.Text);
                    ID_client = Convert.ToString(acc.GET_ID_client().Rows[0][0]);

                    acc.ADD_NEW_debt_Table(Convert.ToDateTime(date), time, "رصيد سابق", int.Parse(for_tx.Text), int.Parse(on_tx.Text), int.Parse(BALANCE), int.Parse(ID_client), 1);
                    
                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }
            }
            else if( stats1 == "Alternate")
            {
                if (acc_tx.Text != string.Empty && ADRESS_tx.Text != string.Empty && EMAIL_tx.Text != string.Empty && MOBILE_tx.Text != string.Empty)
                {
                    acc.ADD_NEW_user_Table(acc_tx.Text, ADRESS_tx.Text, EMAIL_tx.Text, int.Parse(MOBILE_tx.Text));

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

            acc_tx.Text = "";
            MOBILE_tx.Text = "";
            TELEPHONE_tx.Text = "";
            ADRESS_tx.Text = "";
            EMAIL_tx.Text = "";
            BALANCE = "0";
            for_tx.Text = "";
            on_tx.Text = "";
            ID_client = "";
            this.Close();
        }

        private void on_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void MOBILE_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (stats1 == "Client")
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
               
        }

        private void acc_tx_Validated(object sender, EventArgs e)
        {
            Dt = c.VERIFY_NAME_client(acc_tx.Text);
            if (Dt.Rows.Count > 0)
            {
                fn.label1.Text = "الاسم موجود مسبقا";
                fn.ShowDialog();
                acc_tx.Focus();
                return;
            }

            Dt = acc.VERIFY_NAME_user(acc_tx.Text);
            if (Dt.Rows.Count > 0)
            {
                fn.label1.Text = "الاسم موجود مسبقا";
                fn.ShowDialog();
                acc_tx.Focus();
                return;
            }
        }
    }
}
