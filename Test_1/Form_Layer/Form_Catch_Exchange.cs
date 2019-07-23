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
    
    public partial class Form_Catch_Exchange : Form
    {
        public string move, BALANCE = "0", date, time, TYPE="", process="";
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        int ID_Client, ID_system, BALANCE_debt = 0;

        private void Form_Catch_Exchange_Load(object sender, EventArgs e)
        {
            BALANCE = "0";
            client_tx.Text = "";
            TheAmount_tx.Text = "";
            text_tx.Text = Text = "";
            BALANCE_debt = 0;
            BALANCE = "0";
           // move = "";
        }

        public Form_Catch_Exchange()
        {
            InitializeComponent();
        }
        private void if_()
        {
          
            if (TheAmount_tx.Text == string.Empty)
                TheAmount_tx.Text = "0";
            if (BALANCE == string.Empty)
                BALANCE = "0";

        }
        private void but_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            Form_logged fl = new Form_logged();
            Form_not_logged fn = new Form_not_logged();

            if (client_tx.Text != string.Empty && TheAmount_tx.Text != string.Empty)
            {
                 date = DateTime.Now.ToString("yyyy-MM-dd");
                 time = DateTime.Now.ToString("hh:mm:ss tt");

                if (move == "قبض")
                {
                    BALANCE = Convert.ToString(acc.GET_BALANCE_debt(ID_Client).Rows[0][0]);
                    if_();
                    BALANCE_debt = int.Parse(BALANCE) - int.Parse(TheAmount_tx.Text);

                    acc.ADD_debt_Table(Convert.ToDateTime(date), time, process, move, int.Parse(TheAmount_tx.Text), int.Parse("0"), BALANCE_debt, text_tx.Text,
                                        ID_Client, 1, TYPE, ID_system);
                  
                    acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, int.Parse(TheAmount_tx.Text), int.Parse("0"), text_tx.Text,
                            ID_Client, 1, ID_system
                            , ID_system, TYPE);

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }

                if (move == "صرف")
                {
                    BALANCE = Convert.ToString(acc.GET_BALANCE_debt(ID_Client).Rows[0][0]);
                   // if_();
                    BALANCE_debt = int.Parse(BALANCE) + int.Parse(TheAmount_tx.Text);

                    acc.ADD_debt_Table(Convert.ToDateTime(date), time, process, move, int.Parse("0"), int.Parse(TheAmount_tx.Text), BALANCE_debt, text_tx.Text,
                                        ID_Client, 1, TYPE, ID_system);

                    acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, int.Parse(TheAmount_tx.Text), int.Parse("0"), text_tx.Text,
                            ID_Client, 1, ID_system
                            , ID_system, TYPE);

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
            }
            else
            {
                fn.label1.Text = "فشلت العملية";
                fn.ShowDialog();
            }

            client_tx.Text = "";
            TheAmount_tx.Text = "";
            text_tx.Text = Text = "";
            BALANCE_debt = 0;
            BALANCE = "0";
            //move = "";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_client_list FCL = new Form_client_list();
            FCL.ShowDialog();
            if (FCL.state == "اختيار")
            {
                ID_Client = Convert.ToInt32(FCL.DG_list.CurrentRow.Cells[0].Value.ToString());
                client_tx.Text = FCL.DG_list.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
