using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioV6.Modelos
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es Requerido")]
        [MaxLength(60,ErrorMessage ="Nombre debe ser Maximo 60 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripcion es Requerida")]
        [MaxLength(100, ErrorMessage = "La descripcion debe ser Maximo 100 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage ="El estado es requerido")]
        public bool Estado { get; set; }
    }
}
