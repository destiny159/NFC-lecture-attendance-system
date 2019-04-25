using Microsoft.EntityFrameworkCore.Migrations;

namespace NFCSystem.Migrations
{
    public partial class Mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "8f1ea878-efe2-4a5e-b77e-36d1c037b1f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "LECTURER",
                column: "ConcurrencyStamp",
                value: "9c55b54d-9658-4b1a-94d2-f07cfc0884f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "STUDENT",
                column: "ConcurrencyStamp",
                value: "2f6a805b-61aa-4344-98b9-a6ce12079951");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fc865da9-bd62-4a69-b582-7180e7a4c8a8", "VARDENIS.PAVARDENIS@EMAIL.COM", "VARVAV", "AQAAAAEAACcQAAAAEB6C1+58Xu39M0aQhRD1Kohn5rYmk4G5x2Y2iv5PoBjSl2p6W0cu6DiTMZYVe2yBKQ==", "2cbd3bfa-9b86-481d-8ffa-356f175a0560", "varvav" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1d1a99cd-99ed-4351-bfae-194313d9148e", null, null, "AQAAAAEAACcQAAAAEAwIvBYEj/gnkKRARxJLi0WwcwUTyzOsCPEBugvF2GgZZ/vFqbVMPXQRdsg2LOShzg==", "017357fe-8517-4c71-8b01-f294b09ebd09", "VarPav" });
        }
    }
}
