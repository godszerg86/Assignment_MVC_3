using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_MVC_3.Models
{
    public class Product
    {
        public Product()
        {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        //many-to-many
        public virtual ICollection<Sale> Sales { get; set; }
    }
}