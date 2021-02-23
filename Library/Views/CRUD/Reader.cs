using Library.DAOs;
using Library.Models;
using Library.Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Library.Views
{
    public partial class FrmReader : Form
    {
        public FrmReader()
        {
            InitializeComponent();
            this.presenter = new ReaderPresenter(this);
        }

        private readonly ReaderPresenter presenter;

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
            this.TxtReaderId.Text = id.ToString();
        }

        public void ClearFields()
        {
            ClearTextBoxes(this.Controls);
            this.LblMessage.Visible = false;
        }

        public void FillFields(Reader reader)
        {
            this.TxtReaderId.Text = reader.Id.ToString();
            this.TxtName.Text = reader.Name;
            this.TxtRG.Text = reader.RG;
            this.TxtPhone.Text = reader.Phone;
            this.TxtEmail.Text = reader.Email;
        }

        private void Save()
        {
            presenter.Save(
                id: this.TxtReaderId.Text == string.Empty ? 0 : int.Parse(this.TxtReaderId.Text),
                name: this.TxtName.Text,
                rg: this.TxtRG.Text,
                phone: this.TxtPhone.Text,
                email: this.TxtEmail.Text
            );
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            presenter.Search();
            this.LblMessage.Visible = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Tem certeza que deseja excluir esse registro?", 
                "Confirmar Exclusão", 
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.Yes) {
                if (!string.IsNullOrEmpty(this.TxtReaderId.Text))
                    presenter.Delete(int.Parse(this.TxtReaderId.Text));
            }
        }

        private void FrmAddReader_Shown(object sender, EventArgs e)
        {
            this.TxtName.Focus();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        private void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
                if (ctrl is TextBoxBase) ctrl.Text = String.Empty;
                else ClearTextBoxes(ctrl.Controls);
        }

        private void FrmReader_KeyDown(object sender, KeyEventArgs e)
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
