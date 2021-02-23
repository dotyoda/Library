using Library.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library.Views
{
    public partial class FrmSearchBook : Form
    {
        public FrmSearchBook()
        {
            InitializeComponent();
            FillTable(Book.FindAll());
        }

        private Book _book;
        public Book Book { get => _book; }

        public void FillTable(List<Book> books)
        {
            this.DgvBooks.DataSource = books;

            if (this.DgvBooks.Columns.Count > 0)
            {
                this.DgvBooks.Columns[0].HeaderText = "ISBN";
                this.DgvBooks.Columns[1].HeaderText = "Título";
                this.DgvBooks.Columns[2].HeaderText = "Autor";

                this.DgvBooks.Columns[3].Visible = false;

                this.DgvBooks.Columns[4].HeaderText = "Editora";

                this.DgvBooks.Columns[5].Visible = false;
                this.DgvBooks.Columns[6].Visible = false;
                this.DgvBooks.Columns[7].Visible = false;
            }
        }

        protected void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.TxtSearch.Text.Length > 0)
            {
                if (this.RdbISBN.Checked)
                    FillTable(Book.FindWithISBN(this.TxtSearch.Text));
                else if (this.RdbTitle.Checked)
                    FillTable(Book.FindByTitle(this.TxtSearch.Text));
                else if (this.RdbAuthor.Checked)
                    FillTable(Book.FindByAuthor(this.TxtSearch.Text));
            }
            else
                FillTable(Book.FindAll());
        }

        private void SelectBook()
        {
            _book = this.DgvBooks.SelectedRows[0].DataBoundItem as Book;
            this.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            this.SelectBook();
        }

        private void FrmSearchBook_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    this.SelectBook();
                    break;
            }
        }
    } 
}
