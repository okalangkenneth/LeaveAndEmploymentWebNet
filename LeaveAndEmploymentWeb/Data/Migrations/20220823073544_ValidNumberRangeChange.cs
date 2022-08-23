using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveAndEmploymentWeb.Data.Migrations
{
    public partial class ValidNumberRangeChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01ba33b - 5693 - 5c88 - 655b - 305fbb123472",
                column: "ConcurrencyStamp",
                value: "0bfc6abd-6ff2-4f8d-b15e-203fbdc77ccb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b05ba33b - 7873 - 5f88 - 966b - 305fbb146272",
                column: "ConcurrencyStamp",
                value: "7097cc25-9c82-47da-aff6-e5d77a32a8e7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a9db887-45de-42b6-8c7f-a5c2f04952ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b143826-f4c1-4efc-b66f-7e6c82512c0a", "AQAAAAEAACcQAAAAEEFzT7KvHywa7SEmhXFAMfxWHKWxuEJQewSoeHMZlJpou0UQP4JfmmQFiP4qkxL4pQ==", "ee1ac78e-c5ff-490a-be8a-f7b21c8d0405" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b05ca33b-7973-4f88-946b-305fbb144272",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10e2baf2-268b-4851-b558-7535e8ef2c3f", "AQAAAAEAACcQAAAAEM/dKzTxIMYPmkKjinpWzAS8m+PQFoX9UIlsTNpHYjLvLsiHkGoGBfiZdcWMhw5P/A==", "31219600-813d-47ee-ae86-d58e60b24bf4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
