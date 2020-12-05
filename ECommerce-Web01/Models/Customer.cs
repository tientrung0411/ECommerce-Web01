using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce_Web01.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Key]
        public int CodeCus { get; set; }
        [Required]
        public string NameCus { get; set; }
        [Required]
        public string AddressCus { get; set; }
        [MaxLength(10)]
        [MinLength(10)]
        public string PhoneCus { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}