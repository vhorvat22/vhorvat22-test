namespace Evaluation_Manager
{
    partial class FrmFinalReport
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
            this.btnClose = new System.Windows.Forms.Button();
            this.rpvResults = new Microsoft.Reporting.WinForms.ReportViewer();
            this.studentReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentReportViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(911, 522);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rpvResults
            // 
            reportDataSource1.Name = "StudentDataSet";
            reportDataSource1.Value = this.studentReportViewBindingSource;
            this.rpvResults.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvResults.LocalReport.ReportEmbeddedResource = "Evaluation_Manager.Reports.RptStudents.rdlc";
            this.rpvResults.Location = new System.Drawing.Point(12, 12);
            this.rpvResults.Name = "rpvResults";
            this.rpvResults.ServerReport.BearerToken = null;
            this.rpvResults.Size = new System.Drawing.Size(974, 504);
            this.rpvResults.TabIndex = 2;
            // 
            // studentReportViewBindingSource
            // 
            this.studentReportViewBindingSource.DataSource = typeof(Evaluation_Manager.Models.StudentReportView);
            // 
            // FrmFinalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 557);
            this.Controls.Add(this.rpvResults);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmFinalReport";
            this.Text = "FrmFinalReport";
            this.Load += new System.EventHandler(this.FrmFinalReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentReportViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private Microsoft.Reporting.WinForms.ReportViewer rpvResults;
        private System.Windows.Forms.BindingSource studentReportViewBindingSource;
    }
}