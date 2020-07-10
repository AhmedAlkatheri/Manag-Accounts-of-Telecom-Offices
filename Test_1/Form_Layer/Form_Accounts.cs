using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_1.Properties;

namespace Test_1.Form_Layer
{
    public partial class Form_Accounts : Form
    {
        public int ID_Client, rowCunt, ID_Account, GET_ID_Account;
        int user = Program.id_user;
        
        public string FOR_deposit, ON_deposit, BALANCE_deposi, state = "add", move, text, with, BALANCE = "0", BALANCE_debt, sPAY, ss, state1;
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        Form_not_logged fn = new Form_not_logged();
        Form_Mes_Error ME = new Form_Mes_Error();
        Form_main m = new Form_main();
        string date, time, process, TYPE;

        public Form_Accounts()
        {
            InitializeComponent();
            try
            {
                system_cobc.DataSource = acc.GET_NAME_system();
                system_cobc.DisplayMember = "NAME_system";
                system_cobc.ValueMember = "ID_system";

                DG_NAME_REC_EXH.DataSource = acc.GET_NAME_REC_EXH();

                Settings.Default.Alarm_status = 1;
                Settings.Default.Save();
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
        private void if_()
        {
            if (FOR_deposit == string.Empty)
                FOR_deposit = "0";
            if (ON_deposit == string.Empty)
                ON_deposit = "0";
            if (BALANCE_deposi == string.Empty)
                BALANCE_deposi = "0";
            if (no_debe_tx.Text == string.Empty)
                no_debe_tx.Text = "0";
            if (reverse_tx.Text == string.Empty)
                reverse_tx.Text = "0";

            if (TOTEL_REC_tx.Text == string.Empty)
                TOTEL_REC_tx.Text = "0";
            if (TOTEL_EXH_tx.Text == string.Empty)
                TOTEL_EXH_tx.Text = "0";
            if (TOTEL_tx.Text == string.Empty)
                TOTEL_tx.Text = "0";
        }

        private void VARIABLES(string process_te, string TYPE_te)
        {
             date = DateTime.Now.ToString("yyyy-MM-dd");
             time = DateTime.Now.ToString("hh:mm:ss tt");
             process = process_te;
             TYPE = TYPE_te;

            if (cash_ch.Checked == true)
                move = "نقدا";
            else if (breached_ch.Checked == true)
                move = "آجل";
            else if (reverse_ch.Checked == true)
                move = "مرتجع";
            else
            {
                fn.label1.Text = "عذرا، اختر نوع الحركة";
                fn.ShowDialog();
                return;
            }
        }
        
        private void ADD_Catch(string date, string time, string process, string TYPE)
        {
            if (ID_Client == 0)
            {
                if(TYPE == "باقة" || TYPE == "فئة" || TYPE == "شريحة")
                    acc.ADD_Account_Table_Without_ID_Client(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                             user, this.DG2.CurrentRow.Cells[7].Value.ToString(), system_cobc.Text, TYPE);
                else if(TYPE == "الارضي")
                    acc.ADD_Account_Table_Without_ID_Client(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                             user, "Yaman.net", system_cobc.Text, TYPE);
                else if (TYPE == "ماء وكهرباء")
                    acc.ADD_Account_Table_Without_ID_Client(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                             user, TYPE, system_cobc.Text, TYPE);
            }
            else
            {
                if (TYPE == "باقة" || TYPE == "فئة" || TYPE == "شريحة")
                {
                    acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                       ID_Client, user,this.DG2.CurrentRow.Cells[7].Value.ToString(), system_cobc.Text, TYPE);

                    GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);
                    acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), time, process, move, int.Parse(REC_tx.Text), int.Parse(REC_tx.Text), int.Parse(BALANCE), text_tx.Text,
                                    ID_Client, user, TYPE, this.DG2.CurrentRow.Cells[6].Value.ToString(), GET_ID_Account);
                }
                else if (TYPE == "الارضي")
                {
                    acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                       ID_Client, user, "Yaman.net", system_cobc.Text, TYPE);

                    GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);
                    acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), time, process, move, int.Parse(REC_tx.Text), int.Parse(REC_tx.Text), int.Parse(BALANCE), text_tx.Text,
                                    ID_Client, user, TYPE, this.DG2.CurrentRow.Cells[4].Value.ToString(), GET_ID_Account);
                }
                else if (TYPE == "ماء وكهرباء")
                {
                    acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                       ID_Client, user, TYPE, system_cobc.Text, TYPE);

                    GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);
                    acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), time, process, move, int.Parse(REC_tx.Text), int.Parse(REC_tx.Text), int.Parse(BALANCE), text_tx.Text,
                                    ID_Client, user, TYPE, this.DG2.CurrentRow.Cells[4].Value.ToString(), GET_ID_Account);
                }
            }
        }
        private void ADD_Exchange(string date, string time, string process, string TYPE)
        {
            if (ID_Client == 0)
            {
                ME.label1.Text = "عذرا، أختر حساب العميل";
                ME.ShowDialog();
                return;
            }

            Form_you_pay_part ypp = new Form_you_pay_part();
            ypp.totel_tx.Text = REC_tx.Text;
            ypp.ShowDialog();
            if (ypp.sta == "pay")
            {
                ss = REC_tx.Text;
                if (int.Parse(REC_tx.Text) < int.Parse(ypp.pay_tx.Text))
                {
                    ME.label1.Text = " عفوا، مبلغ المدفوع أكبر من مبلغ المطلوب";
                    ME.ShowDialog();
                    return;
                }
                else if (int.Parse(REC_tx.Text) == int.Parse(ypp.pay_tx.Text))
                {
                    ME.label1.Text = " عفوا، مبلغ المدفوع يساوي مبلغ المطلوب";
                    ME.ShowDialog();
                    return;
                }
                sPAY = Convert.ToString(int.Parse(REC_tx.Text) - int.Parse(ypp.pay_tx.Text));
            }
            else if (ypp.sta == "on pay")
                return;

            REC_tx.Text = ypp.pay_tx.Text;

            if (ID_Client == 0)
            {
                ME.label1.Text = "عذرا، أختر حساب العميل";
                ME.ShowDialog();
                return;
            }
            else
            {
                if (TYPE == "باقة" || TYPE == "فئة" || TYPE == "شريحة")
                {
                    acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                       ID_Client, user, this.DG2.CurrentRow.Cells[7].Value.ToString()
                       , system_cobc.Text, TYPE);

                    GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);
                    acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), time, process, move, Convert.ToInt32("0"), int.Parse(sPAY), int.Parse(BALANCE), text_tx.Text,
                                        ID_Client, user, TYPE, this.DG2.CurrentRow.Cells[6].Value.ToString(), GET_ID_Account);
                }
                else if (TYPE == "الارضي")
                {
                    acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                       ID_Client, user, "Yaman.net", system_cobc.Text, TYPE);

                    GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);
                    acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), time, process, move, Convert.ToInt32("0"), int.Parse(sPAY), int.Parse(BALANCE), text_tx.Text,
                                        ID_Client, user, TYPE, this.DG2.CurrentRow.Cells[4].Value.ToString(), GET_ID_Account);
                }
                else if (TYPE == "ماء وكهرباء")
                {
                    acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                       ID_Client, user, TYPE
                       , system_cobc.Text, TYPE);

                    GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);
                    acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), time, process, move, Convert.ToInt32("0"), int.Parse(sPAY), int.Parse(BALANCE), text_tx.Text,
                                        ID_Client, user, TYPE, this.DG2.CurrentRow.Cells[4].Value.ToString(), GET_ID_Account);
                }
            }
        }

        private void calculators()
        {
            FOR_deposit = Convert.ToString(acc.SUM_FOR_deposit(Convert.ToInt32(system_cobc.SelectedValue)).Rows[0][0]);
            ON_deposit = Convert.ToString(acc.SUN_ON_deposit(Convert.ToInt32(system_cobc.SelectedValue)).Rows[0][0]);
            BALANCE_deposi = Convert.ToString(acc.SUM_BALANCE_deposit().Rows[0][0]);
            if_();
            BALANCE_tx.Text = Convert.ToString((int.Parse(BALANCE_deposi) + int.Parse(FOR_deposit)) - int.Parse(ON_deposit));

            no_debe_tx.Text = Convert.ToString(acc.SUM_no_debe(system_cobc.Text).Rows[0][0]);

            TOTEL_REC_tx.Text = Convert.ToString(acc.SUM_REC_Account(system_cobc.Text).Rows[0][0]);
            TOTEL_EXH_tx.Text = Convert.ToString(acc.SUM_EXH_Account(system_cobc.Text).Rows[0][0]);
            if_();
            TOTEL_tx.Text = Convert.ToString((int.Parse(TOTEL_REC_tx.Text) + int.Parse(no_debe_tx.Text)) - int.Parse(TOTEL_EXH_tx.Text));
        }
        private void ADD_SUB()
        {
            GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);

            acc.ADD_ON_deposit(Convert.ToDateTime(date), time, Convert.ToInt32(EXH_tx.Text), text_tx.Text, Convert.ToInt32(system_cobc.SelectedValue),
                                GET_ID_Account);


            DataGrid1.DataSource = acc.GET_Account_Table(system_cobc.Text);

            rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
            count_row_tx.Text = rowCunt.ToString();

            WITH_ch.Enabled = false;
            WITH_ch.Checked = false;

            //DG_category.DataSource = null;
            //DG_category.Refresh();
            DG2.DataSource = null;
            DG2.Refresh();

            calculators();
        }

        private void CLEAN()
        {
            REC_tx.Text = "";
            EXH_tx.Text = "";
            ID_Client = 0;
            client_tx.Text = "";
            DataGrid1.Refresh();
        }
        private void Alarm()
        {
            if (Settings.Default.Alarm_status == 1)
            {
                if (int.Parse(BALANCE_tx.Text) <= Convert.ToInt32(Settings.Default.Alarm))
                {
                    Form_Alarmcs FA = new Form_Alarmcs();
                    FA.ShowDialog();

                    FOR_deposit = Convert.ToString(acc.SUM_FOR_deposit(Convert.ToInt32(system_cobc.SelectedValue)).Rows[0][0]);
                    ON_deposit = Convert.ToString(acc.SUN_ON_deposit(Convert.ToInt32(system_cobc.SelectedValue)).Rows[0][0]);
                    
                    if_();
                    BALANCE_tx.Text = Convert.ToString((int.Parse(FOR_deposit)) - int.Parse(ON_deposit));
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form_Accounts_All FAM = new Form_Accounts_All();
            FAM.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {

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

        private void NAME_category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (NAME_category_cob.Text != string.Empty)
                {
                    DG2.DataSource = acc.GET_category_row(Convert.ToInt32(system_cobc.SelectedValue), NAME_category_cob.Text);

                    WITH_ch.Enabled = true;

                    if (WITH_ch.Checked == true)
                    {
                        REC_tx.Text = this.DG2.CurrentRow.Cells[4].Value.ToString();
                        EXH_tx.Text = this.DG2.CurrentRow.Cells[5].Value.ToString();
                    }
                    else
                    {
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
                }
                else
                    return;

            }

            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    VARIABLES(NAME_category_cob.Text, "فئة");

                    if (NAME_category_cob.Text != string.Empty && REC_tx.Text != string.Empty && EXH_tx.Text != string.Empty)
                    {
                        Alarm();
                        if (move == "نقدا") ADD_Catch(date, time, process, TYPE);

                        else if (move == "آجل") ADD_Exchange(date, time, process, TYPE);
                       
                        ADD_SUB();
                        CLEAN();
                    }
                    else
                    {
                        Form_not_logged FNL = new Form_not_logged();
                        FNL.label1.Text = "فشلت العملية , \nادخل بيانات المطلوبه";
                        FNL.ShowDialog();
                    }
                }
                catch
                {
                    ME.ShowDialog();
                }
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

        private void NAME_bunch_com_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (NAME_category_cob.Text != string.Empty)
                {
                    DG2.DataSource = acc.GET_bunch_row(Convert.ToInt32(system_cobc.SelectedValue), NAME_bunch_cob.Text);

                    WITH_ch.Enabled = true;

                    if (WITH_ch.Checked == true)
                    {
                        REC_tx.Text = this.DG2.CurrentRow.Cells[4].Value.ToString();
                        EXH_tx.Text = this.DG2.CurrentRow.Cells[5].Value.ToString();
                    }
                    else
                    {
                        try
                        {
                            REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                            EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                        }
                        catch 
                        {
                            Form_Mes_Error ME = new Form_Mes_Error();
                            ME.ShowDialog();
                        } 
                    }
                }
                else
                    return;
            }

            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    VARIABLES(NAME_bunch_cob.Text, "باقة");

                    if (NAME_category_cob.Text != string.Empty && REC_tx.Text != string.Empty && EXH_tx.Text != string.Empty)
                    {
                        if (move == "نقدا") ADD_Catch(date, time, process, TYPE);

                        else if (move == "آجل") ADD_Exchange(date, time, process, TYPE);

                        ADD_SUB();
                        CLEAN();
                    }
                    else
                    {
                        Form_not_logged FNL = new Form_not_logged();
                        FNL.label1.Text = "فشلت العملية، \nادخل بيانات المطلوبه";
                        FNL.ShowDialog();
                    }
                }
                catch
                {
                    ME.ShowDialog();
                }
            }   
        }

        private void WITH_ch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void WITH_ch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void WITH_ch_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form_Accounts_Load(object sender, EventArgs e)
        {
            //m.License();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NAME_slice_com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {   
            if (BALANCE_tx.Text == string.Empty || TOTEL_tx.Text == string.Empty || TOTEL_REC_tx.Text == string.Empty)
            {
                fn.label1.Text = "عفوا، اختر النظام أولا";
                fn.ShowDialog();
            }
            else
            {
                DataGrid1.DataSource = acc.GET_Account_Table(system_cobc.Text);

                rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                count_row_tx.Text = rowCunt.ToString();
            } 
        }

        private void NAME_telephone_cob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (NAME_telephone_cob.Text != string.Empty)
                {
                    DG2.DataSource = acc.GET_telephone_row(Convert.ToInt32(system_cobc.SelectedValue), NAME_telephone_cob.Text);

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
                else
                    return;

            }

            if (e.KeyCode == Keys.F2)
            {
               
                    VARIABLES(NAME_telephone_cob.Text, "الارضي");

                    if (NAME_category_cob.Text != string.Empty && REC_tx.Text != string.Empty && EXH_tx.Text != string.Empty)
                    {
                        if (move == "نقدا") ADD_Catch(date, time, process, TYPE);

                        else if (move == "آجل") ADD_Exchange(date, time, process, TYPE);

                        ADD_SUB();
                        CLEAN();
                    }
                    else
                    {
                        Form_not_logged FNL = new Form_not_logged();
                        FNL.label1.Text = "فشلت العملية , \nادخل بيانات المطلوبه";
                        FNL.ShowDialog();
                    }
                
                
            }
        }

        private void NAME_WandE_cob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) 
            {
                if (NAME_telephone_cob.Text != string.Empty)
                {
                    DG2.DataSource = acc.GET_NAME_WandE_row(Convert.ToInt32(system_cobc.SelectedValue), NAME_WandE_cob.Text);

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
                else
                    return;

            }

            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    VARIABLES(NAME_WandE_cob.Text, "ماء وكهرباء");

                    if (NAME_category_cob.Text != string.Empty && REC_tx.Text != string.Empty && EXH_tx.Text != string.Empty)
                    {
                        if (move == "نقدا") ADD_Catch(date, time, process, TYPE);

                        else if (move == "آجل") ADD_Exchange(date, time, process, TYPE);

                        ADD_SUB();
                        CLEAN();
                    }
                    else
                    {
                        Form_not_logged FNL = new Form_not_logged();
                        FNL.label1.Text = "فشلت العملية، \nادخل بيانات المطلوبه";
                        FNL.ShowDialog();
                    }
                }
                catch
                {
                    ME.ShowDialog();
                }
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void edit_bt_Click(object sender, EventArgs e)
        {
            Form_Accounts_Edit AE = new Form_Accounts_Edit();
            try
            {
                if (BALANCE_tx.Text == string.Empty || TOTEL_tx.Text == string.Empty || TOTEL_REC_tx.Text == string.Empty)
                {
                    fn.label1.Text = "عفوا، اختر النظام أولا";
                    fn.ShowDialog();
                }
                else
                {
                    AE.ID_Account       = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());

                    //AE.client_tx.Text = this.DataGrid1.CurrentRow.Cells[2].Value.ToString();
                    AE.move             = this.DataGrid1.CurrentRow.Cells[2].Value.ToString();
                    AE.process_NAME     = this.DataGrid1.CurrentRow.Cells[3].Value.ToString();
                    AE.TYPE_NAME        = this.DataGrid1.CurrentRow.Cells[4].Value.ToString();
                    AE.REC_tx.Text      = this.DataGrid1.CurrentRow.Cells[5].Value.ToString();
                    AE.EXH_tx.Text      = this.DataGrid1.CurrentRow.Cells[6].Value.ToString();
                    AE.system_cob.Text  = this.DataGrid1.CurrentRow.Cells[7].Value.ToString();
                    AE.ID_telecom       = this.DataGrid1.CurrentRow.Cells[8].Value.ToString();
                    AE.text_tx.Text     = this.DataGrid1.CurrentRow.Cells[11].Value.ToString();
                    AE.ID_Client        = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[10].Value.ToString());
                    //AE.ID_telecom       = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[11].Value.ToString());


                    AE.ShowDialog();

                    DataGrid1.DataSource = acc.GET_Account_Table(system_cobc.Text);

                    rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                    count_row_tx.Text = rowCunt.ToString();

                    calculators();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DELETE_bt_Click(object sender, EventArgs e)
        {
            try
            {
                if (BALANCE_tx.Text == string.Empty || TOTEL_tx.Text == string.Empty || TOTEL_REC_tx.Text == string.Empty)
                {
                    fn.label1.Text = "عفوا، اختر النظام أولا";
                    fn.ShowDialog();
                }
                else
                {
                    Form_Delete_Settings DS = new Form_Delete_Settings();
                    DS.ststs = "delete_acc";
                    DS.ID = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());
                    DS.ShowDialog();

                    DataGrid1.DataSource = acc.GET_Account_Table(system_cobc.Text);

                    rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                    count_row_tx.Text = rowCunt.ToString();

                    calculators();
                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show("Message Error " + ex ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NAME_slice_cob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (NAME_slice_cob.Text != string.Empty)
                {
                    DG2.DataSource = acc.GET_slice_row(Convert.ToInt32(system_cobc.SelectedValue), NAME_slice_cob.Text);

                    try
                    {
                        REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                        EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                    }
                    catch 
                    {
                        Form_Mes_Error ME = new Form_Mes_Error();
                        ME.ShowDialog();
                    }
                }
                else
                    return;

            }

            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    VARIABLES(NAME_slice_cob.Text, "شريحة");

                    if (NAME_category_cob.Text != string.Empty && REC_tx.Text != string.Empty && EXH_tx.Text != string.Empty)
                    {
                        if (move == "نقدا") ADD_Catch(date, time, process, TYPE);

                        else if (move == "آجل") ADD_Exchange(date, time, process, TYPE);

                        ADD_SUB();
                        CLEAN();
                    }
                    else
                    {
                        Form_not_logged FNL = new Form_not_logged();
                        FNL.label1.Text = "فشلت العملية، \nادخل بيانات المطلوبه";
                        FNL.ShowDialog();
                    }
                }
                catch
                {
                    ME.ShowDialog();
                }
            }
        }

        private void DG_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PDF_bt_Click(object sender, EventArgs e)
        {
            if (BALANCE_tx.Text == string.Empty || TOTEL_tx.Text == string.Empty || TOTEL_REC_tx.Text == string.Empty)
            {
                fn.label1.Text = "عفوا، اختر النظام أولا";
                fn.ShowDialog();
            }
            else
            {
                Report.Form_Accounts.Report1 R1 = new Report.Form_Accounts.Report1();
                R1.R_BALANCE    = BALANCE_tx.Text;
                R1.R_count_row  = count_row_tx.Text;
                R1.R_TOTEL      = TOTEL_tx.Text;
                R1.R_TOTEL_EXH  = TOTEL_EXH_tx.Text;
                R1.R_TOTEL_REC  = TOTEL_REC_tx.Text;
                R1.R_no_debe_tx = no_debe_tx.Text;
                R1.R_system_tx  = system_cobc.Text;
                R1.Show();
            }
        }

        private void WITH_ch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NAME_bunch_com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NAME_category_cob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WITH_ch_CheckStateChanged(object sender, EventArgs e)
        {
            if (WITH_ch.Checked == true)
            {
                REC_tx.Text = this.DG2.CurrentRow.Cells[4].Value.ToString();
                EXH_tx.Text = this.DG2.CurrentRow.Cells[5].Value.ToString();
                with = "مع السلفة";
                text_tx.Text = with;
            }
            else
            {
                REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                with = "";
                text_tx.Text = with;
            }
        }

        private void REC_tx_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void EXH_tx_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void text_tx_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void reverse_ch_CheckedChanged(object sender, EventArgs e)
        {
            cash_ch.Checked = false;
            breached_ch.Checked = false;
        }

        private void system_cob_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //DG_category.DataSource = null;
            //DG_category.Refresh(); 
            DG2.DataSource = null;
            DG2.Refresh();
            NAME_category_cob.Text = "";
            REC_tx.Text = "";
            EXH_tx.Text = "";

            DataGrid1.DataSource = acc.GET_Account_Table(system_cobc.Text);

            rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
            count_row_tx.Text = rowCunt.ToString();
            DataGrid1.Columns[0].Visible    = false;
            DataGrid1.Columns[10].Visible   = false;
            //DataGrid1.Columns[11].Visible   = false;
            //DataGrid1.Columns[12].Visible   = false;

            //DG_category.DataSource      = acc.GET_category_Table(Convert.ToInt32(system_cobc.SelectedValue));
            //DG_bunch.DataSource         = acc.GET_bunch_Table(Convert.ToInt32(system_cobc.SelectedValue));

            NAME_category_cob.DataSource    = acc.GET_category_Table(Convert.ToInt32(system_cobc.SelectedValue));
            NAME_category_cob.DisplayMember = "NAME_category";
            NAME_category_cob.ValueMember   = "ID_category";

            NAME_bunch_cob.DataSource       = acc.GET_NAME_bunch(Convert.ToInt32(system_cobc.SelectedValue));
            NAME_bunch_cob.DisplayMember    = "NAME_bunch";
            NAME_bunch_cob.ValueMember      = "ID_bunch";

            NAME_slice_cob.DataSource       = acc.GET_slice_Table(Convert.ToInt32(system_cobc.SelectedValue));
            NAME_slice_cob.DisplayMember    = "NAME_slice";
            NAME_slice_cob.ValueMember      = "ID_slice";

            NAME_telephone_cob.DataSource       = acc.GET_telephone_Table(Convert.ToInt32(system_cobc.SelectedValue));
            NAME_telephone_cob.DisplayMember    = "NAME_telephone";
            NAME_telephone_cob.ValueMember      = "ID_telephone";

            NAME_WandE_cob.DataSource       = acc.GET_water_And_Electricity_Table(Convert.ToInt32(system_cobc.SelectedValue));
            NAME_WandE_cob.DisplayMember    = "NAME_WandE";
            NAME_WandE_cob.ValueMember      = "ID_WandE";

            calculators();

            Alarm();
        }
    }
}

