
namespace Library.Views
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PnlForm = new System.Windows.Forms.Panel();
            this.LblMessage = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.TxbUsername = new System.Windows.Forms.TextBox();
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.PnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlForm
            // 
            this.PnlForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlForm.BackColor = System.Drawing.Color.White;
            this.PnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlForm.Controls.Add(this.LblMessage);
            this.PnlForm.Controls.Add(this.BtnLogin);
            this.PnlForm.Controls.Add(this.LblPassword);
            this.PnlForm.Controls.Add(this.LblUsername);
            this.PnlForm.Controls.Add(this.TxbPassword);
            this.PnlForm.Controls.Add(this.TxbUsername);
            this.PnlForm.Location = new System.Drawing.Point(181, 109);
            this.PnlForm.Name = "PnlForm";
            this.PnlForm.Size = new System.Drawing.Size(417, 251);
            this.PnlForm.TabIndex = 0;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.LblMessage.Location = new System.Drawing.Point(13, 163);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(71, 16);
            this.LblMessage.TabIndex = 5;
            this.LblMessage.Text = "message";
            this.LblMessage.Visible = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.Black;
            this.BtnLogin.Location = new System.Drawing.Point(120, 201);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(175, 30);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Entrar";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(13, 95);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(58, 19);
            this.LblPassword.TabIndex = 3;
            this.LblPassword.Text = "Senha";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(13, 23);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(69, 19);
            this.LblUsername.TabIndex = 2;
            this.LblUsername.Text = "Usuário";
            // 
            // TxbPassword
            // 
            this.TxbPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.TxbPassword.Location = new System.Drawing.Point(16, 117);
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.Size = new System.Drawing.Size(385, 26);
            this.TxbPassword.TabIndex = 1;
            this.TxbPassword.UseSystemPasswordChar = true;
            // 
            // TxbUsername
            // 
            this.TxbUsername.Font = new System.Drawing.Font("Arial", 12F);
            this.TxbUsername.Location = new System.Drawing.Point(16, 45);
            this.TxbUsername.Name = "TxbUsername";
            this.TxbUsername.Size = new System.Drawing.Size(385, 26);
            this.TxbUsername.TabIndex = 0;
            // 
            // PcbLogo
            // 
            this.PcbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PcbLogo.BackgroundImage = global::Library.Properties.Resources.large_library_symbol;
            this.PcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PcbLogo.Location = new System.Drawing.Point(339, 81);
            this.PcbLogo.Name = "PcbLogo";
            this.PcbLogo.Size = new System.Drawing.Size(100, 22);
            this.PcbLogo.TabIndex = 1;
            this.PcbLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PcbLogo);
            this.Controls.Add(this.PnlForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library - Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.PnlForm.ResumeLayout(false);
            this.PnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForm;
        private System.Windows.Forms.PictureBox PcbLogo;
        private System.Windows.Forms.TextBox TxbUsername;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblMessage;
    }
}