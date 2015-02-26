using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace proyectoWeb.Models
{
    public class login
    {
        [Required]
        [Display(Name = "Nombre Usuario")]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Contrasenna { get; set; }
    }
    public class Registrarse
    {
        [Required]
        [Display(Name = "Nombre Usuario")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Contrasenna { get; set; }
    }
}