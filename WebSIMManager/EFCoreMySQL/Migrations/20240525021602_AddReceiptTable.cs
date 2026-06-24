using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class AddReceiptTable : Migration
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
                name: "Receipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OldDebt = table.Column<double>(type: "double", nullable: false),
                    Amount = table.Column<double>(type: "double", nullable: false),
                    NewDebt = table.Column<double>(type: "double", nullable: false),
                    AgentId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AgentName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AgentInfo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    formOfPayment = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    BankId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    approvedStatus = table.Column<int>(type: "int", nullable: false),
                    approvedBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    approvedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ReceiptDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "65a93971-ab2e-430b-867d-c4706460bb47", "AQAAAAIAAYagAAAAEFUBKh3osbUW4EAh/n3Mx799wIdpjF2sjtbeSuDxMO1rA2vpOm5xw3sEVFo4//E4EQ==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3663), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3666), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3668), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3670), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3672), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3674), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3419), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3432), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3452), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3455), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3457), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3459), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3461), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3463), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3467), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3469), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3471), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3472), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3474), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3476), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3478), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3480), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3482), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3483), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3485), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3487), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3489), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3491), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3493), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3494), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3496), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3498), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3500), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3502), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3504), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3505), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3507), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3509), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3511), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3513), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3514), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3517), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3519), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3521), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3523), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3525), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3526), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3528), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3530), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3532), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3534), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3536), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3538), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3540), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3541), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3543), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3545), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3547), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3549), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3551), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3552), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3554), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3556), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3558), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3560), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3562), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3563), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3565), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3567), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3569), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3571), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3573), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3574), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3576), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3578), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3580), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3582), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3584), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3586), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3588), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3589), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3591), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3593), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3595), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3597), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3605), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3607), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3609), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3611), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3613), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3614), new DateTime(2024, 5, 25, 9, 16, 1, 699, DateTimeKind.Local).AddTicks(3615) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receipts");

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
                values: new object[] { "91b02a3f-c898-4d29-8388-26ff45f4412a", "AQAAAAIAAYagAAAAELxTpt/Bdgsz7tLs9u1iZCGCFZCxRPXBcz4DYXTD2ngUeYu5D5iMSF2BFQ15m7VD1g==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5309), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5311), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5313), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5315), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5317), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5319), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5083), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5095), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5098), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5100), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5101), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5103), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5105), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5107), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5109), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5110), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5112), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5114), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5116), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5118), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5120), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5123), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5125), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5127), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5129), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5130), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5132), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5134), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5147), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5148), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5150), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5152), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5154), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5155), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5157), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5159), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5161), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5163), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5164), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5166), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5168), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5170), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5171), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5173), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5175), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5177), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5178), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5180), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5182), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5184), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5186), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5187), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5189), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5191), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5193), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5195), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5196), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5198), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5200), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5202), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5203), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5205), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5207), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5209), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5211), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5212), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5214), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5216), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5218), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5219), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5221), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5223), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5225), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5226), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5228), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5230), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5232), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5234), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5235), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5237), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5239), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5241), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5242), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5244), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5246), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5248), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5249), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5251), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5253), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5255), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5256), new DateTime(2024, 5, 24, 8, 52, 1, 816, DateTimeKind.Local).AddTicks(5257) });
        }
    }
}
