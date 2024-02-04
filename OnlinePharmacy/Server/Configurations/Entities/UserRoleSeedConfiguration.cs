using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlinePharmacy.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration :
    IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
            },
            new IdentityUserRole<string>
            {
                RoleId = "3ed2ec18-6112-4de0-8449-be133a072f28",
                UserId = "fedeeeb4-ae9f-4617-b6dc-6bbbe227b05e"
            }
            );
        }
    }
}
