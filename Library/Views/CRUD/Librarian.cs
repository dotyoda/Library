using Library.Models;
using Library.Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library.Views
{
    public partial class FrmLibrarian : Form
    {
        public FrmLibrarian()
        {
            InitializeComponent();
            this.presenter = new LibrarianPresenter(this);
        }

        private readonly LibrarianPresenter presenter;

        public void ShowError(string message)
        {
            this.LblMessage.Text = message;
            this.LblMessage.ForeColor = Color.Red;
            this.LblMessage.Visible = true;
        }

        public void ShowSuccess(string message)
        {
            this.LblMessage.Text = message;
            this.LblMessage.ForeColor = Color.DarkGreen;
            this.LblMessage.Visible = true;
        }

        public void SetId(int id)
        {
            this.TxtLibrarianId.Text = id.ToString();
        }

        public void FillFields(Librarian librarian)
        {
            this.TxtLibrarianId.Text = librarian.Id.ToString();
            this.TxtName.Text = librarian.Name;
            this.TxtPhone.Text = librarian.Phone;
            this.TxtEmail.Text = librarian.Email;
            this.TxtUsername.Text = librarian.Username;
            this.TxtPassword.Text = librarian.Password;
        }

        public void ClearFields()
        {
            ClearTextBoxes(this.Controls);
            this.LblMessage.Visible = false;
        }

        private void Save()
        {
            this.presenter.Save(
                id: this.TxtLibrarianId.Text == string.Empty ? 0 : int.Parse(this.TxtLibrarianId.Text),
                name: this.TxtName.Text,
                phone: this.TxtPhone.Text,
                email: this.TxtEmail.Text,
                username: this.TxtUsername.Text,
                password: this.TxtPassword.Text
            );
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Tem certeza que deseja excluir esse registro?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(this.TxtLibrarianId.Text))
                    presenter.Delete(int.Parse(this.TxtLibrarianId.Text));
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.presenter.Search();
            this.LblMessage.Visible = false;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
                if (ctrl is TextBoxBase) ctrl.Text = String.Empty;
                else ClearTextBoxes(ctrl.Controls);
        }

        private void FrmAddLibrarian_Shown(object sender, EventArgs e)
        {
            this.TxtName.Focus();
        }

        private void FrmLibrarian_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    this.Save();
                    break;
            }
        }
    }
}
