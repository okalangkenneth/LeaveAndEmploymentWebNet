using LeaveAndEmploymentWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveAndEmploymentWeb.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "8a9db887-45de-42b6-8c7f-a5c2f04952ad",
                    Email = "admin1@localhost.com",
                    NormalizedEmail = "ADMIN1@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN1@LOCALHOST.COM",
                    UserName = "admin1@localhost.com",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Passw0rd1@"), 
                    EmailConfirmed = true

                },

                new Employee
                {
                    Id = "b05ca33b-7973-4f88-946b-305fbb144272",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    NormalizedUserName= "USER@LOCALHOST.COM",
                    UserName= "user@localhost.com",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "Passw0rd1@"),
                    EmailConfirmed = true
                }
            );
        }
    }
}