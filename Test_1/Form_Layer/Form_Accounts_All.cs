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
    public partial class Form_Accounts_All : Form
    {
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        License_Layer.Form_License FLicense = new License_Layer.Form_License();
        int ID_Client, rowCunt;

        private void Search_bt_Click(object sender, EventArgs e)
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

        private void PDF_bt_Click(object sender, EventArgs e)
        {
            if (TOTEL_tx.Text == string.Empty || TOTEL_REC_tx.Text == string.Empty)
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
                all.R_count_row = count_row_tx.Text;
                all.R_TOTEL = TOTEL_tx.Text;
                all.R_TOTEL_EXH = TOTEL_EXH_tx.Text;
                all.R_TOTEL_REC = TOTEL_REC_tx.Text;
                all.R_no_debe_tx = no_debe_tx.Text;
                all.R_date1 = d1;
                all.R_date2 = d2;
                if (txtSearch.Text == string.Empty || txtSearch.Text == "")
                    all.R_Search = "-";
                else
                    all.R_Search = txtSearch.Text;
                all.Show();
            }
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            Form_Accounts FA = new Form_Accounts();
            FA.Show();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            DataGrid1.DataSource = acc.GET_Account_Table_manth();
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

        public Form_Accounts_All()
        {
            InitializeComponent();
            try
            {             
                this.Date1.Value = DateTime.Now;
                this.Date2.Value = DateTime.Now;
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
