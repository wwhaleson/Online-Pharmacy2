
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
    public class DeliverySeedConfiguration : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {


            builder.HasData(
            new Delivery
            {
                DeliveryID = 1,
                DeliveryCost = 5,
                DeliveryMethod = "Standard",
                DeliveryStatus = "Packing",
                EstimatedDeliveryDate = DateTime.Now.AddDays(5),
                EstimatedDeliveryTime  = DateTime.Now.AddHours(5),
                OrderID = 1,
                StaffID = 1,

            },
             new Delivery
             {
                 DeliveryID = 2,
                 DeliveryCost = 5,
                 DeliveryMethod = "Standard",
                 DeliveryStatus = "Packing",
                 EstimatedDeliveryDate = DateTime.Now.AddDays(5),
                 EstimatedDeliveryTime = DateTime.Now.AddHours(6),
                 OrderID = 2,
                 StaffID = 1,
             }


             ) ;

            //throw new NotImplementedException();
        }
    }
}