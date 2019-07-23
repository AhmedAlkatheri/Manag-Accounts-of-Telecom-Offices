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
    public partial class User_slice : UserControl
    {
        Business_Layer.Settings S = new Business_Layer.Settings();
        Form_Layer.Form_Insert_Alter IA = new Form_Layer.Form_Insert_Alter();
        Form_Layer.Form_Delete_Settings DS = new Form_Layer.Form_Delete_Settings();
        public User_slice()
        {
            InitializeComponent();
            DataGrid1.DataSource = S.SHOW_slice_Table();
        }

        private void insert_bt_Click(object sender, EventArgs e)
        {
            IA.ststs = "insert_sli";
            IA.name.Text = "شريحة جديدة";
            IA.name.Focus();
            IA.label1.Text = "اسم شريحة";
            IA.label2.Text = "اسم النظام";
            IA.label3.Text = "اتصالات";
            IA.label2.Visible = true;
            IA.label3.Visible = true;
            IA.label4.Visible = true;
            IA.label5.Visible = true;
            IA.system_cob.Visible = true;
            IA.telecom_cob.Visible = true;
            IA.with_ch.Visible = false;
            IA.whth_gro.Visible = false;
            IA.REC_tx.Visible = true;
            IA.EXH_tx.Visible = true;
            IA.ShowDialog();

            DataGrid1.DataSource = S.SHOW_slice_Table();
        }

        private void delete_bt_Click(object sender, EventArgs e)
        {
            DS.ststs = "delete_sli";
            DS.ID = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());
            DS.ShowDialog();

            DataGrid1.DataSource = S.SHOW_slice_Table();
        }

        private void alter_bt_Click(object sender, EventArgs e)
        {
            IA.ststs = "updata_sli";
            IA.name.Text = "تعديل شريحة";
            IA.name.Focus();
            IA.label1.Text = "اسم شريحة";
            IA.label2.Text = "اسم النظام";
            IA.label3.Text = "اتصالات";
            IA.label2.Visible = true;
            IA.label3.Visible = true;
            IA.label4.Visible = true;
            IA.label5.Visible = true;
            IA.system_cob.Visible = true;
            IA.telecom_cob.Visible = true;
            IA.with_ch.Visible = false;
            IA.whth_gro.Visible = false;
            IA.REC_tx.Visible = true;
            IA.EXH_tx.Visible = true;

            IA.ID = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());
            IA.name_tx.Text = this.DataGrid1.CurrentRow.Cells[1].Value.ToString();
            IA.REC_tx.Text = this.DataGrid1.CurrentRow.Cells[2].Value.ToString();
            IA.EXH_tx.Text = this.DataGrid1.CurrentRow.Cells[3].Value.ToString();
            IA.system_cob.Text = this.DataGrid1.CurrentRow.Cells[4].Value.ToString();
            IA.telecom_cob.Text = this.DataGrid1.CurrentRow.Cells[5].Value.ToString();
            IA.ShowDialog();

            DataGrid1.DataSource = S.SHOW_slice_Table();
        }

        private void updata_bt_Click(object sender, EventArgs e)
        {
            DataGrid1.DataSource = S.SHOW_slice_Table();
        }

        private void Search_tx_OnValueChanged(object sender, EventArgs e)
        {
            DataGrid1.DataSource = S.Search_slice_Table(Search_tx.Text);
        }
    }
}
