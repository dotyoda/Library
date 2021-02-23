using Library.DAOs;
using Library.Models;
using Library.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    class ReaderRepository
    {
        public ReaderRepository()
        {
            this.lendingDAO = new LendingDAO();
            this.reservationDAO = new ReservationDAO();
        }

        private readonly LendingDAO lendingDAO;
        private readonly ReservationDAO reservationDAO;

        public int TotalLentBooks(int readerId)
        {
            var lendings = this.lendingDAO.conn.Entity.Where(lending => lending.Reader.Id == readerId).ToList();
            return lendings.Count();
        }

        public bool ReservationAvailableAt(Book book, DateTime checkout)
        {
            int lentBookCounter = this.lendingDAO.conn
                .Entity
                .ToList()
                .Where(lending => lending.Checkout.AddDays(Constants.MAX_DAYS_LENDING).Date < checkout.Date && lending.BookId == book.Id).ToList().Count;

            var reservations = this.reservationDAO.conn
                .Entity
                .ToList()
                .Where(reservation =>
                    (
                        reservation.CheckoutIn.Date <= checkout.Date.AddDays(Constants.MAX_DAYS_LENDING) 
                        && reservation.CheckoutIn.Date >= checkout.Date.AddDays(-Constants.MAX_DAYS_LENDING)
                    )
                    && reservation.BookId == book.Id
                ).ToList();

            return reservations.Count < (book.Quantity - lentBookCounter);
        }

        public Reservation ReserveBook(Reader reader, Book book, DateTime checkout)
        {
            var reservation = new Reservation
            {
                ReaderId = reader.Id,
                BookId = book.Id,
                CheckoutIn = checkout.Date
            };

            return reservationDAO.Save(reservation);
        }

        public Reservation FetchReservation(string bookId, int readerId)
        {
            return 
                this.reservationDAO.conn
                .Entity
                .ToList()
                .Where(r => r.Book.Id == bookId && r.Reader.Id == readerId)
                .First();
        }
    }
}
