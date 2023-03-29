using MessagePack;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace WebCoreExxe.Models
{
    public class Factura
    {
        [Key]
        public int id_Factura { get; set; }
        public string Facturas { get; set; } = string.Empty;
        public string Producto { get; set; } = string.Empty;
        public int idProducto { get; set; }
        public int idUsuario { get; set; }
        public int Impresa { get; set; }

    }
}
