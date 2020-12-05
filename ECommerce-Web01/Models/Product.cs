using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce_Web01.Models
{
    public class Product
    { 
        public Product()
        {
            Image = "~/Content/Images/add.png";
        }
        [Key]
        public int ID { get; set; }
        [Required]
        public string NameProduct { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double UniPrice { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}