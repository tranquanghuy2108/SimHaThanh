using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class AddSimType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTouristSim",
                table: "ProductTypes",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f15f3389-685f-4a3c-b9e5-1ed3160e4eff", "AQAAAAIAAYagAAAAEIzr9J6G0x+f4rfuONsYdIAbNxVxLYdgyWgH1M7X3p1kWoiLPr4x0ELKHsAL/cBlAw==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6132), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6134), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6136), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6138), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6139), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6141), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5917), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5936), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5939), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5941), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5943), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5944), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5946), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5947), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5949), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5951), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5953), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5954), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5956), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5957), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5959), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5962), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5963), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5965), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5966), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5968), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5970), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5971), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5973), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5974), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5976), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5977), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5980), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5982), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5983), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5985), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5986), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5988), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5990), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5991), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5993), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5994), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5996), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5998), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6000), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6001), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6003), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6004), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6006), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6008), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6009), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6011), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6012), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6014), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6016), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6018), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6019), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6021), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6022), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6024), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6026), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6027), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6029), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6030), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6032), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6034), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6036), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6037), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6039), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6041), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6050), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6052), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6053), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6055), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6056), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6058), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6064), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6065), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6067), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6069), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6070), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6072), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6073), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6076), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6080), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6081), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6084), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6085), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6087), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6089), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6090), new DateTime(2024, 9, 21, 15, 17, 55, 969, DateTimeKind.Local).AddTicks(6091) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTouristSim",
                table: "ProductTypes");

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
                values: new object[] { "b209ff48-9a2e-484f-befe-f1c45d91e4e4", "AQAAAAIAAYagAAAAEB1tqJKcopRqXU0yCeMFeD6NFRG3WrB9X+UsPkH/mbYLYLVP124him+7tv8aKlN8iA==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9245), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9247), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9249), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9251), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9253), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9255), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9032), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9044), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9046), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9048), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9050), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9063), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9065), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9067), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9069), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9071), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9073), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9074), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9076), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9078), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9080), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9082), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9083), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9085), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9087), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9088), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9090), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9092), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9093), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9095), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9097), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9098), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9100), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9102), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9103), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9105), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9107), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9108), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9110), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9112), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9113), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9115), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9117), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9118), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9120), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9122), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9124), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9125), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9127), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9129), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9130), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9132), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9134), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9135), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9139), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9140), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9142), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9144), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9146), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9147), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9149), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9151), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9152), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9154), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9156), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9158), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9159), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9161), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9163), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9166), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9168), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9171), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9173), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9175), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9176), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9181), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9183), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9185), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9186), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9188), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9191), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9193), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9195), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9196), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9204), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9206), new DateTime(2024, 6, 30, 23, 23, 5, 206, DateTimeKind.Local).AddTicks(9206) });
        }
    }
}
