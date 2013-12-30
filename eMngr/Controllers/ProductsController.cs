using eMngr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace eMngr.Tests.Controllers
{
    public class ProductsController : Controller
    {
        UsersContext db = new UsersContext();
        public ViewResult Index()
        {
            return View("Products", db.Products);
        }
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductModel product)
        {
            if(ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
            return RedirectToAction("");
        }
        public ViewResult Edit(int id)
        {
            var product = db.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(int id, ProductModel product)
        {
            if (ModelState.IsValid && id == product.ID)
            {
                db.Entry(product).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("");
        }
        public ViewResult Details(int id)
        {
            var product = db.Products.Find(id);
            return View(product);
        }
        public ViewResult Delete(int id)
        {
            var product = db.Products.Find(id);
            return View(product);
        }
    }
}
