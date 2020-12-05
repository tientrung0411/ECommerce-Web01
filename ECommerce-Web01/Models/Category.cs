using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce_Web01.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string NameCategory { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}