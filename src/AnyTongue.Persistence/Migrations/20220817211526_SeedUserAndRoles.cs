using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyTongue.Persistence.Migrations
{
    public partial class SeedUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "9238d991-0153-4ada-aaf3-57d6040f682e", "Admin", "ADMIN" },
                    { 2, "1f0f17ec-738c-4a37-b7c3-2c32a4f84523", "Student", "STUDENT" },
                    { 3, "e976c27d-45e1-4aca-9954-e42def238b7d", "ContentAdmin", "CONTENTADMIN" },
                    { 4, "08b8184c-1af1-40ad-a3bb-94524095caaa", "ContentCreator", "CONTENTCREATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "ecce3dc6-6fda-4b42-805d-c91ec950af6e", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEIvb/VbgsuvrAzJ/6TnEaCv1/Mfr0yVi5R5ki3P6l5cAY1lH9umYDMTeaveAzz+vQ==", null, false, "a7e9e6d0-2f61-49b9-8240-17d04df7fb61", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
