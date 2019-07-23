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
    public partial class Form_Delete_Settings : Form
    {
        public string ststs;
        Business_Layer.Settings S = new Business_Layer.Settings();
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        public int ID;
        public Form_Delete_Settings()
        {
            InitializeComponent();
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            Form_logged fl = new Form_logged();


            if (ststs == "delete_sys")
            {
                S.DELETE_system_Table(ID);

                fl.label1.Text = "تمت العملية بنجاح";
                fl.ShowDialog();
            }
            else if (ststs == "delete_tel")
            {
                S.DELETE_telecom_Table(ID);

                fl.label1.Text = "تمت العملية بنجاح";
                fl.ShowDialog();
            }
            else if (ststs == "delete_bun")
            {
                S.DELETE_bunch_Table(ID);

                fl.label1.Text = "تمت العملية بنجاح";
                fl.ShowDialog();
            }
            else if (ststs == "delete_cat")
            {
                S.DELETE_category_Table(ID);

                fl.label1.Text = "تمت العملية بنجاح";
                fl.ShowDialog();
            }
            else if (ststs == "delete_sli")
            {
                S.DELETE_slice_Table(ID);

                fl.label1.Text = "تمت العملية بنجاح";
                fl.ShowDialog();
            }
            else if (ststs == "delete_dep")
            {
                S.DELETE_deposit_Table(ID);

                fl.label1.Text = "تمت العملية بنجاح";
                fl.ShowDialog();
            }
            else if (ststs == "delete_tep")
            {
                S.DELETE_telephone_Table(ID);

                fl.label1.Text = "تمت العملية بنجاح";
                fl.ShowDialog();
            }
            else if (ststs == "delete_WE")
            {
                S.DELETE_water_And_Electricity_Table(ID);

                fl.label1.Text = "تمت العملية بنجاح";
                fl.ShowDialog();
            }
            else if (ststs == "delete_acc")
            {
                acc.DELETE_Account_Table(ID);

                fl.label1.Text = "تمت العملية بنجاح";
                fl.ShowDialog();
            }
            else
            {
                Form_not_logged fn = new Form_not_logged();
                fn.label1.Text = "فشلت العملية";
                fn.ShowDialog();
            }
            Close();
        }
        
        private void but_close_Click(object sender, EventArgs e)
        {
            Form_not_logged fn = new Form_not_logged();
            fn.label1.Text = "فشلت العملية";
            fn.ShowDialog();
            Close();
        }
    }
}
