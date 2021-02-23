
namespace Library.Views.Reports
{
    partial class FrmViewLendingReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewLendingReport));
            this.RtvLending = new Microsoft.Reporting.WinForms.ReportViewer();
            this.libraryDataSet = new Library.LibraryDataSet();
            this.vwLendingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwLendingTableAdapter = new Library.LibraryDataSetTableAdapters.vwLendingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwLendingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RtvLending
            // 
            this.RtvLending.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "LendingDataSet";
            reportDataSource1.Value = this.vwLendingBindingSource;
            this.RtvLending.LocalReport.DataSources.Add(reportDataSource1);
            this.RtvLending.LocalReport.ReportEmbeddedResource = "Library.Views.Reports.Lending.LendingReport.rdlc";
            this.RtvLending.Location = new System.Drawing.Point(0, 0);
            this.RtvLending.Name = "RtvLending";
            this.RtvLending.ServerReport.BearerToken = null;
            this.RtvLending.Size = new System.Drawing.Size(800, 450);
            this.RtvLending.TabIndex = 0;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwLendingBindingSource
            // 
            this.vwLendingBindingSource.DataMember = "vwLending";
            this.vwLendingBindingSource.DataSource = this.libraryDataSet;
            // 
            // vwLendingTableAdapter
            // 
            this.vwLendingTableAdapter.ClearBeforeFill = true;
            // 
            // FrmViewLendingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RtvLending);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmViewLendingReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library - Relatório de Empréstimos";
            this.Load += new System.EventHandler(this.FrmViewLendingReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwLendingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RtvLending;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource vwLendingBindingSource;
        private LibraryDataSetTableAdapters.vwLendingTableAdapter vwLendingTableAdapter;
    }
}