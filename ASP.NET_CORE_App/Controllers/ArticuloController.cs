using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_CORE_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE_App.Controllers
{
    public class ArticuloController : Controller
    {
        AppDbContext db;

        public ArticuloController(AppDbContext db)
        {
            this.db = db;

        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AllArticulo()
        {

            return View(db.Articulos);
        }

        public IActionResult AddArticulo() 
        {

            return View();
        }

        [HttpPost]

        public IActionResult AddArticulo(Articulos articulo)
        {
            db.Add(articulo);
            db.SaveChanges();

            return RedirectToAction("AllArticulo");
        }

        public IActionResult EditArticulo(int id)
        {
            Articulos articulo;

            articulo = db.Articulos.Find(id);

            return View(articulo);
        }

        [HttpPost]

        public IActionResult EditArticulo(Articulos articulo)
        {
            db.Update(articulo);
            db.SaveChanges();
            return RedirectToAction("AllArticulo");
        }

        public IActionResult DeleteArticulo(int id)
        {
            Articulos articulo;

            articulo = db.Articulos.Find(id);

            return View(articulo);
        }


        [HttpPost]

        public IActionResult DeleteArticulo(Articulos articulo)
        {
            db.Remove(articulo);
            db.SaveChanges();
            return RedirectToAction("AllArticulo");
        }

     
    }
}