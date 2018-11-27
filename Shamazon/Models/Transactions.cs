using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Shamazon.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        [Required]
        public int ItemId { get; set; }
        [Required]
        [StringLength(128)]
        public string OwnerId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; }
    }
}