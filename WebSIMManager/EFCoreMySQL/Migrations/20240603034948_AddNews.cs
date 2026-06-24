using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMySQL.Migrations
{
    /// <inheritdoc />
    public partial class AddNews : Migration
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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Url = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Summary = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Url = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Summary = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    typeOfPage = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdateBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDelete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("c09b6c9b-3405-4abb-b39f-2faa705226d8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba15f374-f8b5-4df2-9fad-b37933768770", "AQAAAAIAAYagAAAAEF2kZ4R6fj1kVY9rq41JDDC+bcnEuxhXsMLN0UE++Nucldz4XOAdtGUvcZ1NRWI43w==" });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4851), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4853), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4857), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4859), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "SIMNetworks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4861), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4635), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4650), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4653), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4655), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4657), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4658), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4660), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4663), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4664), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4666), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4668), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4670), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4671), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4673), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4675), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4677), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4679), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4680), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4682), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4685), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4687), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4689), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4691), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4692), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4694), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4696), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4698), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4699), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4701), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4703), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4704), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4706), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4708), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4710), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4711), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4713), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4715), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4717), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4718), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4720), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4722), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4724), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4725), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4727), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4729), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4731), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4732), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4734), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4736), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4738), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4739), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4743), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4744), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4746), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4748), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4750), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4751), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4753), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4755), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4767), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4769), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4771), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4772), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4774), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4776), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4779), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4781), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4783), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4784), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4788), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4790), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4791), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4793), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4795), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4796), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4798), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4800), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4802), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4803), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4805), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4807), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "TypesOfSIM",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4808), new DateTime(2024, 6, 3, 10, 49, 48, 428, DateTimeKind.Local).AddTicks(4809) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "News");

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
    }
}
