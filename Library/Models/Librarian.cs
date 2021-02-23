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
    [Table("librarians")]
    public class Librarian: Model<int>
    {
        static Librarian()
        {
            DAO = new LibrarianDAO();
        }

        static private readonly LibrarianDAO DAO;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public override int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("Phone")]
        public string Phone { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }

        static public List<Librarian> FindAll()
        {
            return DAO.GetAll();
        }

        static public Librarian FindById(int id)
        {
            return DAO.GetById(id);
        }

        static public List<Librarian> FindWithName(string name)
        {
            return DAO.FindWithName(name);
        }

        static public List<Librarian> FindWithUsername(string username)
        {
            return DAO.FindWithUsername(username);
        }

        static public bool Auth(string username, string password)
        {
            Librarian librarian = DAO.FindByUsername(username);
            return (librarian?.Username == username && librarian?.Password == password);
        }

        public void Save()
        {
            this.Id = DAO.Save(this).Id;
        }

        public void Delete()
        {
            DAO.Delete(Id);
        }
    }
}
