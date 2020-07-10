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
    
    public partial class Form_Add_Catch_Exchange : Form
    {
        public string move, BALANCE = "0", date, time, TYPE="", process="" , status;
        public int ID_debt, ID_user, ID_Client;
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        int ID_system, GET_ID_Account;
        string text;
        private void Form_Catch_Exchange_Load(object sender, EventArgs e)
        {
            BALANCE = "0";
            client_tx.Text = "";
            TheAmount_tx.Text = "";
            text_tx.Text = Text = "";
            //BALANCE_debt = 0;
            BALANCE = "0";
           // move = "";
        }

        public Form_Add_Catch_Exchange()
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
                try
                {
                    if (status == "Add")
                    {
                        if (move == "قبض")
                        {
                            GET_ID_Account = 1;

                            acc.ADD_NEW_debt_Table(Convert.ToDateTime(date), time, "", move, int.Parse(TheAmount_tx.Text), int.Parse("0"), int.Parse(BALANCE), "", ID_Client, Program.id_user, "", "", GET_ID_Account);

                            fl.label1.Text = "تمت العملية بنجاح";
                            fl.ShowDialog();
                        }
                        else if (move == "صرف")
                        {
                            GET_ID_Account = 1;

                            acc.ADD_NEW_debt_Table(Convert.ToDateTime(date), time, "", move, int.Parse("0"), int.Parse(TheAmount_tx.Text), int.Parse(BALANCE), "", ID_Client, Program.id_user, "", "", GET_ID_Account);

                            fl.label1.Text = "تمت العملية بنجاح";
                            fl.ShowDialog();
                        }
                    }
                    else if (status == "Edit")
                    {
                        GET_ID_Account = 1;

                        if (move_cob.Text == "قبض")
                        {
                            text = text_tx.Text + " | " + " تم التعديل من قبل " + Program.userName;
                            acc.EDIT_debt_Table(ID_debt, move_cob.Text, int.Parse(TheAmount_tx.Text), int.Parse("0"), text, ID_Client);

                            fl.label1.Text = "تم العديل بنجاح";
                            fl.ShowDialog();
                        }
                        else if (move_cob.Text == "صرف")
                        {
                            text = text_tx.Text + " | " + " تم التعديل من قبل " + Program.userName;
                            acc.EDIT_debt_Table(ID_debt, move_cob.Text, int.Parse("0"), int.Parse(TheAmount_tx.Text), text, ID_Client);

                            fl.label1.Text = "تم العديل بنجاح";
                            fl.ShowDialog();
                        }
                    }

                    this.Close();
                }
                catch
                {
                    Form_contact FC = new Form_contact();
                    FC.Error_txt.Visible = true;
                    FC.Error_pic.Visible = true;
                    FC.ShowDialog();
                    FC.Error_txt.Visible = false;
                    FC.Error_pic.Visible = false;
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
            //BALANCE_debt = 0;
            BALANCE = "0";
            //move = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_client_list FCL = new Form_client_list();

            FCL.state       = "client";
            FCL.label1.Text = "اختيار عميل";

            FCL.ShowDialog();

            try
            {
                ID_Client = Convert.ToInt32(FCL.DG_list.CurrentRow.Cells[0].Value.ToString());
                client_tx.Text = FCL.DG_list.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {

            }
        }
    }
}



