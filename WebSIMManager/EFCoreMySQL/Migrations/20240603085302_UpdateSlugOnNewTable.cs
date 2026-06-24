using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSlugOnNewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "News",
                newName: "Slug");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "News",
                newName: "Url");

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
                values: new object[] { "ba15f374-f8b5-4df2-9fad-b37933768770", "AQAAAAIAAYagAAAAEF2kZ4R6fj1kVY9rq41JDDC+bcnEuxhXsMLN0UE++Nucldz4XOAdtGUvcZ1NRWI43w==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4851), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4853), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4857), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4859), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4861), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4635), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4650), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4653), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4655), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4657), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4658), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4660), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4663), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4664), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4666), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4668), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4670), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4671), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4673), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4675), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4677), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4679), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4680), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4682), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4685), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4687), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4689), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4691), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4692), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4694), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4696), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4698), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4699), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4701), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4703), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4704), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4706), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4708), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4710), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4711), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4713), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4715), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4717), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4718), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4720), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4722), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4724), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4725), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4727), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4729), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4731), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4732), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4734), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4736), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4738), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4739), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4743), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4744), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4746), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4748), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4750), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4751), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4753), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4755), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4767), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4769), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4771), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4772), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4774), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4776), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4779), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4781), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4783), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4784), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4788), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4790), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4791), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4793), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4795), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4796), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4798), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4800), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4802), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4803), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4805), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4807), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4808), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4809) });
        }
    }
}
