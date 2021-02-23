
namespace Library.Views
{
    partial class FrmSearchBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchBook));
            this.RdbTitle = new System.Windows.Forms.RadioButton();
            this.RdbISBN = new System.Windows.Forms.RadioButton();
            this.LblSearchBy = new System.Windows.Forms.Label();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.RdbAuthor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // RdbTitle
            // 
            this.RdbTitle.AutoSize = true;
            this.RdbTitle.Location = new System.Drawing.Point(68, 438);
            this.RdbTitle.Name = "RdbTitle";
            this.RdbTitle.Size = new System.Drawing.Size(53, 17);
            this.RdbTitle.TabIndex = 14;
            this.RdbTitle.Text = "Título";
            this.RdbTitle.UseVisualStyleBackColor = true;
            // 
            // RdbISBN
            // 
            this.RdbISBN.AutoSize = true;
            this.RdbISBN.Checked = true;
            this.RdbISBN.Location = new System.Drawing.Point(12, 438);
            this.RdbISBN.Name = "RdbISBN";
            this.RdbISBN.Size = new System.Drawing.Size(50, 17);
            this.RdbISBN.TabIndex = 13;
            this.RdbISBN.TabStop = true;
            this.RdbISBN.Text = "ISBN";
            this.RdbISBN.UseVisualStyleBackColor = true;
            // 
            // LblSearchBy
            // 
            this.LblSearchBy.AutoSize = true;
            this.LblSearchBy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearchBy.Location = new System.Drawing.Point(9, 419);
            this.LblSearchBy.Name = "LblSearchBy";
            this.LblSearchBy.Size = new System.Drawing.Size(67, 14);
            this.LblSearchBy.TabIndex = 12;
            this.LblSearchBy.Text = "Buscar por";
            // 
            // BtnSelect
            // 
            this.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect.Image = global::Library.Properties.Resources.check;
            this.BtnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSelect.Location = new System.Drawing.Point(857, 378);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(148, 28);
            this.BtnSelect.TabIndex = 11;
            this.BtnSelect.Text = "Selecionar";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(12, 379);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(839, 27);
            this.TxtSearch.TabIndex = 10;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DgvBooks
            // 
            this.DgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBooks.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvBooks.GridColor = System.Drawing.SystemColors.Control;
            this.DgvBooks.Location = new System.Drawing.Point(12, 12);
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.ReadOnly = true;
            this.DgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBooks.Size = new System.Drawing.Size(993, 349);
            this.DgvBooks.TabIndex = 9;
            // 
            // RdbAuthor
            // 
            this.RdbAuthor.AutoSize = true;
            this.RdbAuthor.Location = new System.Drawing.Point(127, 438);
            this.RdbAuthor.Name = "RdbAuthor";
            this.RdbAuthor.Size = new System.Drawing.Size(50, 17);
            this.RdbAuthor.TabIndex = 15;
            this.RdbAuthor.Text = "Autor";
            this.RdbAuthor.UseVisualStyleBackColor = true;
            // 
            // FrmSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 467);
            this.Controls.Add(this.RdbAuthor);
            this.Controls.Add(this.RdbTitle);
            this.Controls.Add(this.RdbISBN);
            this.Controls.Add(this.LblSearchBy);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DgvBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmSearchBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library - Buscar Livro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSearchBook_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdbTitle;
        private System.Windows.Forms.RadioButton RdbISBN;
        private System.Windows.Forms.Label LblSearchBy;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.RadioButton RdbAuthor;
    }
}