
namespace Library.Views
{
    partial class FrmReader
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReader));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PnlForm = new System.Windows.Forms.Panel();
            this.LblMessage = new System.Windows.Forms.Label();
            this.TxtRG = new System.Windows.Forms.MaskedTextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtReaderId = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblReaderId = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblDocNumber = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.PnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 137);
            this.panel1.TabIndex = 22;
            // 
            // BtnClear
            // 
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Image = global::Library.Properties.Resources.clear;
            this.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClear.Location = new System.Drawing.Point(319, 95);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(148, 28);
            this.BtnClear.TabIndex = 7;
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
            this.BtnDelete.Location = new System.Drawing.Point(520, 95);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(148, 28);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Deletar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitle.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold);
            this.LblTitle.Location = new System.Drawing.Point(1, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(226, 55);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Leitor (a)";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnSearch
            // 
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Image = global::Library.Properties.Resources.search;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.Location = new System.Drawing.Point(165, 95);
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
            this.BtnSave.Location = new System.Drawing.Point(11, 95);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(148, 28);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Salvar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PnlForm
            // 
            this.PnlForm.Controls.Add(this.LblMessage);
            this.PnlForm.Controls.Add(this.TxtRG);
            this.PnlForm.Controls.Add(this.LblEmail);
            this.PnlForm.Controls.Add(this.TxtReaderId);
            this.PnlForm.Controls.Add(this.TxtEmail);
            this.PnlForm.Controls.Add(this.TxtName);
            this.PnlForm.Controls.Add(this.LblReaderId);
            this.PnlForm.Controls.Add(this.LblName);
            this.PnlForm.Controls.Add(this.LblDocNumber);
            this.PnlForm.Controls.Add(this.LblPhone);
            this.PnlForm.Controls.Add(this.TxtPhone);
            this.PnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlForm.Location = new System.Drawing.Point(0, 137);
            this.PnlForm.Name = "PnlForm";
            this.PnlForm.Size = new System.Drawing.Size(680, 249);
            this.PnlForm.TabIndex = 23;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(6, 198);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(78, 19);
            this.LblMessage.TabIndex = 18;
            this.LblMessage.Text = "message";
            this.LblMessage.Visible = false;
            // 
            // TxtRG
            // 
            this.TxtRG.Culture = new System.Globalization.CultureInfo("");
            this.TxtRG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRG.Location = new System.Drawing.Point(562, 61);
            this.TxtRG.Mask = "99.999.999-9";
            this.TxtRG.Name = "TxtRG";
            this.TxtRG.Size = new System.Drawing.Size(105, 26);
            this.TxtRG.TabIndex = 1;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(170, 116);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(50, 16);
            this.LblEmail.TabIndex = 17;
            this.LblEmail.Text = "E-mail";
            // 
            // TxtReaderId
            // 
            this.TxtReaderId.Enabled = false;
            this.TxtReaderId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReaderId.Location = new System.Drawing.Point(10, 61);
            this.TxtReaderId.Name = "TxtReaderId";
            this.TxtReaderId.ReadOnly = true;
            this.TxtReaderId.Size = new System.Drawing.Size(100, 26);
            this.TxtReaderId.TabIndex = 0;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(173, 135);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(293, 26);
            this.TxtEmail.TabIndex = 3;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(116, 61);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(440, 26);
            this.TxtName.TabIndex = 0;
            // 
            // LblReaderId
            // 
            this.LblReaderId.AutoSize = true;
            this.LblReaderId.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReaderId.Location = new System.Drawing.Point(10, 42);
            this.LblReaderId.Name = "LblReaderId";
            this.LblReaderId.Size = new System.Drawing.Size(58, 16);
            this.LblReaderId.TabIndex = 3;
            this.LblReaderId.Text = "Código";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(113, 42);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(48, 16);
            this.LblName.TabIndex = 4;
            this.LblName.Text = "Nome";
            // 
            // LblDocNumber
            // 
            this.LblDocNumber.AutoSize = true;
            this.LblDocNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDocNumber.Location = new System.Drawing.Point(559, 42);
            this.LblDocNumber.Name = "LblDocNumber";
            this.LblDocNumber.Size = new System.Drawing.Size(29, 16);
            this.LblDocNumber.TabIndex = 5;
            this.LblDocNumber.Text = "RG";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhone.Location = new System.Drawing.Point(7, 116);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(69, 16);
            this.LblPhone.TabIndex = 9;
            this.LblPhone.Text = "Telefone";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(10, 135);
            this.TxtPhone.Mask = "(99) 00000-0000";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(157, 26);
            this.TxtPhone.TabIndex = 2;
            // 
            // FrmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 386);
            this.Controls.Add(this.PnlForm);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library -  Leitor";
            this.Shown += new System.EventHandler(this.FrmAddReader_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmReader_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlForm.ResumeLayout(false);
            this.PnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Panel PnlForm;
        private System.Windows.Forms.MaskedTextBox TxtRG;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtReaderId;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblReaderId;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblDocNumber;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Button BtnClear;
    }
}

