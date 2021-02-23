using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Library.DAOs;


namespace Library.Models
{
    public enum ReservationStatus
    {
        PENDING,
        COMPLETED,
        CENCELED
    }

    [Table("reservations")]
    public class Reservation : Model<int>
    {
        static Reservation()
        {
            dao = new ReservationDAO();
        }

        static private readonly ReservationDAO dao;

        [Key]
        [Column("id")]
        public override int Id { get; set; }

        [ForeignKey("ReaderId")]
        public virtual Reader Reader { get; set; }
        public int ReaderId { get; set; }

        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
        public string BookId { get; set; }

        [Column("checkoutIn")]
        public DateTime CheckoutIn { get; set; }

        [Column("status")]
        public ReservationStatus Status { get; set; }

        public void SetStatus(ReservationStatus newStatus)
        {
            this.Status = newStatus;
            dao.Save(this);
        }

        static public Reservation FindById(int id)
        {
            return dao.GetById(id);
        }

        static public List<Reservation> FindWithReader(string name)
        {
            return dao.FindWithReader(name);
        }

        static public List<Reservation> FindWithBook(string title)
        {
            return dao.FindWithBook(title);
        }

        static public List<Reservation> FindAll()
        {
            return dao.GetAll();
        }

        public void Save()
        {
            this.Id = dao.Save(this).Id;
        }

        
    }
}
