using Library.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Library.Models
{
    public enum LendingStatus
    {
        INPROGRESS,
        CONCLUED
    }

    [Table("lendings")]
    public class Lending : Model<int>
    {
        static Lending()
        {
            dao = new LendingDAO();
        }

        static private readonly LendingDAO dao;

        [Key]
        [Column("id")]
        public override int Id { get; set; }

        [ForeignKey("ReaderId")]
        public virtual Reader Reader { get; set; }
        public int ReaderId { get; set; }

        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
        public string BookId { get; set; }

        [Column("checkout")]
        public DateTime Checkout { get; set; }

        [Column("checkin")]
        public DateTime Checkin { get; set; }

        static public Lending LendBook(Book book, Reader reader)
        {
            Lending lending = new Lending {
                ReaderId = reader.Id,
                BookId = book.Id,
                Checkout = DateTime.Now.Date,
            };

            return dao.Save(lending);
        }

        static public Lending FindById(int id)
        {
            return dao.GetById(id);
        }

        static public List<Lending> FindWithReader(string name)
        {
            return dao.FindWithReader(name);
        }

        static public List<Lending> FindWithBook(string title)
        {
            return dao.FindWithBook(title);
        }

        static public List<Lending> FindAll()
        {
            return dao.GetAll();
        }

        public void Save()
        {
            this.Id = dao.Save(this).Id;
        }
    }
}
