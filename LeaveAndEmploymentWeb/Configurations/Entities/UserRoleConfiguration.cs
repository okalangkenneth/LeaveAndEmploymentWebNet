using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveAndEmploymentWeb.Configurations.Entities
{
    internal class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>>builder)
        {
            builder.HasData(
                 new IdentityUserRole<string>
                 {
                     RoleId = "b05ba33b - 7873 - 5f88 - 966b - 305fbb146272",
                     UserId = "8a9db887-45de-42b6-8c7f-a5c2f04952ad"

                 },
                 new IdentityUserRole<string>
                 {
                     RoleId = "b01ba33b - 5693 - 5c88 - 655b - 305fbb123472",
                     UserId = "b05ca33b-7973-4f88-946b-305fbb144272"

                 }

             );
        }    
    }
}