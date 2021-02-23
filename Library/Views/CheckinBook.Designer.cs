
namespace Library.Views
{
    partial class FrmCheckinBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckinBook));
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblTitleReader = new System.Windows.Forms.Label();
            this.LblReader = new System.Windows.Forms.Label();
            this.LblBook = new System.Windows.Forms.Label();
            this.LblTitleBook = new System.Windows.Forms.Label();
            this.LblTitleCheckout = new System.Windows.Forms.Label();
            this.LblReturn = new System.Windows.Forms.Label();
            this.LblCheckout = new System.Windows.Forms.Label();
            this.LblTitleReturn = new System.Windows.Forms.Label();
            this.LblTitlePrice = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblTitleFine = new System.Windows.Forms.Label();
            this.LblFine = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblTitleTotal = new System.Windows.Forms.Label();
            this.LblDivider = new System.Windows.Forms.Label();
            this.LblComments = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.ChbDamage = new System.Windows.Forms.CheckBox();
            this.ChbLost = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitle.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold);
            this.LblTitle.Location = new System.Drawing.Point(5, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(347, 55);
            this.LblTitle.TabIndex = 15;
            this.LblTitle.Text = "Devolver Livro";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTitleReader
            // 
            this.LblTitleReader.AutoSize = true;
            this.LblTitleReader.Font = new System.Drawing.Font("Arial", 11F);
            this.LblTitleReader.Location = new System.Drawing.Point(12, 88);
            this.LblTitleReader.Name = "LblTitleReader";
            this.LblTitleReader.Size = new System.Drawing.Size(44, 17);
            this.LblTitleReader.TabIndex = 16;
            this.LblTitleReader.Text = "Leitor";
            // 
            // LblReader
            // 
            this.LblReader.AutoSize = true;
            this.LblReader.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.LblReader.Location = new System.Drawing.Point(11, 105);
            this.LblReader.Name = "LblReader";
            this.LblReader.Size = new System.Drawing.Size(61, 21);
            this.LblReader.TabIndex = 17;
            this.LblReader.Text = "Leitor";
            // 
            // LblBook
            // 
            this.LblBook.AutoSize = true;
            this.LblBook.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.LblBook.Location = new System.Drawing.Point(12, 165);
            this.LblBook.Name = "LblBook";
            this.LblBook.Size = new System.Drawing.Size(55, 21);
            this.LblBook.TabIndex = 19;
            this.LblBook.Text = "Livro";
            // 
            // LblTitleBook
            // 
            this.LblTitleBook.AutoSize = true;
            this.LblTitleBook.Font = new System.Drawing.Font("Arial", 11F);
            this.LblTitleBook.Location = new System.Drawing.Point(12, 148);
            this.LblTitleBook.Name = "LblTitleBook";
            this.LblTitleBook.Size = new System.Drawing.Size(39, 17);
            this.LblTitleBook.TabIndex = 18;
            this.LblTitleBook.Text = "Livro";
            // 
            // LblTitleCheckout
            // 
            this.LblTitleCheckout.AutoSize = true;
            this.LblTitleCheckout.Font = new System.Drawing.Font("Arial", 10F);
            this.LblTitleCheckout.Location = new System.Drawing.Point(341, 89);
            this.LblTitleCheckout.Name = "LblTitleCheckout";
            this.LblTitleCheckout.Size = new System.Drawing.Size(86, 16);
            this.LblTitleCheckout.TabIndex = 20;
            this.LblTitleCheckout.Text = "Retirado Em";
            // 
            // LblReturn
            // 
            this.LblReturn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LblReturn.Location = new System.Drawing.Point(321, 166);
            this.LblReturn.Name = "LblReturn";
            this.LblReturn.Size = new System.Drawing.Size(105, 16);
            this.LblReturn.TabIndex = 21;
            this.LblReturn.Text = "Devolvido Em";
            this.LblReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCheckout
            // 
            this.LblCheckout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LblCheckout.Location = new System.Drawing.Point(333, 107);
            this.LblCheckout.Name = "LblCheckout";
            this.LblCheckout.Size = new System.Drawing.Size(93, 16);
            this.LblCheckout.TabIndex = 22;
            this.LblCheckout.Text = "Retirado Em";
            this.LblCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTitleReturn
            // 
            this.LblTitleReturn.AutoSize = true;
            this.LblTitleReturn.Font = new System.Drawing.Font("Arial", 10F);
            this.LblTitleReturn.Location = new System.Drawing.Point(333, 150);
            this.LblTitleReturn.Name = "LblTitleReturn";
            this.LblTitleReturn.Size = new System.Drawing.Size(94, 16);
            this.LblTitleReturn.TabIndex = 23;
            this.LblTitleReturn.Text = "Devolvido Em";
            // 
            // LblTitlePrice
            // 
            this.LblTitlePrice.AutoSize = true;
            this.LblTitlePrice.Font = new System.Drawing.Font("Arial", 10F);
            this.LblTitlePrice.Location = new System.Drawing.Point(13, 223);
            this.LblTitlePrice.Name = "LblTitlePrice";
            this.LblTitlePrice.Size = new System.Drawing.Size(40, 16);
            this.LblTitlePrice.TabIndex = 24;
            this.LblTitlePrice.Text = "Valor";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.LblPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblPrice.Location = new System.Drawing.Point(12, 240);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(91, 24);
            this.LblPrice.TabIndex = 25;
            this.LblPrice.Text = "R$ 20,00";
            // 
            // LblTitleFine
            // 
            this.LblTitleFine.AutoSize = true;
            this.LblTitleFine.Font = new System.Drawing.Font("Arial", 10F);
            this.LblTitleFine.Location = new System.Drawing.Point(13, 274);
            this.LblTitleFine.Name = "LblTitleFine";
            this.LblTitleFine.Size = new System.Drawing.Size(42, 16);
            this.LblTitleFine.TabIndex = 26;
            this.LblTitleFine.Text = "Multa";
            // 
            // LblFine
            // 
            this.LblFine.AutoSize = true;
            this.LblFine.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.LblFine.ForeColor = System.Drawing.Color.Firebrick;
            this.LblFine.Location = new System.Drawing.Point(12, 290);
            this.LblFine.Name = "LblFine";
            this.LblFine.Size = new System.Drawing.Size(91, 24);
            this.LblFine.TabIndex = 27;
            this.LblFine.Text = "R$ 00,00";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.LblTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblTotal.Location = new System.Drawing.Point(12, 363);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(126, 32);
            this.LblTotal.TabIndex = 29;
            this.LblTotal.Text = "R$ 25,00";
            // 
            // LblTitleTotal
            // 
            this.LblTitleTotal.AutoSize = true;
            this.LblTitleTotal.Font = new System.Drawing.Font("Arial", 10F);
            this.LblTitleTotal.Location = new System.Drawing.Point(13, 346);
            this.LblTitleTotal.Name = "LblTitleTotal";
            this.LblTitleTotal.Size = new System.Drawing.Size(38, 16);
            this.LblTitleTotal.TabIndex = 28;
            this.LblTitleTotal.Text = "Total";
            // 
            // LblDivider
            // 
            this.LblDivider.AutoSize = true;
            this.LblDivider.Location = new System.Drawing.Point(-60, 319);
            this.LblDivider.Name = "LblDivider";
            this.LblDivider.Size = new System.Drawing.Size(203, 14);
            this.LblDivider.TabIndex = 30;
            this.LblDivider.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - ";
            // 
            // LblComments
            // 
            this.LblComments.AutoSize = true;
            this.LblComments.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.LblComments.Location = new System.Drawing.Point(322, 217);
            this.LblComments.Name = "LblComments";
            this.LblComments.Size = new System.Drawing.Size(83, 15);
            this.LblComments.TabIndex = 32;
            this.LblComments.Text = "Observações";
            // 
            // BtnReturn
            // 
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.Image = global::Library.Properties.Resources.check;
            this.BtnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReturn.Location = new System.Drawing.Point(267, 363);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(160, 28);
            this.BtnReturn.TabIndex = 33;
            this.BtnReturn.Text = "Devolver";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // ChbDamage
            // 
            this.ChbDamage.AutoSize = true;
            this.ChbDamage.Location = new System.Drawing.Point(326, 239);
            this.ChbDamage.Name = "ChbDamage";
            this.ChbDamage.Size = new System.Drawing.Size(57, 18);
            this.ChbDamage.TabIndex = 34;
            this.ChbDamage.Text = "Danos";
            this.ChbDamage.UseVisualStyleBackColor = true;
            this.ChbDamage.CheckedChanged += new System.EventHandler(this.ChbDamage_CheckedChanged);
            // 
            // ChbLost
            // 
            this.ChbLost.AutoSize = true;
            this.ChbLost.Location = new System.Drawing.Point(326, 260);
            this.ChbLost.Name = "ChbLost";
            this.ChbLost.Size = new System.Drawing.Size(54, 18);
            this.ChbLost.TabIndex = 35;
            this.ChbLost.Text = "Perda";
            this.ChbLost.UseVisualStyleBackColor = true;
            this.ChbLost.CheckedChanged += new System.EventHandler(this.ChbLost_CheckedChanged);
            // 
            // FrmCheckinBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 404);
            this.Controls.Add(this.ChbLost);
            this.Controls.Add(this.ChbDamage);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.LblComments);
            this.Controls.Add(this.LblDivider);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblTitleTotal);
            this.Controls.Add(this.LblFine);
            this.Controls.Add(this.LblTitleFine);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblTitlePrice);
            this.Controls.Add(this.LblTitleReturn);
            this.Controls.Add(this.LblCheckout);
            this.Controls.Add(this.LblReturn);
            this.Controls.Add(this.LblTitleCheckout);
            this.Controls.Add(this.LblBook);
            this.Controls.Add(this.LblTitleBook);
            this.Controls.Add(this.LblReader);
            this.Controls.Add(this.LblTitleReader);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCheckinBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library - Devolver Livro       ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblTitleReader;
        private System.Windows.Forms.Label LblReader;
        private System.Windows.Forms.Label LblBook;
        private System.Windows.Forms.Label LblTitleBook;
        private System.Windows.Forms.Label LblTitleCheckout;
        private System.Windows.Forms.Label LblReturn;
        private System.Windows.Forms.Label LblCheckout;
        private System.Windows.Forms.Label LblTitleReturn;
        private System.Windows.Forms.Label LblTitlePrice;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblTitleFine;
        private System.Windows.Forms.Label LblFine;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblTitleTotal;
        private System.Windows.Forms.Label LblDivider;
        private System.Windows.Forms.Label LblComments;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.CheckBox ChbDamage;
        private System.Windows.Forms.CheckBox ChbLost;
    }
}