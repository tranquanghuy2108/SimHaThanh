using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSIMPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SIMPriceOfAgent",
                table: "SIMDetails",
                newName: "OriginalSIMPrice");

            migrationBuilder.AddColumn<int>(
                name: "TypePriceSimOrder",
                table: "SIMOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "AgentSIMPrice",
                table: "SIMDetails",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CollaboratorsSIMPrice",
                table: "SIMDetails",
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
                values: new object[] { "908a78eb-47ab-4f00-b04c-a59ae1cdfb84", "AQAAAAIAAYagAAAAEB4rwZEhcvSSugROh2rVzuKyWzrb1TBeNMHETbCrONWaZQEm6FaQC7rl64MjvnDitg==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6864), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6867), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6868), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6870), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6872), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6874), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6654), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6668), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6670), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6672), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6674), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6676), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6677), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6679), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6681), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6683), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6684), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6686), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6688), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6689), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6691), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6693), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6695), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6696), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6698), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6700), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6702), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6703), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6705), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6707), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6708), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6710), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6712), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6713), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6715), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6717), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6718), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6720), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6722), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6724), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6725), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6727), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6729), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6732), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6734), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6735), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6737), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6739), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6742), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6744), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6746), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6747), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6749), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6751), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6752), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6754), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6756), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6758), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6759), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6761), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6763), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6764), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6766), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6768), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6769), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6771), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6773), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6774), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6776), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6778), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6779), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6781), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6783), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6784), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6793), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6795), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6796), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6798), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6800), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6801), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6803), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6805), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6809), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6811), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6812), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6814), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6816), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6817), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6819), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6820), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6822), new DateTime(2024, 6, 30, 23, 16, 1, 797, DateTimeKind.Local).AddTicks(6823) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypePriceSimOrder",
                table: "SIMOrders");

            migrationBuilder.DropColumn(
                name: "AgentSIMPrice",
                table: "SIMDetails");

            migrationBuilder.DropColumn(
                name: "CollaboratorsSIMPrice",
                table: "SIMDetails");

            migrationBuilder.RenameColumn(
                name: "OriginalSIMPrice",
                table: "SIMDetails",
                newName: "SIMPriceOfAgent");

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
                values: new object[] { "25b18402-02a2-42b7-a951-016690207d2b", "AQAAAAIAAYagAAAAECB8NgsPcIb+AnohPgiNq/miHNWQGos65CIcuyrpJgxkEfgYJ9NLG8h0tIc2A1ccCQ==" });

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
    }
}
