using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_Database.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}
