using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_1.Uesr_Contril_Layer
{
    public partial class User_deposit_settings : UserControl
    {
        Form_Layer.Form_Deposit FD = new Form_Layer.Form_Deposit();
        Business_Layer.Settings S = new Business_Layer.Settings();
        Form_Layer.Form_Delete_Settings DS = new Form_Layer.Form_Delete_Settings();
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        Form_Layer.Form_logged fl = new Form_Layer.Form_logged();
        Form_Layer.Form_not_logged fn = new Form_Layer.Form_not_logged();
        public User_deposit_settings()
        {
            InitializeComponent();
            DataGrid1.DataSource = S.SHOW_deposit_Table();

            DataGrid1.Columns[0].Visible    = false;
            DataGrid1.Columns[5].Visible    = false;

            system_cob.DataSource = acc.GET_NAME_system();
            system_cob.DisplayMember = "NAME_system";
            system_cob.ValueMember = "ID_system";

            alarm_tx.Text = Properties.Settings.Default.Alarm;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            FD.stats1 = "for";
            FD.name.Text = "ايداع";
            FD.name.Focus();
            FD.ShowDialog();

            DataGrid1.DataSource = S.SHOW_deposit_Table();
        }

        private void insert_bt_Click(object sender, EventArgs e)
        {
            FD.stats1 = "on";
            FD.name.Text = "سحب من الايداع";
            FD.name.Focus();
            FD.ShowDialog();

            DataGrid1.DataSource = S.SHOW_deposit_Table();
        }

        private void Search_tx_OnValueChanged(object sender, EventArgs e)
        {
            DataGrid1.DataSource = S.Search_deposit_Table(Search_tx.Text);
        }

        private void delete_bt_Click(object sender, EventArgs e)
        {
            DS.ststs = "delete_dep";
            DS.ID = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());
            DS.ShowDialog();

            DataGrid1.DataSource = S.SHOW_deposit_Table();
        }

        private void updata_bt_Click(object sender, EventArgs e)
        {
            DataGrid1.DataSource = S.SHOW_deposit_Table();
        }



        private void button1_Click_1(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if(alarm_tx.Text != string.Empty)
            {
                Properties.Settings.Default.Alarm = alarm_tx.Text;
                Properties.Settings.Default.Save();

                fl.label1.Text = "تمت العملية بنجاح";
                fl.ShowDialog();
            }
            else
            {
                fn.label1.Text = "فشلت العملية";
                fn.ShowDialog();
            }
        }

        private void alarm_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
