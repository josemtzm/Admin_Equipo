using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Equipos.Models
{
    public class AsignacionDB : DbContext
    {
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Equipos> Equipo { get; set; }

    }
}
