
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePharmacy.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OnlinePharmacy.Server.Configurations.Entities
{
    public class OrderSeedConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {

            builder.HasData(
            new Order
            {
                OrderID = 1,
                OrderDate = DateTime.Now.AddMonths(1), // Set OrderDate to tomorrow (to satisfy the validation rule)
                OrderTime = DateTime.Now.AddMonths(1), // Set OrderTime to one hour later (to satisfy the validation rule)
                TotalCost = 15,
                PaymentType = "Credit Card",
                CustomerID = 1,
                StaffID = 2


            },
             new Order
             {
                 OrderID = 2,
                 OrderDate = DateTime.Now.AddMonths(1), // Set OrderDate to tomorrow (to satisfy the validation rule)
                 OrderTime = DateTime.Now.AddMonths(1), // Set OrderTime to one hour later (to satisfy the validation rule)
                 TotalCost = 25,
                 PaymentType = "Credit Card",
                 CustomerID = 2,
                 StaffID = 2
             }


             );



            //throw new NotImplementedException();
        }
    }
}
