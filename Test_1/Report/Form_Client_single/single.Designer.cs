namespace Test_1.Report.Form_Client_single
{
    partial class single
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
            this.rEPORTdebtTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORT_debt_TableTableAdapter = new Test_1.Report.DataSet1TableAdapters.REPORT_debt_TableTableAdapter();
            this.REPORT_debt_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTdebtTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_debt_TableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.REPORT_debt_TableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Test_1.Report.Form_Client_single.تقرير العميل.rdlc";
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
            // rEPORTdebtTableBindingSource
            // 
            this.rEPORTdebtTableBindingSource.DataMember = "REPORT_debt_Table";
            this.rEPORTdebtTableBindingSource.DataSource = this.dataSet1;
            // 
            // rEPORT_debt_TableTableAdapter
            // 
            this.rEPORT_debt_TableTableAdapter.ClearBeforeFill = true;
            // 
            // REPORT_debt_TableBindingSource
            // 
            this.REPORT_debt_TableBindingSource.DataMember = "REPORT_debt_Table";
            this.REPORT_debt_TableBindingSource.DataSource = this.dataSet1;
            // 
            // single
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 598);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "single";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "single";
            this.Load += new System.EventHandler(this.single_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTdebtTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_debt_TableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rEPORTdebtTableBindingSource;
        private DataSet1TableAdapters.REPORT_debt_TableTableAdapter rEPORT_debt_TableTableAdapter;
        private System.Windows.Forms.BindingSource REPORT_debt_TableBindingSource;
    }
}