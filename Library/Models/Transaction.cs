using Library.DAOs;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    [Table("transactions")]
    public class Transaction : Model<int>
    {
        static Transaction()
        {
            dao = new TransactionDAO();
        }

        static private readonly TransactionDAO dao;

        [Key]
        [Column("id")]
        public override int Id { get; set; }

        [ForeignKey("LendingId")]
        public virtual Lending Lending { get; set; }
        public int LendingId { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("fine")]
        public decimal Fine { get; set; }

        [NotMapped]
        public decimal Total { get => this.Price + this.Fine; }

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }

        public void Save()
        {
            this.Id = dao.Save(this).Id;
        }
    }
}
