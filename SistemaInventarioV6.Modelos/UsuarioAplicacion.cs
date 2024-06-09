using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioV6.Modelos
{
    public class UsuarioAplicacion :IdentityUser
    {
        [Required(ErrorMessage = "El Nombre es requerido")]
        [MaxLength(80)]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El Apellido es requerido")]
        [MaxLength(80)]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "La Direccion es requerida")]
        [MaxLength(200)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "La Ciudad es requerida")]
        [MaxLength(60)]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "El Pais es requerido")]
        [MaxLength(60)]
        public string Pais { get; set; }

        [NotMapped] // No se mapea contra la db
        public string Role { get; set; }
    }
}
