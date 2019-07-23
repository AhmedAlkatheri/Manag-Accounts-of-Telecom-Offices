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
   
    public partial class Form_client_list : Form
    {
        public string state = "اختيار";
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        public Form_client_list()
        {
            InitializeComponent();
            this.DG_list.DataSource = acc.GET_client_list();
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            state = "اغلاق";
            Close();
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
