using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAuctionWithDepositAuction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Auction_Deposit",
                table: "SystemConfigs",
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
                values: new object[] { "de773d5d-4a24-4104-b666-b971038c45f6", "AQAAAAIAAYagAAAAEFFe9z4xOOtGoctPJ+9wj6BAnwoXGTcM+zWPJNASW17RRjgvlnURSvbZ42plFlkgug==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(94), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(96), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(98), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(100), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(102), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(104), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9811), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9827), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9829), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9831), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9833), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9835), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9837), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9839), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9841), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9843), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9881), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9883), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9885), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9886), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9888), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9890), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9892), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9894), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9896), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9898), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9900), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9902), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9904), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9906), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9907), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9909), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9911), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9913), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9915), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9919), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9922), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9924), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9926), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9928), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9930), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9932), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9934), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9936), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9939), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9941), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9943), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9945), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9947), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9949), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9951), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9952), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9954), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9956), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9958), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9960), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9962), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9964), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9966), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9967), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9969), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9971), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9973), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9975), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9977), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9979), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9980), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9982), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9984), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9986), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9988), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9990), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9992), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9994), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9995), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9997), new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 900, DateTimeKind.Local).AddTicks(9999), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(1), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(3), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(5), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(7), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(11), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(13), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(15), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(17), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(18), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(20), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(22), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(24), new DateTime(2024, 5, 1, 23, 13, 22, 901, DateTimeKind.Local).AddTicks(25) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Auction_Deposit",
                table: "SystemConfigs");

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
                values: new object[] { "900f1d83-f476-49e0-9b9c-81936fb5d042", "AQAAAAIAAYagAAAAEDpdUR0F64B1ARyUtyXvDXmcMJLWG8dmx9If5Qc/Y6Z7kYFua7teHPSRZQCpqjSMFQ==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4365), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4368), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4370), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4372), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4374), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4376), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4118), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4134), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4136), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4139), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4140), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4142), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4144), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4147), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4148), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4152), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4154), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4156), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4170), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4172), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4174), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4176), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4178), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4180), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4182), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4183), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4185), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4187), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4189), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4191), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4193), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4195), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4197), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4199), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4200), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4203), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4205), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4207), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4209), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4211), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4213), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4215), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4216), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4218), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4220), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4222), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4225), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4227), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4229), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4229) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4230), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4232), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4234), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4236), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4238), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4240), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4242), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4244), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4246), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4248), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4250), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4251), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4253), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4255), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4257), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4259), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4261), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4263), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4265), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4267), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4269), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4271), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4273), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4275), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4276), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4278), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4280), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4282), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4284), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4286), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4288), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4290), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4292), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4293), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4295), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4297), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4299), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4301), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4303), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4304), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4306), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4308), new DateTime(2024, 4, 26, 11, 13, 28, 964, DateTimeKind.Local).AddTicks(4309) });
        }
    }
}
