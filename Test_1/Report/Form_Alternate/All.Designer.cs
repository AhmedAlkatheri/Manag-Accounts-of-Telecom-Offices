namespace Test_1.Report.Form_Alternate
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
            this.rEPORTuserTableAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORT_user_Table_AllTableAdapter = new Test_1.Report.DataSet1TableAdapters.REPORT_user_Table_AllTableAdapter();
            this.REPORT_user_Table_AllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTuserTableAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_user_Table_AllBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.REPORT_user_Table_AllBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Test_1.Report.Form_Alternate.تقرير جميع مستخدمين.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(727, 598);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEPORTuserTableAllBindingSource
            // 
            this.rEPORTuserTableAllBindingSource.DataMember = "REPORT_user_Table_All";
            this.rEPORTuserTableAllBindingSource.DataSource = this.dataSet1;
            // 
            // rEPORT_user_Table_AllTableAdapter
            // 
            this.rEPORT_user_Table_AllTableAdapter.ClearBeforeFill = true;
            // 
            // REPORT_user_Table_AllBindingSource
            // 
            this.REPORT_user_Table_AllBindingSource.DataMember = "REPORT_user_Table_All";
            this.REPORT_user_Table_AllBindingSource.DataSource = this.dataSet1;
            // 
            // All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 598);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "All";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جميع مستخدمين";
            this.Load += new System.EventHandler(this.All_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTuserTableAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORT_user_Table_AllBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rEPORTuserTableAllBindingSource;
        private DataSet1TableAdapters.REPORT_user_Table_AllTableAdapter rEPORT_user_Table_AllTableAdapter;
        private System.Windows.Forms.BindingSource REPORT_user_Table_AllBindingSource;
    }
}