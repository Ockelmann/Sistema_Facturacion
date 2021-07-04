using Sistema_Facturacion.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Sistema_Facturacion.DB
{
    public class AplicationDbContext: DbContext
    {

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Factura_Productos> Factura_Productos { get; set; }
        public DbSet<Reporte_Productos> Reporte_Productos { get; set; }
        public DbSet<Reporte_Cliente> Reporte_Clientes { get; set; }
        public DbSet<Reporte_Estadistica> Reporte_Estadistica { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            modelBuilder.Entity<Factura_Productos>()
            .HasKey(p => new { p.Numero_Facturafk, p.Codigo_Productofk });



            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            base.OnModelCreating(modelBuilder);
        }

    }
}
