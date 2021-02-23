using Library.Models;
using Library.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAOs
{
    class LibrarianDAO: DAO<Librarian, int>
    {

        public List<Librarian> FindWithName(string name)
        {
            List<Librarian> librarian = conn.Entity.Where(l => l.Name.Contains(name)).ToList();

            if (librarian.Count == 0) return null;

            return librarian;
        }

        public List<Librarian> FindWithUsername(string username)
        {
           return conn.Entity.Where(l => l.Username.Contains(username)).ToList();
        }

        public Librarian FindByUsername(string username)
        {
            var librarians = conn.Entity.Where(l => l.Username == username).ToList();
            return librarians.Count > 0 ? librarians.First() : null;
        }
    }
}
