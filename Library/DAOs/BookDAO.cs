using Library.Models;
using Library.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAOs
{
    class BookDAO : DAO<Book, string>
    {
        public List<Book> FindByTitle(string title)
        {
            List<Book> books = conn.Entity.Where(b => b.Title.Contains(title)).ToList();

            if (books.Count == 0) return null;

            return books;
        }

        public List<Book> FindByAuthor(string author)
        {
            List<Book> books = conn.Entity.Where(b => b.Author.Contains(author)).ToList();

            if (books.Count == 0) return null;

            return books;
        }

        public List<Book> FindWithISBN(string isbn)
        {
            List<Book> books = conn.Entity.Where(b => b.Id.Contains(isbn)).ToList();

            if (books.Count == 0) return null;

            return books;
        }
    }
}
