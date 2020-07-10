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
    
    public partial class Form_Accounts_Manth : Form
    {
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        License_Layer.Form_License FLicense = new License_Layer.Form_License();
        int ID_Client, rowCunt;
        public Form_Accounts_Manth()
        {
            InitializeComponent();
            try
            {
                //DataGrid1.DataSource = acc.GET_Account_Table_manth();

                //rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                //count_row_tx.Text = rowCunt.ToString();

                //DataTable Sum_debe = new DataTable();
                this.Date1.Value = DateTime.Now;
                this.Date2.Value = DateTime.Now;

                //Sum_debe = acc.SUM_no_debe_GET_Account_manth();

                //no_debe_tx.Text = Sum_debe.Rows[0]["ON_debt"].ToString();
                //TOTEL_REC_tx.Text = Convert.ToString(acc.SUM_REC_Account_ALL().Rows[0][0]);
                //TOTEL_EXH_tx.Text = Convert.ToString(acc.SUM_EXH_Account_ALL().Rows[0][0]);
                //if_();
                //TOTEL_tx.Text = Convert.ToString((int.Parse(TOTEL_REC_tx.Text) + int.Parse(no_debe_tx.Text)) - int.Parse(TOTEL_EXH_tx.Text));

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
            if (TOTEL_REC_tx.Text == string.Empty)
                TOTEL_REC_tx.Text = "0";
            if (TOTEL_EXH_tx.Text == string.Empty)
                TOTEL_EXH_tx.Text = "0";
            if (TOTEL_tx.Text == string.Empty)
                TOTEL_tx.Text = "0";
            if (no_debe_tx.Text == string.Empty)
                no_debe_tx.Text = "0";
        }
        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            Form_Accounts FA = new Form_Accounts();
            FA.Show();
        }

        private void client_tx_TextChanged(object sender, EventArgs e)
        {
            DataGrid1.DataSource = acc.Search_Account_Table_manth_string(txtSearch.Text);
        }

        private void Form_Accounts_Manth_Load(object sender, EventArgs e)
        {
            
        }

        private void Search_bt_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            DataGrid1.DataSource = acc.GET_Account_Table_manth();
        }

        private void PDF_bt_Click(object sender, EventArgs e)
        {
            if ( TOTEL_tx.Text == string.Empty || TOTEL_REC_tx.Text == string.Empty)
            {
                Form_not_logged fn = new Form_not_logged();
                fn.label1.Text = "عفوا , اختر النظام أولا";
                fn.ShowDialog();
            }
            else
            {
                string d1 = Date1.Value.Date.ToString("yyyy-MM-dd");
                string d2 = Date2.Value.Date.ToString("yyyy-MM-dd");

                Report.Form_Accounts_All.All all = new Report.Form_Accounts_All.All();
                all.R_count_row     = count_row_tx.Text;
                all.R_TOTEL         = TOTEL_tx.Text;
                all.R_TOTEL_EXH     = TOTEL_EXH_tx.Text;
                all.R_TOTEL_REC     = TOTEL_REC_tx.Text;
                all.R_no_debe_tx    = no_debe_tx.Text;
                all.R_date1         = d1;
                all.R_date2         = d2;
                if (txtSearch.Text == string.Empty || txtSearch.Text == "")
                    all.R_Search = "-";
                else
                    all.R_Search = txtSearch.Text;
                all.Show();
            }
        }

        private void TOTEL_tx_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Search_bt_Click_1(object sender, EventArgs e)
        {

        }

        private void Date2_onValueChanged(object sender, EventArgs e)
        {

        }

        private void Date1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TOTEL_REC_tx_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TOTEL_EXH_tx_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void count_row_tx_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Date2_onValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            //DataGrid1.DataSource = acc.Search_Account_Table_manth_string(txtSearch.Text);
            //DataTable Sum_Dt = new DataTable();

            //Sum_Dt = acc.SUM_Account_ALL_String(txtSearch.Text);
            //TOTEL_REC_tx.Text = Sum_Dt.Rows[0]["REC"].ToString();
            //TOTEL_EXH_tx.Text = Sum_Dt.Rows[0]["EXH"].ToString();
            //if_();
            //TOTEL_tx.Text = Convert.ToString(int.Parse(TOTEL_REC_tx.Text) - int.Parse(TOTEL_EXH_tx.Text));
        }

        private void Search_bt_Click_2(object sender, EventArgs e)
        {
            DateTime dt1 = Date1.Value.Date;
            DateTime dt2 = Date2.Value.Date;
            DataTable Dt = new DataTable();
            DataTable Sum_debe = new DataTable();

            Dt = acc.SEARCH_Account_Table_manth(txtSearch.Text, dt1, dt2);
            this.DataGrid1.DataSource = Dt;
            DataGridView d = new DataGridView();

            Sum_debe = acc.SUM_no_debe_Account_manth(txtSearch.Text, dt1, dt2);
            gg.DataSource = acc.SUM_REC_and_EXH_Account(txtSearch.Text, dt1, dt2);
            TOTEL_REC_tx.Text = Convert.ToString(gg.CurrentRow.Cells[0].Value.ToString());
            TOTEL_EXH_tx.Text = Convert.ToString(gg.CurrentRow.Cells[1].Value.ToString());
            no_debe_tx.Text = Sum_debe.Rows[0]["ON_debt"].ToString();
            if_();
            TOTEL_tx.Text = Convert.ToString((int.Parse(TOTEL_REC_tx.Text) + int.Parse(no_debe_tx.Text)) - int.Parse(TOTEL_EXH_tx.Text));

            rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
            count_row_tx.Text = rowCunt.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_client_list FCL = new Form_client_list();
            FCL.ShowDialog();
            if (FCL.state == "اختيار")
            {
                ID_Client = Convert.ToInt32(FCL.DG_list.CurrentRow.Cells[0].Value.ToString());
                txtSearch.Text = FCL.DG_list.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
