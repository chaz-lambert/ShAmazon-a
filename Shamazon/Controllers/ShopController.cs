using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shamazon.Models;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Shamazon.Controllers
{
    public class ShopController : Controller
    {
        private ApplicationDbContext _context;
        private ApplicationUserManager _userManager;

        public ShopController()
        {
            _context = new ApplicationDbContext();
        }

        public ShopController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
            _context = new ApplicationDbContext();
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
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

        // add to cart
        [Authorize]
        public ActionResult ShoppingCart()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            var items = _context.ShoppingCartItems.Where(c => c.UserId == user.Id).Include(p => p.Product).ToList();
            return View(items);
        }

        // add to cart
        [Authorize]
        [Route("Shop/AddToCart/{id}")]
        public ActionResult AddToCart(int id)
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            var product = _context.Products.SingleOrDefault(c => c.Id == id);

            // create new SoppingCartItem and add to ShoppingCartItems DB
            var item = new ShoppingCartItem()
            {
                UserId = user.Id,
                ProductId = product.Id,
                Quantity = 1
            };
            _context.ShoppingCartItems.Add(item);
            _context.SaveChanges();

            return RedirectToAction("ShoppingCart");
        }

        // remove from cart
        [Authorize]
        [Route("Shop/RemoveItem/{Id}")]
        public ActionResult RemoveItem(int Id)
        {
            var item = _context.ShoppingCartItems.SingleOrDefault(i => i.Id == Id);

            _context.ShoppingCartItems.Remove(item);
            _context.SaveChanges();

            return RedirectToAction("ShoppingCart");
        }
    }
}