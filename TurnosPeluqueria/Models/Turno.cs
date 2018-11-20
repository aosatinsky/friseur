using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TurnosPeluqueria.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        [DisplayName("Cliente")]
        public virtual Cliente Cliente { get; set; }
        public int PeluqueroId { get; set; }
        [DisplayName("Peluquero")]
        public virtual Peluquero Peluquero { get; set; }
        public DateTime Horario { get; set; }
    }
}