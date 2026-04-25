using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sales_Database.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; }
        public int Quantity { get; set; }
        [Precision(10, 2)]
        public decimal Price { get; set; }
        [MaxLength(250)]
        [DefaultValue("No description")]
        public string Description { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
