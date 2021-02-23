
namespace Library.Views
{
    partial class FrmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBook));
            this.PnlForm = new System.Windows.Forms.Panel();
            this.LblMessage = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.CmbFormat = new System.Windows.Forms.ComboBox();
            this.LblFormat = new System.Windows.Forms.Label();
            this.LblNumPages = new System.Windows.Forms.Label();
            this.TxtNumPages = new System.Windows.Forms.TextBox();
            this.LblPublisher = new System.Windows.Forms.Label();
            this.TxtPublisher = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.TxtISBN = new System.Windows.Forms.TextBox();
            this.LblISBN = new System.Windows.Forms.Label();
            this.PnlActions = new System.Windows.Forms.Panel();
            this.LblHeader = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PnlForm.SuspendLayout();
            this.PnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlForm
            // 
            this.PnlForm.Controls.Add(this.LblMessage);
            this.PnlForm.Controls.Add(this.LblAuthor);
            this.PnlForm.Controls.Add(this.TxtAuthor);
            this.PnlForm.Controls.Add(this.LblQuantity);
            this.PnlForm.Controls.Add(this.TxtQuantity);
            this.PnlForm.Controls.Add(this.LblPrice);
            this.PnlForm.Controls.Add(this.TxtPrice);
            this.PnlForm.Controls.Add(this.CmbFormat);
            this.PnlForm.Controls.Add(this.LblFormat);
            this.PnlForm.Controls.Add(this.LblNumPages);
            this.PnlForm.Controls.Add(this.TxtNumPages);
            this.PnlForm.Controls.Add(this.LblPublisher);
            this.PnlForm.Controls.Add(this.TxtPublisher);
            this.PnlForm.Controls.Add(this.LblTitle);
            this.PnlForm.Controls.Add(this.TxtTitle);
            this.PnlForm.Controls.Add(this.TxtISBN);
            this.PnlForm.Controls.Add(this.LblISBN);
            this.PnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlForm.Location = new System.Drawing.Point(0, 131);
            this.PnlForm.Name = "PnlForm";
            this.PnlForm.Size = new System.Drawing.Size(911, 212);
            this.PnlForm.TabIndex = 21;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(12, 168);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(78, 19);
            this.LblMessage.TabIndex = 32;
            this.LblMessage.Text = "message";
            this.LblMessage.Visible = false;
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAuthor.Location = new System.Drawing.Point(603, 31);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(46, 16);
            this.LblAuthor.TabIndex = 31;
            this.LblAuthor.Text = "Autor";
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtAuthor.Location = new System.Drawing.Point(606, 50);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(292, 26);
            this.TxtAuthor.TabIndex = 2;
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(752, 96);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(89, 16);
            this.LblQuantity.TabIndex = 29;
            this.LblQuantity.Text = "Quantidade";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtQuantity.Location = new System.Drawing.Point(755, 114);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(143, 26);
            this.TxtQuantity.TabIndex = 7;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(603, 95);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(49, 16);
            this.LblPrice.TabIndex = 27;
            this.LblPrice.Text = "Preço";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtPrice.Location = new System.Drawing.Point(606, 114);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(143, 26);
            this.TxtPrice.TabIndex = 6;
            // 
            // CmbFormat
            // 
            this.CmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFormat.Font = new System.Drawing.Font("Arial", 12F);
            this.CmbFormat.FormattingEnabled = true;
            this.CmbFormat.Items.AddRange(new object[] {
            "Audiobook",
            "Capa Comum",
            "Capa Dura",
            "Ebook"});
            this.CmbFormat.Location = new System.Drawing.Point(246, 114);
            this.CmbFormat.Name = "CmbFormat";
            this.CmbFormat.Size = new System.Drawing.Size(121, 26);
            this.CmbFormat.Sorted = true;
            this.CmbFormat.TabIndex = 4;
            // 
            // LblFormat
            // 
            this.LblFormat.AutoSize = true;
            this.LblFormat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormat.Location = new System.Drawing.Point(243, 95);
            this.LblFormat.Name = "LblFormat";
            this.LblFormat.Size = new System.Drawing.Size(66, 16);
            this.LblFormat.TabIndex = 24;
            this.LblFormat.Text = "Formato";
            // 
            // LblNumPages
            // 
            this.LblNumPages.AutoSize = true;
            this.LblNumPages.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumPages.Location = new System.Drawing.Point(373, 95);
            this.LblNumPages.Name = "LblNumPages";
            this.LblNumPages.Size = new System.Drawing.Size(82, 16);
            this.LblNumPages.TabIndex = 22;
            this.LblNumPages.Text = "Nº Páginas";
            // 
            // TxtNumPages
            // 
            this.TxtNumPages.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtNumPages.Location = new System.Drawing.Point(373, 114);
            this.TxtNumPages.Name = "TxtNumPages";
            this.TxtNumPages.Size = new System.Drawing.Size(82, 26);
            this.TxtNumPages.TabIndex = 5;
            // 
            // LblPublisher
            // 
            this.LblPublisher.AutoSize = true;
            this.LblPublisher.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPublisher.Location = new System.Drawing.Point(12, 96);
            this.LblPublisher.Name = "LblPublisher";
            this.LblPublisher.Size = new System.Drawing.Size(58, 16);
            this.LblPublisher.TabIndex = 20;
            this.LblPublisher.Text = "Editora";
            // 
            // TxtPublisher
            // 
            this.TxtPublisher.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtPublisher.Location = new System.Drawing.Point(12, 115);
            this.TxtPublisher.Name = "TxtPublisher";
            this.TxtPublisher.Size = new System.Drawing.Size(228, 26);
            this.TxtPublisher.TabIndex = 3;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(193, 31);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(47, 16);
            this.LblTitle.TabIndex = 18;
            this.LblTitle.Text = "Título";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtTitle.Location = new System.Drawing.Point(196, 50);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(404, 26);
            this.TxtTitle.TabIndex = 1;
            // 
            // TxtISBN
            // 
            this.TxtISBN.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtISBN.Location = new System.Drawing.Point(12, 50);
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.Size = new System.Drawing.Size(178, 26);
            this.TxtISBN.TabIndex = 0;
            // 
            // LblISBN
            // 
            this.LblISBN.AutoSize = true;
            this.LblISBN.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblISBN.Location = new System.Drawing.Point(12, 31);
            this.LblISBN.Name = "LblISBN";
            this.LblISBN.Size = new System.Drawing.Size(41, 16);
            this.LblISBN.TabIndex = 3;
            this.LblISBN.Text = "ISBN";
            // 
            // PnlActions
            // 
            this.PnlActions.Controls.Add(this.LblHeader);
            this.PnlActions.Controls.Add(this.BtnClear);
            this.PnlActions.Controls.Add(this.BtnDelete);
            this.PnlActions.Controls.Add(this.BtnSearch);
            this.PnlActions.Controls.Add(this.BtnSave);
            this.PnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlActions.Location = new System.Drawing.Point(0, 0);
            this.PnlActions.Name = "PnlActions";
            this.PnlActions.Size = new System.Drawing.Size(911, 131);
            this.PnlActions.TabIndex = 22;
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblHeader.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold);
            this.LblHeader.Location = new System.Drawing.Point(2, 8);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(138, 55);
            this.LblHeader.TabIndex = 12;
            this.LblHeader.Text = "Livro";
            this.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnClear
            // 
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Image = global::Library.Properties.Resources.clear;
            this.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClear.Location = new System.Drawing.Point(320, 87);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(148, 28);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "Limpar";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Image = global::Library.Properties.Resources.delete;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(750, 87);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(148, 28);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Deletar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Image = global::Library.Properties.Resources.search;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.Location = new System.Drawing.Point(166, 87);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(148, 28);
            this.BtnSearch.TabIndex = 9;
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
            this.BtnSave.Location = new System.Drawing.Point(12, 87);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(148, 28);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Salvar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 343);
            this.Controls.Add(this.PnlForm);
            this.Controls.Add(this.PnlActions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library - Livro";
            this.Shown += new System.EventHandler(this.FrmBook_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBookCRUD_KeyDown);
            this.PnlForm.ResumeLayout(false);
            this.PnlForm.PerformLayout();
            this.PnlActions.ResumeLayout(false);
            this.PnlActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlForm;
        private System.Windows.Forms.Label LblISBN;
        private System.Windows.Forms.Panel PnlActions;
        private System.Windows.Forms.TextBox TxtISBN;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.ComboBox CmbFormat;
        private System.Windows.Forms.Label LblFormat;
        private System.Windows.Forms.Label LblNumPages;
        private System.Windows.Forms.TextBox TxtNumPages;
        private System.Windows.Forms.Label LblPublisher;
        private System.Windows.Forms.TextBox TxtPublisher;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label LblMessage;
    }
}