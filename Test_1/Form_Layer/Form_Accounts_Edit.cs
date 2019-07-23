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
    public partial class Form_Accounts_Edit : Form
    {
        public int ID_Client, ID_Account, ID_telecom;
        public string move, process_NAME;
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        Form_not_logged fn = new Form_not_logged();
        Form_Accounts FA = new Form_Accounts();
        public Form_Accounts_Edit()
        {
            InitializeComponent();

            system_cob.DataSource = acc.GET_NAME_system();
            system_cob.DisplayMember = "NAME_system";
            system_cob.ValueMember = "ID_system";

            //ID_Client = 1;
            //client_tx.Text = "زبون";
        }
        private void ss()
        {
            if (TYPE_cob.Text == "فئة")
            {
                process_cob.DataSource = acc.GET_category_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_category";
                process_cob.ValueMember = "ID_category";

                //DG2.DataSource = acc.GET_category_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                //try
                //{
                //    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                //    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                //}
                //catch (Exception ex)
                //{
                //    Form_Mes_Error ME = new Form_Mes_Error();
                //    ME.ShowDialog();
                //}
            }
            else if (TYPE_cob.Text == "باقة")
            {
                process_cob.DataSource = acc.GET_NAME_bunch(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_bunch";
                process_cob.ValueMember = "ID_bunch";

                //DG2.DataSource = acc.GET_bunch_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                //try
                //{
                //    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                //    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                //}
                //catch (Exception ex)
                //{
                //    Form_Mes_Error ME = new Form_Mes_Error();
                //    ME.ShowDialog();
                //}
            }
            else if (TYPE_cob.Text == "شريحة")
            {
                process_cob.DataSource = acc.GET_slice_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_slice";
                process_cob.ValueMember = "ID_slice";

            }
            else if (TYPE_cob.Text == "هاتف")
            {
                process_cob.DataSource = acc.GET_telephone_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_telephone";
                process_cob.ValueMember = "ID_telephone";

                //DG2.DataSource = acc.GET_telephone_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                //try
                //{
                //    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                //    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                //}
                //catch (Exception ex)
                //{
                //    Form_Mes_Error ME = new Form_Mes_Error();
                //    ME.ShowDialog();
                //}
            }
            else if (TYPE_cob.Text == "ماء وكهرباء")
            {
                process_cob.DataSource = acc.GET_water_And_Electricity_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_WandE";
                process_cob.ValueMember = "ID_WandE";

                //DG2.DataSource = acc.GET_NAME_WandE_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                //try
                //{
                //    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                //    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                //}
                //catch (Exception ex)
                //{
                //    Form_Mes_Error ME = new Form_Mes_Error();
                //    ME.ShowDialog();
                //}
            }
        }

        private void NAME_category_cob_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TYPE_cob.Text == "فئة")
            {
                process_cob.DataSource = acc.GET_category_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_category";
                process_cob.ValueMember = "ID_category";
            }
            else if (TYPE_cob.Text == "باقة")
            {
                process_cob.DataSource = acc.GET_NAME_bunch(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_bunch";
                process_cob.ValueMember = "ID_bunch";
            }
            else if (TYPE_cob.Text == "شريحة")
            {
                process_cob.DataSource = acc.GET_slice_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_slice";
                process_cob.ValueMember = "ID_slice";
            }
            else if (TYPE_cob.Text == "هاتف")
            {
                process_cob.DataSource = acc.GET_telephone_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_telephone";
                process_cob.ValueMember = "ID_telephone";
            }
            else if (TYPE_cob.Text == "ماء وكهرباء")
            {
                process_cob.DataSource = acc.GET_water_And_Electricity_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_WandE";
                process_cob.ValueMember = "ID_WandE";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TYPE_cob.Text == "فئة")
            {
                process_cob.DataSource = acc.GET_category_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_category";
                process_cob.ValueMember = "ID_category";
            }
            else if (TYPE_cob.Text == "باقة")
            {
                process_cob.DataSource = acc.GET_NAME_bunch(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_bunch";
                process_cob.ValueMember = "ID_bunch";
            }
            else if (TYPE_cob.Text == "شريحة")
            {
                process_cob.DataSource = acc.GET_slice_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_slice";
                process_cob.ValueMember = "ID_slice";
            }
            else if (TYPE_cob.Text == "هاتف")
            {
                process_cob.DataSource = acc.GET_telephone_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_telephone";
                process_cob.ValueMember = "ID_telephone";
            }
            else if (TYPE_cob.Text == "ماء وكهرباء")
            {
                process_cob.DataSource = acc.GET_water_And_Electricity_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_WandE";
                process_cob.ValueMember = "ID_WandE";
            }
        }

        private void cash_ch_CheckedChanged(object sender, EventArgs e)
        {
            breached_ch.Checked = false;
            reverse_ch.Checked = false;
        }

        private void breached_ch_CheckedChanged(object sender, EventArgs e)
        {
            cash_ch.Checked = false;
            reverse_ch.Checked = false;
        }

        private void reverse_ch_CheckedChanged(object sender, EventArgs e)
        {
            cash_ch.Checked = false;
            breached_ch.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TYPE_cob.Text == "فئة")
            {
                DG2.DataSource = acc.GET_category_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                try
                {
                    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                    ID_telecom = Convert.ToInt32(this.DG2.CurrentRow.Cells[7].Value.ToString()); 
                }
                catch (Exception ex)
                {
                    Form_Mes_Error ME = new Form_Mes_Error();
                    ME.ShowDialog();
                }
            }
            else if (TYPE_cob.Text == "باقة")
            {
                DG2.DataSource = acc.GET_bunch_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                try
                {
                    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                    ID_telecom = Convert.ToInt32(this.DG2.CurrentRow.Cells[7].Value.ToString());

                }
                catch (Exception ex)
                {
                    Form_Mes_Error ME = new Form_Mes_Error();
                    ME.ShowDialog();
                }
            }
            else if (TYPE_cob.Text == "شريحة")
            {
                
            }
            else if (TYPE_cob.Text == "هاتف")
            {
                DG2.DataSource = acc.GET_telephone_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                try
                {
                    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                    ID_telecom = 1;

                }
                catch (Exception ex)
                {
                    Form_Mes_Error ME = new Form_Mes_Error();
                    ME.ShowDialog();
                }
            }
            else if (TYPE_cob.Text == "ماء وكهرباء")
            {
                DG2.DataSource = acc.GET_NAME_WandE_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                try
                {
                    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                    ID_telecom = 1;

                }
                catch (Exception ex)
                {
                    Form_Mes_Error ME = new Form_Mes_Error();
                    ME.ShowDialog();
                }
            }
        }

        private void pay_bt_Click(object sender, EventArgs e)
        {
            string text, BALANCE;
            if (cash_ch.Checked == true)
                move = "نقدا";
            else if (breached_ch.Checked == true)
                move = "آجل";
            else if (reverse_ch.Checked == true)
                move = "مرتجع";
            else
                move = "";

            if (move == "نقدا")
            {
                text = text_tx.Text + " | تم التعديل من قبل" + 1;

                BALANCE = Convert.ToString(acc.GET_BALANCE_debt(ID_Client).Rows[0][0]);

                acc.EDIT_Account_Table(ID_Account, process_cob.Text, move, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), text, ID_Client, ID_telecom, Convert.ToInt32(system_cob.SelectedValue), TYPE_cob.Text);
                acc.EDIT_debt_Table_and_ID_Account(process_cob.Text, move, int.Parse(REC_tx.Text), int.Parse(REC_tx.Text), int.Parse(BALANCE), text, ID_Client, TYPE_cob.Text, Convert.ToInt32(system_cob.SelectedValue), ID_Account);
            }
            else if(move == "آجل")
            {
                text = text_tx.Text + " | تم التعديل من قبل" + 1;

            }
        }

        private void Form_Accounts_Edit_Load(object sender, EventArgs e)
        {
            ss();
            process_cob.Text = process_NAME;

            if (move == "نقدا")
            {
                cash_ch.Checked = true;
                breached_ch.Checked = false;
                reverse_ch.Checked = false;
            }

            else if (move == "آجل")
            {
                cash_ch.Checked = false;
                breached_ch.Checked = true;
                reverse_ch.Checked = false;
            }
            else if (move == "مرتجع")
            {
                cash_ch.Checked = false;
                breached_ch.Checked = false;
                reverse_ch.Checked = true;
            }

        }
    }
}
