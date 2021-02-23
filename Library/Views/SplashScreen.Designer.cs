
namespace Library.Views
{
    partial class FrmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplashScreen));
            this.PgbLoad = new System.Windows.Forms.ProgressBar();
            this.PnlBoddy = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PgbLoad
            // 
            this.PgbLoad.Location = new System.Drawing.Point(12, 159);
            this.PgbLoad.Name = "PgbLoad";
            this.PgbLoad.Size = new System.Drawing.Size(388, 23);
            this.PgbLoad.TabIndex = 1;
            // 
            // PnlBoddy
            // 
            this.PnlBoddy.BackgroundImage = global::Library.Properties.Resources.large_library;
            this.PnlBoddy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlBoddy.Location = new System.Drawing.Point(0, 13);
            this.PnlBoddy.Name = "PnlBoddy";
            this.PnlBoddy.Size = new System.Drawing.Size(412, 130);
            this.PnlBoddy.TabIndex = 0;
            // 
            // FrmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(412, 194);
            this.Controls.Add(this.PgbLoad);
            this.Controls.Add(this.PnlBoddy);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.FrmSplashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBoddy;
        private System.Windows.Forms.ProgressBar PgbLoad;
    }
}