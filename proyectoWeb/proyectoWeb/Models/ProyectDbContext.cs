using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proyectoWeb.Models
{
    public class ProyectDbContext : DbContext
    {
        public ProyectDbContext() : base("ProyectoWebConnection") {

        }

        public DbSet<Producto> Productos { set; get; }
        public DbSet<Transaccion> Transacciones { set; get; }

    }
}