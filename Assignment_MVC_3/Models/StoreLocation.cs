using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_MVC_3.Models
{
    public class StoreLocation
    {
        public StoreLocation()
        {
            Sales = new List<Sale>();
        }

        public int Id { get; set; }
        public string LocationName { get; set; }

        //relations
        public ICollection<Sale> Sales { get; set; }
    }
}