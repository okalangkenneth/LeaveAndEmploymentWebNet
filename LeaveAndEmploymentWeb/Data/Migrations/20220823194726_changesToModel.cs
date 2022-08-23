using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveAndEmploymentWeb.Data.Migrations
{
    public partial class changesToModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b01ba33b - 5693 - 5c88 - 655b - 305fbb123472",
                column: "ConcurrencyStamp",
                value: "0b9299c3-98b6-42e0-b19a-7741236db6ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b05ba33b - 7873 - 5f88 - 966b - 305fbb146272",
                column: "ConcurrencyStamp",
                value: "1fbefdde-c87b-4c2e-ac3c-ea70a70078fa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a9db887-45de-42b6-8c7f-a5c2f04952ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "353dacb6-9594-493d-b431-29700c1c0664", "AQAAAAEAACcQAAAAEKvwiIcj5iFBrfg3KZ/joLr1Lc4B2PqcO72ltDI1ejVEUE4DfWiIU3DeS9GTkO5N1g==", "70569b3c-0d32-4fad-b11d-17c9ff43ef8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b05ca33b-7973-4f88-946b-305fbb144272",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be034d46-e847-4b5e-b041-4078c8df4487", "AQAAAAEAACcQAAAAEPxBZq9RuOnnOa4imF/gjysH9giUG4HUEoY8WVULTtVeE63mD0bwDNluN7ekbVQUiA==", "da86d847-84ac-4721-a9e1-46b73924869e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
