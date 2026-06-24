using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class AddingCountry1 : Migration
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

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c25b070-32a9-4329-b164-7be36e30c2c9", "AQAAAAIAAYagAAAAEAhiNrXIPnPG2roQc1EDMAZkoqCpIsDwNUeB0f1xh+gBm77OPWkljB/Qrbq/jikGeQ==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1163), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1165), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1167), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1169), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1171), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1172), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(947), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(958), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(960), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(962), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(964), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(975), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(977), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(979), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(980), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(982), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(984), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(986), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(987), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(989), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(991), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(992), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(994), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(996), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(998), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(999), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1001), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1003), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1005), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1006), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1008), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1010), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1012), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1013), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1015), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1017), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1018), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1020), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1022), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1024), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1025), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1027), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1029), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1031), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1032), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1034), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1036), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1038), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1039), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1041), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1043), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1045), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1046), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1048), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1050), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1051), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1053), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1055), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1057), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1059), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1061), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1062), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1063) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1064), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1066), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1068), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1069), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1071), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1073), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1074), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1076), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1078), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1079), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1081), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1083), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1084), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1086), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1088), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1090), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1091), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1093), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1095), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1097), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1098), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1102), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1103), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1105), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1107), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1108), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1110), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1118), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1120), new DateTime(2024, 4, 23, 1, 28, 49, 639, DateTimeKind.Local).AddTicks(1121) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

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
    }
}
