
namespace Library.Views
{
    partial class FrmReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReturnBook));
            this.LtvLendings = new System.Windows.Forms.ListView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnReturnBook = new System.Windows.Forms.Button();
            this.LblSearch = new System.Windows.Forms.Label();
            this.LblSearchBy = new System.Windows.Forms.Label();
            this.RdbId = new System.Windows.Forms.RadioButton();
            this.RdbReader = new System.Windows.Forms.RadioButton();
            this.RdbBook = new System.Windows.Forms.RadioButton();
            this.LblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LtvLendings
            // 
            this.LtvLendings.AllowColumnReorder = true;
            this.LtvLendings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LtvLendings.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LtvLendings.FullRowSelect = true;
            this.LtvLendings.GridLines = true;
            this.LtvLendings.HideSelection = false;
            this.LtvLendings.Location = new System.Drawing.Point(12, 191);
            this.LtvLendings.Name = "LtvLendings";
            this.LtvLendings.Size = new System.Drawing.Size(1010, 336);
            this.LtvLendings.TabIndex = 0;
            this.LtvLendings.UseCompatibleStateImageBehavior = false;
            this.LtvLendings.View = System.Windows.Forms.View.Details;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.TxtSearch.Location = new System.Drawing.Point(12, 109);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(532, 26);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // BtnReturnBook
            // 
            this.BtnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturnBook.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturnBook.Image = global::Library.Properties.Resources.book;
            this.BtnReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReturnBook.Location = new System.Drawing.Point(832, 148);
            this.BtnReturnBook.Name = "BtnReturnBook";
            this.BtnReturnBook.Size = new System.Drawing.Size(190, 28);
            this.BtnReturnBook.TabIndex = 8;
            this.BtnReturnBook.Text = "Devolver Livro";
            this.BtnReturnBook.UseVisualStyleBackColor = true;
            this.BtnReturnBook.Click += new System.EventHandler(this.BtnReturnBook_Click);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LblSearch.Location = new System.Drawing.Point(9, 90);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(57, 16);
            this.LblSearch.TabIndex = 9;
            this.LblSearch.Text = "Buscar";
            // 
            // LblSearchBy
            // 
            this.LblSearchBy.AutoSize = true;
            this.LblSearchBy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearchBy.Location = new System.Drawing.Point(9, 148);
            this.LblSearchBy.Name = "LblSearchBy";
            this.LblSearchBy.Size = new System.Drawing.Size(67, 14);
            this.LblSearchBy.TabIndex = 10;
            this.LblSearchBy.Text = "Buscar por";
            // 
            // RdbId
            // 
            this.RdbId.AutoSize = true;
            this.RdbId.Checked = true;
            this.RdbId.Location = new System.Drawing.Point(12, 166);
            this.RdbId.Name = "RdbId";
            this.RdbId.Size = new System.Drawing.Size(58, 17);
            this.RdbId.TabIndex = 11;
            this.RdbId.TabStop = true;
            this.RdbId.Text = "Código";
            this.RdbId.UseVisualStyleBackColor = true;
            // 
            // RdbReader
            // 
            this.RdbReader.AutoSize = true;
            this.RdbReader.Location = new System.Drawing.Point(76, 166);
            this.RdbReader.Name = "RdbReader";
            this.RdbReader.Size = new System.Drawing.Size(51, 17);
            this.RdbReader.TabIndex = 12;
            this.RdbReader.Text = "Leitor";
            this.RdbReader.UseVisualStyleBackColor = true;
            // 
            // RdbBook
            // 
            this.RdbBook.AutoSize = true;
            this.RdbBook.Location = new System.Drawing.Point(133, 166);
            this.RdbBook.Name = "RdbBook";
            this.RdbBook.Size = new System.Drawing.Size(48, 17);
            this.RdbBook.TabIndex = 13;
            this.RdbBook.Text = "Livro";
            this.RdbBook.UseVisualStyleBackColor = true;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitle.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold);
            this.LblTitle.Location = new System.Drawing.Point(2, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(347, 55);
            this.LblTitle.TabIndex = 14;
            this.LblTitle.Text = "Devolver Livro";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 539);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.RdbBook);
            this.Controls.Add(this.RdbReader);
            this.Controls.Add(this.RdbId);
            this.Controls.Add(this.LblSearchBy);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.BtnReturnBook);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LtvLendings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library - Devolver Livro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmReturnBook_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnReturnBook;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Label LblSearchBy;
        private System.Windows.Forms.RadioButton RdbId;
        private System.Windows.Forms.RadioButton RdbReader;
        private System.Windows.Forms.RadioButton RdbBook;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.ListView LtvLendings;
    }
}