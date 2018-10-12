namespace Assignment_MVC_3.Migrations
{
    using Assignment_MVC_3.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment_MVC_3.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Assignment_MVC_3.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            //seeding tables
            if (!context.Products.Any())
            {
                context.Products.AddOrUpdate(item => item.Id,
                    new Product() { Name = "Banana" , Quantity = 3, Price = 3.75m},
                    new Product() { Name = "Apple", Quantity = 5, Price = 2.35m }
                    );
            }


            if (!context.StoreLocations.Any())
            {
                context.StoreLocations.AddOrUpdate(item => item.Id,
                    new StoreLocation() { LocationName = "Polo Park" },
                    new StoreLocation() { LocationName = "Kenaston"}
                    );
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddOrUpdate(item => item.Id,
                    new Employee() { Name = "John" , RegistrationNumber = 31234 },
                    new Employee() { Name = "Dan", RegistrationNumber = 11223 }
                    );
            }

            if (!context.Customers.Any())
            {
                context.Customers.AddOrUpdate(item => item.Id,
                    new Customer() { Name = "Anna", Email = "anna@gmail.com" },
                    new Customer() { Name = "Mary", Email = "mary@gmail.com" }
                    );
            }
        }

      
    }
}
