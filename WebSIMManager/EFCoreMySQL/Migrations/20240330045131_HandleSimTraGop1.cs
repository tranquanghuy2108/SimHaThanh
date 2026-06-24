using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class HandleSimTraGop1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstallmentSims");

            migrationBuilder.AddColumn<int>(
                name: "DateOfPayment",
                table: "SIMOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "DownPayment",
                table: "SIMOrders",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "InstallmentEndDate",
                table: "SIMOrders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "InstallmentPayment",
                table: "SIMOrders",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "InstallmentPeriod",
                table: "SIMOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "InterestRate",
                table: "SIMOrders",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MonthlyInstallmentPayment",
                table: "SIMOrders",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "PayOrderType",
                table: "SIMOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "PriceAfterDiscount",
                table: "SIMOrders",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

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

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e64469da-bcf3-4830-9916-cdd3f263208c", "AQAAAAIAAYagAAAAEGCm1Kdc5Ii0vqXjs8SzZTLdLC/vWGMrNxoOt+EwOhRfF80z5oyKTUnb03DIg6jWEg==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4789), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4791), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4793), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4796), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4803), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4538), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4554), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4557), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4560), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4562), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4565), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4567), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4569), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4571), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4573), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4575), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4577), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4580), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4582), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4586), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4588), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4590), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4592), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4594), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4596), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4598), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4600), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4603), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4605), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4606), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4608), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4610), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4612), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4614), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4616), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4618), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4620), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4622), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4624), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4626), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4642), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4644), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4646), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4648), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4650), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4651), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4653), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4655), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4657), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4662), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4664), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4666), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4668), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4670), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4672), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4674), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4676), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4678), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4680), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4682), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4686), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4688), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4690), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4692), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4694), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4696), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4698), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4700), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4702), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4704), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4706), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4708), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4710), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4712), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4714), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4716), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4718), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4719), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4721), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4723), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4725), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4728), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4730), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4732), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4734), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4736), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4738), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 3, 30, 11, 51, 30, 784, DateTimeKind.Local).AddTicks(4742) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfPayment",
                table: "SIMOrders");

            migrationBuilder.DropColumn(
                name: "DownPayment",
                table: "SIMOrders");

            migrationBuilder.DropColumn(
                name: "InstallmentEndDate",
                table: "SIMOrders");

            migrationBuilder.DropColumn(
                name: "InstallmentPayment",
                table: "SIMOrders");

            migrationBuilder.DropColumn(
                name: "InstallmentPeriod",
                table: "SIMOrders");

            migrationBuilder.DropColumn(
                name: "InterestRate",
                table: "SIMOrders");

            migrationBuilder.DropColumn(
                name: "MonthlyInstallmentPayment",
                table: "SIMOrders");

            migrationBuilder.DropColumn(
                name: "PayOrderType",
                table: "SIMOrders");

            migrationBuilder.DropColumn(
                name: "PriceAfterDiscount",
                table: "SIMOrders");

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
                name: "InstallmentSims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApprovedBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ApprovedStatus = table.Column<int>(type: "int", nullable: false),
                    ApprovedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateOfPayment = table.Column<int>(type: "int", nullable: false),
                    DownPayment = table.Column<double>(type: "double", nullable: false),
                    GDNOfSimId = table.Column<int>(type: "int", nullable: false),
                    InstallmentEndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    InstallmentPayment = table.Column<double>(type: "double", nullable: false),
                    InstallmentPeriod = table.Column<int>(type: "int", nullable: false),
                    InterestRate = table.Column<double>(type: "double", nullable: false),
                    IsDebtSettlement = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MonthlyInstallmentPayment = table.Column<double>(type: "double", nullable: false),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    SimId = table.Column<int>(type: "int", nullable: false),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstallmentSims", x => x.Id);
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
    }
}
