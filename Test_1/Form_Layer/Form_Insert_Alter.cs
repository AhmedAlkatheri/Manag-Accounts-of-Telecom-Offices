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
    public partial class Form_Insert_Alter : Form
    {
        public string ststs;
        Business_Layer.Settings S = new Business_Layer.Settings();
        public int ID;
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        Form_not_logged fn = new Form_not_logged();
        DataTable Dt = new DataTable();

        public Form_Insert_Alter()
        {
            InitializeComponent();

            system_cob.DataSource = acc.GET_NAME_system();
            system_cob.DisplayMember = "NAME_system";
            system_cob.ValueMember = "ID_system";

            telecom_cob.DataSource = acc.GET_NAME_telecom();
            telecom_cob.DisplayMember = "NAME_telecom";
            telecom_cob.ValueMember = "ID_telecom";

            with_ch.Checked = false;
            whth_gro.Enabled = false;

            name_tx.Focus();
        }
        private void VERIFY_NAME()
        {
            if (ststs == "insert_sys" )
            {
                Dt = S.VERIFY_NAME_system(name_tx.Text);
                if (Dt.Rows.Count > 0)
                {
                    fn.label1.Text = "الاسم موجود مسبقا";
                    fn.ShowDialog();
                    name_tx.Focus();
                    return;
                }
            }
            else if (ststs == "insert_tel")
            {

                Dt = S.VERIFY_NAME_telecom(name_tx.Text);
                if (Dt.Rows.Count > 0)
                {
                    fn.label1.Text = "الاسم موجود مسبقا";
                    fn.ShowDialog();
                    name_tx.Focus();
                    return;
                }
            }
            else if (ststs == "insert_bun")
            {

                Dt = S.VERIFY_NAME_bunch(name_tx.Text);
                if (Dt.Rows.Count > 0)
                {
                    fn.label1.Text = "الاسم موجود مسبقا";
                    fn.ShowDialog();
                    name_tx.Focus();
                    return;
                }
            }
            else if (ststs == "insert_cat" )
            {

                Dt = S.VERIFY_NAME_category(name_tx.Text);
                if (Dt.Rows.Count > 0)
                {
                    fn.label1.Text = "الاسم موجود مسبقا";
                    fn.ShowDialog();
                    name_tx.Focus();
                    return;
                }
            }
            else if (ststs == "insert_sli")
            {

                Dt = S.VERIFY_NAME_slice(name_tx.Text);
                if (Dt.Rows.Count > 0)
                {
                    fn.label1.Text = "الاسم موجود مسبقا";
                    fn.ShowDialog();
                    name_tx.Focus();
                    return;
                }
            }
        }

        private void if_Empty()
        {
            if(REC_tx.Text == string.Empty)
                REC_tx.Text = "0";
            if (EXH_tx.Text == string.Empty)
                EXH_tx.Text = "0";
            if (REC_WITH_tx.Text == string.Empty)
                REC_WITH_tx.Text = "0";
            if (EXH_WITH_tx.Text == string.Empty)
                EXH_WITH_tx.Text = "0";
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            Form_logged fl = new Form_logged();

            if (ststs == "insert_sys")
            {
                if (name_tx.Text != string.Empty)
                {
                    Dt = S.VERIFY_NAME_system(name_tx.Text);
                    if (Dt.Rows.Count > 0)
                    {
                        fn.label1.Text = "الاسم موجود مسبقا";
                        fn.ShowDialog();
                        name_tx.Focus();
                        return;
                    }

                    S.ADD_system_Table(name_tx.Text);

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }
            }
            else if (ststs == "updata_sys")
            {
                if (name_tx.Text != string.Empty)
                {
                    S.UPDATE_system_Table(ID, name_tx.Text);

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }
            }
            else if (ststs == "insert_tel")
            {
                if (name_tx.Text != string.Empty)
                {
                    Dt = S.VERIFY_NAME_telecom(name_tx.Text);
                    if (Dt.Rows.Count > 0)
                    {
                        fn.label1.Text = "الاسم موجود مسبقا";
                        fn.ShowDialog();
                        name_tx.Focus();
                        return;
                    }

                    S.ADD_telecom_Table(name_tx.Text, Convert.ToInt32(system_cob.SelectedValue));

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }
            }
            else if (ststs == "updata_tel")
            {
                if (name_tx.Text != string.Empty)
                {
                    S.EDIT_telecom_Table(ID, name_tx.Text, Convert.ToInt32(system_cob.SelectedValue));

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }
            }
            else if (ststs == "insert_bun")
            {
                if (name_tx.Text != string.Empty )
                {
                    if (with_ch.Checked == false)
                    {
                        REC_WITH_tx.Text = "0";
                        EXH_WITH_tx.Text = "0";
                    }

                    Dt = S.VERIFY_NAME_bunch(name_tx.Text);
                    if (Dt.Rows.Count > 0)
                    {
                        fn.label1.Text = "الاسم موجود مسبقا";
                        fn.ShowDialog();
                        name_tx.Focus();
                        return;
                    }

                    if_Empty();

                    S.ADD_bunch_Table(name_tx.Text, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), int.Parse(REC_WITH_tx.Text),
                    int.Parse(EXH_WITH_tx.Text), Convert.ToInt32(system_cob.SelectedValue), Convert.ToInt32(telecom_cob.SelectedValue));

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }
            }
            else if (ststs == "updata_bun")
            {
                if (name_tx.Text != string.Empty)
                {
                    if (REC_WITH_tx.Text != "0" || EXH_WITH_tx.Text != "0")
                        with_ch.Checked = true;

                    if_Empty();
                    S.EDIT_bunch_Table(ID, name_tx.Text, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), int.Parse(REC_WITH_tx.Text),
                        int.Parse(EXH_WITH_tx.Text), Convert.ToInt32(system_cob.SelectedValue), Convert.ToInt32(telecom_cob.SelectedValue));

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }
            }
            else if (ststs == "insert_cat")
            {
                if (name_tx.Text != string.Empty )
                {
                    if (with_ch.Checked == false)
                    {
                        REC_WITH_tx.Text = "0";
                        EXH_WITH_tx.Text = "0";
                    }

                        Dt = S.VERIFY_NAME_category(name_tx.Text);
                        if (Dt.Rows.Count > 0)
                        {
                            fn.label1.Text = "الاسم موجود مسبقا";
                            fn.ShowDialog();
                            name_tx.Focus();
                            return;
                        }

                    if_Empty();

                    S.ADD_category_Table(name_tx.Text, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), int.Parse(REC_WITH_tx.Text),
                    int.Parse(EXH_WITH_tx.Text), Convert.ToInt32(system_cob.SelectedValue), Convert.ToInt32(telecom_cob.SelectedValue));

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }
            }
            else if (ststs == "updata_cat")
            {
                if (name_tx.Text != string.Empty)
                {
                    if (REC_WITH_tx.Text != "0" || EXH_WITH_tx.Text != "0")
                        with_ch.Checked = true;
                    else
                        with_ch.Checked = false;

                    if_Empty();

                    S.EDIT_category_Table(ID, name_tx.Text, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), int.Parse(REC_WITH_tx.Text),
                        int.Parse(EXH_WITH_tx.Text), Convert.ToInt32(system_cob.SelectedValue), Convert.ToInt32(telecom_cob.SelectedValue));

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }
            }
            else if (ststs == "insert_sli")
            {
                if (name_tx.Text != string.Empty )
                {
                    if (with_ch.Checked == false)
                    {
                        REC_WITH_tx.Text = "0";
                        EXH_WITH_tx.Text = "0";
                    }

                    Dt = S.VERIFY_NAME_slice(name_tx.Text);
                    if (Dt.Rows.Count > 0)
                    {
                        fn.label1.Text = "الاسم موجود مسبقا";
                        fn.ShowDialog();
                        name_tx.Focus();
                        return;
                    }

                    if_Empty();

                    S.ADD_slice_Table(name_tx.Text, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), Convert.ToInt32(system_cob.SelectedValue), Convert.ToInt32(telecom_cob.SelectedValue));

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }
            }
            else if (ststs == "updata_sli")
            {
                if (name_tx.Text != string.Empty )
                {
                    if_Empty();

                    S.EDIT_slice_Table(ID, name_tx.Text, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), Convert.ToInt32(system_cob.SelectedValue), Convert.ToInt32(telecom_cob.SelectedValue));

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }
            }

            if (ststs == "insert_tep")
            {
                if (name_tx.Text != string.Empty)
                {
                    Dt = S.VERIFY_NAME_telephone(name_tx.Text);
                    if (Dt.Rows.Count > 0)
                    {
                        fn.label1.Text = "الاسم موجود مسبقا";
                        fn.ShowDialog();
                        name_tx.Focus();
                        return;
                    }

                    if_Empty();

                    S.ADD_telephone_Table(name_tx.Text, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), Convert.ToInt32(system_cob.SelectedValue));

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }
            }
            else if (ststs == "updata_tep")
            {
                if (name_tx.Text != string.Empty)
                {

                    if_Empty();

                    S.EDIT_telephone_Table(ID, name_tx.Text, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), Convert.ToInt32(system_cob.SelectedValue));

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }
            }
            if (ststs == "insert_WE")
            {
                if (name_tx.Text != string.Empty)
                {
                    Dt = S.VERIFY_NAME_WandE(name_tx.Text);
                    if (Dt.Rows.Count > 0)
                    {
                        fn.label1.Text = "الاسم موجود مسبقا";
                        fn.ShowDialog();
                        name_tx.Focus();
                        return;
                    }

                    if_Empty();

                    S.ADD_water_And_Electricity_Table(name_tx.Text, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), Convert.ToInt32(system_cob.SelectedValue));

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }
            }
            else if (ststs == "updata_WE")
            {
                if (name_tx.Text != string.Empty)
                {

                    if_Empty();

                    S.EDIT_water_And_Electricity_Table(ID, name_tx.Text, int.Parse(REC_tx.Text), int.Parse(EXH_tx.Text), Convert.ToInt32(system_cob.SelectedValue));

                    fl.label1.Text = "تمت العملية بنجاح";
                    fl.ShowDialog();
                }
                else
                {
                    fn.label1.Text = "فشلت العملية";
                    fn.ShowDialog();
                }
            }

            name_tx.Text = "";
            REC_tx.Text = "";
            EXH_tx.Text = "";
            REC_WITH_tx.Text = "";
            EXH_WITH_tx.Text = "";

            Close();
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            fn.label1.Text = "فشلت العملية";
            fn.ShowDialog();

            name_tx.Text = "";
            REC_tx.Text = "";
            EXH_tx.Text = "";
            REC_WITH_tx.Text = "";
            EXH_WITH_tx.Text = "";

            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void telecom_cob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ADRESS_tx_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void with_ch_CheckedChanged(object sender, EventArgs e)
        {
            if (with_ch.Checked == true)
                whth_gro.Enabled = true;

            else if (with_ch.Checked == false)
                whth_gro.Enabled = false;
        }

        private void REC_tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void name_tx_Validated(object sender, EventArgs e)
        {
            VERIFY_NAME();
        }
    }
}
