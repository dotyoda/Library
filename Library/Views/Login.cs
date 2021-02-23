using Library.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Views
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.presenter = new LoginPresenter(this);
        }

        public bool Login { get; set; }

        private readonly LoginPresenter presenter;

        public void ShowError(string message)
        {
            this.LblMessage.Visible = true;
            this.LblMessage.Text = message;
        }

        private void Auth()
        {
            this.presenter.Auth(this.TxbUsername.Text, this.TxbPassword.Text);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Auth();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    this.Auth();
                    break;
                    
            }
        }
    }
}
