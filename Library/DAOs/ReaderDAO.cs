using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.DAOs
{
    class ReaderDAO: DAO<Reader, int>
    {
        public Reader FindByRG(string rg)
        {
            List<Reader> readers =  conn.Entity.Where(r => r.RG == rg).ToList();

            if (readers.Count == 0) return null;

            return readers.First();
        }

        public List<Reader> FindByName(string name)
        {
            List<Reader> readers = conn.Entity.Where(reader => reader.Name.Contains(name)).ToList();

            if (readers.Count == 0) return null;

            return readers;
        }
    }
}
