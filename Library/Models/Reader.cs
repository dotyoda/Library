using Library.DAOs;
using Library.Errors;
using Library.Repository;
using Library.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    [Table("readers")]
    public class Reader: Model<int>
    {
        static Reader()
        {
            dao = new ReaderDAO();
            repository = new ReaderRepository();
        }

        static private readonly ReaderDAO dao;
        static private readonly ReaderRepository repository;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public override int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("rg")]
        public string RG { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("email")]
        public string Email { get; set; }

        static public Reader FindById(int id)
        {
            return dao.GetById(id);
        }

        static public Reader FindByDocNumber(string docNumber)
        {
            return dao.FindByRG(docNumber);
        }

        static public List<Reader> FindByName(string name)
        {
            return dao.FindByName(name);
        }

        static public List<Reader> FindAll()
        {
            return dao.GetAll();
        }

        public void Save()
        {
            Reader reader = dao.FindByRG(this.RG);

            if (reader != null && reader.Id != this.Id)
                throw new AlreadyRegistered("Leitor já cadastrado!");
            
            this.Id = dao.Save(this).Id;
        }

        public void Delete()
        {
            dao.Delete(this.Id);
        }

        public Reservation ReserveBook(Book book, DateTime checkout)
        {
            bool available = repository.ReservationAvailableAt(book, checkout);

            if (!available)
                throw new UnavailableData();

            int totalLending = repository.TotalLentBooks(this.Id);

            if (totalLending >= Constants.MAX_BOOKS_LENDING)
                throw new MaxLentBooks();

            return repository.ReserveBook(this, book, checkout);
        }

        public Lending LendBook(Book book)
        {
            int totalLending = repository.TotalLentBooks(this.Id);

            if (totalLending >= Constants.MAX_BOOKS_LENDING)
                throw new MaxLentBooks();

            Reservation reservation = repository.FetchReservation(book.Id, this.Id);

            if (reservation != null)
                reservation.SetStatus(ReservationStatus.COMPLETED);
            else
                throw new Exception("Esse livro já está reservado para outros leitores.");

            return Lending.LendBook(book, this);
        }
    }
}
