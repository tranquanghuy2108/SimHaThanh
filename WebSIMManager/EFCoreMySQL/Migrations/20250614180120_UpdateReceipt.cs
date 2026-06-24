using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReceipt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Receipts",
                newName: "Receivables");

            migrationBuilder.AddColumn<double>(
                name: "Liabilities",
                table: "Receipts",
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
                values: new object[] { "12cc323c-b331-4da5-bacc-9c265fb86445", "AQAAAAIAAYagAAAAEGzAQGjGW/MREOb9XxrUPrFW/vpv9XHvCtw0b99yDEbIFUd8pAbhnpYBbHE6k2f8cA==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9141), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9144), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9146), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9149), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9151), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9153), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6881), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6896), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6899), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6902), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6904), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6907), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6910), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6912), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6915), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6917), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6920), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6922), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6925), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6927), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(6929), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8845), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8848), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8850), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8852), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8855), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8857), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8861), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8863), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8866), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8868), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8870), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8872), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8875), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8877), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8879), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8881), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8883), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8885), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8887), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8889), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8891), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8893), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8895), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8897), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8899), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8916), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8919), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8920), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8923), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8925), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8927), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8929), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8931), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8933), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8935), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8937), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8940), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8942), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8944), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8946), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8949), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8951), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8953), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8955), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8958), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8960), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8962), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8964), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8967), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8969), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8971), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8974), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8977), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8980), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8982), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8984), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8986), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8989), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8991), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8993), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8995), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8998), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9000), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9002), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9004), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9007), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9009), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9011), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9013), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9015), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9017), new DateTime(2025, 6, 15, 1, 1, 20, 26, DateTimeKind.Local).AddTicks(9018) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Liabilities",
                table: "Receipts");

            migrationBuilder.RenameColumn(
                name: "Receivables",
                table: "Receipts",
                newName: "Amount");

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
                values: new object[] { "be3faf08-c13d-4290-862a-5ef21fd19e59", "AQAAAAIAAYagAAAAEIi/H5vuaGnigd+KxS3Qd3r7D2xHgWnuO3NWOFGU/XAs+kywjxp5WH2+h7qkT+z13A==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5468), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5470), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5472), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5474), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5475), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5477), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5237), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5253), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5255), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5257), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5258), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5260), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5262), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5264), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5266), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5268), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5270), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5272), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5274), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5276), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5278), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5280), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5282), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5284), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5285), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5287), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5289), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5291), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5293), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5294), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5296), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5298), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5300), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5301), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5303), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5305), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5307), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5309), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5310), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5312), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5314), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5316), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5318), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5320), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5321), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5323), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5325), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5327), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5329), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5330), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5332), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5334), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5336), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5337), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5339), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5342), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5344), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5346), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5347), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5349), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5351), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5353), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5355), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5356), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5375), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5377), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5378), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5380), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5382), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5384), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5386), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5387), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5389), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5391), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5393), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5394), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5397), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5399), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5401), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5403), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5404), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5406), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5408), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5410), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5412), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5414), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5416), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5418), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5419), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5421), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5423), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5425), new DateTime(2025, 6, 13, 0, 7, 44, 686, DateTimeKind.Local).AddTicks(5425) });
        }
    }
}
