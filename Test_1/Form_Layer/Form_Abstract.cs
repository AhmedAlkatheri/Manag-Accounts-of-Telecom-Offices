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

namespace Test_1.Form_Layer
{
    public partial class Form_Abstract : Form
    {
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        DateTime dt1, dt2;
        ReportDataSource rds = new ReportDataSource();
        Form_not_logged fn = new Form_not_logged();
        public string Date_statut;

        public Form_Abstract()
        {
            InitializeComponent();

            this.Date1.Value = DateTime.Now;
            this.Date2.Value = DateTime.Now;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Date_statut == "daily")
                {
                    Form_Abstract_Reveal f2 = new Form_Abstract_Reveal();
                    f2.status = "sales";
                    f2.date_Status = "daily";
                    f2.Text = " كشف مبيعات تاريح " + Convert.ToDateTime(this.DataGrid1.CurrentRow.Cells[0].Value).ToString("yyyy-dd-MM");
                    f2.date = Convert.ToDateTime(this.DataGrid1.CurrentRow.Cells[0].Value);
                    f2.Show();
                }
                else if (Date_statut == "monthly")
                {
                    Form_Abstract_Reveal f2 = new Form_Abstract_Reveal();
                    f2.status = "sales";
                    f2.date_Status = "monthly";
                    f2.Text = " كشف مبيعات شهر " + this.DataGrid1.CurrentRow.Cells[0].Value.ToString();
                    f2.month_year = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value);
                    f2.Show();
                }
                else if (Date_statut == "yearly")
                {
                    Form_Abstract_Reveal f2 = new Form_Abstract_Reveal();
                    f2.status = "sales";
                    f2.date_Status = "yearly";
                    f2.Text = " كشف مبيعات سنة " + this.DataGrid1.CurrentRow.Cells[0].Value.ToString();
                    f2.month_year = Convert.ToInt32(this.DataGrid1.CurrentRow.Cells[0].Value);
                    f2.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Date_statut == "daily")
                {
                    Form_Abstract_Reveal f2 = new Form_Abstract_Reveal();
                    f2.status = "Catch_Exchange";
                    f2.date_Status = "daily";
                    f2.Text = " كشف قبض وصرف تاريح " + Convert.ToDateTime(this.DataGrid2.CurrentRow.Cells[0].Value).ToString("yyyy-dd-MM");
                    f2.date = Convert.ToDateTime(this.DataGrid2.CurrentRow.Cells[0].Value);
                    f2.Show();
                }
                else if (Date_statut == "monthly")
                {
                    Form_Abstract_Reveal f2 = new Form_Abstract_Reveal();
                    f2.status = "Catch_Exchange";
                    f2.date_Status = "monthly";
                    f2.Text = " كشف قبض وصرف شهر " + this.DataGrid2.CurrentRow.Cells[0].Value.ToString();
                    f2.month_year = Convert.ToInt32(this.DataGrid2.CurrentRow.Cells[0].Value);
                    f2.Show();
                }
                else if (Date_statut == "yearly")
                {
                    Form_Abstract_Reveal f2 = new Form_Abstract_Reveal();
                    f2.status = "Catch_Exchange";
                    f2.date_Status = "yearly";
                    f2.Text = " كشف قبض وصرف سنة " + this.DataGrid2.CurrentRow.Cells[0].Value.ToString();
                    f2.month_year = Convert.ToInt32(this.DataGrid2.CurrentRow.Cells[0].Value);
                    f2.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PDF_bt_Click(object sender, EventArgs e)
        {
            //Business_Layer.SalesAndCatchExchange sce = new Business_Layer.SalesAndCatchExchange();
            List<Business_Layer.SalesAndCatchExchange> list = new List<Business_Layer.SalesAndCatchExchange>();
            list.Clear();

            for (int i = 0; i < DataGrid1.Rows.Count - 1; ++i)
            {
                list.Add(new Business_Layer.SalesAndCatchExchange
                {
                    date = Convert.ToDateTime(DataGrid1.Rows[i].Cells[0].Value.ToString()),
                    count_row = Convert.ToInt32(DataGrid1.Rows[i].Cells[1].Value.ToString()),
                    REC_cash = Convert.ToInt32(DataGrid1.Rows[i].Cells[2].Value.ToString()),
                    REC_late = Convert.ToInt32(DataGrid1.Rows[i].Cells[3].Value.ToString()),
                    EXH_Account = Convert.ToInt32(DataGrid1.Rows[i].Cells[4].Value.ToString()),
                    totel = Convert.ToInt32(DataGrid1.Rows[i].Cells[5].Value.ToString())
                });
            }

            rds.Name = "DataSet1";
            rds.Value = list;
            Report.Form_Abstract.Form1 f = new Report.Form_Abstract.Form1();
            f.reportViewer1.LocalReport.DataSources.Clear();
            f.reportViewer1.LocalReport.DataSources.Add(rds);
            //f.reportViewer1.LocalReport.Refresh();
            f.reportViewer1.LocalReport.ReportEmbeddedResource = "ManagOfAccounts1.Report.Form_Abstract.Report2.rdlc";

            f.ShowDialog();
        }

        private void Search_bt_Click(object sender, EventArgs e)
        {
            try
            {
                if (Date_statut == "daily")
                {
                    dt1 = Date1.Value.Date;
                    dt2 = Date2.Value.Date;

                    DataTable Dt1 = new DataTable();
                    DataTable Dt2 = new DataTable();
                    DataTable Dt3 = new DataTable();

                    Dt1 = acc.SHOW_Account_Table_Where_DATE_Account(dt1, dt2);
                    this.DataGrid1.DataSource = Dt1;

                    Dt2 = acc.SHOW_debt_Table_Where_DATE_debt(dt1, dt2);
                    this.DataGrid2.DataSource = Dt2;

                    Dt3 = acc.SHOW_debt_Table_Where_DATE_debt_AND_MOVE_debt(dt1, dt2);
                    this.DataGrid3.DataSource = Dt3;

                    bool check = false;
                    for (int i = 0; i < DataGrid1.Rows.Count - 1; ++i)
                    {
                        for (int j = 0; j < DataGrid3.Rows.Count - 1; ++j)
                        {
                            if (Dt1.Rows[i]["تاريخ"].ToString() == Dt3.Rows[j]["تاريخ"].ToString())
                            {
                                check = true;

                                this.DataGrid1.Rows[i].Cells[3].Value = DataGrid3.Rows[j].Cells[1].Value.ToString();
                            }
                        }
                        if (check == false)
                        {
                            this.DataGrid1.Rows[i].Cells[3].Value = "0";
                        }
                        check = false;
                    }

                    int sum3;
                    for (int i = 0; i < DataGrid1.Rows.Count - 1; ++i)
                    {
                        for (int j = 0; j < DataGrid3.Rows.Count - 1; ++j)
                        {
                            if (Dt1.Rows[i]["تاريخ"].ToString() == Dt3.Rows[j]["تاريخ"].ToString())
                            {
                                sum3 = (Convert.ToInt32(this.DataGrid1.Rows[i].Cells[2].Value) + Convert.ToInt32(this.DataGrid3.Rows[j].Cells[1].Value)) - Convert.ToInt32(this.DataGrid1.Rows[i].Cells[4].Value);
                                this.DataGrid1.Rows[i].Cells[5].Value = sum3;
                            }
                        }
                    }

                    int sum1 = 0;
                    for (int i = 0; i < DataGrid1.Rows.Count - 1; ++i)
                    {
                        sum1 += Convert.ToInt32(DataGrid1.Rows[i].Cells[5].Value);
                    }

                    TOTEL_REC_tx.Text = sum1.ToString();

                    int sum2 = 0;
                    for (int i = 0; i < DataGrid2.Rows.Count - 1; ++i)
                    {
                        sum2 += Convert.ToInt32(DataGrid2.Rows[i].Cells[3].Value);
                    }

                    TOTEL_EXH_tx.Text = sum2.ToString();

                    TOTEL_tx.Text = (Math.Abs(int.Parse(TOTEL_REC_tx.Text)) - Math.Abs(int.Parse(TOTEL_EXH_tx.Text))).ToString();
                }
                else if (Date_statut == "monthly")
                {
                    DataTable Dt1 = new DataTable();
                    DataTable Dt2 = new DataTable();
                    DataTable Dt3 = new DataTable();


                    Dt1 = acc.SHOW_Account_Table_Where_DATE_Account_Month(int.Parse(Drop1_Month.selectedValue), int.Parse(Drop2_Month.selectedValue), int.Parse(Drop_Year.selectedValue));
                    this.DataGrid1.DataSource = Dt1;

                    Dt2 = acc.SHOW_debt_Table_Where_DATE_debt_Month(int.Parse(Drop1_Month.selectedValue), int.Parse(Drop2_Month.selectedValue), int.Parse(Drop_Year.selectedValue));
                    this.DataGrid2.DataSource = Dt2;

                    Dt3 = acc.SHOW_debt_Table_Where_DATE_debt_AND_MOVE_debt_Month(int.Parse(Drop1_Month.selectedValue), int.Parse(Drop2_Month.selectedValue), int.Parse(Drop_Year.selectedValue));
                    this.DataGrid3.DataSource = Dt3;

                    bool check = false;
                    for (int i = 0; i < DataGrid1.Rows.Count - 1; ++i)
                    {
                        for (int j = 0; j < DataGrid3.Rows.Count - 1; ++j)
                        {
                            if (Dt1.Rows[i]["شهر"].ToString() == Dt3.Rows[j]["شهر"].ToString())
                            {
                                check = true;

                                this.DataGrid1.Rows[i].Cells[3].Value = DataGrid3.Rows[j].Cells[1].Value.ToString();
                            }
                        }
                        if (check == false)
                        {
                            this.DataGrid1.Rows[i].Cells[3].Value = "0";
                        }
                        check = false;
                    }

                    int sum3;
                    for (int i = 0; i < DataGrid1.Rows.Count - 1; ++i)
                    {
                        for (int j = 0; j < DataGrid3.Rows.Count - 1; ++j)
                        {
                            if (Dt1.Rows[i]["شهر"].ToString() == Dt3.Rows[j]["شهر"].ToString())
                            {
                                sum3 = (Convert.ToInt32(this.DataGrid1.Rows[i].Cells[2].Value) + Convert.ToInt32(this.DataGrid3.Rows[j].Cells[1].Value)) - Convert.ToInt32(this.DataGrid1.Rows[i].Cells[4].Value);
                                this.DataGrid1.Rows[i].Cells[5].Value = sum3;
                            }
                        }
                    }

                    int sum1 = 0;
                    for (int i = 0; i < DataGrid1.Rows.Count - 1; ++i)
                    {
                        sum1 += Convert.ToInt32(DataGrid1.Rows[i].Cells[5].Value);
                    }

                    TOTEL_REC_tx.Text = sum1.ToString();

                    int sum2 = 0;
                    for (int i = 0; i < DataGrid2.Rows.Count - 1; ++i)
                    {
                        sum2 += Convert.ToInt32(DataGrid2.Rows[i].Cells[3].Value);
                    }

                    TOTEL_EXH_tx.Text = sum2.ToString();

                    TOTEL_tx.Text = (Math.Abs(int.Parse(TOTEL_REC_tx.Text)) - Math.Abs(int.Parse(TOTEL_EXH_tx.Text))).ToString();
                }
                else if (Date_statut == "yearly")
                {
                    DataTable Dt1 = new DataTable();
                    DataTable Dt2 = new DataTable();
                    DataTable Dt3 = new DataTable();


                    Dt1 = acc.SHOW_Account_Table_Where_DATE_Account_Year(int.Parse(Drop1_Year.selectedValue), int.Parse(Drop2_Year.selectedValue));
                    this.DataGrid1.DataSource = Dt1;

                    Dt2 = acc.SHOW_debt_Table_Where_DATE_debt_Year(int.Parse(Drop1_Year.selectedValue), int.Parse(Drop2_Year.selectedValue));
                    this.DataGrid2.DataSource = Dt2;

                    Dt3 = acc.SHOW_debt_Table_Where_DATE_debt_AND_MOVE_debt_Year(int.Parse(Drop1_Year.selectedValue), int.Parse(Drop2_Year.selectedValue));
                    this.DataGrid3.DataSource = Dt3;

                    bool check = false;
                    for (int i = 0; i < DataGrid1.Rows.Count - 1; ++i)
                    {
                        for (int j = 0; j < DataGrid3.Rows.Count - 1; ++j)
                        {
                            if (Dt1.Rows[i]["سنة"].ToString() == Dt3.Rows[j]["سنة"].ToString())
                            {
                                check = true;

                                this.DataGrid1.Rows[i].Cells[3].Value = DataGrid3.Rows[j].Cells[1].Value.ToString();
                            }
                        }
                        if (check == false)
                        {
                            this.DataGrid1.Rows[i].Cells[3].Value = "0";
                        }
                        check = false;
                    }

                    int sum3;
                    for (int i = 0; i < DataGrid1.Rows.Count - 1; ++i)
                    {
                        for (int j = 0; j < DataGrid3.Rows.Count - 1; ++j)
                        {
                            if (Dt1.Rows[i]["سنة"].ToString() == Dt3.Rows[j]["سنة"].ToString())
                            {
                                sum3 = (Convert.ToInt32(this.DataGrid1.Rows[i].Cells[2].Value) + Convert.ToInt32(this.DataGrid3.Rows[j].Cells[1].Value)) - Convert.ToInt32(this.DataGrid1.Rows[i].Cells[4].Value);
                                this.DataGrid1.Rows[i].Cells[5].Value = sum3;
                            }
                        }
                    }

                    int sum1 = 0;
                    for (int i = 0; i < DataGrid1.Rows.Count - 1; ++i)
                    {
                        sum1 += Convert.ToInt32(DataGrid1.Rows[i].Cells[5].Value);
                    }

                    TOTEL_REC_tx.Text = sum1.ToString();

                    int sum2 = 0;
                    for (int i = 0; i < DataGrid2.Rows.Count - 1; ++i)
                    {
                        sum2 += Convert.ToInt32(DataGrid2.Rows[i].Cells[3].Value);
                    }

                    TOTEL_EXH_tx.Text = sum2.ToString();

                    TOTEL_tx.Text = (Math.Abs(int.Parse(TOTEL_REC_tx.Text)) - Math.Abs(int.Parse(TOTEL_EXH_tx.Text))).ToString();
                }
            }
            catch
            {
                fn.label1.Text = "عفوا , ادخل البيانات أولا";
                fn.Show();
            }            
        }
    }
}
