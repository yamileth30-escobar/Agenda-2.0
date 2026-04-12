using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Contacto> Contactos { get; set; }

        public DatabaseContext() : base("name=MiConexion")
        {
        }
    }
}
