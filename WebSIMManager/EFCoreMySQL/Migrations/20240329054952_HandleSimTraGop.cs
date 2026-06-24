using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class HandleSimTraGop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "v_SIMViews");

            migrationBuilder.AlterColumn<Guid>(
                name: "Owner",
                table: "SIMDetails",
                type: "char(250)",
                maxLength: 250,
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "char(250)",
                oldMaxLength: 250,
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
                name: "Auctions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auctions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AuctionSimPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AuctionId = table.Column<int>(type: "int", nullable: false),
                    SimId = table.Column<int>(type: "int", nullable: false),
                    SimNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MinPrice = table.Column<double>(type: "double", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionSimPrices", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AuctionUserBidding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AuctionId = table.Column<int>(type: "int", nullable: false),
                    AuctionSimPriceId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Price = table.Column<double>(type: "double", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionUserBidding", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InstallmentSims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SimId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    GDNOfSimId = table.Column<int>(type: "int", nullable: false),
                    InstallmentPeriod = table.Column<int>(type: "int", nullable: false),
                    DateOfPayment = table.Column<int>(type: "int", nullable: false),
                    InstallmentEndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DownPayment = table.Column<double>(type: "double", nullable: false),
                    InstallmentPayment = table.Column<double>(type: "double", nullable: false),
                    MonthlyInstallmentPayment = table.Column<double>(type: "double", nullable: false),
                    InterestRate = table.Column<double>(type: "double", nullable: false),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApprovedStatus = table.Column<int>(type: "int", nullable: false),
                    ApprovedBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ApprovedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDebtSettlement = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallmentSims", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SystemConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Installment_DailyInterestRate = table.Column<double>(type: "double", nullable: false),
                    Installment_MinimumPaymentRate = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemConfigs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24d7eca9-32ba-4a36-99de-1ee1b433b179", "AQAAAAIAAYagAAAAEEoldRIW0gUX0b92W0k3LwOLzWA5iGbveuvwU8G6Gd+K9Sd0FhNQrTYYUAhcEsFIiw==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8338), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8340), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8342), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8344), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8346), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8348), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8091), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8106), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8108), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8114), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8116), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8118), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8122), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8124), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8126), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8127), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8129), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8131), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8133), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8135), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8137), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8139), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8141), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8143), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8145), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8147), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8149), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8151), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8153), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8168), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8170), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8172), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8174), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8176), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8178), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8183), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8185), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8187), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8189), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8191), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8193), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8195), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8197), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8199), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8201), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8202), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8204), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8206), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8208), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8210), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8211), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8213), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8215), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8217), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8219), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8221), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8222), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8224), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8226), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8232), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8234), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8235), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8237), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8239), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8243), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8245), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8246), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8248), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8252), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8254), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8255), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8257), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8259), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8261), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8263), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8265), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8267), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8268), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8270), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8272), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8274), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8276), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8278), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8279), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8281), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8283), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8285), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 3, 29, 12, 49, 52, 666, DateTimeKind.Local).AddTicks(8287) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auctions");

            migrationBuilder.DropTable(
                name: "AuctionSimPrices");

            migrationBuilder.DropTable(
                name: "AuctionUserBidding");

            migrationBuilder.DropTable(
                name: "InstallmentSims");

            migrationBuilder.DropTable(
                name: "SystemConfigs");

            migrationBuilder.AlterColumn<string>(
                name: "Owner",
                table: "SIMDetails",
                type: "char(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(250)",
                oldMaxLength: 250,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

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

            migrationBuilder.CreateTable(
                name: "v_SIMViews",
                columns: table => new
                {
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id = table.Column<int>(type: "int", nullable: true),
                    Network = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Owner = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OwnerPhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<double>(type: "double", nullable: true),
                    ProductType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SIMEmbryoFee = table.Column<double>(type: "double", nullable: true),
                    SIMImgUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SIMServiceFee = table.Column<double>(type: "double", nullable: true),
                    Seria = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4100dae4-de72-493c-9442-c0ce928ca972", "AQAAAAIAAYagAAAAEIVbNbxMJwnMrKoBQUCq46uR0syocyY4jos1PeXTWjQY1CD3grwagrGczEgWPB6Peg==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5078), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5081), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5083), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5085), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5088), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5090), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4753), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4768), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4770), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4772), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4774), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4776), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4780), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4782), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4784), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4788), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4790), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4792), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4794), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4862), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4864), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4866), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4868), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4870), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4872), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4874), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4876), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4878), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4880), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4882), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4884), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4886), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4888), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4890), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4892), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4894), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4896), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4898), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4900), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4902), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4904), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4906), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4908), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4910), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4912), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4914), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4916), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4918), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4920), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4922), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4926), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4930), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4932), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4934), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4936), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4938), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4940), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4942), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4944), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4946), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4948), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4949), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4951), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4953), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4955), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4957), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4959), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4961), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4963), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4965), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4967), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4969), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4971), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4973), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4975), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4977), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4978), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4980), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4982), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4984), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4986), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4988), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4990), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4992), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4994), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4996), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4998), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5000), new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5000) });
        }
    }
}
