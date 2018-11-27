using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shamazon.Models;


// CONTROLLER: for user to create new Product
namespace Shamazon.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _context;
        public ProductController()
        {
            _context = new ApplicationDbContext();
        }

        // dispose DB object
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {

            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("Index", "Product");
        }
    }
}