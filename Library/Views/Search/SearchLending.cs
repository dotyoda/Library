using Library.Models;
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
    public partial class FrmSearchLending : Form
    {
        public FrmSearchLending()
        {
            InitializeComponent();
            FillTable(Lending.FindAll());
        }

        private List<Lending> _lendings;

        private Lending _lending;
        public Lending Lending { get => _lending; }

        private void FillTable(List<Lending> lendings)
        {
            this._lendings = lendings;

            if (lendings != null && lendings.Count > 0)
            {
                var newReservations = lendings.Select(l => new {
                    l.Id,
                    Reader = l.Reader.Name,
                    Book = l.Book.Title,
                    Checkin = l.Checkin.ToString("dd/MM/yyyy")
                }).ToList();
                
                DgvLendings.DataSource = newReservations;

                if (this.DgvLendings.Columns.Count > 0)
                {
                    this.DgvLendings.Columns[0].HeaderText = "Código";
                    this.DgvLendings.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    this.DgvLendings.Columns[0].Width = 70;

                    this.DgvLendings.Columns[1].HeaderText = "Leitor";
                    this.DgvLendings.Columns[2].HeaderText = "Livro";
                    this.DgvLendings.Columns[3].HeaderText = "Devolver Em";
                }
            }

        }

        public void SelectLending()
        {
            var reservation = this.DgvLendings.SelectedRows[0].Cells;

            _lending = this._lendings.Where(r => r.Id == int.Parse(reservation[0].Value.ToString())).First();

            this.Close();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.TxtSearch.Text.Length > 0)
            {
                if (this.RdbId.Checked)
                {
                    bool success = int.TryParse(this.TxtSearch.Text, out int id);

                    List<Lending> lendings = new List<Lending>();
                    if (success)
                    {
                        var lending = Lending.FindById(id);
                        if (lending != null)
                            lendings.Add(lending);
                    }
                    FillTable(lendings);
                }
                else if (this.RdbReader.Checked)
                    FillTable(Lending.FindWithReader(this.TxtSearch.Text));
                else if (this.RdbBook.Checked)
                    FillTable(Lending.FindWithBook(this.TxtSearch.Text));
            }
            else
                FillTable(Lending.FindAll());
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            _lending = this.DgvLendings.SelectedRows[0].DataBoundItem as Lending;
            this.Close();
        }

        private void FrmSearchLending_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    this.SelectLending();
                    break;
            }
        }
    }
}
