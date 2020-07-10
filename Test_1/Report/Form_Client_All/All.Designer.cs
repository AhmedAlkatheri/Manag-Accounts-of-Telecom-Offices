namespace Test_1.Report.Form_Client_All
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1 = new Test_1.Report.DataSet1();
            this.rEPORTclientTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORT_client_TableTableAdapter = new Test_1.Report.DataSet1TableAdapters.REPORT_client_TableTableAdapter();
            this.REPORT_client_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTclientTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_client_TableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.REPORT_client_TableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Test_1.Report.Form_Client_All.تقرير جميع عملاء.rdlc";
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
            // rEPORTclientTableBindingSource
            // 
            this.rEPORTclientTableBindingSource.DataMember = "REPORT_client_Table";
            this.rEPORTclientTableBindingSource.DataSource = this.dataSet1;
            // 
            // rEPORT_client_TableTableAdapter
            // 
            this.rEPORT_client_TableTableAdapter.ClearBeforeFill = true;
            // 
            // REPORT_client_TableBindingSource
            // 
            this.REPORT_client_TableBindingSource.DataMember = "REPORT_client_Table";
            this.REPORT_client_TableBindingSource.DataSource = this.dataSet1;
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
            this.Text = "جميع العملاء";
            this.Load += new System.EventHandler(this.All_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTclientTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_client_TableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rEPORTclientTableBindingSource;
        private DataSet1TableAdapters.REPORT_client_TableTableAdapter rEPORT_client_TableTableAdapter;
        private System.Windows.Forms.BindingSource REPORT_client_TableBindingSource;
    }
}