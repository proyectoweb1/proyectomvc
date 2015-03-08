using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace proyectoWeb.Models
{
    public class Productos
    {
        public int Id { get; set; }
        public string usuario { get; set; }
        [DisplayName("Nombre del Producto")]
        public string nombre_producto { get; set; }
        [DisplayName("Descripcion del Producto")]
        public string descripcion { get; set; }
        [DisplayName("Estado del Producto")]
        public string estado { get; set; }
        [DisplayName("Fecha del Producto")]
        public string fecha { get; set; }
        [DisplayName("Precio del Producto")]
        public int precio { get; set; }
    }
}