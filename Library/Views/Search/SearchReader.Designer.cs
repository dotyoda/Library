
namespace Library.Views
{
    partial class FrmSearchReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchReader));
            this.LblSearchBy = new System.Windows.Forms.Label();
            this.RdbId = new System.Windows.Forms.RadioButton();
            this.RdbName = new System.Windows.Forms.RadioButton();
            this.DgvReaders = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSearchBy
            // 
            this.LblSearchBy.AutoSize = true;
            this.LblSearchBy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearchBy.Location = new System.Drawing.Point(9, 419);
            this.LblSearchBy.Name = "LblSearchBy";
            this.LblSearchBy.Size = new System.Drawing.Size(67, 14);
            this.LblSearchBy.TabIndex = 6;
            this.LblSearchBy.Text = "Buscar por";
            // 
            // RdbId
            // 
            this.RdbId.AutoSize = true;
            this.RdbId.Checked = true;
            this.RdbId.Location = new System.Drawing.Point(12, 438);
            this.RdbId.Name = "RdbId";
            this.RdbId.Size = new System.Drawing.Size(58, 17);
            this.RdbId.TabIndex = 7;
            this.RdbId.TabStop = true;
            this.RdbId.Text = "Código";
            this.RdbId.UseVisualStyleBackColor = true;
            // 
            // RdbName
            // 
            this.RdbName.AutoSize = true;
            this.RdbName.Location = new System.Drawing.Point(76, 438);
            this.RdbName.Name = "RdbName";
            this.RdbName.Size = new System.Drawing.Size(53, 17);
            this.RdbName.TabIndex = 8;
            this.RdbName.Text = "Nome";
            this.RdbName.UseVisualStyleBackColor = true;
            // 
            // DgvReaders
            // 
            this.DgvReaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReaders.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DgvReaders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvReaders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvReaders.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvReaders.GridColor = System.Drawing.SystemColors.Control;
            this.DgvReaders.Location = new System.Drawing.Point(12, 12);
            this.DgvReaders.Name = "DgvReaders";
            this.DgvReaders.ReadOnly = true;
            this.DgvReaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvReaders.Size = new System.Drawing.Size(993, 349);
            this.DgvReaders.TabIndex = 0;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(12, 379);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(839, 27);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
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
            this.BtnSelect.TabIndex = 5;
            this.BtnSelect.Text = "Selecionar";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // FrmSearchReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 468);
            this.Controls.Add(this.RdbName);
            this.Controls.Add(this.RdbId);
            this.Controls.Add(this.LblSearchBy);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DgvReaders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmSearchReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library - Procurar Leitor (a)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSearchReader_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblSearchBy;
        private System.Windows.Forms.RadioButton RdbId;
        private System.Windows.Forms.RadioButton RdbName;
        private System.Windows.Forms.DataGridView DgvReaders;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSelect;
    }
}