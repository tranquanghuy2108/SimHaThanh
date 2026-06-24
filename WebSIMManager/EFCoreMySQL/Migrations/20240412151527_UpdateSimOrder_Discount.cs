using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSimOrder_Discount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PriceAfterDiscount",
                table: "SIMOrders",
                newName: "PriceOfSim");

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "SIMOrders",
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
                values: new object[] { "dd7b64e1-563a-4f8a-bf56-2ec642f509e1", "AQAAAAIAAYagAAAAEIEVtLLPNX2qBlEuK2CXFK/kzdpMY21IkPEWkE40WplYNXILj9y+N1+6j0FDvwR90Q==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7171), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7173), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7175), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7183), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7187), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6933), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6947), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6949), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6951), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6953), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6955), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6955) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6956), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6958), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6960), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6962), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6963), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6966), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6968), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6969), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6971), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6975), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6977), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6978), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6980), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6982), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6984), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6985), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6987), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6989), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6991), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6992), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6995), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6997), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6998), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7000), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7002), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7004), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7006), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7020), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7022), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7024), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7026), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7027), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7029), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7031), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7033), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7034), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7036), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7038), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7043), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7044), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7046), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7048), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7050), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7052), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7053), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7055), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7057), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7059), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7061), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7063), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7064), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7068), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7069), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7071), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7073), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7077), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7080), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7082), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7085), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7087), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7089), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7095), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7096), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7098), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7102), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7103), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7105), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7107), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7109), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7111), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7112), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7115), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7118), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7119), new DateTime(2024, 4, 12, 22, 15, 27, 564, DateTimeKind.Local).AddTicks(7120) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "SIMOrders");

            migrationBuilder.RenameColumn(
                name: "PriceOfSim",
                table: "SIMOrders",
                newName: "PriceAfterDiscount");

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
                values: new object[] { "33c2ac60-14ff-4afc-9213-cb5320c8c8df", "AQAAAAIAAYagAAAAEPyKibyBeQJeZRsAiHMc9pGiwpT1l67KN+KY9URJVV50ZyqeuMyIcE5P09r2lTZJBQ==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6919), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6923), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6925), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6928), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6930), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6932), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6047), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6068), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6071), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6075), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6098), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6103), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6106), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6109), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6112), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6115), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6118), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6121), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6124), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6127), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6130), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6513), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6519), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6522), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6525), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6527), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6529), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6532), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6534), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6536), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6539), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6541), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6543), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6545), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6548), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6552), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6555), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6557), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6559), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6561), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6564), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6566), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6568), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6571), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6574), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6576), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6577) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6578), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6580), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6582), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6585), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6587), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6589), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6591), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6594), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6598), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6600), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6603), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6605), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6607), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6609), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6612), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6614), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6616), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6618), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6620), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6624), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6626), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6628), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6630), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6633), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6637), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6639), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6642), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6644), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6646), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6648), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6651), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6654), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6656), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6658), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6660), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6663), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6665), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6667), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6669), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6671), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6690), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6694), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6696), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6698), new DateTime(2024, 4, 9, 15, 12, 0, 144, DateTimeKind.Local).AddTicks(6699) });
        }
    }
}
