using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class AddingCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVerify",
                table: "SIMDetails",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "ProductTypes",
                type: "int",
                nullable: true);

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
                values: new object[] { "560f1d3f-3594-4d2a-a731-83154e4d7988", "AQAAAAIAAYagAAAAEHp9EFYNZGy/JrMN4OtjkHlr07U1r/fVf/Wq1m09C+y6SYfRdpj9V28a0pEML88xAw==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6846), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6848), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6850), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6852), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6854), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6856), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6634), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6646), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6648), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6650), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6652), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6653), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6657), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6659), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6661), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6662), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6664), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6666), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6668), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6669), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6672), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6674), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6675), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6677), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6679), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6681), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6682), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6684), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6686), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6688), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6689), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6691), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6693), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6695), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6696), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6698), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6700), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6702), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6703), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6705), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6707), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6709), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6711), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6712), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6714), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6716), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6718), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6719), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6721), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6723), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6725), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6727), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6728), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6733), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6734), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6736), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6738), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6740), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6742), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6743), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6745), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6747), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6749), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6751), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6756), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6758), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6760), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6762), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6763), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6771), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6774), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6775), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6777), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6779), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6781), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6782), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6784), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6786), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6788), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6790), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6792), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6793), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6795), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6797), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6799), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6800), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6802), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6804), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6806), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6808), new DateTime(2024, 4, 22, 21, 13, 29, 604, DateTimeKind.Local).AddTicks(6808) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerify",
                table: "SIMDetails");

            migrationBuilder.DropColumn(
                name: "CountryId",
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
    }
}
