using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveAndEmploymentWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01ba33b - 5693 - 5c88 - 655b - 305fbb123472",
                column: "ConcurrencyStamp",
                value: "2432cc46-8662-48d4-bca9-aa1773d80865");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b05ba33b - 7873 - 5f88 - 966b - 305fbb146272",
                column: "ConcurrencyStamp",
                value: "6b1c3485-bb1f-48a7-8d52-97b4e6ce7519");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a9db887-45de-42b6-8c7f-a5c2f04952ad",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63deeb23-98c1-45a0-a511-a645630afbf1", "ADMIN1@LOCALHOST.COM", "ADMIN1@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHDXR/pzv02tKsf8zcTiJ59/nXMvyvJGb8do0zNDdmZk4OqM4uohErVzUucLcuB6AA==", "01c6ee7a-e7fa-444a-a5a2-4e810d1489d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b05ca33b-7973-4f88-946b-305fbb144272",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2965114a-e50e-4c4e-aecf-d0c71b2d5c63", "AQAAAAEAACcQAAAAEMaMGz2z0VfoSTjk6SPUbNrtvmLgLjbGdik9313Lesnu4lYwLTANvfC9RsL+AkcsSA==", "fa34e423-b21c-4c00-b5f4-b6dd517b4c1e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "effe7bd1-34e3-4ea2-8e35-08285dbcc9be", "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKZaqPQ3Q1Y+xzM69vxU6jike144re5HvLSlUfPEGz//yDPA4szLpDh6wQQz5DRshQ==", "a02dfe7e-2d19-47ce-80c4-db29c550bd16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b05ca33b-7973-4f88-946b-305fbb144272",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55d57b95-97ef-49bf-8c48-8bedb43d2ac1", "AQAAAAEAACcQAAAAEGue4UxTWAv9wjpwsnF0USj+Vz5NNbf5JHa+FYLbN8IpjK1RHXddaC4SHpK6cm7wZw==", "5ec7e2c3-69fb-4afa-9a95-7c8b1ff9c8e4" });
        }
    }
}
