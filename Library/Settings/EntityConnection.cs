using Library.Models;
using System.Configuration;
using System.Data.Entity;

namespace Library.Settings
{
    class EntityConnection<T, I> : DbContext where T : Model<I>
    {
        public EntityConnection() : base(ConfigurationManager.ConnectionStrings["DB"].ConnectionString) { }

        public DbSet<T> Entity { get; set; }

    }
}
