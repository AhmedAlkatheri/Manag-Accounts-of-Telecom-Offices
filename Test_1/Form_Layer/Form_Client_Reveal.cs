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
    
    public partial class Form_Client_Reveal : Form
    {
        Business_Layer.Client C = new Business_Layer.Client();
        public int ID_Client;
        public Form_Client_Reveal()
        {
            InitializeComponent();
            //DataGrid1.DataSource = C.SHOW_debt_Table(ID_client);
        }

        private void Form_Client_Reveal_Load(object sender, EventArgs e)
        {
            DataGrid1.DataSource = C.SHOW_debt_Table(ID_Client);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_client_list FCL = new Form_client_list();
            FCL.ShowDialog();
            if (FCL.state == "اختيار")
            {
                ID_Client = Convert.ToInt32(FCL.DG_list.CurrentRow.Cells[0].Value.ToString());
                client_tx.Text = FCL.DG_list.CurrentRow.Cells[1].Value.ToString();
            }
            DataGrid1.DataSource = C.SHOW_debt_Table(ID_Client);

        }
    }
}
