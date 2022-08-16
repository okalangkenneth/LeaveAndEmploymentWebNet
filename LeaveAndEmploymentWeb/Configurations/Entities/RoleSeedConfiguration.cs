using LeaveAndEmploymentWeb.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveAndEmploymentWeb.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "b05ba33b - 7873 - 5f88 - 966b - 305fbb146272",
                    Name =Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()

                },
                new IdentityRole 
                {
                    Id = "b01ba33b - 5693 - 5c88 - 655b - 305fbb123472",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()

                }


            );
        }
    }
}