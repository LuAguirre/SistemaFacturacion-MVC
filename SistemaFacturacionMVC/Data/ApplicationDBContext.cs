using Microsoft.EntityFrameworkCore;
using SistemaFacturacionMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<invoiceProduct>()
                .HasKey(ip => new { ip.idInvoice, ip.idProduct });
            modelBuilder.Entity<spProducts>()
                .HasNoKey();
            modelBuilder.Entity<estadisticasFactura>()
                .HasNoKey();
        }


        public DbSet<invoiceProduct> invoiceProduct {get; set;}

        public DbSet<product> product { get; set; }

        public DbSet<invoice> invoice { get; set; }
        public DbSet<client> client { get; set; }
        public DbSet<spProducts> spProducts { get; set; }
        public DbSet<estadisticasFactura> estadisticasFacturas { get; set; }
        public DbSet<SistemaFacturacionMVC.Models.userT> user { get; set; }
    }
}
