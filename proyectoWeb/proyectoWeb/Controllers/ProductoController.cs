using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using proyectoWeb.Models;

namespace proyectoWeb.Controllers
{
    public class ProductoController : Controller
    {
        private ProyectDbContext db = new ProyectDbContext();

        // GET: /Producto/
        public ActionResult Index()
        {
            return View(db.Productos.ToList());
        }

        // GET: /Producto/Details/5
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

        // GET: /Producto/Create
        public ActionResult Create()
        {
            if (Session["User"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("login", "Account");
            }
            
        }

        // POST: /Producto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,nombre_producto,descripcion,foto,estado,fecha,precio")] Producto producto)
        {
            producto.usuario = User.Identity.Name;
            if (ModelState.IsValid)
            {
                db.Productos.Add(producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(producto);
        }

        // GET: /Producto/Edit/5
        public ActionResult Edit(int? id)
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
            if (Session["User"] != null)
            {
                return View(producto);
            }
            else
            {
                return RedirectToAction("login", "Account");
            }
        }

        // POST: /Producto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,nombre_producto,descripcion,foto,estado,fecha,precio")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(producto);
        }

        // GET: /Producto/Delete/5
        public ActionResult Delete(int? id)
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
            if (Session["User"] != null)
            {
                return View(producto);
            }
            else
            {
                return RedirectToAction("login", "Account");
            }
        }

        // POST: /Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Producto producto = db.Productos.Find(id);
            db.Productos.Remove(producto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Search()
        {
                return View();
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Search([Bind(Include = "nombre_producto")] Producto producto)
        //{
        //    producto.usuario = User.Identity.Name;
        //    if (ModelState.IsValid)
        //    {
        //        var product = from Products in Producto
        //                                   where Products.nombre_producto == producto
        //                                   select Products;
        //        return RedirectToAction("Index");
        //    }

        //    return View(producto);
        //}
            
    }
}
