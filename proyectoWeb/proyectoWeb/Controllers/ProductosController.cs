using proyectoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace proyectoWeb.Controllers
{
    public class ProductosController : Controller
    {
        //
        private ProyectDbContext db = new ProyectDbContext();
        // GET: /Productos/
        public ActionResult Index()
        {
            return View(db.Productos.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }
	}
}