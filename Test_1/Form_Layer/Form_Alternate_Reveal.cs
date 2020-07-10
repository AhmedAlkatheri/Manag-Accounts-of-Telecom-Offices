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
    public partial class Form_Alternate_Reveal : Form
    {
        public int ID_user;
        int rowCunt;
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        Form_client_list FCL = new Form_client_list();
        Form_Alternate FA = new Form_Alternate();

        public Form_Alternate_Reveal()
        {
            InitializeComponent();

            this.Date1.Value = DateTime.Now;
            this.Date2.Value = DateTime.Now;
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

        private void sum_Between_Twe_date(string Search, DateTime d1, DateTime d2, int ID)
        {
            DataTable Sum_Dt    = new DataTable();
            DataTable Sum_debe  = new DataTable();

            Sum_Dt      = acc.SUM_REC_and_EXH_Where_UserID(Search, d1, d2, ID);
            Sum_debe    = acc.SUM_no_debe_Where_UserID(Search, d1, d2, ID);

            TOTEL_REC_tx.Text   = Sum_Dt.Rows[0]["REC"].ToString();
            TOTEL_EXH_tx.Text   = Sum_Dt.Rows[0]["EXH"].ToString();
            no_debe_tx.Text     = Sum_debe.Rows[0]["ON_debt"].ToString();
            if_();
            TOTEL_tx.Text = Convert.ToString((int.Parse(TOTEL_REC_tx.Text) + int.Parse(no_debe_tx.Text)) - int.Parse(TOTEL_EXH_tx.Text));
        }

        private void sum(string Search, int ID)
        {
            DataTable Sum_Dt = new DataTable();

            Sum_Dt = acc.SUM_REC_and_EXH_Where_UserID_only(Search, ID);

            TOTEL_REC_tx.Text = Sum_Dt.Rows[0]["REC"].ToString();
            TOTEL_EXH_tx.Text = Sum_Dt.Rows[0]["EXH"].ToString();
            if_();
            TOTEL_tx.Text = Convert.ToString(int.Parse(TOTEL_REC_tx.Text) - int.Parse(TOTEL_EXH_tx.Text));
        }

        private void row_Cunt(){

            rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
            count_row_tx.Text = rowCunt.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FCL.state       = "Alternate";
            FCL.label1.Text = "اختيار مناوب";

            FCL.ShowDialog();

            ID_user             = Convert.ToInt32(FCL.DG_list.CurrentRow.Cells[0].Value.ToString());
            fullName_txt.Text   = FCL.DG_list.CurrentRow.Cells[1].Value.ToString();

            Text = " كشف المناوب " + FCL.DG_list.CurrentRow.Cells[1].Value.ToString();
            //DataGrid1.DataSource = acc.GET_Account_Table_All_Where_UserID(ID_user);

            //sum(txtSearch.Text, ID_user);

            //row_Cunt();
        }

        private void Form_Alternate_Reveal_Load(object sender, EventArgs e)
        {
            //DataGrid1.DataSource = acc.GET_Account_Table_All_Where_UserID(ID_user);

            //sum(txtSearch.Text, ID_user);

            //row_Cunt();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            //DataGrid1.DataSource = acc.GET_Account_Table_All_Where_UserID(ID_user);
            //sum(txtSearch.Text, ID_user);

            //row_Cunt();
        }

        private void Search_bt_Click(object sender, EventArgs e)
        {
            DateTime dt1 = Date1.Value.Date;
            DateTime dt2 = Date2.Value.Date;
            DataTable Dt = new DataTable();

            Dt = acc.SEARCH_Account_Table_manth_Where_UserID(txtSearch.Text, dt1, dt2, ID_user);
            this.DataGrid1.DataSource = Dt;
            DataGrid1.Columns[0].Visible = false;

            sum_Between_Twe_date(txtSearch.Text, dt1, dt2, ID_user);

            row_Cunt();
        }

        private void PDF_bt_Click(object sender, EventArgs e)
        {
            Form_not_logged fn = new Form_not_logged();
            if (count_row_tx.Text == string.Empty || TOTEL_REC_tx.Text == string.Empty || TOTEL_EXH_tx.Text == string.Empty || TOTEL_tx.Text == string.Empty)
            {
                fn.label1.Text = "عفوا , ادخل البيانات أولا";
                fn.ShowDialog();
            }
            else
            {

            }
            string d1 = Date1.Value.Date.ToString("yyyy-MM-dd");
            string d2 = Date2.Value.Date.ToString("yyyy-MM-dd");

            Report.Form_Alternate_single.single single = new Report.Form_Alternate_single.single();

            single.R_ID_user    = ID_user;
            single.R_count_row  = count_row_tx.Text;
            single.R_TOTEL_REC  = TOTEL_REC_tx.Text;
            single.R_TOTEL_EXH  = TOTEL_EXH_tx.Text;
            single.R_TOTEL      = TOTEL_tx.Text;
            single.R_date1      = d1;
            single.R_date2      = d2;
            single.R_no_debe    = no_debe_tx.Text;


            single.Text = " كشف المناوب " + fullName_txt.Text;

            if (txtSearch.Text == string.Empty || txtSearch.Text == "")
                single.R_Search = "-";
            else
                single.R_Search = txtSearch.Text;

            single.Show();

        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
