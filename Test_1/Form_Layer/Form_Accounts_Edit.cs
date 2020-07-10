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
        public int ID_Client, ID_Account;
        public string move, process_NAME, TYPE_NAME, BALANCE_debt, sPAY, sss, with, ID_telecom;
        string uaerName = Program.userName;
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        Form_not_logged fn = new Form_not_logged();
        Form_logged fl = new Form_logged();
        Form_Accounts FA = new Form_Accounts();
        Form_Mes_Error ME = new Form_Mes_Error();

        public Form_Accounts_Edit()
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
                FC.Error_txt.Visible = true;
                FC.Error_pic.Visible = true;
                FC.ShowDialog();
                FC.Error_txt.Visible = false;
                FC.Error_pic.Visible = false;
            }
        }
        private void ss()
        {
            if (TYPE_cob.Text == "فئة")
            {
                process_cob.DataSource = acc.GET_category_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_category";
                process_cob.ValueMember = "ID_category";

                process_cob.Text = process_NAME;
                WITH_ch.Enabled = true;

                DG2.DataSource = acc.GET_category_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                try
                {
                    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                }
                catch
                {
                    ME.ShowDialog();
                }
            }
            else if (TYPE_cob.Text == "باقة")
            {
                process_cob.DataSource = acc.GET_NAME_bunch(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_bunch";
                process_cob.ValueMember = "ID_bunch";

                process_cob.Text = process_NAME;
                WITH_ch.Enabled = true;

                DG2.DataSource = acc.GET_bunch_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                try
                {
                    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                }
                catch
                {
                    ME.ShowDialog();
                }
            }
            else if (TYPE_cob.Text == "شريحة")
            {
                process_cob.DataSource = acc.GET_slice_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_slice";
                process_cob.ValueMember = "ID_slice";

                process_cob.Text = process_NAME;
                WITH_ch.Enabled = false;

                DG2.DataSource = acc.GET_slice_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                try
                {
                    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                }
                catch 
                {
                    ME.ShowDialog();
                }

            }
            else if (TYPE_cob.Text == "هاتف")
            {
                process_cob.DataSource = acc.GET_telephone_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_telephone";
                process_cob.ValueMember = "ID_telephone";

                process_cob.Text = process_NAME;
                WITH_ch.Enabled = false;

                DG2.DataSource = acc.GET_telephone_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                try
                {
                    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                }
                catch
                {
                    ME.ShowDialog();
                }
            }
            
            else if (TYPE_cob.Text == "ماء وكهربا")
            {
                process_cob.DataSource = acc.GET_water_And_Electricity_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_WandE";
                process_cob.ValueMember = "ID_WandE";

                process_cob.Text = process_NAME;
                WITH_ch.Enabled = false;

                DG2.DataSource = acc.GET_NAME_WandE_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                try
                {
                    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                }
                catch
                {
                    //ME.ShowDialog();
                }
            }
        }

        private void ssWithout()
        {
            if (TYPE_cob.Text == "فئة")
            {
                process_cob.DataSource = acc.GET_category_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_category";
                process_cob.ValueMember = "ID_category";

                process_cob.Text = process_NAME;
                WITH_ch.Enabled = true;

                DG2.DataSource = acc.GET_category_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);
            }
            else if (TYPE_cob.Text == "باقة")
            {
                process_cob.DataSource = acc.GET_NAME_bunch(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_bunch";
                process_cob.ValueMember = "ID_bunch";

                process_cob.Text = process_NAME;
                WITH_ch.Enabled = true;

                DG2.DataSource = acc.GET_bunch_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);
            }
            else if (TYPE_cob.Text == "شريحة")
            {
                process_cob.DataSource = acc.GET_slice_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_slice";
                process_cob.ValueMember = "ID_slice";

                process_cob.Text = process_NAME;
                WITH_ch.Enabled = false;

                DG2.DataSource = acc.GET_slice_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);
            }
            else if (TYPE_cob.Text == "هاتف")
            {
                process_cob.DataSource = acc.GET_telephone_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_telephone";
                process_cob.ValueMember = "ID_telephone";

                process_cob.Text = process_NAME;
                WITH_ch.Enabled = false;

                DG2.DataSource = acc.GET_telephone_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);
            }

            else if (TYPE_cob.Text == "ماء وكهربا")
            {
                process_cob.DataSource = acc.GET_water_And_Electricity_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_WandE";
                process_cob.ValueMember = "ID_WandE";

                process_cob.Text = process_NAME;
                WITH_ch.Enabled = false;

                DG2.DataSource = acc.GET_NAME_WandE_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);
            }
        }

        private void NAME_category_cob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_client_list FCL = new Form_client_list();

            FCL.state = "client";
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
            else if (TYPE_cob.Text == "ماء وكهربا")
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
                WITH_ch.Enabled = true;
            }
            else if (TYPE_cob.Text == "باقة")
            {
                process_cob.DataSource = acc.GET_NAME_bunch(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_bunch";
                process_cob.ValueMember = "ID_bunch";
                WITH_ch.Enabled = true;
            }
            else if (TYPE_cob.Text == "شريحة")
            {
                process_cob.DataSource = acc.GET_slice_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_slice";
                process_cob.ValueMember = "ID_slice";
                WITH_ch.Enabled = false;
            }
            else if (TYPE_cob.Text == "هاتف")
            {
                process_cob.DataSource = acc.GET_telephone_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_telephone";
                process_cob.ValueMember = "ID_telephone";
                WITH_ch.Enabled = false;
            }
            else if (TYPE_cob.Text == "ماء وكهربا")
            {
                process_cob.DataSource = acc.GET_water_And_Electricity_Table(Convert.ToInt32(system_cob.SelectedValue));
                process_cob.DisplayMember = "NAME_WandE";
                process_cob.ValueMember = "ID_WandE";
                WITH_ch.Enabled = false;
            }
        }

        private void cash_ch_CheckedChanged(object sender, EventArgs e)
        {
            breached_ch.Checked = false;
            reverse_ch.Checked = false;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (WITH_ch.Checked == true)
            {
                if (TYPE_cob.Text == "فئة")
                {
                    DG2.DataSource = acc.GET_category_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                    try
                    {
                        REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                        EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                        ID_telecom = this.DG2.CurrentRow.Cells[7].Value.ToString();
                    }
                    catch 
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
                        ID_telecom = this.DG2.CurrentRow.Cells[7].Value.ToString();

                    }
                    catch 
                    {
                        Form_Mes_Error ME = new Form_Mes_Error();
                        ME.ShowDialog();
                    }
                }
                
                REC_tx.Text = this.DG2.CurrentRow.Cells[4].Value.ToString();
                EXH_tx.Text = this.DG2.CurrentRow.Cells[5].Value.ToString();
                with = "مع السلفة";
                text_tx.Text = with;
            }
            else
            {
                ss();
                REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                with = "";
                text_tx.Text = with;
            }
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
                    ID_telecom = this.DG2.CurrentRow.Cells[7].Value.ToString(); 
                }
                catch
                {
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
                    ID_telecom = this.DG2.CurrentRow.Cells[7].Value.ToString();
                }
                catch
                {
                    ME.ShowDialog();
                }
            }
            else if (TYPE_cob.Text == "شريحة")
            {
                DG2.DataSource = acc.GET_slice_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                try
                {
                    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                    ID_telecom = this.DG2.CurrentRow.Cells[7].Value.ToString();
                }
                catch
                {
                    ME.ShowDialog();
                }
            }
            else if (TYPE_cob.Text == "هاتف")
            {
                DG2.DataSource = acc.GET_telephone_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                try
                {
                    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                    ID_telecom = "هاتف";
                }
                catch
                {
                    ME.ShowDialog();
                }
            }
            else if (TYPE_cob.Text == "ماء وكهربا")
            {
                DG2.DataSource = acc.GET_NAME_WandE_row(Convert.ToInt32(system_cob.SelectedValue), process_cob.Text);

                try
                {
                    REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                    EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                    ID_telecom = "ماء وكهرباء";
                }
                catch
                {
                    ME.ShowDialog();
                }
            }
        }

        private void pay_bt_Click(object sender, EventArgs e)
        {
            string text, BALANCE = "0";
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            if (cash_ch.Checked == true)
                move = "نقدا";
            else if (breached_ch.Checked == true)
                move = "آجل";
            else if (reverse_ch.Checked == true)
                move = "مرتجع";
            else
            {
                fn.label1.Text = "عذرا, اختر نوع الحركة";
                fn.ShowDialog();
                return;
            }

            if (move == "نقدا")
            {
                if (ID_Account.ToString() != string.Empty && process_cob.Text != string.Empty && REC_tx.Text != string.Empty && EXH_tx.Text != string.Empty
                    && ID_Client.ToString() != string.Empty && ID_telecom.ToString() != string.Empty && system_cob.Text != string.Empty && TYPE_cob.Text != string.Empty)
                {
                    text = text_tx.Text + " | " + " تم التعديل من قبل " + uaerName;
                    
                    if (ID_Client == 0)
                    {
                        acc.EDIT_Account_Table_Wihtout_ID_client(ID_Account, process_cob.Text, move, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), text, ID_telecom, system_cob.Text, TYPE_cob.Text);
                    }
                    else
                    {
                        DataTable IF_ID_debt = new DataTable();
                        IF_ID_debt = acc.IF_ID_debt_existent(ID_Account);

                        if (IF_ID_debt.Rows.Count > 0)
                        {
                            acc.EDIT_Account_Table(ID_Account, process_cob.Text, move, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), text, ID_Client, ID_telecom, system_cob.Text, TYPE_cob.Text);
                            acc.EDIT_debt_Table_and_ID_Account(process_cob.Text, move, int.Parse(REC_tx.Text), int.Parse(REC_tx.Text), int.Parse(BALANCE), text, ID_Client, TYPE_cob.Text, this.DG2.CurrentRow.Cells[6].Value.ToString(), ID_Account);
                        }
                        else
                        {
                            acc.EDIT_Account_Table(ID_Account, process_cob.Text, move, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), text, ID_Client, ID_telecom, system_cob.Text, TYPE_cob.Text);
                            acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), DateTime.Now.ToString("hh:mm:ss tt"), process_cob.Text, move, int.Parse(REC_tx.Text), int.Parse(REC_tx.Text), int.Parse(BALANCE), text_tx.Text,
                                                ID_Client, Program.id_user, TYPE_cob.Text, this.DG2.CurrentRow.Cells[6].Value.ToString(), ID_Account);
                        }
                    }

                    acc.EDIT_NO_deposit(int.Parse(EXH_tx.Text), text, Convert.ToInt32(system_cob.SelectedValue), ID_Account);

                    fl.label1.Text = "تم التعديل بنجاح";
                    fl.ShowDialog();

                    this.Close();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية , \nادخل بيانات المطلوبه";
                    fn.ShowDialog();
                }
            }           
             
            else if (move == "آجل")
            {
                if (ID_Client == 0 || client_tx.Text == string.Empty || client_tx.Text == "")
                {
                    ME.label1.Text = "عذرا , أختر حساب العميل";
                    ME.ShowDialog();
                    return;
                }

                if (ID_Account.ToString() != string.Empty && process_cob.Text != string.Empty && REC_tx.Text != string.Empty && EXH_tx.Text != string.Empty
                    && ID_Client.ToString() != string.Empty && ID_telecom.ToString() != string.Empty && system_cob.Text != string.Empty && TYPE_cob.Text != string.Empty)
                {
                    text = text_tx.Text + " | " + " تم التعديل من قبل " + uaerName;

                    Form_you_pay_part ypp = new Form_you_pay_part();
                    ypp.totel_tx.Text = REC_tx.Text;
                    ypp.ShowDialog();
                    if (ypp.sta == "pay")
                    {
                        sss = REC_tx.Text;
                        sPAY = Convert.ToString(int.Parse(REC_tx.Text) - int.Parse(ypp.pay_tx.Text));
                        
                    }
                    else if (ypp.sta == "on pay")
                        return;

                    REC_tx.Text = ypp.pay_tx.Text;

                    if (ID_Client == 0 || client_tx.Text == string.Empty || client_tx.Text == "")
                    {
                        ME.label1.Text = "عذرا , أختر حساب العميل";
                        ME.ShowDialog();
                        return;
                    }
                    else
                    {
                        DataTable IF_ID_debt = new DataTable();
                        IF_ID_debt = acc.IF_ID_debt_existent(ID_Account);

                        if (IF_ID_debt.Rows.Count > 0)
                        {
                            acc.EDIT_Account_Table(ID_Account, process_cob.Text, move, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), text, ID_Client, ID_telecom, system_cob.Text, TYPE_cob.Text);
                            acc.EDIT_debt_Table_and_ID_Account(process_cob.Text, move, Convert.ToInt32("0"), int.Parse(sPAY), int.Parse(BALANCE), text, ID_Client, TYPE_cob.Text, this.DG2.CurrentRow.Cells[6].Value.ToString(), ID_Account);
                        }
                        else
                        {
                            acc.EDIT_Account_Table(ID_Account, process_cob.Text, move, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), text, ID_Client, ID_telecom, system_cob.Text, TYPE_cob.Text);
                            acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), DateTime.Now.ToString("hh:mm:ss tt"), process_cob.Text, move, Convert.ToInt32("0"), int.Parse(sPAY), int.Parse(BALANCE), text_tx.Text,
                                                    ID_Client, Program.id_user, TYPE_cob.Text, this.DG2.CurrentRow.Cells[6].Value.ToString(), ID_Account);
                        }
                        acc.EDIT_NO_deposit(int.Parse(REC_tx.Text), text, Convert.ToInt32(system_cob.SelectedValue), ID_Account);
                    }

                    fl.label1.Text = "تم التعديل بنجاح";
                    fl.ShowDialog();

                    this.Close();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية , \nادخل بيانات المطلوبه";
                    fn.ShowDialog();
                } 
            }
        }

        private void Form_Accounts_Edit_Load(object sender, EventArgs e)
        {
            try
            {
                TYPE_cob.Text = TYPE_NAME;
                process_cob.Text = process_NAME;
                ssWithout();

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

                if (ID_Client == 0)
                {

                }
                else
                {
                    client_tx.Text = Convert.ToString(acc.GET_NAME_client(ID_Client).Rows[0][0]);
                }
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
    }
}
