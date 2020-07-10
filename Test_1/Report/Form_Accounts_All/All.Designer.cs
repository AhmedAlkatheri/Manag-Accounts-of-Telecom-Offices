namespace Test_1.Report.Form_Accounts_All
{
    partial class All
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
            this.REPORT_Account_Table_ALLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Test_1.Report.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rEPORTAccountTableALLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORT_Account_Table_ALLTableAdapter = new Test_1.Report.DataSet1TableAdapters.REPORT_Account_Table_ALLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_Account_Table_ALLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTAccountTableALLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // REPORT_Account_Table_ALLBindingSource
            // 
            this.REPORT_Account_Table_ALLBindingSource.DataMember = "REPORT_Account_Table_ALL";
            this.REPORT_Account_Table_ALLBindingSource.DataSource = this.dataSet1;
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
            reportDataSource1.Value = this.REPORT_Account_Table_ALLBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Test_1.Report.Form_Accounts_All.تقرير جميع مبيعات.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1069, 598);
            this.reportViewer1.TabIndex = 0;
            // 
            // rEPORTAccountTableALLBindingSource
            // 
            this.rEPORTAccountTableALLBindingSource.DataMember = "REPORT_Account_Table_ALL";
            this.rEPORTAccountTableALLBindingSource.DataSource = this.dataSet1;
            // 
            // rEPORT_Account_Table_ALLTableAdapter
            // 
            this.rEPORT_Account_Table_ALLTableAdapter.ClearBeforeFill = true;
            // 
            // All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 598);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "All";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جميع مبيعات";
            this.Load += new System.EventHandler(this.All_Load);
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_Account_Table_ALLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTAccountTableALLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rEPORTAccountTableALLBindingSource;
        private DataSet1TableAdapters.REPORT_Account_Table_ALLTableAdapter rEPORT_Account_Table_ALLTableAdapter;
        private System.Windows.Forms.BindingSource REPORT_Account_Table_ALLBindingSource;
    }
}