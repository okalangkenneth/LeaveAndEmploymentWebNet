using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveAndEmploymentWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01ba33b - 5693 - 5c88 - 655b - 305fbb123472",
                column: "ConcurrencyStamp",
                value: "11ac7566-5171-4ebc-9ed7-def679b86bd2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b05ba33b - 7873 - 5f88 - 966b - 305fbb146272",
                column: "ConcurrencyStamp",
                value: "f17f48b7-6320-4fe9-897d-69a563ffd904");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a9db887-45de-42b6-8c7f-a5c2f04952ad",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "effe7bd1-34e3-4ea2-8e35-08285dbcc9be", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKZaqPQ3Q1Y+xzM69vxU6jike144re5HvLSlUfPEGz//yDPA4szLpDh6wQQz5DRshQ==", "a02dfe7e-2d19-47ce-80c4-db29c550bd16", "admin1@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b05ca33b-7973-4f88-946b-305fbb144272",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "55d57b95-97ef-49bf-8c48-8bedb43d2ac1", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGue4UxTWAv9wjpwsnF0USj+Vz5NNbf5JHa+FYLbN8IpjK1RHXddaC4SHpK6cm7wZw==", "5ec7e2c3-69fb-4afa-9a95-7c8b1ff9c8e4", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01ba33b - 5693 - 5c88 - 655b - 305fbb123472",
                column: "ConcurrencyStamp",
                value: "3f790398-0243-4167-ba65-8e6126e4b630");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b05ba33b - 7873 - 5f88 - 966b - 305fbb146272",
                column: "ConcurrencyStamp",
                value: "70e56b86-15a5-4e40-b670-5d983aab8884");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a9db887-45de-42b6-8c7f-a5c2f04952ad",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "77727fb4-c2d9-4310-9f05-b7cebd538871", false, null, "AQAAAAEAACcQAAAAEPpT63CHJY7kumMPNd1WKHTsadK+ekgG+UeivmPHHkrvX/uMd1RPxOiZ2W/85c6FOw==", "5919d75c-35fe-4c74-a2fe-dfa25a604e27", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b05ca33b-7973-4f88-946b-305fbb144272",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "dfa1386f-a308-4f33-9f4a-b20c023db283", false, null, "AQAAAAEAACcQAAAAEIuxpXhBHMW5PzZvhY4puT85cjk9iyXJUZWLBamm6IKO/57s6tTmZWh2foX0OATR5g==", "9e1592f1-97f5-4b6d-afa5-e7a6028b0bdd", null });
        }
    }
}
