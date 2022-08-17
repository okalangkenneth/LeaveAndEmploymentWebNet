using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveAndEmploymentWeb.Data.Migrations
{
    public partial class AddPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01ba33b - 5693 - 5c88 - 655b - 305fbb123472",
                column: "ConcurrencyStamp",
                value: "13a855ce-e81f-42fe-9099-72f050bfc7bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b05ba33b - 7873 - 5f88 - 966b - 305fbb146272",
                column: "ConcurrencyStamp",
                value: "9c480b56-cd48-42be-bf15-eb1707a7acdc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a9db887-45de-42b6-8c7f-a5c2f04952ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf96bce8-d335-40aa-9e5c-c70bafe7eb49", "AQAAAAEAACcQAAAAEHEnPrxQ7Wu0JtjmofMOOT9KMaif7aEkEjqD34BVBvtd/AHFsWgqjeJA9UkSfu2icw==", "2f596b57-0da4-4d53-a993-dfd7da2df1de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b05ca33b-7973-4f88-946b-305fbb144272",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "522530d9-4d3a-48ff-9b95-d68881ded902", "AQAAAAEAACcQAAAAELjkjSE498tXugjLv4vfEpqYZ7gsZb6ovazoDXz0LVx3vXbC2eRq/UBHbIkTfYV4tw==", "fa765b1f-add9-43a6-9862-56a114fe6ae6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63deeb23-98c1-45a0-a511-a645630afbf1", "AQAAAAEAACcQAAAAEHDXR/pzv02tKsf8zcTiJ59/nXMvyvJGb8do0zNDdmZk4OqM4uohErVzUucLcuB6AA==", "01c6ee7a-e7fa-444a-a5a2-4e810d1489d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b05ca33b-7973-4f88-946b-305fbb144272",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2965114a-e50e-4c4e-aecf-d0c71b2d5c63", "AQAAAAEAACcQAAAAEMaMGz2z0VfoSTjk6SPUbNrtvmLgLjbGdik9313Lesnu4lYwLTANvfC9RsL+AkcsSA==", "fa34e423-b21c-4c00-b5f4-b6dd517b4c1e" });
        }
    }
}
