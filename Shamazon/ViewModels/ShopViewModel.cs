using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shamazon.Models;

namespace Shamazon.ViewModels
{
    public class ShopViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<ApplicationUser> Seller { get; set; }
    }
}