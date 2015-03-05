using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proyectoWeb.Models
{
    public class Transaccion
    {
        public int Id { get; set; }
        public string usuario { get; set; }
        public string Estado { get; set; }
        public string FechaCreacion { get; set; }

        public int ProductoOfrecidoId { get; set; }

        public virtual Producto ProductoOfrecido { get; set; }

    }
}