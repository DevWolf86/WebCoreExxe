using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using WebCoreExxe.DataLayer;

namespace WebCoreExxe.Controllers
{
    public class InventarioController : Controller
    {
        private readonly ApplicationDataContext _db;

        public InventarioController(ApplicationDataContext db)
        {
            _db = db; 
        }
        public IActionResult Index()
        {
            var GetAllProducts = _db.LInventarios.FromSql($"SELECT * from pb.LInventario").ToList();
            return View(GetAllProducts);
        }

        public IActionResult GenerarFactura()
        {
            var GetAllVentas = _db.LInventarios.FromSql($"SELECT * from pb.LInventario where vendido = 'Si'").ToList();
            return new ViewAsPdf("GenerarFactura", GetAllVentas.ToList())
            {
                FileName = $"Factura_Vendidos.pdf",
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                PageSize = Rotativa.AspNetCore.Options.Size.A4
            };
        }

        public IActionResult Facturacion()
        {
            var GetAllFacturas = _db.Facturas.FromSql($"select f.* from pb.Factura f inner join pb.Usuarios u on u.idUsuario = f.idUsuario").ToList();
            return View(GetAllFacturas);
        }
    }
}
