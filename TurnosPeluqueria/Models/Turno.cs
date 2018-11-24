using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurnosPeluqueria.Models
{
    public class Turno
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Cliente")]
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        [Required]
        [DisplayName("Peluquero")]
        public int PeluqueroId { get; set; }
        public virtual Peluquero Peluquero { get; set; }
        [Required]
        public DateTime Horario { get; set; }
    }
}