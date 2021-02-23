
namespace Library.Views
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MnAddReader = new System.Windows.Forms.ToolStripMenuItem();
            this.MnAddLibrarian = new System.Windows.Forms.ToolStripMenuItem();
            this.MnAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.MnMakeReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.MnMakeLending = new System.Windows.Forms.ToolStripMenuItem();
            this.MnReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.MnReports = new System.Windows.Forms.ToolStripMenuItem();
            this.MnBookReport = new System.Windows.Forms.ToolStripMenuItem();
            this.leitoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnLibrarian = new System.Windows.Forms.ToolStripMenuItem();
            this.MnReservations = new System.Windows.Forms.ToolStripMenuItem();
            this.MnLendingReport = new System.Windows.Forms.ToolStripMenuItem();
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCreate,
            this.MnMakeReservation,
            this.MnMakeLending,
            this.MnReturnBook,
            this.MnReports});
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.Name = "MainMenu";
            // 
            // mnCreate
            // 
            this.mnCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnAddReader,
            this.MnAddLibrarian,
            this.MnAddBook});
            this.mnCreate.Name = "mnCreate";
            resources.ApplyResources(this.mnCreate, "mnCreate");
            // 
            // MnAddReader
            // 
            this.MnAddReader.Name = "MnAddReader";
            resources.ApplyResources(this.MnAddReader, "MnAddReader");
            this.MnAddReader.Click += new System.EventHandler(this.MnAddReader_Click);
            // 
            // MnAddLibrarian
            // 
            this.MnAddLibrarian.Name = "MnAddLibrarian";
            resources.ApplyResources(this.MnAddLibrarian, "MnAddLibrarian");
            this.MnAddLibrarian.Click += new System.EventHandler(this.MnAddLibrarian_Click);
            // 
            // MnAddBook
            // 
            this.MnAddBook.Name = "MnAddBook";
            resources.ApplyResources(this.MnAddBook, "MnAddBook");
            this.MnAddBook.Click += new System.EventHandler(this.MnAddBook_Click);
            // 
            // MnMakeReservation
            // 
            this.MnMakeReservation.Name = "MnMakeReservation";
            resources.ApplyResources(this.MnMakeReservation, "MnMakeReservation");
            this.MnMakeReservation.Click += new System.EventHandler(this.MnMakeReservation_Click);
            // 
            // MnMakeLending
            // 
            this.MnMakeLending.Name = "MnMakeLending";
            resources.ApplyResources(this.MnMakeLending, "MnMakeLending");
            this.MnMakeLending.Click += new System.EventHandler(this.MnMakeLending_Click);
            // 
            // MnReturnBook
            // 
            this.MnReturnBook.Name = "MnReturnBook";
            resources.ApplyResources(this.MnReturnBook, "MnReturnBook");
            this.MnReturnBook.Click += new System.EventHandler(this.MnReturnBook_Click);
            // 
            // MnReports
            // 
            this.MnReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnBookReport,
            this.leitoresToolStripMenuItem,
            this.MnLibrarian,
            this.MnReservations,
            this.MnLendingReport});
            this.MnReports.Name = "MnReports";
            resources.ApplyResources(this.MnReports, "MnReports");
            // 
            // MnBookReport
            // 
            this.MnBookReport.Name = "MnBookReport";
            resources.ApplyResources(this.MnBookReport, "MnBookReport");
            this.MnBookReport.Click += new System.EventHandler(this.MnBookReport_Click);
            // 
            // leitoresToolStripMenuItem
            // 
            this.leitoresToolStripMenuItem.Name = "leitoresToolStripMenuItem";
            resources.ApplyResources(this.leitoresToolStripMenuItem, "leitoresToolStripMenuItem");
            this.leitoresToolStripMenuItem.Click += new System.EventHandler(this.leitoresToolStripMenuItem_Click);
            // 
            // MnLibrarian
            // 
            this.MnLibrarian.Name = "MnLibrarian";
            resources.ApplyResources(this.MnLibrarian, "MnLibrarian");
            this.MnLibrarian.Click += new System.EventHandler(this.MnLibrarian_Click);
            // 
            // MnReservations
            // 
            this.MnReservations.Name = "MnReservations";
            resources.ApplyResources(this.MnReservations, "MnReservations");
            this.MnReservations.Click += new System.EventHandler(this.MnReservations_Click);
            // 
            // MnLendingReport
            // 
            this.MnLendingReport.Name = "MnLendingReport";
            resources.ApplyResources(this.MnLendingReport, "MnLendingReport");
            this.MnLendingReport.Click += new System.EventHandler(this.MnLendingReport_Click);
            // 
            // PcbLogo
            // 
            resources.ApplyResources(this.PcbLogo, "PcbLogo");
            this.PcbLogo.BackgroundImage = global::Library.Properties.Resources.large_library;
            this.PcbLogo.Name = "PcbLogo";
            this.PcbLogo.TabStop = false;
            // 
            // FrmHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PcbLogo);
            this.Controls.Add(this.MainMenu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "FrmHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmHome_KeyDown);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnCreate;
        private System.Windows.Forms.ToolStripMenuItem MnAddReader;
        private System.Windows.Forms.ToolStripMenuItem MnMakeReservation;
        private System.Windows.Forms.ToolStripMenuItem MnAddLibrarian;
        private System.Windows.Forms.ToolStripMenuItem MnAddBook;
        private System.Windows.Forms.ToolStripMenuItem MnMakeLending;
        private System.Windows.Forms.ToolStripMenuItem MnReturnBook;
        private System.Windows.Forms.ToolStripMenuItem MnReports;
        private System.Windows.Forms.ToolStripMenuItem MnBookReport;
        private System.Windows.Forms.ToolStripMenuItem leitoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnLibrarian;
        private System.Windows.Forms.ToolStripMenuItem MnReservations;
        private System.Windows.Forms.ToolStripMenuItem MnLendingReport;
        private System.Windows.Forms.PictureBox PcbLogo;
    }
}