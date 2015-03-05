﻿using System;
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
    public class TransaccionController : Controller
    {
        private ProyectDbContext db = new ProyectDbContext();

        // GET: /Transaccion/
        public ActionResult Index()
        {
            var transacciones = db.Transacciones.Include(t => t.ProductoOfrecido);
            return View(transacciones.ToList());
        }

        // GET: /Transaccion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaccion transaccion = db.Transacciones.Find(id);
            if (transaccion == null)
            {
                return HttpNotFound();
            }
            return View(transaccion);
        }

        // GET: /Transaccion/Create
        public ActionResult Create()
        {
            ViewBag.ProductoOfrecidoId = new SelectList(db.Productos, "Id", "nombre_producto");
            if (Session["User"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("login", "Account");
            }
        }

        // POST: /Transaccion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Estado,FechaCreacion,ProductoOfrecidoId")] Transaccion transaccion)
        {
            transaccion.usuario = User.Identity.Name;
            if (ModelState.IsValid)
            {
                db.Transacciones.Add(transaccion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductoOfrecidoId = new SelectList(db.Productos, "Id", "nombre_producto", transaccion.ProductoOfrecidoId);
            return View(transaccion);
        }

        // GET: /Transaccion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaccion transaccion = db.Transacciones.Find(id);
            if (transaccion == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductoOfrecidoId = new SelectList(db.Productos, "Id", "nombre_producto", transaccion.ProductoOfrecidoId);           
            if (Session["User"] != null)
            {
                return View(transaccion);
            }
            else
            {
                return RedirectToAction("login", "Account");
            }
        }

        // POST: /Transaccion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Estado,FechaCreacion,ProductoOfrecidoId")] Transaccion transaccion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transaccion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductoOfrecidoId = new SelectList(db.Productos, "Id", "nombre_producto", transaccion.ProductoOfrecidoId);
            return View(transaccion);
        }

        // GET: /Transaccion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaccion transaccion = db.Transacciones.Find(id);
            if (transaccion == null)
            {
                return HttpNotFound();
            }
            if (Session["User"] != null)
            {
                return View(transaccion);
            }
            else
            {
                return RedirectToAction("login", "Account");
            }

        }

        // POST: /Transaccion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Transaccion transaccion = db.Transacciones.Find(id);
            db.Transacciones.Remove(transaccion);
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
    }
}
