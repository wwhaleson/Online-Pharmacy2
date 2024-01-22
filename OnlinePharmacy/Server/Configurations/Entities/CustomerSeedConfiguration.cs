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
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
     new Customer
     {
         CustomerID = 1,
         CustFname = "Chae",
         CustLname = "Won",
         CustGender = "Female",
         CustPostalCode = 123983,
         CustBlockNo = 55,
         CustFloorNo = 5,
         CustUnitNo = 210,
         CustAddress = "Ubi Avenue 1",
         CustPhoneNo = 83719378,
         CustEmail = "chaewon55@gmail.com",
         CustPass = "helloworld#1"
     },
     new Customer
     {
         CustomerID = 2,
         CustFname = "John",
         CustLname = "Wick",
         CustGender = "Male",
         CustPostalCode = 103933,
         CustBlockNo = 62,
         CustFloorNo = 6,
         CustUnitNo = 208,
         CustAddress = "Tampines Street 61",
         CustPhoneNo = 93682946,
         CustEmail = "johnwick66@gmail.com",
         CustPass = "helloworld#2"
     }
     );


        }
    }
}