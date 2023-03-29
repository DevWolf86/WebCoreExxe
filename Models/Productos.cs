using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCoreExxe.Models
{
    public class Productos
    {
        [Key]
        public int idProducto { get; set; }
        public string Producto { get; set; }
        public string Tipo { get; set; }

        [NotMapped]
        public int idproducto { get; set;}
    }
}
