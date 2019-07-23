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
    
    public partial class Form_Accounts_Manth : Form
    {
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        int ID_Client, rowCunt;
        public Form_Accounts_Manth()
        {
            InitializeComponent();

            DataGrid1.DataSource = acc.GET_Account_Table_manth();

            rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
            count_row_tx.Text = rowCunt.ToString();

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
        }
        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            Form_Accounts FA = new Form_Accounts();
            FA.Show();
        }

        private void client_tx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form_Accounts_Manth_Load(object sender, EventArgs e)
        {

        }

        private void Search_bt_Click(object sender, EventArgs e)
        {
            DateTime dt1 = Date1.Value.Date;
            DateTime dt2 = Date2.Value.Date;
            DataTable Dt = new DataTable();

            Dt = acc.SEARCH_Account_Table_manth(txtSearch.Text, dt1, dt2);
            this.DataGrid1.DataSource = Dt;
            DataGridView d = new DataGridView();

            gg.DataSource = acc.SUM_REC_and_EXH_Account(txtSearch.Text, dt1, dt2);
            TOTEL_REC_tx.Text = Convert.ToString(gg.CurrentRow.Cells[0].Value.ToString());
            TOTEL_EXH_tx.Text = Convert.ToString(gg.CurrentRow.Cells[1].Value.ToString());
            if_();
            TOTEL_tx.Text = Convert.ToString(int.Parse(TOTEL_REC_tx.Text) - int.Parse(TOTEL_EXH_tx.Text));

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
