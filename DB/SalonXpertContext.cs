using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class SalonXpertContext: DbContext
    {
        public SalonXpertContext(DbContextOptions<SalonXpertContext> options) 
            : base(options) 
        { 
        
        }
       public DbSet<Clientes> Clientes { get; set; }
       public DbSet<Servicios> Servicios { get; set; }
       public DbSet<Corporacion> Corporacion { get; set; }
       public DbSet<Facturacion> Facturacion { get; set; }
       public DbSet<Citas> Citas { get; set; }
       public DbSet<Login> Login { get; set; }
    }
}