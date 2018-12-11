using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Shamazon.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }
        [StringLength(128)]
        public string UserId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}


