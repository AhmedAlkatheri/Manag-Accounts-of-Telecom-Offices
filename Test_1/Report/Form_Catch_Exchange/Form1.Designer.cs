namespace Test_1.Report.Form_Catch_Exchange
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1 = new Test_1.Report.DataSet1();
            this.rEPORTdebtTableWhereCatchExchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORT_debt_Table_Where_Catch_ExchangeTableAdapter = new Test_1.Report.DataSet1TableAdapters.REPORT_debt_Table_Where_Catch_ExchangeTableAdapter();
            this.REPORT_debt_Table_Where_Catch_ExchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTdebtTableWhereCatchExchangeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_debt_Table_Where_Catch_ExchangeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.REPORT_debt_Table_Where_Catch_ExchangeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Test_1.Report.Form_Catch_Exchange.تقرير قبض وصرف.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1069, 598);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEPORTdebtTableWhereCatchExchangeBindingSource
            // 
            this.rEPORTdebtTableWhereCatchExchangeBindingSource.DataMember = "REPORT_debt_Table_Where_Catch_Exchange";
            this.rEPORTdebtTableWhereCatchExchangeBindingSource.DataSource = this.dataSet1;
            // 
            // rEPORT_debt_Table_Where_Catch_ExchangeTableAdapter
            // 
            this.rEPORT_debt_Table_Where_Catch_ExchangeTableAdapter.ClearBeforeFill = true;
            // 
            // REPORT_debt_Table_Where_Catch_ExchangeBindingSource
            // 
            this.REPORT_debt_Table_Where_Catch_ExchangeBindingSource.DataMember = "REPORT_debt_Table_Where_Catch_Exchange";
            this.REPORT_debt_Table_Where_Catch_ExchangeBindingSource.DataSource = this.dataSet1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 598);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTdebtTableWhereCatchExchangeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_debt_Table_Where_Catch_ExchangeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rEPORTdebtTableWhereCatchExchangeBindingSource;
        private DataSet1TableAdapters.REPORT_debt_Table_Where_Catch_ExchangeTableAdapter rEPORT_debt_Table_Where_Catch_ExchangeTableAdapter;
        private System.Windows.Forms.BindingSource REPORT_debt_Table_Where_Catch_ExchangeBindingSource;
    }
}