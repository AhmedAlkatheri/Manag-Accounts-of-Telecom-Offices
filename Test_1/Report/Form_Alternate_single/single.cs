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

namespace Test_1.Report.Form_Alternate_single
{

    public partial class single : Form
    {

        DataSet1TableAdapters.REPORT_Account_Table_ALLTableAdapter Adapter = new DataSet1TableAdapters.REPORT_Account_Table_ALLTableAdapter();
        DataSet1.REPORT_Account_Table_ALLDataTable Table = new DataSet1.REPORT_Account_Table_ALLDataTable();
        public string  R_count_row, R_TOTEL_REC, R_TOTEL_EXH, R_TOTEL, R_date1, R_date2, R_Search, R_no_debe;
        public int R_ID_user;
        public single()
        {
            InitializeComponent();
        }

        private void single_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.REPORT_Account_Table_ALL' table. You can move, or remove it, as needed.
            this.rEPORT_Account_Table_ALLTableAdapter.Fill(this.dataSet1.REPORT_Account_Table_ALL);

            ReportParameter userName = new ReportParameter("userName", Program.userName);
            ReportParameter Search = new ReportParameter("Search", R_Search);
            ReportParameter count_row = new ReportParameter("count_row", R_count_row);
            ReportParameter date1 = new ReportParameter("date1", R_date1);
            ReportParameter date2 = new ReportParameter("date2", R_date2);
            ReportParameter TOTEL_REC = new ReportParameter("TOTEL_REC", R_TOTEL_REC);
            ReportParameter TOTEL_EXH = new ReportParameter("TOTEL_EXH", R_TOTEL_EXH);
            ReportParameter TOTEL = new ReportParameter("TOTEL", R_TOTEL);
            ReportParameter no_debe = new ReportParameter("no_debe", R_no_debe);

            

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { userName, Search, count_row, date1, date2, TOTEL_REC, TOTEL_EXH, TOTEL, no_debe });

            
            //Adapter.FillBy(Table, comboID_USER.Text);
            Adapter.FillBy1(Table, R_ID_user, R_date1, R_date2, R_Search);

            //ReportDataSource RDS = new ReportDataSource("DataSet1", (DataTable)Table);
            ReportDataSource RDS1 = new ReportDataSource("DataSet1", (DataTable)Table);

            this.reportViewer1.LocalReport.DataSources.Clear();

            //this.reportViewer1.LocalReport.DataSources.Add(RDS);
            this.reportViewer1.LocalReport.DataSources.Add(RDS1);

            this.rEPORT_Account_Table_ALLTableAdapter.Fill(this.dataSet1.REPORT_Account_Table_ALL);

            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
        }
    }
}
