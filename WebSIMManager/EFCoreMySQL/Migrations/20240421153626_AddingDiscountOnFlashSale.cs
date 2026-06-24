using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class AddingDiscountOnFlashSale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "SIMOnFlashSales",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

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
                values: new object[] { "5ebbc49e-5e33-4e20-9ba7-cdc03aca3794", "AQAAAAIAAYagAAAAEOMJR8PkAtWU5k0Xrww5z/t8agurCqm/xgAd894gk+aB9A7WmHg7ExlICfd4ngBClg==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9437), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9440), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9442), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9444), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9446), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9448), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9187), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9204), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9206), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9208), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9210), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9212), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9213), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9217), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9219), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9221), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9223), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9225), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9229), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9231), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9233), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9234), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9236), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9238), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9240), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9242), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9244), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9246), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9248), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9250), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9252), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9254), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9256), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9269), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9271), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9273), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9275), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9277), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9279), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9281), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9283), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9285), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9286), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9288), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9290), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9291) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9292), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9294), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9296), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9298), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9300), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9302), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9304), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9306), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9308), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9310), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9312), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9314), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9315), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9317), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9319), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9321), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9323), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9325), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9327), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9329), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9331), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9333), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9335), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9336), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9338), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9340), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9342), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9344), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9346), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9348), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9350), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9352), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9354), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9356), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9358), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9360), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9362), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9364), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9366), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9368), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9369), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9371), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9373), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9375), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9377), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9379), new DateTime(2024, 4, 21, 22, 36, 25, 763, DateTimeKind.Local).AddTicks(9379) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "SIMOnFlashSales");

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
                values: new object[] { "91b885f9-ccd1-486e-bafd-775747bcea42", "AQAAAAIAAYagAAAAEDbO7qjSTucnvlfAUhljg06K5duHa9rFJ+S93cJmVKmPHhKM8yiZdGv5zByh2QcIYA==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6422), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6425), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6427), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6429), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6431), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6433), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6177), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6197), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6199), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6201), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6203), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6205), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6207), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6209), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6211), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6213), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6215), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6216), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6218), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6220), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6222), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6224), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6226), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6227), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6229), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6231), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6233), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6235), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6237), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6239), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6242), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6244), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6246), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6248), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6252), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6254), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6255), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6257), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6259), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6261), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6263), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6265), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6267), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6268), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6270), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6272), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6274), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6276), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6278), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6280), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6282), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6284), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6285), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6287), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6289), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6291), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6293), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6295), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6297), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6300), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6302), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6317), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6319), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6321), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6323), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6325), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6327), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6329), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6330), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6332), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6334), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6336), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6338), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6340), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6342), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6343), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6345), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6347), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6349), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6351), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6353), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6355), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6357), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6358), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6360), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6362), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6364), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6368), new DateTime(2024, 4, 19, 13, 58, 45, 154, DateTimeKind.Local).AddTicks(6368) });
        }
    }
}
