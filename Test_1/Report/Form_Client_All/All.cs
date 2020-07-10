using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Test_1.Report.Form_Client_All
{
    public partial class All : Form
    {
        public All()
        {
            InitializeComponent();
        }

        private void All_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.REPORT_client_Table' table. You can move, or remove it, as needed.
            this.rEPORT_client_TableTableAdapter.Fill(this.dataSet1.REPORT_client_Table);

            ReportParameter userName = new ReportParameter("userName", Program.userName);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { userName });

            this.reportViewer1.RefreshReport();
        }
    }
}
