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
        public string state;
        Business_Layer.Accounts acc = new Business_Layer.Accounts();

        public Form_client_list()
        {
            InitializeComponent();
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            state = "";
            Close();
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            state = "";
            Close();
        }

        private void Form_client_list_Load(object sender, EventArgs e)
        {
            try
            {
                if (state == "client")
                {
                    this.DG_list.DataSource = acc.GET_client_list();
                    DG_list.Columns[0].Visible = false;

                }
                else if (state == "Alternate")
                {
                    this.DG_list.DataSource = acc.GET_user_list();
                }
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
    }
}
