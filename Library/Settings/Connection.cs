using System.Configuration;
using System.Data.Entity;


namespace Library.Settings
{
    class Connection: DbContext
    {
        public Connection() : base(ConfigurationManager.ConnectionStrings["DB"].ConnectionString) { }
    }
}
