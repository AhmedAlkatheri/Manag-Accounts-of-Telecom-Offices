namespace Test_1.Report.Form_Accounts
{
    partial class Report1
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
            this.REPORT_Account_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Test_1.Report.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORTAccountTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORT_Account_TableTableAdapter = new Test_1.Report.DataSet1TableAdapters.REPORT_Account_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_Account_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTAccountTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // REPORT_Account_TableBindingSource
            // 
            this.REPORT_Account_TableBindingSource.DataMember = "REPORT_Account_Table";
            this.REPORT_Account_TableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.REPORT_Account_TableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Test_1.Report.Form_Accounts.تقرير مبيعات يومية.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1069, 598);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // rEPORTAccountTableBindingSource
            // 
            this.rEPORTAccountTableBindingSource.DataMember = "REPORT_Account_Table";
            this.rEPORTAccountTableBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // rEPORT_Account_TableTableAdapter
            // 
            this.rEPORT_Account_TableTableAdapter.ClearBeforeFill = true;
            // 
            // Report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 598);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "Report1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابات يومية";
            this.Load += new System.EventHandler(this.Report1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_Account_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTAccountTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rEPORTAccountTableBindingSource;
        private DataSet1TableAdapters.REPORT_Account_TableTableAdapter rEPORT_Account_TableTableAdapter;
        private System.Windows.Forms.BindingSource REPORT_Account_TableBindingSource;
    }
}