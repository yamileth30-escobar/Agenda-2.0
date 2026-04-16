using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AgendaContactos.DAL;

namespace DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<ContactoDAL> Contactos { get; set; }

        public DatabaseContext() : base("name=MiConexion")
        {
        }
    }
}
