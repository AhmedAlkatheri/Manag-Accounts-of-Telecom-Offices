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
    public partial class Form_Client : Form
    {
        Business_Layer.Client C = new Business_Layer.Client();
        public Form_Client()
        {
            InitializeComponent();
            DataGrid1.DataSource = C.SHOW_client_Table();

            int rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
            count_row_tx.Text = rowCunt.ToString();

            totel_for_tx.Text = Convert.ToString(C.SUM_for_client_debe().Rows[0][0]);
            totel_on_tx.Text = Convert.ToString(C.SUM_no_client_debe().Rows[0][0]);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form_Client_Reveal FCR = new Form_Client_Reveal();
            FCR.ID_Client = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value);
            FCR.client_tx.Text = this.DataGrid1.CurrentRow.Cells[1].Value.ToString();
            FCR.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataGrid1.DataSource = C.Search_client_Table(textBox1.Text);
        }
    }
}
