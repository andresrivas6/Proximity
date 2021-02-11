using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ModelDbContext : DbContext 
    {
        public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Articulo> Articulo { get; set; }

        public DbSet<ArticulosFactura> ArticulosFactura { get; set; }

    }
    
}
