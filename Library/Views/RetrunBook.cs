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
    public partial class FrmReturnBook : Form
    {
        public FrmReturnBook()
        {
            InitializeComponent();
            this.presenter = new ReturnBookPresenter(this);

            LtvLendings.Columns.Add("Código", 30, HorizontalAlignment.Center);
            LtvLendings.Columns.Add("Leitor", 100, HorizontalAlignment.Left);
            LtvLendings.Columns.Add("Livro", 100, HorizontalAlignment.Left);
            LtvLendings.Columns.Add("Retirado Em", 50, HorizontalAlignment.Center);
            
            LtvLendings.FullRowSelect = true;
            LtvLendings.GridLines = true;
            LtvLendings.View = View.Details;

            SizeLastColumn(this.LtvLendings);

            this.presenter.SelectAll();
        }

        private readonly ReturnBookPresenter presenter;

        public void FillTable(List<Lending> lendings)
        {
            if (lendings != null && lendings.Count > 0)
            {
                this.LtvLendings.Items.Clear();

                var newLendings = lendings.Select(l => new {
                    l.Id,
                    Reader = l.Reader.Name,
                    Book = l.Book.Title,
                    Checkout = l.Checkout.ToString("dd/MM/yyyy")
                }).ToList();

                foreach (var lending in newLendings)
                {
                    ListViewItem item = new ListViewItem(lending.Id.ToString());

                    item.SubItems.Add(lending.Reader.ToString());
                    item.SubItems.Add(lending.Book.ToString());
                    item.SubItems.Add(lending.Checkout.ToString());

                    item.Font = new Font("Arial", 10, FontStyle.Regular);
                    LtvLendings.Items.Add(item);
                }
            }
        }

        private void SizeLastColumn(ListView lv)
        {
            int x = lv.Width / 8 == 0 ? 1 : lv.Width / 8;
            lv.Columns[0].Width = x;
            lv.Columns[1].Width = x * 3;
            lv.Columns[2].Width = x * 3;
            lv.Columns[3].Width = x;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = this.TxtSearch.Text;

            if (this.RdbId.Checked)
                this.presenter.Search(search, SearchBy.ID);
            else if (this.RdbReader.Checked)
                this.presenter.Search(search, SearchBy.READER);
            else if (this.RdbBook.Checked)
                this.presenter.Search(search, SearchBy.BOOK);
        }

        private void FrmReturnBook_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {
            if (LtvLendings.SelectedItems.Count > 0)
            {
                var item = LtvLendings.SelectedItems[0];
                this.presenter.ReturnBook(int.Parse(item.SubItems[0].Text));
            }
        }
    }
}
