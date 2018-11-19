using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosPeluqueria.Models
{
    public class Peluquero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Dni { get; set; }

        public virtual List<Turno> Turnos { get; set; }
    }
}