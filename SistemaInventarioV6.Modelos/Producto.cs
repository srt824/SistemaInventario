using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioV6.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El Numero de Serie es requerido.")]
        [MaxLength(60)]
        public string NumeroSerie { get; set; }

        [Required(ErrorMessage = "La Descripcion es requerida.")]
        [MaxLength(100)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El Precio es requerido.")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "El Costo es requerida.")]
        public double Costo { get; set; }

        public string ImagenUrl { get; set; }

        [Required(ErrorMessage = "El Estado es requerido.")]
        public bool Estado { get; set; }

        //relaciones con otros modelos

        [Required(ErrorMessage = "La Categoria es requerida.")]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "La Marca es requerida.")]
        public int MarcaId { get; set; }

        [ForeignKey("MarcaId")]
        public Marca Marca { get; set; }

        public int? PadreId { get; set; }
        public virtual Producto Padre { get; set; }
    }
}
