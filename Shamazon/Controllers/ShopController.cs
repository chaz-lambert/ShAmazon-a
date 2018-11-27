using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shamazon.Models;
using System.Data.Entity;

namespace Shamazon.Controllers
{
    public class ShopController : Controller
    {
        private ApplicationDbContext _context;
        public ShopController()
        {
            _context = new ApplicationDbContext();
        }

        // dispose DB object
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Shop Products
        public ActionResult Index(string sortBy)
        {

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            var products = _context.Products.OrderBy(n => n.Name);
            return View(products);
        }

        // RETURN: details of product
        // PARAM: product ID
        [Route("Shop/Product/{id}")]
        public ActionResult Product(int id)
        {
            var product = _context.Products.SingleOrDefault(c => c.Id == id);

            if (product == null)
                return HttpNotFound();

            return View(product);
        }
    }
}