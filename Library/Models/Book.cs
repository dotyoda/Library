using Library.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    [Table("books")]
    public class Book: Model<string>
    {

        static Book()
        {
            dao = new BookDAO();
        }

        static private readonly BookDAO dao;

        [Key]
        [Column("isbn")]
        public override string Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Column("numPages")]
        public int NumPages { get; set; }

        [Column("publisher")]
        public string Publisher { get; set; }

        [Column("format")]
        public string Format { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        static public Book FindById(string id)
        {
            return dao.GetById(id);
        }

        static public List<Book> FindWithISBN(string isbn)
        {
            return dao.FindWithISBN(isbn);
        }

        static public List<Book> FindByTitle(string title)
        {
            return dao.FindByTitle(title);
        }

        static public List<Book> FindByAuthor(string author)
        {
            return dao.FindByAuthor(author);
        }

        static public List<Book> FindAll()
        {
            return dao.GetAll();
        }

        public void Save()
        {
            this.Id = dao.Save(this).Id;
        }

        public void Delete()
        {
            dao.Delete(this.Id);
        }
    }
}
