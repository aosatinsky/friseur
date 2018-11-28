using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosPeluqueria.Models
{
    public class Feriado
    {
        public string Motivo { get; set; }
        public string Tipo { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public string Id { get; set; }
    }
}