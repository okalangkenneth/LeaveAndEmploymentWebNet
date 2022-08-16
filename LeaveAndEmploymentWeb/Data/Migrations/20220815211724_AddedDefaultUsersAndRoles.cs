using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveAndEmploymentWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b01ba33b - 5693 - 5c88 - 655b - 305fbb123472", "3f790398-0243-4167-ba65-8e6126e4b630", "User", "USER" },
                    { "b05ba33b - 7873 - 5f88 - 966b - 305fbb146272", "70e56b86-15a5-4e40-b670-5d983aab8884", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8a9db887-45de-42b6-8c7f-a5c2f04952ad", 0, "77727fb4-c2d9-4310-9f05-b7cebd538871", null, null, "admin1@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEPpT63CHJY7kumMPNd1WKHTsadK+ekgG+UeivmPHHkrvX/uMd1RPxOiZ2W/85c6FOw==", null, false, "5919d75c-35fe-4c74-a2fe-dfa25a604e27", null, false, null },
                    { "b05ca33b-7973-4f88-946b-305fbb144272", 0, "dfa1386f-a308-4f33-9f4a-b20c023db283", null, null, "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEIuxpXhBHMW5PzZvhY4puT85cjk9iyXJUZWLBamm6IKO/57s6tTmZWh2foX0OATR5g==", null, false, "9e1592f1-97f5-4b6d-afa5-e7a6028b0bdd", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b05ba33b - 7873 - 5f88 - 966b - 305fbb146272", "8a9db887-45de-42b6-8c7f-a5c2f04952ad" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b01ba33b - 5693 - 5c88 - 655b - 305fbb123472", "b05ca33b-7973-4f88-946b-305fbb144272" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b05ba33b - 7873 - 5f88 - 966b - 305fbb146272", "8a9db887-45de-42b6-8c7f-a5c2f04952ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b01ba33b - 5693 - 5c88 - 655b - 305fbb123472", "b05ca33b-7973-4f88-946b-305fbb144272" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01ba33b - 5693 - 5c88 - 655b - 305fbb123472");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b05ba33b - 7873 - 5f88 - 966b - 305fbb146272");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a9db887-45de-42b6-8c7f-a5c2f04952ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b05ca33b-7973-4f88-946b-305fbb144272");
        }
    }
}
