using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment_MVC_3.Models
{
    public class Employee
    {

        public Employee()
        {
            SalesMade = new HashSet<Sale>();
            SalesApproved = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }

        //relations
        [InverseProperty("EmployeeMakeSale")]
        public ICollection<Sale> SalesMade { get; set; }

        [InverseProperty("EmployeeApprovedSale")]
        public ICollection<Sale> SalesApproved { get; set; }
    }
}