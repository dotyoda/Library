
namespace Library.Views
{
    partial class FrmSearchLending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchLending));
            this.RdbBook = new System.Windows.Forms.RadioButton();
            this.RdbReader = new System.Windows.Forms.RadioButton();
            this.RdbId = new System.Windows.Forms.RadioButton();
            this.LblSearchBy = new System.Windows.Forms.Label();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DgvLendings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLendings)).BeginInit();
            this.SuspendLayout();
            // 
            // RdbBook
            // 
            this.RdbBook.AutoSize = true;
            this.RdbBook.Location = new System.Drawing.Point(133, 438);
            this.RdbBook.Name = "RdbBook";
            this.RdbBook.Size = new System.Drawing.Size(48, 17);
            this.RdbBook.TabIndex = 22;
            this.RdbBook.Text = "Livro";
            this.RdbBook.UseVisualStyleBackColor = true;
            // 
            // RdbReader
            // 
            this.RdbReader.AutoSize = true;
            this.RdbReader.Location = new System.Drawing.Point(76, 438);
            this.RdbReader.Name = "RdbReader";
            this.RdbReader.Size = new System.Drawing.Size(51, 17);
            this.RdbReader.TabIndex = 21;
            this.RdbReader.Text = "Leitor";
            this.RdbReader.UseVisualStyleBackColor = true;
            // 
            // RdbId
            // 
            this.RdbId.AutoSize = true;
            this.RdbId.Checked = true;
            this.RdbId.Location = new System.Drawing.Point(12, 438);
            this.RdbId.Name = "RdbId";
            this.RdbId.Size = new System.Drawing.Size(58, 17);
            this.RdbId.TabIndex = 20;
            this.RdbId.TabStop = true;
            this.RdbId.Text = "Código";
            this.RdbId.UseVisualStyleBackColor = true;
            // 
            // LblSearchBy
            // 
            this.LblSearchBy.AutoSize = true;
            this.LblSearchBy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearchBy.Location = new System.Drawing.Point(9, 419);
            this.LblSearchBy.Name = "LblSearchBy";
            this.LblSearchBy.Size = new System.Drawing.Size(67, 14);
            this.LblSearchBy.TabIndex = 19;
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
            this.BtnSelect.TabIndex = 18;
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
            this.TxtSearch.TabIndex = 17;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DgvLendings
            // 
            this.DgvLendings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLendings.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DgvLendings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvLendings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvLendings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvLendings.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvLendings.GridColor = System.Drawing.SystemColors.Control;
            this.DgvLendings.Location = new System.Drawing.Point(12, 12);
            this.DgvLendings.Name = "DgvLendings";
            this.DgvLendings.ReadOnly = true;
            this.DgvLendings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLendings.Size = new System.Drawing.Size(993, 349);
            this.DgvLendings.TabIndex = 16;
            // 
            // FrmSearchLending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 468);
            this.Controls.Add(this.RdbBook);
            this.Controls.Add(this.RdbReader);
            this.Controls.Add(this.RdbId);
            this.Controls.Add(this.LblSearchBy);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DgvLendings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmSearchLending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library - Buscar Empréstimo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSearchLending_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLendings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdbBook;
        private System.Windows.Forms.RadioButton RdbReader;
        private System.Windows.Forms.RadioButton RdbId;
        private System.Windows.Forms.Label LblSearchBy;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DgvLendings;
    }
}