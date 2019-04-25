using Microsoft.EntityFrameworkCore.Migrations;

namespace NFCSystem.Migrations
{
    public partial class Mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "155dbf03-7cd5-486a-bbf1-f9c5762cda7d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "LECTURER",
                column: "ConcurrencyStamp",
                value: "c39ca311-15b5-4ac4-bc67-684f4cf88f2d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "STUDENT",
                column: "ConcurrencyStamp",
                value: "b93fbf5c-19e6-4044-8fa0-aea2482b0924");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Group", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudentCode", "Surname", "TwoFactorEnabled", "UID", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "1d1a99cd-99ed-4351-bfae-194313d9148e", "vardenis.pavardenis@email.com", false, "IFF-6/9", false, null, "Vardenis", null, null, "AQAAAAEAACcQAAAAEAwIvBYEj/gnkKRARxJLi0WwcwUTyzOsCPEBugvF2GgZZ/vFqbVMPXQRdsg2LOShzg==", null, false, "017357fe-8517-4c71-8b01-f294b09ebd09", "C0000", "Pavardenis", false, 25554654L, "VarPav" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "STUDENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "21dfb814-73a2-4cca-b3cf-d0e0f0f73241");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "LECTURER",
                column: "ConcurrencyStamp",
                value: "33cb247d-bb3f-4c88-9d5a-f9010a1abfef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "STUDENT",
                column: "ConcurrencyStamp",
                value: "2518b0ff-44fc-4df4-a7cd-bb06b930ae3f");
        }
    }
}
