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
    public partial class Form_Accounts : Form
    {
        public int ID_Client, rowCunt, ID_Account, GET_ID_Account;
        public string FOR_deposit, ON_deposit, BALANCE_deposi, state = "add", move, text, with, BALANCE, BALANCE_debt, sPAY, ss;
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        Form_not_logged fn = new Form_not_logged();
        public Form_Accounts()
        {
            InitializeComponent();

            system_cob.DataSource = acc.GET_NAME_system();
            system_cob.DisplayMember = "NAME_system";
            system_cob.ValueMember = "ID_system";

            ID_Client = 1;
            client_tx.Text = "زبون";

            DG_NAME_REC_EXH.DataSource = acc.GET_NAME_REC_EXH();

            Properties.Settings.Default.Alarm_status = 1;
            Properties.Settings.Default.Save();

            //DataGrid1.Columns[5].Visible = false;

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

            //if(TOTEL_tx.Text == string.Empty)
            //    TOTEL_tx.Text = "0";
            //if (TOTEL_tx.Text == string.Empty)
            //    TOTEL_tx.Text = "0";
        }

        private void Alarm()
        {
            if (Properties.Settings.Default.Alarm_status == 1)
            {
                if (int.Parse(BALANCE_tx.Text) <= Convert.ToInt32(Properties.Settings.Default.Alarm))
                {
                    Form_Alarmcs FA = new Form_Alarmcs();
                    FA.ShowDialog();

                    FOR_deposit = Convert.ToString(acc.SUM_FOR_deposit(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    ON_deposit = Convert.ToString(acc.SUN_ON_deposit(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    BALANCE_deposi = Convert.ToString(acc.SUM_BALANCE_deposit().Rows[0][0]);
                    if_();
                    BALANCE_tx.Text = Convert.ToString((int.Parse(BALANCE_deposi) + int.Parse(FOR_deposit)) - int.Parse(ON_deposit));
                }
            }
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form_Accounts_Manth FAM = new Form_Accounts_Manth();
            FAM.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void NAME_category_KeyUp(object sender, KeyEventArgs e)
        {
            //REC_tx.Text = NAME_category.Text;
            //DataGrid dg = new DataGrid();
            //if (NAME_category.Text != string.Empty)
            //{

            //    DG.DataSource = acc.GET_category_Table(Int32.Parse(NAME_category.Text));


            //    REC_tx.Text = this.DG.CurrentRow.Cells[2].Value.ToString();
            //    EXH_tx.Text = this.DG.CurrentRow.Cells[3].Value.ToString();
            //}
            //else
            //    return;

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

        private void NAME_category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (NAME_category_cob.Text != string.Empty)
                {
                    DG2.DataSource = acc.GET_category_row(Convert.ToInt32(system_cob.SelectedValue), NAME_category_cob.Text);

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
                        catch(Exception ex)
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
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string time = DateTime.Now.ToString("hh:mm:ss tt");
                string process = NAME_category_cob.Text;
                string TYPE = "فئة";

                if (cash_ch.Checked == true)
                    move = "نقدا";
                else if (breached_ch.Checked == true)
                    move = "آجل";
                else if (reverse_ch.Checked == true)
                    move = "مرتجع";
                else
                {
                    fn.label1.Text = "غذرا /n اختر نوع الحركة نقدا أو آجل";
                    fn.ShowDialog();
                    return;

                }

                if (NAME_category_cob.Text != string.Empty && REC_tx.Text != string.Empty && EXH_tx.Text != string.Empty)
                {

                    if (state == "add")
                    {
                       if (move == "نقدا")
                        {
                            Alarm();
                            acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                                    ID_Client, 1, Convert.ToInt32(this.DG2.CurrentRow.Cells[7].Value.ToString())
                                    , Convert.ToInt32(this.DG2.CurrentRow.Cells[6].Value.ToString()), TYPE);


                            BALANCE = Convert.ToString(acc.GET_BALANCE_debt(ID_Client).Rows[0][0]);
                            GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);

                            acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), time, process , move, int.Parse(REC_tx.Text), int.Parse(REC_tx.Text), int.Parse(BALANCE), text_tx.Text,
                                                    ID_Client, 1, TYPE, Convert.ToInt32(this.DG2.CurrentRow.Cells[6].Value.ToString()), GET_ID_Account);
                        }
                        if (move == "آجل")
                        {
                            Alarm();
                            BALANCE = Convert.ToString(acc.GET_BALANCE_debt(ID_Client).Rows[0][0]);
                            if_();
                            BALANCE_debt = Convert.ToString(int.Parse(BALANCE) + int.Parse(REC_tx.Text));

                            Form_you_pay_part ypp = new Form_you_pay_part();
                            ypp.totel_tx.Text = REC_tx.Text;
                            ypp.ShowDialog();
                            if (ypp.sta == "pay")
                            {
                                ss = REC_tx.Text;
                                sPAY = Convert.ToString(int.Parse(REC_tx.Text) - int.Parse(ypp.pay_tx.Text));
                                BALANCE_debt = Convert.ToString(int.Parse(BALANCE) + int.Parse(sPAY));
                                //if (ypp.pay_tx.Text != string.Empty)
                                //    sPAY = "0";
                            }
                            else if (ypp.sta == "on pay")
                                return;
                            //sPAY = REC_tx.Text;

                            REC_tx.Text = ypp.pay_tx.Text;

                            acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                                    ID_Client, 1, Convert.ToInt32(this.DG2.CurrentRow.Cells[7].Value.ToString())
                                    , Convert.ToInt32(this.DG2.CurrentRow.Cells[6].Value.ToString()), TYPE);

                            GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);

                            acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), time, process, move, Convert.ToInt32("0"), int.Parse(sPAY), int.Parse(BALANCE_debt), text_tx.Text,
                                                ID_Client, 1, TYPE, Convert.ToInt32(this.DG2.CurrentRow.Cells[6].Value.ToString()), GET_ID_Account);
                            

                        }
                        GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);

                        acc.ADD_ON_deposit(Convert.ToDateTime(date), time, Convert.ToInt32(EXH_tx.Text), text_tx.Text, Convert.ToInt32(system_cob.SelectedValue),
                                            GET_ID_Account);

                        DataGrid1.DataSource = acc.GET_Account_Table(Convert.ToInt32(system_cob.SelectedValue));

                        rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                        count_row_tx.Text = rowCunt.ToString();

                        WITH_ch.Enabled = false;
                        WITH_ch.Checked = false;

                        DG_category.DataSource = null;
                        DG_category.Refresh();
                        DG2.DataSource = null;
                        DG2.Refresh();
                    }
                    

                    //if (state == "update")
                    //{
                    //    text = text_tx.Text + " | تم التعديل من قبل" + 1;
                    //    acc.EDIT_Account_Table(ID_Account, NAME_category_cob.Text, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text,
                    //                           ID_Client, Convert.ToInt32(this.DG2.CurrentRow.Cells[7].Value.ToString()), Convert.ToInt32(system_cob.SelectedValue));

                    //    acc.EDIT_NO_deposit( Convert.ToInt32(EXH_tx.Text), text_tx.Text, Convert.ToInt32(system_cob.SelectedValue),
                    //                        Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString()));

                    //    NAME_slice_cob.Enabled = true;
                    //    NAME_bunch_cob.Enabled = true;

                    //    Form_logged FL = new Form_logged();
                    //    FL.label1.Text = "تم التعديل";
                    //    FL.ShowDialog();
                        
                    //    DG_category.DataSource = null;
                    //    DG_category.Refresh();
                    //    DG2.DataSource = null;
                    //    DG2.Refresh();

                    //}

                    DataGrid1.DataSource = acc.GET_Account_Table(Convert.ToInt32(system_cob.SelectedValue));

                    rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                    count_row_tx.Text = rowCunt.ToString();

                    FOR_deposit = Convert.ToString(acc.SUM_FOR_deposit(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    ON_deposit = Convert.ToString(acc.SUN_ON_deposit(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    BALANCE_deposi = Convert.ToString(acc.SUM_BALANCE_deposit().Rows[0][0]);

                    if_();
                    no_debe_tx.Text = Convert.ToString(acc.SUM_no_debe(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);

                    BALANCE_tx.Text = Convert.ToString((int.Parse(BALANCE_deposi) + int.Parse(FOR_deposit)) - int.Parse(ON_deposit));

                    TOTEL_REC_tx.Text = Convert.ToString(acc.SUM_REC_Account(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    TOTEL_EXH_tx.Text = Convert.ToString(acc.SUM_EXH_Account(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    if_();
                    TOTEL_tx.Text = Convert.ToString(int.Parse(TOTEL_REC_tx.Text) - int.Parse(TOTEL_EXH_tx.Text));

                    REC_tx.Text = "";
                    EXH_tx.Text = "";
                    ID_Client = 1;
                    client_tx.Text = "زبون";
                    state = "add";
                    DataGrid1.Refresh();
                }
                else
                {
                    Form_not_logged FNL = new Form_not_logged();
                    FNL.label1.Text = "فشلت العملية , \nادخل بيانات المطلوبه";
                    FNL.ShowDialog();
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
                    DG2.DataSource = acc.GET_bunch_row(Convert.ToInt32(system_cob.SelectedValue), NAME_bunch_cob.Text);

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
                        catch (Exception ex)
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


                string date = DateTime.Now.ToString("MM-dd-yyyy");
                string time = DateTime.Now.ToString("hh:mm:ss tt");
                string process = NAME_bunch_cob.Text;
                string TYPE = "باقة";


                if (cash_ch.Checked == true)
                    move = "نقدا";
                else if (breached_ch.Checked == true)
                    move = "آجل";
                else if (reverse_ch.Checked == true)
                    move = "مرتجع";
                else
                    move = "";

                if (NAME_bunch_cob.Text != string.Empty && REC_tx.Text != string.Empty && EXH_tx.Text != string.Empty)
                {

                    if (state == "add")
                    {
                        if (move == "نقدا")
                        {
                            acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                                    ID_Client, 1, Convert.ToInt32(this.DG2.CurrentRow.Cells[7].Value.ToString())
                                    , Convert.ToInt32(this.DG2.CurrentRow.Cells[6].Value.ToString()), TYPE);

                            BALANCE = Convert.ToString(acc.GET_BALANCE_debt(ID_Client).Rows[0][0]);

                            GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);

                            acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), time, process, move, int.Parse(REC_tx.Text), int.Parse(REC_tx.Text), int.Parse(BALANCE), text_tx.Text,
                                                    ID_Client, 1, TYPE, Convert.ToInt32(this.DG2.CurrentRow.Cells[6].Value.ToString()), GET_ID_Account);
                        }

                        if (move == "آجل")
                        {
                            BALANCE = Convert.ToString(acc.GET_BALANCE_debt(ID_Client).Rows[0][0]);
                            if_();
                            BALANCE_debt = Convert.ToString(int.Parse(BALANCE) + int.Parse(REC_tx.Text));

                            Form_you_pay_part ypp = new Form_you_pay_part();
                            ypp.totel_tx.Text = REC_tx.Text;
                            ypp.ShowDialog();
                            if (ypp.sta == "pay")
                            {
                                ss = REC_tx.Text;
                                sPAY = Convert.ToString(int.Parse(REC_tx.Text) - int.Parse(ypp.pay_tx.Text));
                                BALANCE_debt = Convert.ToString(int.Parse(BALANCE) + int.Parse(sPAY));
                                //if (ypp.pay_tx.Text != string.Empty)
                                //    sPAY = "0";
                            }
                            else if (ypp.sta == "on pay")
                                return;

                            REC_tx.Text = ypp.pay_tx.Text;

                            acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                                    ID_Client, 1, Convert.ToInt32(this.DG2.CurrentRow.Cells[7].Value.ToString())
                                    , Convert.ToInt32(this.DG2.CurrentRow.Cells[6].Value.ToString()), TYPE);

                            GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);

                            acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), time, process, move, Convert.ToInt32("0"), int.Parse(sPAY), int.Parse(BALANCE_debt), text_tx.Text,
                                                ID_Client, 1, TYPE, Convert.ToInt32(this.DG2.CurrentRow.Cells[6].Value.ToString()), GET_ID_Account);
                            
                        }
                        //acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                        //            ID_Client, 1, Convert.ToInt32(this.DG2.CurrentRow.Cells[7].Value.ToString())
                        //            , Convert.ToInt32(this.DG2.CurrentRow.Cells[6].Value.ToString()), TYPE);

                        GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);

                        acc.ADD_ON_deposit(Convert.ToDateTime(date), time, Convert.ToInt32(EXH_tx.Text), text_tx.Text, Convert.ToInt32(system_cob.SelectedValue),
                                            GET_ID_Account);

                        WITH_ch.Enabled = false;
                        WITH_ch.Checked = false;

                        DG_category.DataSource = null;
                        DG_category.Refresh();
                        DG2.DataSource = null;
                        DG2.Refresh();
                    }


                    //if (state == "update")
                    //{
                    //text = text_tx.Text + " | تم التعديل من قبل" + 1;
                    //acc.EDIT_Account_Table(ID_Account, NAME_category_cob.Text, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text,
                    //                       ID_Client, Convert.ToInt32(this.DG2.CurrentRow.Cells[7].Value.ToString()), Convert.ToInt32(system_cob.SelectedValue));

                    //    acc.EDIT_NO_deposit(Convert.ToInt32(EXH_tx.Text), text_tx.Text, Convert.ToInt32(system_cob.SelectedValue),
                    //                        Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString()));

                    //    NAME_slice_cob.Enabled = true;
                    //    NAME_bunch_cob.Enabled = true;

                    //    Form_logged FL = new Form_logged();
                    //    FL.label1.Text = "تم التعديل";
                    //    FL.ShowDialog();

                    //    DG_category.DataSource = null;
                    //    DG_category.Refresh();
                    //    DG2.DataSource = null;
                    //    DG2.Refresh();

                    //}

                    DataGrid1.DataSource = acc.GET_Account_Table(Convert.ToInt32(system_cob.SelectedValue));

                    rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                    count_row_tx.Text = rowCunt.ToString();

                    FOR_deposit = Convert.ToString(acc.SUM_FOR_deposit(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    ON_deposit = Convert.ToString(acc.SUN_ON_deposit(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    BALANCE_deposi = Convert.ToString(acc.SUM_BALANCE_deposit().Rows[0][0]);

                    if_();
                    no_debe_tx.Text = Convert.ToString(acc.SUM_no_debe(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);

                    BALANCE_tx.Text = Convert.ToString((int.Parse(BALANCE_deposi) + int.Parse(FOR_deposit)) - int.Parse(ON_deposit));

                    TOTEL_REC_tx.Text = Convert.ToString(acc.SUM_REC_Account(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    TOTEL_EXH_tx.Text = Convert.ToString(acc.SUM_EXH_Account(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    if_();
                    TOTEL_tx.Text = Convert.ToString(int.Parse(TOTEL_REC_tx.Text) - int.Parse(TOTEL_EXH_tx.Text));

                    REC_tx.Text = "";
                    EXH_tx.Text = "";
                    ID_Client = 1;
                    client_tx.Text = "زبون";
                    state = "add";
                    DataGrid1.Refresh();
                }
                else
                {
                    Form_not_logged FNL = new Form_not_logged();
                    FNL.label1.Text = "فشلت العملية , \nادخل بيانات المطلوبه";
                    FNL.ShowDialog();
                }
                Alarm();
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

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NAME_slice_com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            DataGrid1.DataSource = acc.GET_Account_Table(Convert.ToInt32(system_cob.SelectedValue));
        }

        private void NAME_telephone_cob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (NAME_telephone_cob.Text != string.Empty)
                {
                    DG2.DataSource = acc.GET_telephone_row(Convert.ToInt32(system_cob.SelectedValue), NAME_telephone_cob.Text);

                    try
                    {
                        REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                        EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                    }
                    catch (Exception ex)
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

                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string time = DateTime.Now.ToString("hh:mm:ss tt");
                string process = NAME_telephone_cob.Text;
                string TYPE = "هاتف";

                if (cash_ch.Checked == true)
                    move = "نقدا";
                else if (breached_ch.Checked == true)
                    move = "آجل";
                else if (reverse_ch.Checked == true)
                    move = "مرتجع";
                else
                    move = "";

                if (NAME_telephone_cob.Text != string.Empty && REC_tx.Text != string.Empty && EXH_tx.Text != string.Empty)
                {
                    if (move == "نقدا")
                    {
                        Alarm();
                        acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                                ID_Client, 1, 1
                                , Convert.ToInt32(this.DG2.CurrentRow.Cells[4].Value.ToString()), TYPE);

                        BALANCE = Convert.ToString(acc.GET_BALANCE_debt(ID_Client).Rows[0][0]);

                        GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);

                        acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), time, process, move, int.Parse(REC_tx.Text), int.Parse(REC_tx.Text), int.Parse(BALANCE), text_tx.Text,
                                                ID_Client, 1, TYPE, Convert.ToInt32(this.DG2.CurrentRow.Cells[4].Value.ToString()), GET_ID_Account);
                    }
                    if (move == "آجل")
                    {
                        Alarm();
                        BALANCE = Convert.ToString(acc.GET_BALANCE_debt(ID_Client).Rows[0][0]);
                        if_();
                        BALANCE_debt = Convert.ToString(int.Parse(BALANCE) + int.Parse(REC_tx.Text));

                        Form_you_pay_part ypp = new Form_you_pay_part();
                        ypp.totel_tx.Text = REC_tx.Text;
                        ypp.ShowDialog();
                        if (ypp.sta == "pay")
                        {
                            ss = REC_tx.Text;
                            sPAY = Convert.ToString(int.Parse(REC_tx.Text) - int.Parse(ypp.pay_tx.Text));
                            BALANCE_debt = Convert.ToString(int.Parse(BALANCE) + int.Parse(sPAY));
                            //if (ypp.pay_tx.Text != string.Empty)
                            //    sPAY = "0";
                        }
                        else if (ypp.sta == "on pay")
                            return;
                        //sPAY = REC_tx.Text;

                        REC_tx.Text = ypp.pay_tx.Text;


                        acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                                ID_Client, 1, 1
                                , Convert.ToInt32(this.DG2.CurrentRow.Cells[4].Value.ToString()), TYPE);

                        GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);

                        acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), time, process, move, Convert.ToInt32("0"), int.Parse(sPAY), int.Parse(BALANCE_debt), text_tx.Text,
                                            ID_Client, 1, TYPE, Convert.ToInt32(this.DG2.CurrentRow.Cells[4].Value.ToString()), GET_ID_Account);
                        

                    }
                    GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);

                    acc.ADD_ON_deposit(Convert.ToDateTime(date), time, Convert.ToInt32(EXH_tx.Text), text_tx.Text, Convert.ToInt32(system_cob.SelectedValue),
                                        GET_ID_Account);

                    DataGrid1.DataSource = acc.GET_Account_Table(Convert.ToInt32(system_cob.SelectedValue));

                    rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                    count_row_tx.Text = rowCunt.ToString();

                    WITH_ch.Enabled = false;
                    WITH_ch.Checked = false;

                    DG_category.DataSource = null;
                    DG_category.Refresh();
                    DG2.DataSource = null;
                    DG2.Refresh();


                    DataGrid1.DataSource = acc.GET_Account_Table(Convert.ToInt32(system_cob.SelectedValue));

                    rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                    count_row_tx.Text = rowCunt.ToString();

                    FOR_deposit = Convert.ToString(acc.SUM_FOR_deposit(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    ON_deposit = Convert.ToString(acc.SUN_ON_deposit(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    BALANCE_deposi = Convert.ToString(acc.SUM_BALANCE_deposit().Rows[0][0]);

                    if_();
                    no_debe_tx.Text = Convert.ToString(acc.SUM_no_debe(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);

                    BALANCE_tx.Text = Convert.ToString((int.Parse(BALANCE_deposi) + int.Parse(FOR_deposit)) - int.Parse(ON_deposit));

                    TOTEL_REC_tx.Text = Convert.ToString(acc.SUM_REC_Account(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    TOTEL_EXH_tx.Text = Convert.ToString(acc.SUM_EXH_Account(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    if_();
                    TOTEL_tx.Text = Convert.ToString(int.Parse(TOTEL_REC_tx.Text) - int.Parse(TOTEL_EXH_tx.Text));

                    REC_tx.Text = "";
                    EXH_tx.Text = "";
                    ID_Client = 1;
                    client_tx.Text = "زبون";
                    state = "add";
                    DataGrid1.Refresh();
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
                    DG2.DataSource = acc.GET_NAME_WandE_row(Convert.ToInt32(system_cob.SelectedValue), NAME_WandE_cob.Text);

                    try
                    {
                        REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                        EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                    }
                    catch (Exception ex)
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

                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string time = DateTime.Now.ToString("hh:mm:ss tt");
                string process = NAME_WandE_cob.Text;
                string TYPE = "ماء وكهرباء";

                if (cash_ch.Checked == true)
                    move = "نقدا";
                else if (breached_ch.Checked == true)
                    move = "آجل";
                else if (reverse_ch.Checked == true)
                    move = "مرتجع";
                else
                    move = "";

                if (NAME_telephone_cob.Text != string.Empty && REC_tx.Text != string.Empty && EXH_tx.Text != string.Empty)
                {
                    if (move == "نقدا")
                    {
                        Alarm();
                        acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                                ID_Client, 1, 1
                                , Convert.ToInt32(this.DG2.CurrentRow.Cells[4].Value.ToString()), TYPE);

                        BALANCE = Convert.ToString(acc.GET_BALANCE_debt(ID_Client).Rows[0][0]);
                        GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);

                        acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), time, process, move, int.Parse(REC_tx.Text), int.Parse(REC_tx.Text), int.Parse(BALANCE), text_tx.Text,
                                                ID_Client, 1, TYPE, Convert.ToInt32(this.DG2.CurrentRow.Cells[4].Value.ToString()), GET_ID_Account);


                    }
                    if (move == "آجل")
                    {
                        Alarm();
                        BALANCE = Convert.ToString(acc.GET_BALANCE_debt(ID_Client).Rows[0][0]);
                        if_();
                        BALANCE_debt = Convert.ToString(int.Parse(BALANCE) + int.Parse(REC_tx.Text));

                        Form_you_pay_part ypp = new Form_you_pay_part();
                        ypp.totel_tx.Text = REC_tx.Text;
                        ypp.ShowDialog();
                        if (ypp.sta == "pay")
                        {
                            ss = REC_tx.Text;
                            sPAY = Convert.ToString(int.Parse(REC_tx.Text) - int.Parse(ypp.pay_tx.Text));
                            BALANCE_debt = Convert.ToString(int.Parse(BALANCE) + int.Parse(sPAY));
                            //if (ypp.pay_tx.Text != string.Empty)
                            //    sPAY = "0";
                        }
                        else if (ypp.sta == "on pay")
                            return;
                        //sPAY = REC_tx.Text;

                        REC_tx.Text = ypp.pay_tx.Text;

                        acc.ADD_Account_Table(Convert.ToDateTime(date), time, process, move, Convert.ToInt32(REC_tx.Text), Convert.ToInt32(EXH_tx.Text), text_tx.Text,
                                ID_Client, 1, 1
                                , Convert.ToInt32(this.DG2.CurrentRow.Cells[4].Value.ToString()), TYPE);

                        GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);

                        acc.ADD_debt_Table_and_ID_Account(Convert.ToDateTime(date), time, process, move, Convert.ToInt32("0"), int.Parse(sPAY), int.Parse(BALANCE_debt), text_tx.Text,
                                            ID_Client, 1, TYPE, Convert.ToInt32(this.DG2.CurrentRow.Cells[4].Value.ToString()), GET_ID_Account);
                        

                    }
                    GET_ID_Account = Convert.ToInt32(acc.GET_ID_Account().Rows[0][0]);

                    acc.ADD_ON_deposit(Convert.ToDateTime(date), time, Convert.ToInt32(EXH_tx.Text), text_tx.Text, Convert.ToInt32(system_cob.SelectedValue),
                                        GET_ID_Account);

                    DataGrid1.DataSource = acc.GET_Account_Table(Convert.ToInt32(system_cob.SelectedValue));

                    rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                    count_row_tx.Text = rowCunt.ToString();

                    WITH_ch.Enabled = false;
                    WITH_ch.Checked = false;

                    DG_category.DataSource = null;
                    DG_category.Refresh();
                    DG2.DataSource = null;
                    DG2.Refresh();


                    DataGrid1.DataSource = acc.GET_Account_Table(Convert.ToInt32(system_cob.SelectedValue));

                    rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                    count_row_tx.Text = rowCunt.ToString();

                    FOR_deposit = Convert.ToString(acc.SUM_FOR_deposit(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    ON_deposit = Convert.ToString(acc.SUN_ON_deposit(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    BALANCE_deposi = Convert.ToString(acc.SUM_BALANCE_deposit().Rows[0][0]);

                    if_();
                    no_debe_tx.Text = Convert.ToString(acc.SUM_no_debe(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);

                    BALANCE_tx.Text = Convert.ToString((int.Parse(BALANCE_deposi) + int.Parse(FOR_deposit)) - int.Parse(ON_deposit));

                    TOTEL_REC_tx.Text = Convert.ToString(acc.SUM_REC_Account(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    TOTEL_EXH_tx.Text = Convert.ToString(acc.SUM_EXH_Account(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
                    if_();
                    TOTEL_tx.Text = Convert.ToString(int.Parse(TOTEL_REC_tx.Text) - int.Parse(TOTEL_EXH_tx.Text));

                    REC_tx.Text = "";
                    EXH_tx.Text = "";
                    ID_Client = 1;
                    client_tx.Text = "زبون";
                    state = "add";
                    DataGrid1.Refresh();
                }
                else
                {
                    Form_not_logged FNL = new Form_not_logged();
                    FNL.label1.Text = "فشلت العملية , \nادخل بيانات المطلوبه";
                    FNL.ShowDialog();
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
            AE.ID_Account = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());
            AE.system_cob.Text = this.DataGrid1.CurrentRow.Cells[7].Value.ToString();
            AE.client_tx.Text = this.DataGrid1.CurrentRow.Cells[2].Value.ToString();
            AE.move = this.DataGrid1.CurrentRow.Cells[3].Value.ToString();
            AE.process_NAME = this.DataGrid1.CurrentRow.Cells[4].Value.ToString();
            AE.TYPE_cob.Text = this.DataGrid1.CurrentRow.Cells[5].Value.ToString();
            AE.REC_tx.Text = this.DataGrid1.CurrentRow.Cells[6].Value.ToString();
            AE.EXH_tx.Text = this.DataGrid1.CurrentRow.Cells[7].Value.ToString();
            AE.text_tx.Text = this.DataGrid1.CurrentRow.Cells[10].Value.ToString();
            AE.ID_Client = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[11].Value.ToString());
            AE.ID_telecom = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[12].Value.ToString());
            AE.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DELETE_bt_Click(object sender, EventArgs e)
        {
            Form_Delete_Settings DS = new Form_Delete_Settings();
            DS.ststs = "delete_acc";
            DS.ID = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());
            DS.ShowDialog();

            DataGrid1.DataSource = acc.GET_Account_Table(Convert.ToInt32(system_cob.SelectedValue));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                state = "update";

                DG_category.DataSource = null;
                DG_category.Refresh();
                DG2.DataSource = null;
                DG2.Refresh();

                system_cob.Text = this.DataGrid1.CurrentRow.Cells[8].Value.ToString();
                DG_category.DataSource = acc.GET_category_Table(Convert.ToInt32(system_cob.SelectedValue));
                //DG_bunch.DataSource = acc.GET_bunch_Table(Convert.ToInt32(system_cob.SelectedValue));

                NAME_category_cob.DataSource = acc.GET_category_Table(Convert.ToInt32(system_cob.SelectedValue));
                NAME_category_cob.DisplayMember = "NAME_category";
                NAME_category_cob.ValueMember = "ID_category";

                //NAME_bunch_com.DataSource = acc.GET_NAME_bunch(Convert.ToInt32(system_cob.SelectedValue));
                //NAME_bunch_com.DisplayMember = "NAME_bunch";
                //NAME_bunch_com.ValueMember = "ID_bunch";

               

                string TYPE = this.DataGrid1.CurrentRow.Cells[5].Value.ToString();

                //if (TYPE == "فئة")
                //{
                //DG2.DataSource = acc.GET_category_row(Convert.ToInt32(system_cob.SelectedValue), NAME_category_cob.Text);


                ID_Account = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());
                client_tx.Text = this.DataGrid1.CurrentRow.Cells[2].Value.ToString();
                move = this.DataGrid1.CurrentRow.Cells[3].Value.ToString();
                NAME_category_cob.Text = this.DataGrid1.CurrentRow.Cells[4].Value.ToString();
                REC_tx.Text = this.DataGrid1.CurrentRow.Cells[6].Value.ToString();
                EXH_tx.Text = this.DataGrid1.CurrentRow.Cells[7].Value.ToString();
                text_tx.Text = this.DataGrid1.CurrentRow.Cells[10].Value.ToString();
                ID_Client = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[11].Value.ToString());
                NAME_slice_cob.Enabled = false;
                NAME_bunch_cob.Enabled = false;
                DataGrid1.Rows.RemoveAt(DataGrid1.CurrentRow.Index);
                

                //    if (NAME_category_cob.Text != string.Empty)
                //    {
                //        DG2.DataSource = acc.GET_category_row(Convert.ToInt32(system_cob.SelectedValue), NAME_category_cob.Text);

                //        REC_tx.Text = this.DG2.CurrentRow.Cells[2].Value.ToString();
                //        EXH_tx.Text = this.DG2.CurrentRow.Cells[3].Value.ToString();
                //    }
                //    else
                //        return;
                //}



                //if (move == "نقدا")
                //{
                //    cash_ch.Checked = true;
                //    cash_ch.Checked = true;
                //}
                //else if (move == "آجل")
                //{
                //    breached_ch.Checked = true;
                //    breached_ch.Checked = true;
                //}
                //else if (move == "مرتجع")
                //{
                //    reverse_ch.Checked = true;
                //    reverse_ch.Checked = true;
                //}




            }
            catch
            {
                return;
            }
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
            DG_category.DataSource = null;
            DG_category.Refresh(); 
            DG2.DataSource = null;
            DG2.Refresh();
            NAME_category_cob.Text = "";
            REC_tx.Text = "";
            EXH_tx.Text = "";

            DataGrid1.DataSource = acc.GET_Account_Table(Convert.ToInt32(system_cob.SelectedValue));

            rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
            count_row_tx.Text = rowCunt.ToString();
            DataGrid1.Columns[0].Visible = false;

            DG_category.DataSource = acc.GET_category_Table(Convert.ToInt32(system_cob.SelectedValue));
            DG_bunch.DataSource = acc.GET_bunch_Table(Convert.ToInt32(system_cob.SelectedValue));

            NAME_category_cob.DataSource = acc.GET_category_Table(Convert.ToInt32(system_cob.SelectedValue));
            NAME_category_cob.DisplayMember = "NAME_category";
            NAME_category_cob.ValueMember = "ID_category";

            NAME_bunch_cob.DataSource = acc.GET_NAME_bunch(Convert.ToInt32(system_cob.SelectedValue));
            NAME_bunch_cob.DisplayMember = "NAME_bunch";
            NAME_bunch_cob.ValueMember = "ID_bunch";

            NAME_slice_cob.DataSource = acc.GET_slice_Table(Convert.ToInt32(system_cob.SelectedValue));
            NAME_slice_cob.DisplayMember = "NAME_slice";
            NAME_slice_cob.ValueMember = "ID_slice";

            NAME_telephone_cob.DataSource = acc.GET_telephone_Table(Convert.ToInt32(system_cob.SelectedValue));
            NAME_telephone_cob.DisplayMember = "NAME_telephone";
            NAME_telephone_cob.ValueMember = "ID_telephone";

            NAME_WandE_cob.DataSource = acc.GET_water_And_Electricity_Table(Convert.ToInt32(system_cob.SelectedValue));
            NAME_WandE_cob.DisplayMember = "NAME_WandE";
            NAME_WandE_cob.ValueMember = "ID_WandE";

            FOR_deposit = Convert.ToString(acc.SUM_FOR_deposit(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
            ON_deposit = Convert.ToString(acc.SUN_ON_deposit(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
            BALANCE_deposi = Convert.ToString(acc.SUM_BALANCE_deposit().Rows[0][0]);
            if_();
            BALANCE_tx.Text = Convert.ToString((int.Parse(BALANCE_deposi) + int.Parse(FOR_deposit)) - int.Parse(ON_deposit));

            no_debe_tx.Text = Convert.ToString(acc.SUM_no_debe(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);

            TOTEL_REC_tx.Text = Convert.ToString(acc.SUM_REC_Account(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
            TOTEL_EXH_tx.Text = Convert.ToString(acc.SUM_EXH_Account(Convert.ToInt32(system_cob.SelectedValue)).Rows[0][0]);
            if_();
            TOTEL_tx.Text = Convert.ToString(int.Parse(TOTEL_REC_tx.Text) - int.Parse(TOTEL_EXH_tx.Text));

            Alarm();
        }
    }
}

