
namespace Library.Views.Reports
{
    partial class FrmViewReadersReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewReadersReport));
            this.RpwReader = new Microsoft.Reporting.WinForms.ReportViewer();
            this.libraryDataSet = new Library.LibraryDataSet();
            this.readersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readersTableAdapter = new Library.LibraryDataSetTableAdapters.readersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RpwReader
            // 
            this.RpwReader.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReaderDataSet";
            reportDataSource1.Value = this.readersBindingSource;
            this.RpwReader.LocalReport.DataSources.Add(reportDataSource1);
            this.RpwReader.LocalReport.ReportEmbeddedResource = "Library.Views.Reports.Reader.ReaderReport.rdlc";
            this.RpwReader.Location = new System.Drawing.Point(0, 0);
            this.RpwReader.Name = "RpwReader";
            this.RpwReader.ServerReport.BearerToken = null;
            this.RpwReader.Size = new System.Drawing.Size(800, 450);
            this.RpwReader.TabIndex = 0;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readersBindingSource
            // 
            this.readersBindingSource.DataMember = "readers";
            this.readersBindingSource.DataSource = this.libraryDataSet;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
            // 
            // FrmViewReadersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RpwReader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmViewReadersReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library - Relatório de Leitores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmViewReadersReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RpwReader;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource readersBindingSource;
        private LibraryDataSetTableAdapters.readersTableAdapter readersTableAdapter;
    }
}