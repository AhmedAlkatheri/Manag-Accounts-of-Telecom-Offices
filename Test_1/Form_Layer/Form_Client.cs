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
        Form_Delete_Settings DS = new Form_Delete_Settings();
        int rowCunt;
        public Form_Client()
        {
            InitializeComponent();

            try
            {
                DataGrid1.DataSource = C.SHOW_client_Table();
                DataGrid1.Columns[0].Visible = false;

                rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                count_row_tx.Text = rowCunt.ToString();

                totel_for_tx.Text = Convert.ToString(C.SUM_for_client_debe().Rows[0][0]);
                totel_on_tx.Text = Convert.ToString(C.SUM_no_client_debe().Rows[0][0]);
            }
            catch
            {
                Form_contact FC = new Form_contact();
                FC.Error_txt.Visible = true;
                FC.Error_pic.Visible = true;
                FC.ShowDialog();
                FC.Error_txt.Visible = false;
                FC.Error_pic.Visible = false;
                return;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Client_Reveal FCR = new Form_Client_Reveal();
                FCR.ID_Client = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value);
                FCR.client_tx.Text = this.DataGrid1.CurrentRow.Cells[1].Value.ToString();
                FCR.Text = " كشف العميل " + this.DataGrid1.CurrentRow.Cells[1].Value.ToString();
                FCR.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataGrid1.DataSource = C.Search_client_Table(textBox1.Text);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Form_new_Client_Alternate edit = new Form_new_Client_Alternate();
                edit.ID = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());
                edit.acc_tx.Text = this.DataGrid1.CurrentRow.Cells[1].Value.ToString();
                edit.MOBILE_tx.Text = this.DataGrid1.CurrentRow.Cells[5].Value.ToString();
                edit.TELEPHONE_tx.Text = this.DataGrid1.CurrentRow.Cells[6].Value.ToString();
                edit.ADRESS_tx.Text = this.DataGrid1.CurrentRow.Cells[8].Value.ToString();
                edit.EMAIL_tx.Text = this.DataGrid1.CurrentRow.Cells[7].Value.ToString();

                edit.stats1 = "Client";
                edit.name.Text = "حساب تعديل";
                edit.AddEdit = "Edit";
                edit.label1.Text = "اسم الحساب";
                edit.label2.Text = "الايميل";
                edit.label3.Text = "عنوان";
                edit.label4.Text = "هاتف";
                edit.label5.Text = "جوال";

                edit.label9.Visible = false;
                edit.tyap_com.Visible = false;
                edit.ADRESS_tx.isPassword = false;
                edit.TELEPHONE_tx.isPassword = false;
                edit.panel1.Visible = false;
                edit.acc_tx.Enabled = false;
                edit.ShowDialog();

                DataGrid1.DataSource = C.SHOW_client_Table();

                rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                count_row_tx.Text = rowCunt.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message Error " + ex);
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            try
            {
                DS.ststs = "delete_client";
                DS.ID = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());
                DS.ShowDialog();

                DataGrid1.DataSource = C.SHOW_client_Table();

                rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                count_row_tx.Text = rowCunt.ToString();

                totel_for_tx.Text = Convert.ToString(C.SUM_for_client_debe().Rows[0][0]);
                totel_on_tx.Text = Convert.ToString(C.SUM_no_client_debe().Rows[0][0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message Error " + ex , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            DataGrid1.DataSource = C.SHOW_client_Table();

            rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
            count_row_tx.Text = rowCunt.ToString();

            totel_for_tx.Text = Convert.ToString(C.SUM_for_client_debe().Rows[0][0]);
            totel_on_tx.Text = Convert.ToString(C.SUM_no_client_debe().Rows[0][0]);
        }

        private void textBox1_OnValueChanged(object sender, EventArgs e)
        {
            DataGrid1.DataSource = C.Search_client_Table(textBox1.Text);
            DataGrid1.Columns[0].Visible = false;

        }

        private void Form_Client_Load(object sender, EventArgs e)
        {

        }

        private void PDF_bt_Click(object sender, EventArgs e)
        {
            Report.Form_Client_All.All all = new Report.Form_Client_All.All();
            all.ShowDialog();
        }
    }
}
