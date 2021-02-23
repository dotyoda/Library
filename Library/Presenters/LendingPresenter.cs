using Library.DAOs;
using Library.Models;
using Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presenters
{
    class LendingPresenter
    {
        public LendingPresenter(FrmLending form)
        {
            this.form = form;
        }

        private readonly FrmLending form;

        private Book _book;
        private Reader _reader;

        public void Save()
        {
            if (_reader == null || _book == null)
            {
                form.ShowError("Os campos Leitor, Livro e Preço são obrigatórios");
                return;
            }

            try
            {
                Lending lending = _reader.LendBook(_book);
                form.SetId(lending.Id);
                form.ShowSuccess("Empréstimo realizado com succeso!");
            } catch (Exception)
            {
                form.ShowError("Não foi possível emprestar o livro.");
            }
        }

        public void Search()
        {
            FrmSearchReservation search = new FrmSearchReservation();
            search.ShowDialog();

            Reservation reservation = search.Reservation;

            if (reservation == null)
                form.ShowError("Registro não encontrado.");
            else
            {
                _reader = reservation.Reader;
                _book = reservation.Book;
                form.FillFields(reservation);
            }
        }
    }
}
