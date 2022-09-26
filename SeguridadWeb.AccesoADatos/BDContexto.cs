using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ********************************
using Microsoft.EntityFrameworkCore;
using SeguridadWeb.EntidadesDeNegocio;

namespace SeguridadWeb.AccesoADatos
{
    public class BDContexto: DbContext
    {
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=M17-C1;Initial Catalog=SeguridadWebdb;Integrated Security=True");
        }
    }
}
