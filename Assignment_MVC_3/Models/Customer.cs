using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_MVC_3.Models
{
    public class Customer
    {

        public Customer()
        {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //relations
        public ICollection<Sale> Sales { get; set; }

       

    }
}