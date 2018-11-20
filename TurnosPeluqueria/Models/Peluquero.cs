using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage = "El nombre de usuario es necesario.")]
        [DisplayName("Nombre de usuario")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "La contrasena es necesaria.")]
        [DataType(DataType.Password)]
        [DisplayName("Contraseña")]
        public string Passw { get; set; }

        public virtual List<Turno> Turnos { get; set; }
    }
}