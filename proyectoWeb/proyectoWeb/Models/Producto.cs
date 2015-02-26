using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proyectoWeb.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string nombre_producto { get; set; }
        public string descripcion { get; set; }
        public string foto { get;set; }
        public string estado { get; set; }
        public string fecha { get; set; }

        public int precio { get; set; }
    }
}