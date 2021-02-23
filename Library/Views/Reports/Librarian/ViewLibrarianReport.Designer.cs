
namespace Library.Views.Reports
{
    partial class FrmViewLibrarianReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewLibrarianReport));
            this.RtvLibrarian = new Microsoft.Reporting.WinForms.ReportViewer();
            this.libraryDataSet = new Library.LibraryDataSet();
            this.librariansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librariansTableAdapter = new Library.LibraryDataSetTableAdapters.librariansTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librariansBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RtvLibrarian
            // 
            this.RtvLibrarian.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "LibrarianDataSet";
            reportDataSource1.Value = this.librariansBindingSource;
            this.RtvLibrarian.LocalReport.DataSources.Add(reportDataSource1);
            this.RtvLibrarian.LocalReport.ReportEmbeddedResource = "Library.Views.Reports.Librarian.LibrarianReport.rdlc";
            this.RtvLibrarian.Location = new System.Drawing.Point(0, 0);
            this.RtvLibrarian.Name = "RtvLibrarian";
            this.RtvLibrarian.ServerReport.BearerToken = null;
            this.RtvLibrarian.Size = new System.Drawing.Size(800, 450);
            this.RtvLibrarian.TabIndex = 0;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librariansBindingSource
            // 
            this.librariansBindingSource.DataMember = "librarians";
            this.librariansBindingSource.DataSource = this.libraryDataSet;
            // 
            // librariansTableAdapter
            // 
            this.librariansTableAdapter.ClearBeforeFill = true;
            // 
            // FrmViewLibrarianReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RtvLibrarian);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmViewLibrarianReport";
            this.Text = "Library - Relatório de Bibliotecários";
            this.Load += new System.EventHandler(this.ViewLibrarianReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librariansBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RtvLibrarian;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource librariansBindingSource;
        private LibraryDataSetTableAdapters.librariansTableAdapter librariansTableAdapter;
    }
}