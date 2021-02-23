using Library.Models;
using Library.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAOs
{ 
    class LendingDAO: DAO<Lending, int> 
    {
        public List<Lending> FindWithReader(string name)
        {
            return conn.Entity.Where(l => l.Reader.Name.Contains(name) && l.Checkin <= new DateTime(1, 1, 1)).ToList<Lending>();
        }

        public List<Lending> FindByReaderId(int readerId)
        {
            return conn.Entity.Where(l => l.Reader.Id == readerId && l.Checkin <= new DateTime(1, 1, 1)).ToList();
        }

        public List<Lending> FindWithBook(string title)
        {
            return conn.Entity.Where(l => l.Book.Title.Contains(title) && l.Checkin <= new DateTime(1, 1, 1)).ToList<Lending>();
        }

        public override List<Lending> GetAll()
        {
            return conn.Entity.Where(l => l.Checkin <= new DateTime(1, 1, 1)).ToList();
        }
    }
}
