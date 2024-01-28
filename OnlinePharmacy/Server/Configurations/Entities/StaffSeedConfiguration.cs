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
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    StaffID=1,
                    StaffImage = "https://www.shutterstock.com/image-photo/indian-young-doctor-cardiologist-man-260nw-2370864331.jpg",
                    StaffFname = "Tom" ,
                    StaffLname = "Lim",
                    StaffGender = "Male",
                    Staff_email = "tomlim@blazor.com",
                    Staff_pass = "P@ssword2",
                    Position = "Pharmacist"
                },


                new Staff
                {
                    StaffID = 2,
                    StaffImage = "https://images.pond5.com/pharmacist-icon-profession-and-job-illustration-137441229_iconl_nowm.jpeg",
                    StaffFname = "Mary",
                    StaffLname = "Ong",
                    StaffGender = "Female",
                    Staff_email = "maryong@blazor.com",
                    Staff_pass = "P@ssword3",
                    Position = "Order Clerk"
                }



                );

            //throw new NotImplementedException();
        }
    }
}
