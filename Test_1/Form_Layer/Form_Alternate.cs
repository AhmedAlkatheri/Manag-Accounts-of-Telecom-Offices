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
        public Form_Alternate()
        {
            InitializeComponent();

            DataGrid1.DataSource = acc.SHOW_user_Table();
        }
    }
}
