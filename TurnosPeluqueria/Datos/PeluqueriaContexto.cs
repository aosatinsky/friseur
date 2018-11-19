using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TurnosPeluqueria.Models;

namespace TurnosPeluqueria.Datos
{
    public class PeluqueriaContexto : DbContext
    {
        public PeluqueriaContexto() : base("cn")
        {
        }

        public DbSet<Peluquero> Peluqueros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
    }
}