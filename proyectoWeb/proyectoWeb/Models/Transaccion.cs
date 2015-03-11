using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Fecha")]
        public string FechaCreacion { get; set; }
        [DisplayName("Producto Ofrecido")]
        public int ProductoOfrecidoId { get; set; }
        [DisplayName("Producto Cambio")]
        public int ProductoCambioId { get; set; }
        public string Comentario { get; set; }

        public virtual Producto ProductoOfrecido { get; set; }

    }
}