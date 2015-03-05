using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proyectoWeb.Models
{
    public class Producto
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