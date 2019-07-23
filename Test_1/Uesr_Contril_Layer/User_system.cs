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
    
    public partial class User_system : UserControl
    {
        Business_Layer.Settings S = new Business_Layer.Settings();
        Form_Layer.Form_Insert_Alter IA = new Form_Layer.Form_Insert_Alter();
        Form_Layer.Form_Delete_Settings DS = new Form_Layer.Form_Delete_Settings();
        public User_system()
        {
            InitializeComponent();
            DataGrid1.DataSource = S.SHOW_system_Table();
        }

        private void updata_bt_Click(object sender, EventArgs e)
        {
            DataGrid1.DataSource = S.SHOW_system_Table();
        }

        private void insert_bt_Click(object sender, EventArgs e)
        {
            IA.ststs = "insert_sys";
            IA.name.Text = "نظام جديد";
            IA.name.Focus();
            IA.label1.Text = "اسم النظام";
            IA.label2.Visible = false;
            IA.label3.Visible = false;
            IA.label4.Visible = false;
            IA.label5.Visible = false;
            IA.system_cob.Visible = false;
            IA.telecom_cob.Visible = false;
            IA.with_ch.Visible = false;
            IA.whth_gro.Visible = false;
            IA.REC_tx.Visible = false;
            IA.EXH_tx.Visible = false;

            IA.ShowDialog();

            DataGrid1.DataSource = S.SHOW_system_Table();
        }

        private void alter_bt_Click(object sender, EventArgs e)
        {
            IA.ststs = "updata_sys";
            IA.name.Text = " تعديل نظام ";
            IA.name.Focus();
            IA.label1.Text = "اسم النظام";
            IA.label2.Visible = false;
            IA.label3.Visible = false;
            IA.label4.Visible = false;
            IA.label5.Visible = false;
            IA.system_cob.Visible = false;
            IA.telecom_cob.Visible = false;
            IA.with_ch.Visible = false;
            IA.whth_gro.Visible = false;
            IA.REC_tx.Visible = false;
            IA.EXH_tx.Visible = false;

            IA.ID = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());
            IA.name_tx.Text = this.DataGrid1.CurrentRow.Cells[1].Value.ToString();
            IA.ShowDialog();

            DataGrid1.DataSource = S.SHOW_system_Table();
        }

        private void delete_bt_Click(object sender, EventArgs e)
        {
            DS.ststs = "delete_sys";
            DS.ID = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value.ToString());
            DS.ShowDialog();

            DataGrid1.DataSource = S.SHOW_system_Table();
        }

        private void TheAmount_tx_OnValueChanged(object sender, EventArgs e)
        {
            DataGrid1.DataSource = S.Search_system_Table(Search_tx.Text);
        }
    }
}
