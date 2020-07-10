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
    public partial class Form_Alternate : Form
    {
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        Form_Delete_Settings DS = new Form_Delete_Settings();
        int rowCunt;

        public Form_Alternate()
        {
            InitializeComponent();
            try
            {
                DataGrid1.DataSource = acc.SHOW_user_Table();
                DataGrid1.Columns[0].Visible = false;
                DataGrid1.Columns[2].Visible = false;

                rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                count_row_tx.Text = rowCunt.ToString();
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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Form_new_Client_Alternate edit = new Form_new_Client_Alternate();
                edit.stats1 = "Alternate";
                edit.AddEdit = "Edit";
                edit.ID = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());
                edit.acc_tx.Text = this.DataGrid1.CurrentRow.Cells[1].Value.ToString();
                edit.ADRESS_tx.Text = this.DataGrid1.CurrentRow.Cells[2].Value.ToString();
                edit.TELEPHONE_tx.Text = this.DataGrid1.CurrentRow.Cells[2].Value.ToString();
                edit.tyap_com.Text = this.DataGrid1.CurrentRow.Cells[3].Value.ToString();
                edit.EMAIL_tx.Text = this.DataGrid1.CurrentRow.Cells[4].Value.ToString();
                edit.MOBILE_tx.Text = this.DataGrid1.CurrentRow.Cells[5].Value.ToString();

                edit.name.Text = "تعديل مناوب";
                edit.label1.Text = "اسم المستخدم";
                edit.label2.Text = "اسم المناوب";
                edit.label3.Text = "كلمة المرور";
                edit.label4.Text = "تأكيد كلمة المرور";
                edit.label5.Text = "جوال";

                edit.label9.Visible = true;
                edit.tyap_com.Visible = true;
                edit.ADRESS_tx.isPassword = true;
                edit.TELEPHONE_tx.isPassword = true;
                edit.panel1.Visible = false;
                edit.acc_tx.Enabled = false;
                edit.ShowDialog();

                DataGrid1.DataSource = acc.SHOW_user_Table();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            DataGrid1.DataSource = acc.SHOW_user_Table();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            try
            {
                DS.ststs = "delete_user";
                DS.ID = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());
                DS.ShowDialog();

                DataGrid1.DataSource = acc.SHOW_user_Table();

                rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
                count_row_tx.Text = rowCunt.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PDF_bt_Click(object sender, EventArgs e)
        {
            Report.Form_Alternate.All all = new Report.Form_Alternate.All();
            all.Show();
        }

        private void Search_tx_OnValueChanged(object sender, EventArgs e)
        {
            DataGrid1.DataSource = acc.Search_user_Table(Search_tx.Text);

            rowCunt = DataGrid1.BindingContext[DataGrid1.DataSource].Count;
            count_row_tx.Text = rowCunt.ToString();
        }

        private void count_row_tx_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Alternate_Reveal FCR = new Form_Alternate_Reveal();
                FCR.ID_user = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value);
                FCR.fullName_txt.Text = this.DataGrid1.CurrentRow.Cells[4].Value.ToString();
                FCR.Text = " كشف المناوب " + this.DataGrid1.CurrentRow.Cells[4].Value.ToString();
                FCR.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
