
namespace Library.Views
{
    partial class FrmSearchLibrarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchLibrarian));
            this.BtnSelect = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DgvLibrarians = new System.Windows.Forms.DataGridView();
            this.RdbId = new System.Windows.Forms.RadioButton();
            this.LblSearchBy = new System.Windows.Forms.Label();
            this.RdbName = new System.Windows.Forms.RadioButton();
            this.RdbUsername = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibrarians)).BeginInit();
            this.SuspendLayout();
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
            this.BtnSelect.TabIndex = 8;
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
            this.TxtSearch.TabIndex = 7;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DgvLibrarians
            // 
            this.DgvLibrarians.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLibrarians.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DgvLibrarians.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvLibrarians.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvLibrarians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvLibrarians.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvLibrarians.GridColor = System.Drawing.SystemColors.Control;
            this.DgvLibrarians.Location = new System.Drawing.Point(12, 12);
            this.DgvLibrarians.Name = "DgvLibrarians";
            this.DgvLibrarians.ReadOnly = true;
            this.DgvLibrarians.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLibrarians.Size = new System.Drawing.Size(993, 349);
            this.DgvLibrarians.TabIndex = 6;
            // 
            // RdbId
            // 
            this.RdbId.AutoSize = true;
            this.RdbId.Checked = true;
            this.RdbId.Location = new System.Drawing.Point(12, 439);
            this.RdbId.Name = "RdbId";
            this.RdbId.Size = new System.Drawing.Size(58, 17);
            this.RdbId.TabIndex = 10;
            this.RdbId.Text = "Código";
            this.RdbId.UseVisualStyleBackColor = true;
            // 
            // LblSearchBy
            // 
            this.LblSearchBy.AutoSize = true;
            this.LblSearchBy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearchBy.Location = new System.Drawing.Point(9, 420);
            this.LblSearchBy.Name = "LblSearchBy";
            this.LblSearchBy.Size = new System.Drawing.Size(67, 14);
            this.LblSearchBy.TabIndex = 9;
            this.LblSearchBy.Text = "Buscar por";
            // 
            // RdbName
            // 
            this.RdbName.AutoSize = true;
            this.RdbName.Location = new System.Drawing.Point(76, 439);
            this.RdbName.Name = "RdbName";
            this.RdbName.Size = new System.Drawing.Size(53, 17);
            this.RdbName.TabIndex = 11;
            this.RdbName.Text = "Nome";
            this.RdbName.UseVisualStyleBackColor = true;
            // 
            // RdbUsername
            // 
            this.RdbUsername.AutoSize = true;
            this.RdbUsername.Location = new System.Drawing.Point(135, 439);
            this.RdbUsername.Name = "RdbUsername";
            this.RdbUsername.Size = new System.Drawing.Size(61, 17);
            this.RdbUsername.TabIndex = 12;
            this.RdbUsername.Text = "Usuário";
            this.RdbUsername.UseVisualStyleBackColor = true;
            // 
            // FrmSearchLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 468);
            this.Controls.Add(this.RdbUsername);
            this.Controls.Add(this.RdbName);
            this.Controls.Add(this.RdbId);
            this.Controls.Add(this.LblSearchBy);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DgvLibrarians);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmSearchLibrarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library - Buscar Bibliotecário (a)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSearchLibrarian_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibrarians)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DgvLibrarians;
        private System.Windows.Forms.RadioButton RdbId;
        private System.Windows.Forms.Label LblSearchBy;
        private System.Windows.Forms.RadioButton RdbName;
        private System.Windows.Forms.RadioButton RdbUsername;
    }
}