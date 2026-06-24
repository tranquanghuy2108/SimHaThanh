using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForGoodsReceivedNote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoaiSanPhams");

            migrationBuilder.DropTable(
                name: "NhomSanPhams");

            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "Warehouse",
                newName: "approvedStatus");

            migrationBuilder.RenameColumn(
                name: "IDSanPhamNguyenVatLieu",
                table: "Warehouse",
                newName: "MaterialTypeId");

            migrationBuilder.RenameColumn(
                name: "IDLoaiSanPham",
                table: "Warehouse",
                newName: "MaterialId");

            migrationBuilder.RenameColumn(
                name: "GhiChu",
                table: "Warehouse",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "DonGiaTrungBinh",
                table: "Warehouse",
                newName: "PriceAfterDiscount");

            migrationBuilder.RenameColumn(
                name: "DonGiaThapNhat",
                table: "Warehouse",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "DonGiaCaoNhat",
                table: "Warehouse",
                newName: "Discount");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Warehouse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ApprovedBy",
                table: "Warehouse",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedTime",
                table: "Warehouse",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GoodsDeliveryNoteId",
                table: "Warehouse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoodsReceivedNoteId",
                table: "Warehouse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MaterialCode",
                table: "Warehouse",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MaterialName",
                table: "Warehouse",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MaterialTypeCode",
                table: "Warehouse",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MaterialTypeName",
                table: "Warehouse",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "UsingSeria",
                table: "Warehouse",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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
                name: "GoodsReceivedNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SupplierId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    SupplierName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SupplierPhone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SupplierAddress = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StaffId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    StaffName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StaffPhone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StaffAddress = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalPrice = table.Column<double>(type: "double", nullable: false),
                    OtherFee = table.Column<double>(type: "double", nullable: false),
                    TienPhaiTra = table.Column<double>(type: "double", nullable: false),
                    TienDaTra = table.Column<double>(type: "double", nullable: false),
                    OldDebt = table.Column<double>(type: "double", nullable: false),
                    NewDebt = table.Column<double>(type: "double", nullable: false),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PayOrderType = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: true),
                    CongNoPhatSinh = table.Column<double>(type: "double", nullable: false),
                    approvedStatus = table.Column<int>(type: "int", nullable: false),
                    ApprovedTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ApprovedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsReceivedNotes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MaterialGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
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
                    table.PrimaryKey("PK_MaterialGroups", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NetworkId = table.Column<int>(type: "int", nullable: false),
                    MaterialTypeId = table.Column<int>(type: "int", nullable: false),
                    MaterialGroupId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "double", nullable: false),
                    ImportSeria = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ExportSeria = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsSimEmbryo = table.Column<bool>(type: "tinyint(1)", nullable: false),
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
                    table.PrimaryKey("PK_Materials", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MaterialSerias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GoodsReceivedNoteId = table.Column<int>(type: "int", nullable: false),
                    GoodsDeliveryNoteId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    MaterialCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MaterialName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Seria = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HadSelled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    approvedStatus = table.Column<int>(type: "int", nullable: false),
                    ApprovedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ApprovedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSerias", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MaterialTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
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
                    table.PrimaryKey("PK_MaterialTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3725cbb5-7e50-45ff-aa07-e6e033bae66c", "AQAAAAIAAYagAAAAEDFE6lTopV0eZu3mCIgtt9OF4SvKQtPUTVK9Vk8MCSLwRMb2TI2M9ItroVHdCSqWNQ==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(340), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(343), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(345), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(347), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(349), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(351), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(55), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(69), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(72), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(74), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(114), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(116), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(117), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(119), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(121), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(123), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(126), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(127), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(130), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(132), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(133), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(135), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(137), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(139), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(141), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(143), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(144), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(147), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(149), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(151), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(152), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(154), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(156), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(158), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(159), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(161), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(163), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(165), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(169), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(171), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(173), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(175), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(176), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(178), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(182), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(184), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(185), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(187), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(190), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(191), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(193), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(195), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(197), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(199), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(200), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(203), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(204), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(206), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(208), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(210), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(212), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(214), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(216), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(217), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(219), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(221), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(223), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(225), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(226), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(228), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(230), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(234), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(236), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(238), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(240), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(241), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(243), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(245), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(247), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(248), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(250), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(253), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(255), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(257), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(258), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(260), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(262), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(264), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(265), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(267), new DateTime(2024, 3, 8, 9, 43, 19, 756, DateTimeKind.Local).AddTicks(268) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodsReceivedNotes");

            migrationBuilder.DropTable(
                name: "MaterialGroups");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "MaterialSerias");

            migrationBuilder.DropTable(
                name: "MaterialTypes");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "ApprovedBy",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "ApprovedTime",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "GoodsDeliveryNoteId",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "GoodsReceivedNoteId",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "MaterialCode",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "MaterialName",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "MaterialTypeCode",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "MaterialTypeName",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "UsingSeria",
                table: "Warehouse");

            migrationBuilder.RenameColumn(
                name: "approvedStatus",
                table: "Warehouse",
                newName: "SoLuong");

            migrationBuilder.RenameColumn(
                name: "PriceAfterDiscount",
                table: "Warehouse",
                newName: "DonGiaTrungBinh");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Warehouse",
                newName: "DonGiaThapNhat");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "Warehouse",
                newName: "GhiChu");

            migrationBuilder.RenameColumn(
                name: "MaterialTypeId",
                table: "Warehouse",
                newName: "IDSanPhamNguyenVatLieu");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "Warehouse",
                newName: "IDLoaiSanPham");

            migrationBuilder.RenameColumn(
                name: "Discount",
                table: "Warehouse",
                newName: "DonGiaCaoNhat");

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
                name: "LoaiSanPhams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPhams", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NhomSanPhams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomSanPhams", x => x.Id);
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
    }
}
