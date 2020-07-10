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
    public partial class Form_Abstract_Reveal : Form
    {
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        public DateTime date;
        public int month_year;
        public string status, date_Status;

        public Form_Abstract_Reveal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if      (status == "sales" && date_Status == "daily")
                DataGrid1.DataSource = acc.GET_Account_Table_Where_DATE_Account(date);

            else if (status == "sales" && date_Status == "monthly")
                DataGrid1.DataSource = acc.GET_Account_Table_Where_DATE_Account_INT_MONTH(month_year);

            else if (status == "sales" && date_Status == "yearly")
                DataGrid1.DataSource = acc.GET_Account_Table_Where_DATE_Account_INT_YEAR(month_year);

            else if (status == "Catch_Exchange" & date_Status == "daily")
                DataGrid1.DataSource = acc.GET_debt_Table_Where_DATE_debt(date);

            else if (status == "Catch_Exchange" && date_Status == "monthly")
                DataGrid1.DataSource = acc.GET_debt_Table_Where_DATE_debt_INT_MONTH(month_year);

            else if (status == "Catch_Exchange" && date_Status == "yearly")
                DataGrid1.DataSource = acc.GET_debt_Table_Where_DATE_debt_INT_YEAR(month_year);
        }
    }
}
