using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveAndEmploymentWeb.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01ba33b - 5693 - 5c88 - 655b - 305fbb123472",
                column: "ConcurrencyStamp",
                value: "59f9d26f-8b3c-46e3-b20f-16331d69e0fc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b05ba33b - 7873 - 5f88 - 966b - 305fbb146272",
                column: "ConcurrencyStamp",
                value: "8f657f6e-4b5f-46f4-8782-a63b4aa22bbd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a9db887-45de-42b6-8c7f-a5c2f04952ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d025c519-84e5-450d-a1b5-e08c08f30f5b", "AQAAAAEAACcQAAAAEBGyCtKlsjoK9L1vICG7cddclEUDRl7/rRtcmbanEBn6L4o96qRx7gcsfY3R5yiQpA==", "91d5b0e3-d932-489c-8c91-b296a420df5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b05ca33b-7973-4f88-946b-305fbb144272",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7ade733-7f25-4854-b8df-05a285242b8a", "AQAAAAEAACcQAAAAEN9s3jo1Eku9y4eRF0jDZPZVKRyekVUAAJc829hnFa2Gu2DRtuSJP3UZw/EB43R0lg==", "249f3f4b-305e-4645-9a46-ac9709a52fe0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01ba33b - 5693 - 5c88 - 655b - 305fbb123472",
                column: "ConcurrencyStamp",
                value: "b1aa563d-759c-4c4a-9b17-6e7a9c9e1eee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b05ba33b - 7873 - 5f88 - 966b - 305fbb146272",
                column: "ConcurrencyStamp",
                value: "1327750d-8d17-4ced-b85f-f685a458bf51");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a9db887-45de-42b6-8c7f-a5c2f04952ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcb265e1-2c27-4dad-a9dd-928217e3fb44", "AQAAAAEAACcQAAAAEK05qqcG2JvU/idcZvicCWCItHtHx3boYNDB00lbT3VBjG+ORZ8FEgbbV4n6wsH7zQ==", "ce827253-9b4f-4c56-94a8-b7682bc8575d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b05ca33b-7973-4f88-946b-305fbb144272",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03df177d-f8f1-4cb5-a5b7-98e317fe9279", "AQAAAAEAACcQAAAAEEdgYhZcGlKl6CbCPcBHpHj7gFtFZ3jkfWvxQgTINMHs7HuIlNUte9pxUChwhG3lWA==", "2915f7a2-9627-42d1-8361-53729e49eec0" });
        }
    }
}
