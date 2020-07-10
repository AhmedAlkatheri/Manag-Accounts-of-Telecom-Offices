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
    
    public partial class Form_Client_Reveal : Form
    {
        Business_Layer.Client C = new Business_Layer.Client();
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        public int ID_Client;
        int rowCunt;
        public Form_Client_Reveal()
        {
            InitializeComponent();
            this.Date1.Value = DateTime.Now;
            this.Date2.Value = DateTime.Now;
            //DataGrid1.DataSource = C.SHOW_debt_Table(ID_client);
        }

        private void Form_Client_Reveal_Load(object sender, EventArgs e)
        {
            //DataGrid1.DataSource = C.SHOW_debt_Table(ID_Client);
        }

        private void if_()
        {
            if (TOTEL_REC_tx.Text == string.Empty)
                TOTEL_REC_tx.Text = "0";
            if (TOTEL_EXH_tx.Text == string.Empty)
                TOTEL_EXH_tx.Text = "0";
            if (TOTEL_tx.Text == string.Empty)
                TOTEL_tx.Text = "0";
        }

        private void row_Cunt()
        {
            rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
            count_row_tx.Text = rowCunt.ToString();
        }

        private void sum_Between_Twe_date(string Search, DateTime d1, DateTime d2, int ID)
        {
            DataTable Sum_Dt = new DataTable();

            Sum_Dt = acc.SUM_debt_Table_Where_clientID(Search, d1, d2, ID);

            TOTEL_REC_tx.Text = Sum_Dt.Rows[0]["FOR"].ToString();
            TOTEL_EXH_tx.Text = Sum_Dt.Rows[0]["ON"].ToString();
            if_();
            TOTEL_tx.Text = Convert.ToString(int.Parse(TOTEL_REC_tx.Text) - int.Parse(TOTEL_EXH_tx.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_client_list FCL = new Form_client_list();

            FCL.state       = "client";
            FCL.label1.Text = "اختيار عميل";

            FCL.ShowDialog();

            ID_Client       = Convert.ToInt32(FCL.DG_list.CurrentRow.Cells[0].Value.ToString());
            client_tx.Text  = FCL.DG_list.CurrentRow.Cells[1].Value.ToString();

            Text = " كشف العميل " + FCL.DG_list.CurrentRow.Cells[1].Value.ToString();
            //DataGrid1.DataSource = C.SHOW_debt_Table(ID_Client);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Search_bt_Click(object sender, EventArgs e)
        {
            DateTime dt1 = Date1.Value.Date;
            DateTime dt2 = Date2.Value.Date;
            DataTable Dt = new DataTable();

            Dt = acc.Search_debt_Table(txtSearch.Text, dt1, dt2, ID_Client);
            this.DataGrid1.DataSource = Dt;
            DataGrid1.Columns[0].Visible = false;
            DataGrid1.Columns[1].Visible = false;

            sum_Between_Twe_date(txtSearch.Text, dt1, dt2, ID_Client);

            if (int.Parse(TOTEL_EXH_tx.Text) < int.Parse(TOTEL_REC_tx.Text))
                status_txt.Text = "دائن";
            else if (int.Parse(TOTEL_EXH_tx.Text) > int.Parse(TOTEL_REC_tx.Text))
                status_txt.Text = "مدين";
            else if (int.Parse(TOTEL_EXH_tx.Text) == int.Parse(TOTEL_REC_tx.Text))
                status_txt.Text = "لا يوجد";

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
                string d1 = Date1.Value.Date.ToString("yyyy-MM-dd");
                string d2 = Date2.Value.Date.ToString("yyyy-MM-dd");

                Report.Form_Client_single.single single = new Report.Form_Client_single.single();

                single.R_ID_Client = ID_Client;
                single.R_count_row = count_row_tx.Text;
                single.R_TOTEL_REC = TOTEL_REC_tx.Text;
                single.R_TOTEL_EXH = TOTEL_EXH_tx.Text;
                single.R_TOTEL = TOTEL_tx.Text;
                single.R_date1 = d1;
                single.R_date2 = d2;
                single.Text = " كشف العميل " + client_tx.Text;
                single.R_status = status_txt.Text;

                if (txtSearch.Text == string.Empty || txtSearch.Text == "")
                    single.R_Search = "-";
                else
                    single.R_Search = txtSearch.Text;

                single.Show();
            }
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
