
namespace Library.Views.Reports
{
    partial class FrmViewReservationsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewReservationsReport));
            this.RpvLending = new Microsoft.Reporting.WinForms.ReportViewer();
            this.libraryDataSet = new Library.LibraryDataSet();
            this.vwReservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwReservationTableAdapter = new Library.LibraryDataSetTableAdapters.vwReservationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwReservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RpvLending
            // 
            this.RpvLending.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReservationDataSet";
            reportDataSource1.Value = this.vwReservationBindingSource;
            this.RpvLending.LocalReport.DataSources.Add(reportDataSource1);
            this.RpvLending.LocalReport.ReportEmbeddedResource = "Library.Views.Reports.Reservations.ReservationReport.rdlc";
            this.RpvLending.Location = new System.Drawing.Point(0, 0);
            this.RpvLending.Name = "RpvLending";
            this.RpvLending.ServerReport.BearerToken = null;
            this.RpvLending.Size = new System.Drawing.Size(800, 450);
            this.RpvLending.TabIndex = 0;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwReservationBindingSource
            // 
            this.vwReservationBindingSource.DataMember = "vwReservation";
            this.vwReservationBindingSource.DataSource = this.libraryDataSet;
            // 
            // vwReservationTableAdapter
            // 
            this.vwReservationTableAdapter.ClearBeforeFill = true;
            // 
            // FrmViewReservationsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RpvLending);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmViewReservationsReport";
            this.Text = "Library - Relatório de Reservas";
            this.Load += new System.EventHandler(this.FrmViewLendingReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwReservationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RpvLending;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource vwReservationBindingSource;
        private LibraryDataSetTableAdapters.vwReservationTableAdapter vwReservationTableAdapter;
    }
}