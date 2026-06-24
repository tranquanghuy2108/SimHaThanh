using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class DebtType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DebtTypeId",
                table: "Debts",
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

            migrationBuilder.CreateTable(
                name: "DebtTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DebtReceiveType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebtTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransferMoneys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<double>(type: "double", nullable: false),
                    ReceiverId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RemittersId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    GRNId = table.Column<int>(type: "int", nullable: true),
                    GDNId = table.Column<int>(type: "int", nullable: true),
                    GDNSId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    approvedStatus = table.Column<int>(type: "int", nullable: false),
                    approvedBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    approvedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferMoneys", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17851f3c-7f9f-4f96-b1ab-6f0024ba375d", "AQAAAAIAAYagAAAAEBH67h4sFHk7/CQsCXD2qbj/PgB4tLBracd5S6WHc+PHzIpfttVtlHG5EQfr8u58DA==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7615), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7617), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7619), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7621), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7623), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7633), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7412), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7423), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7426), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7427), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7429), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7431), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7432), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7435), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7436), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7438), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7440), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7441), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7443), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7445), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7446), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7448), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7450), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7451), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7453), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7455), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7456), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7458), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7460), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7461), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7463), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7465), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7466), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7468), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7470), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7471), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7473), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7475), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7476), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7478), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7482), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7483), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7495), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7498), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7501), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7503), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7505), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7506), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7508), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7510), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7511), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7513), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7515), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7518), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7520), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7522), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7523), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7525), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7527), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7528), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7530), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7532), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7534), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7536), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7537), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7539), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7541), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7542), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7544), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7546), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7547), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7549), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7551), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7553), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7555), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7556), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7558), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7560), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7562), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7564), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7566), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7567), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7569), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7571), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7573), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7575), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7577), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7578), new DateTime(2024, 5, 21, 15, 34, 59, 614, DateTimeKind.Local).AddTicks(7579) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DebtTypes");

            migrationBuilder.DropTable(
                name: "TransferMoneys");

            migrationBuilder.DropColumn(
                name: "DebtTypeId",
                table: "Debts");

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
                values: new object[] { "31753692-8284-4cb8-9ac7-b43a62296c8a", "AQAAAAIAAYagAAAAEHAkVGAMh3fOF6/rkW1pY4BCoS9FBCqgWwkmftTymUDgGsVgqR7oS9Gglh5Eir1O6g==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4229), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4232), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4234), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4236), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4238), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4240), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3969), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3985), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3987), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3989), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3991), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3993), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3995), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3998), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(3999), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4001), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4003), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4005), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4007), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4009), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4011), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4013), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4015), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4017), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4020), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4021), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4024), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4026), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4028), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4030), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4032), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4033), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4035), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4037), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4039), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4042), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4059), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4060), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4062), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4064), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4066), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4068), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4070), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4072), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4074), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4076), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4078), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4080), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4082), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4084), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4086), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4088), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4090), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4092), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4094), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4096), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4098), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4100), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4102), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4104), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4106), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4108), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4110), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4111), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4113), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4115), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4117), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4119), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4122), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4124), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4126), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4128), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4130), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4132), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4134), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4136), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4138), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4140), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4141), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4144), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4146), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4148), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4150), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4152), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4154), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4156), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4158), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4160), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4162), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4164), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4166), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4168), new DateTime(2024, 5, 6, 12, 54, 19, 817, DateTimeKind.Local).AddTicks(4169) });
        }
    }
}
