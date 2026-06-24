using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIsConsignmentAgent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<bool>(
                name: "IsConsignmentAgent",
                table: "AppUser",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "IsConsignmentAgent", "PasswordHash" },
                values: new object[] { "25b18402-02a2-42b7-a951-016690207d2b", false, "AQAAAAIAAYagAAAAECB8NgsPcIb+AnohPgiNq/miHNWQGos65CIcuyrpJgxkEfgYJ9NLG8h0tIc2A1ccCQ==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5236), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5239), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5241), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5242), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5244), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5246), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5021), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5034), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5036), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5038), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5040), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5042), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5044), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5045), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5047), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5049), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5051), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5054), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5055), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5057), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5059), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5061), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5062), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5064), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5066), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5068), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5069), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5071), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5073), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5075), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5076), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5078), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5080), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5082), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5083), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5085), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5087), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5089), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5091), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5092), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5094), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5096), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5098), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5100), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5101), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5103), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5105), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5107), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5108), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5110), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5112), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5114), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5116), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5129), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5131), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5133), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5135), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5136), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5138), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5140), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5142), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5144), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5145), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5147), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5149), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5151), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5153), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5154), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5156), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5158), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5160), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5162), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5164), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5165), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5167), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5169), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5171), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5172), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5174), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5176), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5178), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5180), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5181), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5184), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5186), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5187), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5189), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5191), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5193), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5195), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5196), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5198), new DateTime(2024, 6, 12, 12, 29, 52, 863, DateTimeKind.Local).AddTicks(5199) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConsignmentAgent",
                table: "AppUser");

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

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1195f100-cf55-4a1a-8ddb-c75544db91b3", "AQAAAAIAAYagAAAAELg/VXbyuImost7HAesn/tLOTKbHCcAvE/jlb7Qc52/u0VQIJjRyX9vRHOCg7mu5/Q==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9181), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9183), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9186), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9188), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9192), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8945), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8961), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8964), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8966), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8968), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8970), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8972), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8974), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8976), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8978), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8980), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8982), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8984), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8986), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8988), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8990), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8992), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8994), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8995), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8997), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(8999), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9003), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9005), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9007), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9009), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9011), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9012), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9014), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9016), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9018), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9020), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9022), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9023), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9026), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9028), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9030), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9032), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9034), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9036), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9037), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9039), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9041), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9043), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9045), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9049), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9050), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9052), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9055), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9057), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9058), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9060), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9062), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9064), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9066), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9068), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9069), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9071), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9073), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9075), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9077), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9079), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9080), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9082), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9084), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9086), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9088), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9090), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9092), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9094), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9095), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9097), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9099), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9101), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9103), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9111), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9113), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9115), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9117), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9119), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9121), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9122), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9124), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9126), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9128), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 6, 3, 15, 53, 1, 819, DateTimeKind.Local).AddTicks(9131) });
        }
    }
}
