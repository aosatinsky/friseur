using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TurnosPeluqueria.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es necesario.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es necesario.")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El DNI es necesario.")]
        [RegularExpression("^[0-9]{1,8}$", ErrorMessage = "Ingrese un DNI valido")]
        public long Dni { get; set; }
        [Required(ErrorMessage = "El email es necesario.")]
        [EmailAddress(ErrorMessage = "Ingrese un email valido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El nombre de usuario es necesario.")]
        [DisplayName("Nombre de usuario")]
        public string User { get; set; }
        [Required(ErrorMessage = "La contrasena es necesaria.")]
        [DataType(DataType.Password)]
        [DisplayName("Contraseña")]
        public string Passw { get; set; }

        public virtual List<Turno> Turnos { get; set; }

    }
}