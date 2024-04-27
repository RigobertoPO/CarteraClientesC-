using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CarteraClientes.Api.Models
{
    public partial class ModeloCartera : DbContext
    {
        public ModeloCartera()
            : base("name=CarteraEntities")
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);
        }
    }
}
