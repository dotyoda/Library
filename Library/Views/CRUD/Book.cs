using Library.DAOs;
using Library.Models;
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
    public partial class FrmBook : Form
    {
        public FrmBook()
        {
            InitializeComponent();
            this.presenter = new BookPresenter(this);
        }

        private readonly BookPresenter presenter;

        private void Save()
        {
            this.presenter.Save(
                isbn: this.TxtISBN.Text,
                title: this.TxtTitle.Text,
                author: this.TxtAuthor.Text,
                numPages: this.TxtPrice.Text == string.Empty ? 0 : int.Parse(this.TxtNumPages.Text),
                publisher: this.TxtPublisher.Text,
                format: this.CmbFormat.Items[this.CmbFormat.SelectedIndex].ToString(),
                price: this.TxtPrice.Text == string.Empty ? 0 : decimal.Parse(this.TxtPrice.Text),
                quantity: this.TxtQuantity.Text == string.Empty ? 0 : int.Parse(this.TxtQuantity.Text)
            );
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.presenter.Search();
            this.LblMessage.Visible = false;
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
                if (!string.IsNullOrEmpty(this.TxtISBN.Text))
                    presenter.Delete(this.TxtISBN.Text);
            }
        }

        public void FillFields(Book book)
        {
            this.TxtISBN.Text = book.Id;
            this.TxtTitle.Text = book.Title;
            this.TxtAuthor.Text = book.Author;
            this.TxtNumPages.Text = book.NumPages.ToString();
            this.TxtPublisher.Text = book.Publisher;
            this.CmbFormat.SelectedIndex = this.CmbFormat.FindStringExact(book.Format);
            this.TxtPrice.Text = book.Price.ToString(); ;
            this.TxtQuantity.Text = book.Quantity.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

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

        public void ClearFields()
        {
            ClearTextBoxes(this.Controls);
            this.LblMessage.Visible = false;
        }

        private void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
                if (ctrl is TextBoxBase) ctrl.Text = String.Empty;
                else ClearTextBoxes(ctrl.Controls);
        }

        private void FrmBookCRUD_KeyDown(object sender, KeyEventArgs e)
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

        private void FrmBook_Shown(object sender, EventArgs e)
        {
            this.TxtISBN.Focus();
            this.CmbFormat.SelectedIndex = 0;
        }
    }
}
