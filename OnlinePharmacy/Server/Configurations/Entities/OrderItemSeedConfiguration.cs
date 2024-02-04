
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
    public class OrderItemSeedConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasData(
           new OrderItem
           {
               OrderItemID = 1,
               OrderItemQty = 2,
               OrderItemSubTotal = 20,
               OrderID = 1,
               ProductID = 1,



           },
            new OrderItem
            {
                OrderItemID = 2,
                OrderItemQty = 3,
                OrderItemSubTotal = 20,
                OrderID = 2,
                ProductID = 2,
            

            }


            );






            //throw new NotImplementedException();
        }
    }
}