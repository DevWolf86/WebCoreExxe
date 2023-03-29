using System.ComponentModel.DataAnnotations;

namespace WebCoreExxe.Models
{
    public class Inventario
    {
        [Key]
        public int idInventario { get; set; }
        public int idProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
