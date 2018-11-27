using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Shamazon.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(128)]
        public string SellerId { get; set; }

        [Display(Name = "Seller")]
        public string SellerName { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        [Display(Name = "Price")]
        public float CurrentPrice { get; set; }
        public float OriginalPrice { get; set; }
        public int ImageId { get; set; }
        public byte Rating { get; set; }
    }
}