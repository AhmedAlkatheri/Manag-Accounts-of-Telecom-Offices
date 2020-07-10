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
    public partial class Form_Catch_Exchange : Form
    {
        int rowCunt;
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        Form_client_list FCL = new Form_client_list();
        Form_Alternate FA = new Form_Alternate();
        DateTime dt1, dt2;

        public Form_Catch_Exchange()
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

        private void if_()
        {
            if (TOTEL_REC_tx.Text == string.Empty)
                TOTEL_REC_tx.Text = "0";
            if (TOTEL_EXH_tx.Text == string.Empty)
                TOTEL_EXH_tx.Text = "0";
        }
        private void sum_Between_Twe_date(string Search, DateTime d1, DateTime d2)
        {
            DataTable Sum_Dt = new DataTable();

            Sum_Dt = acc.SUM_debt_Table_Where_Catch_Exchange(Search, d1, d2);

            TOTEL_REC_tx.Text = Sum_Dt.Rows[0]["FOR"].ToString();
            TOTEL_EXH_tx.Text = Sum_Dt.Rows[0]["ON"].ToString();
            if_();
        }

        private void row_Cunt()
        {
            rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
            count_row_tx.Text = rowCunt.ToString();
        }

        private void Search_bt_Click(object sender, EventArgs e)
        {
            dt1 = Date1.Value.Date;
            dt2 = Date2.Value.Date;
            DataTable Dt = new DataTable();

            Dt = acc.SHOW_debt_Table_Where_Catch_Exchange(txtSearch.Text, dt1, dt2);
            this.DataGrid1.DataSource = Dt;
            DataGrid1.Columns[0].Visible = false;
            DataGrid1.Columns[1].Visible = false;
            DataGrid1.Columns[10].Visible = false;
            DataGrid1.Columns[11].Visible = false;

            sum_Between_Twe_date(txtSearch.Text, dt1, dt2);

            row_Cunt();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();

            Dt = acc.SHOW_debt_Table_Where_Catch_Exchange(txtSearch.Text, dt1, dt2);
            this.DataGrid1.DataSource = Dt;

            sum_Between_Twe_date(txtSearch.Text, dt1, dt2);

            row_Cunt();
        }

        private void DELETE_bt_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Delete_Settings FD = new Form_Delete_Settings();
                FD.ststs = "delete_debt";
                FD.ID = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());
                FD.ShowDialog();

                DataTable Dt = new DataTable();

                Dt = acc.SHOW_debt_Table_Where_Catch_Exchange(txtSearch.Text, dt1, dt2);
                this.DataGrid1.DataSource = Dt;

                sum_Between_Twe_date(txtSearch.Text, dt1, dt2);

                row_Cunt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PDF_bt_Click(object sender, EventArgs e)
        {
            Form_not_logged fn = new Form_not_logged();
            if (count_row_tx.Text == string.Empty || TOTEL_REC_tx.Text == string.Empty || TOTEL_EXH_tx.Text == string.Empty )
            {
                fn.label1.Text = "عفوا , ادخل البيانات أولا";
                fn.ShowDialog();
            }
            else
            {
                string d1 = Date1.Value.Date.ToString("yyyy-MM-dd");
                string d2 = Date2.Value.Date.ToString("yyyy-MM-dd");

                
                Report.Form_Catch_Exchange.Form1 FCE = new Report.Form_Catch_Exchange.Form1();

                FCE.R_count_row = count_row_tx.Text;
                FCE.R_TOTEL_REC = TOTEL_REC_tx.Text;
                FCE.R_TOTEL_EXH = TOTEL_EXH_tx.Text;
                FCE.R_date1 = d1;
                FCE.R_date2 = d2;
                FCE.Text = "تقرير مقبوضات ومصروفات";

                if (txtSearch.Text == string.Empty || txtSearch.Text == "")
                    FCE.R_Search = " ";
                else
                    FCE.R_Search = txtSearch.Text;

                FCE.Show();
            }
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_Catch_Exchange_Load(object sender, EventArgs e)
        {
            
        }

        private void edit_bt_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Add_Catch_Exchange FACE = new Form_Add_Catch_Exchange();
                FACE.name.Text = "تعديل";
                FACE.status = "Edit";
                FACE.label4.Visible = true;
                FACE.move_cob.Visible = true;

                FACE.ID_debt = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());
                FACE.ID_Client = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[10].Value.ToString());
                FACE.ID_user = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[11].Value.ToString());

                FACE.move_cob.Text = this.DataGrid1.CurrentRow.Cells[5].Value.ToString();

                FACE.Show();
                FACE.client_tx.Text = this.DataGrid1.CurrentRow.Cells[4].Value.ToString();
                FACE.text_tx.Text = this.DataGrid1.CurrentRow.Cells[9].Value.ToString();

                string move1 = FACE.move_cob.Text;

                if (move1 == "قبض")
                    FACE.TheAmount_tx.Text = this.DataGrid1.CurrentRow.Cells[6].Value.ToString();
                else if (move1 == "صرف")
                    FACE.TheAmount_tx.Text = this.DataGrid1.CurrentRow.Cells[7].Value.ToString();

                DataTable Dt = new DataTable();

                Dt = acc.SHOW_debt_Table_Where_Catch_Exchange(txtSearch.Text, dt1, dt2);
                this.DataGrid1.DataSource = Dt;

                sum_Between_Twe_date(txtSearch.Text, dt1, dt2);

                row_Cunt();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Message Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
