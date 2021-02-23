using Library.DAOs;
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
    public partial class FrmSearchReservation : Form
    {
        public FrmSearchReservation()
        {
            InitializeComponent();
            FillTable(Reservation.FindAll());
        }

        private List<Reservation> _reservations;

        private Reservation _reservation;
        public Reservation Reservation { get => _reservation; }

        private void FillTable(List<Reservation> reservations)
        {
            this._reservations = reservations;
            
            if (reservations != null && reservations.Count > 0)
            {
                var newReservations = reservations.Select(r => new {
                    r.Id,
                    Reader = r.Reader.Name,
                    Book = r.Book.Title,
                    CheckoutIn = r.CheckoutIn.ToString("dd/MM/yyyy")
                }).ToList();

                DgvReservations.DataSource = newReservations;

                if (this.DgvReservations.Columns.Count > 0)
                {
                    this.DgvReservations.Columns[0].HeaderText = "Código";
                    this.DgvReservations.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    this.DgvReservations.Columns[0].Width = 70;

                    this.DgvReservations.Columns[1].HeaderText = "Leitor";
                    this.DgvReservations.Columns[2].HeaderText = "Livro";
                    this.DgvReservations.Columns[3].HeaderText = "Retirar Em";
                }
            }
            
        }

        public void SelectReservation()
        {
            var reservation = this.DgvReservations.SelectedRows[0].Cells;

            _reservation = this._reservations.Where(r => r.Id == int.Parse(reservation[0].Value.ToString())).First();

            this.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            this.SelectReservation();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.TxtSearch.Text.Length > 0)
            {
                if (this.RdbId.Checked)
                {

                    bool success = int.TryParse(this.TxtSearch.Text, out int id);

                    List<Reservation> readers = new List<Reservation>();
                    if (success)
                    {
                        var reservation = Reservation.FindById(id);
                        if (reservation != null)
                            readers.Add(reservation);
                    }
                    FillTable(readers);
                }
                else if (this.RdbReader.Checked)
                    FillTable(Reservation.FindWithReader(this.TxtSearch.Text));
                else if (this.RdbBook.Checked)
                    FillTable(Reservation.FindWithBook(this.TxtSearch.Text));
            }
            else
                FillTable(Reservation.FindAll());
        }

        private void FrmSearchReservation_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    this.SelectReservation();
                    break;
            }
        }
    }
}
