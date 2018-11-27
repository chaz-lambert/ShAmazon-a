using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Shamazon.Models
{
    public class ShoppingCart
    {
        public List<Product> products { get; set; }

        [StringLength(128)]
        public string SellerId { get; set; }
    }
}