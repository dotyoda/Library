using Library.Models;
using Library.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAOs
{
    class ReservationDAO: DAO<Reservation, int>
    {
        public List<Reservation> FindWithReader(string name)
        {
            return conn.Entity.Where(reservation => reservation.Reader.Name.Contains(name)).ToList<Reservation>();
        }

        public List<Reservation> FindWithBook(string title)
        {
            return conn.Entity.Where(r => r.Book.Title.Contains(title)).ToList();
        }

        public override List<Reservation> GetAll()
        {
            return conn.Entity.Where(r => r.Status == ReservationStatus.PENDING).ToList();
        }
    } 
}
