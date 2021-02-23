using System;
using Library.Errors;
using Library.Models;
using Library.Views;

namespace Library.Presenters
{
    class ReservationPresenter
    {
        public ReservationPresenter(FrmReservation form)
        {
            this.form = form;
        }

        private readonly FrmReservation form;

        public void Save(
            Reader reader,
            Book book,
            DateTime checkoutIn
        )
        {
            if (reader == null || book == null)
            {
                form.ShowError("Os campos ISBN, Título e Autor são obrigatórios");
                return;
            }

            try
            {
                var reservation = reader.ReserveBook(book, checkoutIn);

                form.SetId(reservation.Id);
                form.ShowSuccess("Reserva realizada com sucesso!");
            } catch (UnavailableData error) {
                form.ShowError(error.Message);
            } catch (Exception error) {
                Console.WriteLine(error);
                form.ShowError("Não foi possível realizar a reserva.");
            }
        }

        public void Search()
        {
            FrmSearchReservation search = new FrmSearchReservation();
            search.ShowDialog();

            Reservation reservation = search.Reservation;

            if (reservation == null)
            {
                form.ShowError("Registro não encontrado.");
            }
            else
                form.FillFields(reservation);
        }

        public void SearchReader()
        {
            FrmSearchReader search = new FrmSearchReader();
            search.ShowDialog();

            Reader reader = search.Reader;

            if (reader != null)
            {
                form.Reader = reader;
            }
            else
                form.ShowError("Registro não encontrado.");

        }

        public void SearchBook()
        {
            FrmSearchBook search = new FrmSearchBook();
            search.ShowDialog();

            Book book = search.Book;

            if (book != null)
            {
                form.Book = book;
            }
            else
                form.ShowError("Registro não encontrado.");
        }

    }
}
