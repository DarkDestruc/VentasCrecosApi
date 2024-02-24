using Microsoft.EntityFrameworkCore;
using VentasCrecosApi.Models;

namespace VentasCrecosApi.Data
{
    public class VentasCreCrosDbContext: DbContext
    {
        public VentasCreCrosDbContext(DbContextOptions<VentasCreCrosDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
