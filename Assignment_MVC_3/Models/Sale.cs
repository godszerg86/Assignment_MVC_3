using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_MVC_3.Models
{
    public class Sale
    {
        public Sale ()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }

        //relation props:
        //Customer
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        //StoreLocations
        public int StoreLocationId { get; set; }
        public virtual StoreLocation StoreLocation { get; set; }

        //Products
        //many-to-many
        public ICollection<Product> Products { get; set; }

        //Employee made sale
        public int EmployeeMakeSaleId { get; set; }
        public virtual Employee EmployeeMakeSale { get; set; }

        //Employee aproved sale
        public int? EmployeeApprovedSaleId { get; set; }
        public virtual Employee EmployeeApprovedSale { get; set; }
    }
}