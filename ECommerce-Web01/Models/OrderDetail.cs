using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce_Web01.Models
{
    public class OrderDetail
    {
        [Key]
        public int ID { get; set; }

        public int QuantitySale { get; set; }
        public double UnitPriceSale { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}