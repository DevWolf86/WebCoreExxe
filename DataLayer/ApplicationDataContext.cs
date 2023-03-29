using Microsoft.EntityFrameworkCore;
using WebCoreExxe.Models;

namespace WebCoreExxe.DataLayer
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Productos> Productos { get; set; }

        public DbSet<Inventario> Inventarios { get; set; }

        public DbSet<LInventario> LInventarios { get; set; }

        public DbSet<Factura> Facturas { get; set; }
    }
}
