using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveAndEmploymentWeb.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
