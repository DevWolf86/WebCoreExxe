using System.ComponentModel.DataAnnotations;

namespace WebCoreExxe.Models
{
    public class LInventario
    {
        [Key]
        public int id_registro {  get; set; }
        public string Producto { get; set; } = string.Empty;
        public string Cantidad_producto { get; set; } = string.Empty;
        public string Vendido { get; set; } = string.Empty;
    }
}
