
namespace Library.Views
{
    partial class FrmLibrarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibrarian));
            this.PnlActions = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtLibrarianId = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblReaderId = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.PnlForm = new System.Windows.Forms.Panel();
            this.LblMessage = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblPhone = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.PnlActions.SuspendLayout();
            this.PnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlActions
            // 
            this.PnlActions.Controls.Add(this.LblTitle);
            this.PnlActions.Controls.Add(this.BtnClear);
            this.PnlActions.Controls.Add(this.BtnDelete);
            this.PnlActions.Controls.Add(this.BtnSearch);
            this.PnlActions.Controls.Add(this.BtnSave);
            this.PnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlActions.Location = new System.Drawing.Point(0, 0);
            this.PnlActions.Name = "PnlActions";
            this.PnlActions.Size = new System.Drawing.Size(894, 137);
            this.PnlActions.TabIndex = 22;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold);
            this.LblTitle.Location = new System.Drawing.Point(2, 8);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(380, 55);
            this.LblTitle.TabIndex = 12;
            this.LblTitle.Text = "Bibliotecário (a)";
            // 
            // BtnClear
            // 
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Image = global::Library.Properties.Resources.clear;
            this.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClear.Location = new System.Drawing.Point(320, 92);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(148, 28);
            this.BtnClear.TabIndex = 11;
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
            this.BtnDelete.Location = new System.Drawing.Point(733, 92);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(148, 28);
            this.BtnDelete.TabIndex = 10;
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
            this.BtnSearch.Location = new System.Drawing.Point(166, 92);
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
            this.BtnSave.Location = new System.Drawing.Point(12, 92);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(148, 28);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Salvar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(635, 31);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(50, 16);
            this.LblEmail.TabIndex = 17;
            this.LblEmail.Text = "E-mail";
            // 
            // TxtLibrarianId
            // 
            this.TxtLibrarianId.Enabled = false;
            this.TxtLibrarianId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibrarianId.Location = new System.Drawing.Point(12, 50);
            this.TxtLibrarianId.Name = "TxtLibrarianId";
            this.TxtLibrarianId.ReadOnly = true;
            this.TxtLibrarianId.Size = new System.Drawing.Size(100, 26);
            this.TxtLibrarianId.TabIndex = 0;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(638, 50);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(243, 26);
            this.TxtEmail.TabIndex = 16;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(118, 50);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(372, 26);
            this.TxtName.TabIndex = 2;
            // 
            // LblReaderId
            // 
            this.LblReaderId.AutoSize = true;
            this.LblReaderId.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReaderId.Location = new System.Drawing.Point(12, 31);
            this.LblReaderId.Name = "LblReaderId";
            this.LblReaderId.Size = new System.Drawing.Size(58, 16);
            this.LblReaderId.TabIndex = 3;
            this.LblReaderId.Text = "Código";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(115, 31);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(48, 16);
            this.LblName.TabIndex = 4;
            this.LblName.Text = "Nome";
            // 
            // PnlForm
            // 
            this.PnlForm.Controls.Add(this.LblMessage);
            this.PnlForm.Controls.Add(this.LblPassword);
            this.PnlForm.Controls.Add(this.TxtPassword);
            this.PnlForm.Controls.Add(this.LblUsername);
            this.PnlForm.Controls.Add(this.TxtUsername);
            this.PnlForm.Controls.Add(this.LblEmail);
            this.PnlForm.Controls.Add(this.TxtLibrarianId);
            this.PnlForm.Controls.Add(this.TxtEmail);
            this.PnlForm.Controls.Add(this.TxtName);
            this.PnlForm.Controls.Add(this.LblReaderId);
            this.PnlForm.Controls.Add(this.LblName);
            this.PnlForm.Controls.Add(this.LblPhone);
            this.PnlForm.Controls.Add(this.TxtPhone);
            this.PnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlForm.Location = new System.Drawing.Point(0, 137);
            this.PnlForm.Name = "PnlForm";
            this.PnlForm.Size = new System.Drawing.Size(894, 212);
            this.PnlForm.TabIndex = 21;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblMessage.Location = new System.Drawing.Point(12, 165);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(78, 19);
            this.LblMessage.TabIndex = 22;
            this.LblMessage.Text = "message";
            this.LblMessage.Visible = false;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(227, 97);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(52, 16);
            this.LblPassword.TabIndex = 21;
            this.LblPassword.Text = "Senha";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(230, 116);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(212, 26);
            this.TxtPassword.TabIndex = 20;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(9, 97);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(62, 16);
            this.LblUsername.TabIndex = 19;
            this.LblUsername.Text = "Usuário";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(12, 116);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(212, 26);
            this.TxtUsername.TabIndex = 18;
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhone.Location = new System.Drawing.Point(493, 31);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(69, 16);
            this.LblPhone.TabIndex = 9;
            this.LblPhone.Text = "Telefone";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(496, 50);
            this.TxtPhone.Mask = "(99) 00000-0000";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(136, 26);
            this.TxtPhone.TabIndex = 8;
            // 
            // FrmLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 350);
            this.Controls.Add(this.PnlForm);
            this.Controls.Add(this.PnlActions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmLibrarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library - Biibliotecário (a)";
            this.Shown += new System.EventHandler(this.FrmAddLibrarian_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLibrarian_KeyDown);
            this.PnlActions.ResumeLayout(false);
            this.PnlActions.PerformLayout();
            this.PnlForm.ResumeLayout(false);
            this.PnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlActions;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtLibrarianId;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblReaderId;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Panel PnlForm;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblTitle;
    }
}