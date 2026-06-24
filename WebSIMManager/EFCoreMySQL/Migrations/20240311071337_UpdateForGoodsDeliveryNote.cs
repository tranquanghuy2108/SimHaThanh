using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForGoodsDeliveryNote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExportSeria",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "ListSimNumberInOrder",
                table: "GoodsDeliveryNotes");

            migrationBuilder.DropColumn(
                name: "NoLai",
                table: "GoodsDeliveryNotes");

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "GoodsDeliveryNotes");

            migrationBuilder.RenameColumn(
                name: "ImportSeria",
                table: "Materials",
                newName: "UsingSeria");

            migrationBuilder.RenameColumn(
                name: "OrderIds",
                table: "GoodsDeliveryNotes",
                newName: "StaffPhone");

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

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "MaterialSerias",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "GoodsDeliveryNotes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPhone",
                table: "GoodsDeliveryNotes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "GoodsDeliveryNotes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerAddress",
                table: "GoodsDeliveryNotes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ListMaterial",
                table: "GoodsDeliveryNotes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StaffAddress",
                table: "GoodsDeliveryNotes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "StaffId",
                table: "GoodsDeliveryNotes",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "StaffName",
                table: "GoodsDeliveryNotes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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
                values: new object[] { "33cd39d6-d7f1-4b2b-8039-18e6d05187b1", "AQAAAAIAAYagAAAAEKsi5BBUuXU+mVhHVJu38gGbUAX7RWe5jjuw2+J0WAishPACGdtrubvIwv1dhfe6+Q==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7336), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7338), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7341), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7342), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7344), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7346), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7115), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7133), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7137), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7140), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7142), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7144), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7146), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7148), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7149), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7152), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7153), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7155), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7157), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7159), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7162), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7164), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7166), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7168), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7169), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7171), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7173), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7175), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7176), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7178), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7182), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7183), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7187), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7188), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7190), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7192), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7194), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7195), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7197), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7199), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7201), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7202), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7204), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7206), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7208), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7209), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7211), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7213), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7215), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7217), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7218), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7220), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7222), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7225), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7226), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7228), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7230), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7232), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7234), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7235), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7237), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7239), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7241), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7242), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7245), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7247), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7249), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7250), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7252), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7254), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7256), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7257), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7259), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7261), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7263), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7265), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7267), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7269), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7271), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7272), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7274), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7276), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7278), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7279), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7281), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7289), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7291), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7293), new DateTime(2024, 3, 11, 14, 13, 37, 182, DateTimeKind.Local).AddTicks(7294) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListMaterial",
                table: "GoodsDeliveryNotes");

            migrationBuilder.DropColumn(
                name: "StaffAddress",
                table: "GoodsDeliveryNotes");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "GoodsDeliveryNotes");

            migrationBuilder.DropColumn(
                name: "StaffName",
                table: "GoodsDeliveryNotes");

            migrationBuilder.RenameColumn(
                name: "UsingSeria",
                table: "Materials",
                newName: "ImportSeria");

            migrationBuilder.RenameColumn(
                name: "StaffPhone",
                table: "GoodsDeliveryNotes",
                newName: "OrderIds");

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
                name: "Price",
                table: "MaterialSerias",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "ExportSeria",
                table: "Materials",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "GoodsDeliveryNotes",
                keyColumn: "Note",
                keyValue: null,
                column: "Note",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "GoodsDeliveryNotes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "GoodsDeliveryNotes",
                keyColumn: "CustomerPhone",
                keyValue: null,
                column: "CustomerPhone",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPhone",
                table: "GoodsDeliveryNotes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "GoodsDeliveryNotes",
                keyColumn: "CustomerName",
                keyValue: null,
                column: "CustomerName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "GoodsDeliveryNotes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "GoodsDeliveryNotes",
                keyColumn: "CustomerAddress",
                keyValue: null,
                column: "CustomerAddress",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerAddress",
                table: "GoodsDeliveryNotes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ListSimNumberInOrder",
                table: "GoodsDeliveryNotes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<double>(
                name: "NoLai",
                table: "GoodsDeliveryNotes",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "WarehouseId",
                table: "GoodsDeliveryNotes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
