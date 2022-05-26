using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _FieldDtTracker.Data.Migrations
{
    public partial class AddAuthRoleConfiguration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2301D884-221A-4E7D-B509-0113DCC043E1", "4eee1062-d768-4626-92de-6988a459cb37", "SuperAdmin", "SUPERADMIN" },
                    { "78A7570F-3CE5-48BA-9461-80283ED1D94D", "1046c0b5-1b2b-48c1-b699-3dabef7ad7bf", "Staff", "STAFF" },
                    { "7D9B7113-A8F8-4035-99A7-A20DD400F6A3", "7d8e1ab3-24fb-4b68-8b64-37196abf5e87", "Administrator", "ADMINISTRATOR" },
                    { "FFE8796D-9AB2-4C5C-9B01-BB58C9F73657", "d11035bd-c8fe-4273-a030-8c18b574b42b", "Visitor", "VISITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "198E6AEA-6827-4562-B415-242146DE9B9B", 0, "df8cccbb-36cc-4818-a7dd-c648c70b5bbb", "superadmin@ner.com", true, null, false, null, "SUPERADMIN@NER.COM", "SUPERADMIN@NER.COM", "AQAAAAEAACcQAAAAEBVvtun3dBLL56ZKyxt5YHHq9IelRofGwRGcfHwXgRmzXnh8TuU9JHVohVk2HAkxuQ==", "0811704141", true, "SuperAdmin", "1a9a971e-7658-47b3-b881-f2eb982f38d1", false, "superadmin@ner.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2301D884-221A-4E7D-B509-0113DCC043E1", "198E6AEA-6827-4562-B415-242146DE9B9B" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78A7570F-3CE5-48BA-9461-80283ED1D94D");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "FFE8796D-9AB2-4C5C-9B01-BB58C9F73657");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2301D884-221A-4E7D-B509-0113DCC043E1", "198E6AEA-6827-4562-B415-242146DE9B9B" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "198E6AEA-6827-4562-B415-242146DE9B9B");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
