﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePharmacy.Shared.Domain;
using System.Collections.Generic;

namespace OnlinePharmacy.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    CustomerID = 1,
                    CustFname = "Chae",
                    CustLname = "Won",
                    CustGender = "Female",
                    CustPostalCode = 123983,
                    CustBlockNo = "123",
                    CustFloorNo = 5,
                    CustUnitNo = 210,
                    CustAddress = "Ubi Avenue 1",
                    CustPhoneNo = 83719378,
                    CustEmail = "chaewon55@gmail.com",
                    CustPass = "HelloWorld#1",

                },
                new Customer
                {
                    CustomerID = 2,
                    CustFname = "John",
                    CustLname = "Wick",
                    CustGender = "Male",
                    CustPostalCode = 103933,
                    CustBlockNo = "123A",
                    CustFloorNo = 6,
                    CustUnitNo = 208,
                    CustAddress = "Tampines Street 61",
                    CustPhoneNo = 93682946,
                    CustEmail = "johnwick66@gmail.com",
                    CustPass = "HelloWorld#2",

                }
            );
        }
    }
}
