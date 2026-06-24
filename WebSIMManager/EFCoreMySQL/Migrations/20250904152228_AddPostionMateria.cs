using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class AddPostionMateria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("a32513b8-6eb4-433d-af51-ce369bcf4d80"));

            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("a32513b8-6eb4-433d-af51-ce369bcf4d83"));

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a32513b8-6eb4-433d-af51-ce369bcf4d83"), new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8") });

            migrationBuilder.DeleteData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "MaterialSerias",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "AppUserGroups",
                type: "char(128)",
                maxLength: 128,
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "char(128)",
                oldMaxLength: 128)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                table: "AppRoleGroups",
                type: "char(128)",
                maxLength: 128,
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "char(128)",
                oldMaxLength: 128)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "MaterialSerias");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AppUserGroups",
                type: "char(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(128)",
                oldMaxLength: 128)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AppRoleGroups",
                type: "char(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(128)",
                oldMaxLength: 128)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.InsertData(
                table: "AppRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("a32513b8-6eb4-433d-af51-ce369bcf4d80"), null, "Quyền nhân viên", "Nhân viên", "Nhân viên" },
                    { new Guid("a32513b8-6eb4-433d-af51-ce369bcf4d83"), null, "Quyền quản trị hệ thống", "Quản trị hệ thống", "Quản trị" }
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "Birthday", "ConcurrencyStamp", "DiscountForSimSellersId", "Email", "EmailConfirmed", "FullName", "Hotline", "IsActive", "IsAgent", "IsConsignmentAgent", "IsStaff", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Province", "Remark", "SecurityStamp", "TwoFactorEnabled", "UserName", "Website" },
                values: new object[] { new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), 0, null, null, null, "12cc323c-b331-4da5-bacc-9c265fb86445", null, "huongnx@tigergames.vn", true, "Tiger Games .JSC", null, false, false, false, true, true, null, "huongnx@tigergames.vn", "admin", "AQAAAAIAAYagAAAAEGzAQGjGW/MREOb9XxrUPrFW/vpv9XHvCtw0b99yDEbIFUd8pAbhnpYBbHE6k2f8cA==", "+840123456789", false, null, null, "", false, "admin", null });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("a32513b8-6eb4-433d-af51-ce369bcf4d83"), new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8") });

            migrationBuilder.InsertData(
                table: "SIMNetworks",
                columns: new[] { "Id", "CreateBy", "CreateTime", "Description", "HtmlId", "IsDelete", "NetworkImgUrl", "NetworkName", "PrefixNumber", "UpdateBy", "UpdateTime" },
                values: new object[,]
                {
                    { 1, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9141), "Nhà mạng Viettel", "viettel", false, "viettel", "Viettel", null, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9142) },
                    { 2, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9144), "Nhà mạng Vinaphone", "vina", false, "vina", "Vinaphone", null, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9145) },
                    { 3, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9146), "Nhà mạng Mobiphone", "mobi", false, "mobi", "Mobiphone", null, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9147) },
                    { 4, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9149), "Nhà mạng Vinaphone", "vnn", false, "vnn", "Vietnamobile", null, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9149) },
                    { 5, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9151), "Nhà mạng Vinaphone", "gmobile", false, "gmobile", "Gmobile", null, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9152) },
                    { 6, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9153), "Nhà mạng Vinaphone", "vina", false, "vina", "Itelecom", null, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9154) }
                });

            migrationBuilder.InsertData(
                table: "TypesOfSIM",
                columns: new[] { "Id", "CreateBy", "CreateTime", "Description", "EstimatedPrice", "Format", "IsDelete", "Name", "UpdateBy", "UpdateTime" },
                values: new object[,]
                {
                    { 1, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6881), "*00000,*11111,*22222,*33333,*44444,*55555,*66666,*77777,*88888,*99999", 0.0, "AAAAA", false, "Ngũ quý", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6893) },
                    { 2, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6896), "*0000,*1111,*2222,*3333,*4444,*5555,*6666,*7777,*8888,*9999", 0.0, "AAAA", false, "Tứ quý", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6897) },
                    { 3, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6899), "*0000*,*1111*,*2222*,*3333*,*4444*,*5555*,*6666*,*7777*,*8888*,*9999*", 0.0, "AAAA.b", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6900) },
                    { 4, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6902), "", 0.0, "AAAA.", false, "Tứ quý giữa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6903) },
                    { 5, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6904), "", 0.0, "AAAA.bx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6905) },
                    { 6, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6907), "", 0.0, "AAAA.bxx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6908) },
                    { 7, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6910), "", 0.0, "AAA.BBB", false, "Tam hoa kép", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6910) },
                    { 8, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6912), "*000,*111,*222,*333,*444,*555,*666,*777,*888,*999", 0.0, ".AAA", false, "Tam hoa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6913) },
                    { 9, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6915), "", 0.0, "ABC.AAA", false, "Tam hoa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6915) },
                    { 10, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6917), "", 0.0, "BcB.AAA", false, "Tam hoa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6918) },
                    { 11, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6920), "", 0.0, "BBx.AAA", false, "Tam hoa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6921) },
                    { 12, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6922), "", 0.0, "xBB.AAA", false, "Tam hoa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6923) },
                    { 13, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6925), "*000*,*111*,*222*,*333*,*444*,*555*,*666*,*777*,*888*,*999*", 0.0, "AAA.b", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6925) },
                    { 14, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6927), "", 0.0, "AAA.bx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6927) },
                    { 15, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6929), "", 0.0, "AAA.xxx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8831) },
                    { 16, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8845), "", 0.0, "AB.AB.AB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8846) },
                    { 17, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8848), "", 0.0, "ABCD.ABCD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8848) },
                    { 18, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8850), "", 0.0, "BAA.BAA", false, "Taxi", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8851) },
                    { 19, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8852), "", 0.0, "ABC.ABC", false, "Taxi", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8853) },
                    { 20, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8855), "", 0.0, "ABA.ABA", false, "Taxi", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8856) },
                    { 21, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8857), "", 0.0, "AAB.AAB", false, "Taxi", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8859) },
                    { 22, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8861), "", 0.0, "bxx.bxx", false, "Taxi thường", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8862) },
                    { 23, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8863), "", 0.0, "ABCDE", false, "Tiến đơn 5", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8864) },
                    { 24, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8866), "", 0.0, "ABCD", false, "Tiến đơn 4", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8866) },
                    { 25, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8868), "", 0.0, "ABC.ABC", false, "Tiến đơn 3 kép", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8869) },
                    { 26, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8870), "", 0.0, "SPECIAL", false, "Số đặc biệt", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8871) },
                    { 27, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8872), "", 0.0, "SPECIAL_UP", false, "Tiến đặc biệt", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8873) },
                    { 28, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8875), "", 0.0, "AA.BB.AA", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8875) },
                    { 29, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8877), "", 0.0, "AA.BB.CC", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8877) },
                    { 30, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8879), "", 0.0, "AbA.AcA", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8879) },
                    { 31, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8881), "", 0.0, "ABB.CBB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8881) },
                    { 32, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8883), "", 0.0, "AAB.AAC", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8883) },
                    { 33, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8885), "", 0.0, "ABC.ABD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8885) },
                    { 34, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8887), "", 0.0, "ABAB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8887) },
                    { 35, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8889), "", 0.0, "ABBA", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8889) },
                    { 36, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8891), "", 0.0, "ABBA.CDDC", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8891) },
                    { 37, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8893), "", 0.0, "AA.BB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8893) },
                    { 38, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8895), "*012,*123,*234,*345,*456,*567,*678,*789", 0.0, "ABC", false, "Tiến đơn 3", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8895) },
                    { 39, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8897), "*012*,*123*,*234*,*345*,*456*,*567*,*678*,*789*", 0.0, "123.xxx", false, "Tiến giữa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8897) },
                    { 40, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8899), "", 0.0, "AB.CB.DB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8899) },
                    { 41, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8916), "", 0.0, "AB.AC.AD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8917) },
                    { 42, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8919), "", 0.0, "AA.BC.AA", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8919) },
                    { 43, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8920), "*79,*39", 0.0, "79-39", false, "Thần tài", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8921) },
                    { 44, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8923), "", 0.0, "xyz.zyx", false, "Số đối", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8924) },
                    { 45, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8925), "*68", 0.0, "68", false, "Lộc phát", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8926) },
                    { 46, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8927), "*86", 0.0, "86", false, "Phát lộc", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8928) },
                    { 47, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8929), "*99", 0.0, "99", false, "Cửu cửu", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8930) },
                    { 48, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8931), "*88", 0.0, "88", false, "Phát phát", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8932) },
                    { 49, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8933), "*89", 0.0, "0.89", false, "Đuôi 89", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8934) },
                    { 50, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8935), "*66", 0.0, "66", false, "Lộc lộc", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8936) },
                    { 51, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8937), "*78,*38", 0.0, "78-38", false, "Ông địa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8938) },
                    { 52, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8940), "", 0.0, "AAb.xxx", false, "Kép giữa", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8940) },
                    { 53, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8942), "", 0.0, "AB.AB.AB.xy", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8943) },
                    { 54, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8944), "", 0.0, "ABC.Abc+1", false, "Tiến đầu", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8945) },
                    { 55, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8946), "", 0.0, "dd.MM.yy", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8947) },
                    { 56, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8949), "", 0.0, "xA.yA.zA", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8949) },
                    { 57, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8951), "", 0.0, "AB AD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8952) },
                    { 58, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8953), "", 0.0, ".ABA", false, "Số gánh", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8954) },
                    { 59, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8955), "", 0.0, "ABB CDD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8956) },
                    { 60, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8958), "", 0.0, "A<B<C<D", false, "Tiến 4 số cuối", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8958) },
                    { 61, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8960), "", 0.0, "ADB.ACB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8961) },
                    { 62, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8962), "", 0.0, "bxx.bxx.", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8963) },
                    { 63, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8964), "", 0.0, "AAB.CDD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8965) },
                    { 64, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8967), "", 0.0, "ABA.CDD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8967) },
                    { 65, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8969), "", 0.0, "ABA.CCD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8969) },
                    { 66, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8971), "", 0.0, "CBA.CBD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8972) },
                    { 67, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8974), "", 0.0, "ACB.DCB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8975) },
                    { 68, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8977), "", 0.0, "ABAB.xxx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8978) },
                    { 69, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8980), "", 0.0, "AABB.Cx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8980) },
                    { 70, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8982), "", 0.0, "AABB.CxD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8983) },
                    { 71, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8984), "", 0.0, "BCD.EAA", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8985) },
                    { 72, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8986), "", 0.0, "ABAB.xx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8987) },
                    { 73, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8989), "", 0.0, "ABCB", false, "Tiến 2 đôi", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8989) },
                    { 74, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8991), "", 0.0, "ABAC", false, "Tiến 2 đôi", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8992) },
                    { 75, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8993), "", 0.0, "AB.CD.AB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8994) },
                    { 76, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8995), "", 0.0, "ABA", false, "Gánh thường", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8996) },
                    { 77, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8998), "", 0.0, "AAB CCD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8998) },
                    { 78, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9000), "", 0.0, "xAABBx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9001) },
                    { 79, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9002), "", 0.0, "AAB.CDE", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9003) },
                    { 80, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9004), "", 0.0, "xAA.BCD", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9005) },
                    { 81, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9007), "", 0.0, "BCD.AAx", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9007) },
                    { 82, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9009), "", 0.0, "ABC.BAC", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9010) },
                    { 83, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9011), "", 0.0, "ABC.ACB", false, "Sim số đẹp", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9012) },
                    { 84, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9013), "", 0.0, "ABA.CDC", false, "Gánh đôi", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9014) },
                    { 85, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9015), "", 0.0, "NORMAL", false, "Bình thường", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9016) },
                    { 86, new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9017), "", 0.0, "19bx", false, "Năm sinh", new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9018) }
                });
        }
    }
}
