using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForXuatSimFlow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CongNoPhatSinhGiaoDichHo",
                table: "GoodsDeliveryNoteOfSims");

            migrationBuilder.RenameColumn(
                name: "SoTienThuHo",
                table: "GoodsDeliveryNoteOfSims",
                newName: "Deposit");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SIMOrders",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.AddColumn<int>(
                name: "GDNId",
                table: "Shippings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelivered",
                table: "Shippings",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDebtSettlement",
                table: "DebtStaffs",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDebtSettlement",
                table: "DebtShippings",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDebtSettlement",
                table: "DebtBanks",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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
                name: "SimInfosInOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GDNId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    SimId = table.Column<int>(type: "int", nullable: false),
                    SimNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PriceOfSim = table.Column<double>(type: "double", nullable: false),
                    DiscountOfSim = table.Column<double>(type: "double", nullable: false),
                    PriceOfDiscount = table.Column<double>(type: "double", nullable: false),
                    PriceAfterDiscount = table.Column<double>(type: "double", nullable: false),
                    SimSeria = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SimEmbryoFee = table.Column<double>(type: "double", nullable: false),
                    SimServiceFee = table.Column<double>(type: "double", nullable: false),
                    AgentId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    AgentName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PriceOfAgent = table.Column<double>(type: "double", nullable: false),
                    DiscountOfAgent = table.Column<double>(type: "double", nullable: false),
                    PriceOfDiscountAgent = table.Column<double>(type: "double", nullable: false),
                    PriceAfterDiscountAgent = table.Column<double>(type: "double", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimInfosInOrders", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a693860-8c7c-4db5-a1fd-1fd17fbb23c4", "AQAAAAIAAYagAAAAEF8HZX4n7vLmvtRu/dw9+qBAsRBNED0+RF7/oD59vGbUMAXHvptVAlDgNMmOZga4gQ==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3426), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3428), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3430), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3432), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3434), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3435), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3185), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3202), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3204), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3206), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3208), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3210), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3212), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3214), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3216), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3218), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3219), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3222), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3223), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3225), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3227), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3229), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3231), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3232), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3234), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3236), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3238), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3239), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3241), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3243), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3245), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3246), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3248), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3250), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3252), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3253), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3255), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3257), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3259), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3261), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3262), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3264), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3266), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3268), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3270), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3271), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3273), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3275), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3277), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3278), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3280), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3282), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3286), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3287), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3289), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3291), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3293), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3295), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3296), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3298), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3300), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3302), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3303), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3305), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3307), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3309), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3311), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3312), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3314), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3316), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3318), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3320), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3321), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3348), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3350), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3352), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3354), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3356), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3357), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3359), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3361), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3363), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3365), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3367), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3369), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3370), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3372), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3374), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3376), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3378), new DateTime(2024, 3, 4, 0, 30, 54, 795, DateTimeKind.Local).AddTicks(3378) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SimInfosInOrders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "SIMOrders");

            migrationBuilder.DropColumn(
                name: "GDNId",
                table: "Shippings");

            migrationBuilder.DropColumn(
                name: "IsDelivered",
                table: "Shippings");

            migrationBuilder.DropColumn(
                name: "IsDebtSettlement",
                table: "DebtStaffs");

            migrationBuilder.DropColumn(
                name: "IsDebtSettlement",
                table: "DebtShippings");

            migrationBuilder.DropColumn(
                name: "IsDebtSettlement",
                table: "DebtBanks");

            migrationBuilder.RenameColumn(
                name: "Deposit",
                table: "GoodsDeliveryNoteOfSims",
                newName: "SoTienThuHo");

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

            migrationBuilder.AddColumn<double>(
                name: "CongNoPhatSinhGiaoDichHo",
                table: "GoodsDeliveryNoteOfSims",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

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
                values: new object[] { "0f9f346b-4357-417f-b73e-4a0755812303", "AQAAAAIAAYagAAAAEOi3DAvxlzGZIn2YwA++eja+yV4c/m5abmQXANteqJwCtEKsxjmzbNs8Jiaw0/GwgA==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5720), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5723), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5725), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5727), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5729), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5731), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5478), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5499), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5501), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5503), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5505), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5507), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5510), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5511), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5513), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5515), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5517), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5519), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5520), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5522), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5524), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5526), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5528), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5530), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5532), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5533), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5535), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5537), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5539), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5540), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5542), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5544), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5563), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5564), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5566), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5568), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5570), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5572), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5573), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5575), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5577), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5579), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5581), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5583), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5584), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5586), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5590), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5592), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5593), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5595), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5597), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5599), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5600), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5602), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5604), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5606), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5608), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5609), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5611), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5613), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5615), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5616), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5618), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5620), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5622), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5624), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5625), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5627), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5629), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5631), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5633), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5634), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5636), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5638), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5640), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5641), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5643), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5645), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5647), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5649), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5652), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5654), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5655), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5657), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5659), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5661), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5663), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5664), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5666), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5668), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5670), new DateTime(2024, 3, 1, 10, 55, 57, 855, DateTimeKind.Local).AddTicks(5670) });
        }
    }
}
