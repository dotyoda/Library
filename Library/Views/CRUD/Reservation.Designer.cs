
namespace Library.Views
{
    partial class FrmReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservation));
            this.PnlForm = new System.Windows.Forms.Panel();
            this.LblMessage = new System.Windows.Forms.Label();
            this.DtpCheckoutIn = new System.Windows.Forms.DateTimePicker();
            this.LblBook = new System.Windows.Forms.Label();
            this.TxtBook = new System.Windows.Forms.TextBox();
            this.LblCheckoutIn = new System.Windows.Forms.Label();
            this.LblLeitor = new System.Windows.Forms.Label();
            this.TxtReader = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.PnlActions = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PnlForm.SuspendLayout();
            this.PnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlForm
            // 
            this.PnlForm.Controls.Add(this.LblMessage);
            this.PnlForm.Controls.Add(this.DtpCheckoutIn);
            this.PnlForm.Controls.Add(this.LblBook);
            this.PnlForm.Controls.Add(this.TxtBook);
            this.PnlForm.Controls.Add(this.LblCheckoutIn);
            this.PnlForm.Controls.Add(this.LblLeitor);
            this.PnlForm.Controls.Add(this.TxtReader);
            this.PnlForm.Controls.Add(this.TxtId);
            this.PnlForm.Controls.Add(this.LblId);
            this.PnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlForm.Location = new System.Drawing.Point(0, 140);
            this.PnlForm.Name = "PnlForm";
            this.PnlForm.Size = new System.Drawing.Size(708, 212);
            this.PnlForm.TabIndex = 23;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(12, 170);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(78, 19);
            this.LblMessage.TabIndex = 33;
            this.LblMessage.Text = "message";
            this.LblMessage.Visible = false;
            // 
            // DtpCheckoutIn
            // 
            this.DtpCheckoutIn.Font = new System.Drawing.Font("Arial", 12F);
            this.DtpCheckoutIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpCheckoutIn.Location = new System.Drawing.Point(12, 124);
            this.DtpCheckoutIn.MinDate = new System.DateTime(2021, 2, 4, 0, 0, 0, 0);
            this.DtpCheckoutIn.Name = "DtpCheckoutIn";
            this.DtpCheckoutIn.Size = new System.Drawing.Size(121, 26);
            this.DtpCheckoutIn.TabIndex = 3;
            // 
            // LblBook
            // 
            this.LblBook.AutoSize = true;
            this.LblBook.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBook.Location = new System.Drawing.Point(402, 31);
            this.LblBook.Name = "LblBook";
            this.LblBook.Size = new System.Drawing.Size(44, 16);
            this.LblBook.TabIndex = 31;
            this.LblBook.Text = "Livro";
            // 
            // TxtBook
            // 
            this.TxtBook.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtBook.Location = new System.Drawing.Point(405, 50);
            this.TxtBook.Name = "TxtBook";
            this.TxtBook.Size = new System.Drawing.Size(289, 26);
            this.TxtBook.TabIndex = 2;
            this.TxtBook.Enter += new System.EventHandler(this.TxtBook_Enter);
            // 
            // LblCheckoutIn
            // 
            this.LblCheckoutIn.AutoSize = true;
            this.LblCheckoutIn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCheckoutIn.Location = new System.Drawing.Point(9, 105);
            this.LblCheckoutIn.Name = "LblCheckoutIn";
            this.LblCheckoutIn.Size = new System.Drawing.Size(124, 16);
            this.LblCheckoutIn.TabIndex = 22;
            this.LblCheckoutIn.Text = "Data de Retirada";
            // 
            // LblLeitor
            // 
            this.LblLeitor.AutoSize = true;
            this.LblLeitor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLeitor.Location = new System.Drawing.Point(107, 31);
            this.LblLeitor.Name = "LblLeitor";
            this.LblLeitor.Size = new System.Drawing.Size(49, 16);
            this.LblLeitor.TabIndex = 18;
            this.LblLeitor.Text = "Leitor";
            // 
            // TxtReader
            // 
            this.TxtReader.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtReader.Location = new System.Drawing.Point(110, 50);
            this.TxtReader.Name = "TxtReader";
            this.TxtReader.Size = new System.Drawing.Size(289, 26);
            this.TxtReader.TabIndex = 1;
            this.TxtReader.Click += new System.EventHandler(this.SearchReader_event);
            this.TxtReader.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtReader_KeyDown);
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtId.Location = new System.Drawing.Point(12, 50);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(92, 26);
            this.TxtId.TabIndex = 0;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Location = new System.Drawing.Point(12, 31);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(58, 16);
            this.LblId.TabIndex = 3;
            this.LblId.Text = "Código";
            // 
            // PnlActions
            // 
            this.PnlActions.Controls.Add(this.LblTitle);
            this.PnlActions.Controls.Add(this.BtnClear);
            this.PnlActions.Controls.Add(this.BtnSearch);
            this.PnlActions.Controls.Add(this.BtnSave);
            this.PnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlActions.Location = new System.Drawing.Point(0, 0);
            this.PnlActions.Name = "PnlActions";
            this.PnlActions.Size = new System.Drawing.Size(708, 140);
            this.PnlActions.TabIndex = 24;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitle.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold);
            this.LblTitle.Location = new System.Drawing.Point(2, 8);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(205, 55);
            this.LblTitle.TabIndex = 11;
            this.LblTitle.Text = "Reserva";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnClear
            // 
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Image = global::Library.Properties.Resources.clear;
            this.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClear.Location = new System.Drawing.Point(320, 95);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(148, 28);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "Limpar";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Image = global::Library.Properties.Resources.search;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.Location = new System.Drawing.Point(166, 95);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(148, 28);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = global::Library.Properties.Resources.check;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(12, 95);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(148, 28);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Salvar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 352);
            this.Controls.Add(this.PnlForm);
            this.Controls.Add(this.PnlActions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library - Reserva";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMakeReservation_KeyDown);
            this.PnlForm.ResumeLayout(false);
            this.PnlForm.PerformLayout();
            this.PnlActions.ResumeLayout(false);
            this.PnlActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForm;
        private System.Windows.Forms.Label LblBook;
        private System.Windows.Forms.TextBox TxtBook;
        private System.Windows.Forms.Label LblCheckoutIn;
        private System.Windows.Forms.Label LblLeitor;
        private System.Windows.Forms.TextBox TxtReader;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Panel PnlActions;
        private System.Windows.Forms.DateTimePicker DtpCheckoutIn;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblMessage;
    }
}