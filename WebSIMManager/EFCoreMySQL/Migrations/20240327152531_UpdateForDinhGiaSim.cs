using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForDinhGiaSim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "EstimatedPrice",
                table: "TypesOfSIM",
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
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4753), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4768), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4770), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4772), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4774), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4776), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4778), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4780), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4782), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4784), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4786), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4788), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4790), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4792), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4794), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4862), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4864), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4866), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4868), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4870), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4872), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4874), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4876), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4878), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4880), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4882), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4884), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4886), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4888), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4890), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4892), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4894), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4896), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4898), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4900), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4902), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4904), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4906), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4908), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4910), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4912), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4914), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4916), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4918), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4920), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4922), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4924), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4926), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4928), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4930), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4932), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4934), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4936), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4938), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4940), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4942), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4944), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4946), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4948), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4949), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4951), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4953), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4955), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4957), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4959), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4961), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4963), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4965), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4967), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4969), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4971), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4973), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4975), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4977), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4978), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4980), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4982), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4984), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4986), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4988), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4990), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4992), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4994), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4996), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4998), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "EstimatedPrice", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5000), 0.0, new DateTime(2024, 3, 27, 22, 25, 30, 766, DateTimeKind.Local).AddTicks(5000) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstimatedPrice",
                table: "TypesOfSIM");

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

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a976e6f3-57be-420c-af6e-bd8652a698e9", "AQAAAAIAAYagAAAAEPdz2dRES9iUFIgALCGjVTOKlntl+YgHrE5yJb4Rr/TNcmHqGrMCxj5PK687vk5HSA==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8468), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8471), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8473), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8475), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8477), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8479), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8176), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8191), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8193), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8195), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8197), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8198), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8200), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8202), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8204), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8205), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8207), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8209), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8211), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8213), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8214), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8216), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8218), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8220), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8221), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8223), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8225), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8227), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8229), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8230), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8232), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8234), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8235), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8237), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8239), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8243), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8244), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8246), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8248), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8251), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8253), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8255), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8257), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8258), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8260), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8262), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8264), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8265), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8267), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8269), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8271), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8272), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8274), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8276), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8278), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8279), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8281), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8283), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8285), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8289), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8328), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8330), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8332), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8334), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8336), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8337), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8339), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8341), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8343), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8345), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8347), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8349), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8351), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8352), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8354), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8356), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8358), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8359), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8361), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8363), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8365), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8366), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8368), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8372), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8373), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8377), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8379), new DateTime(2024, 3, 27, 14, 42, 11, 422, DateTimeKind.Local).AddTicks(8379) });
        }
    }
}
