using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mall.PersistentImpl.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityStatus = table.Column<int>(nullable: false, defaultValue: 1),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 6, 17, 11, 59, 0, 299, DateTimeKind.Local).AddTicks(8144)),
                    DeleteTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ParentOrganizationId = table.Column<int>(nullable: false),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityStatus = table.Column<int>(nullable: false, defaultValue: 1),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 6, 17, 11, 59, 0, 307, DateTimeKind.Local).AddTicks(3971)),
                    DeleteTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Account = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    IsAdministrator = table.Column<bool>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    IsVisible = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityStatus = table.Column<int>(nullable: false, defaultValue: 1),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 6, 17, 11, 59, 0, 306, DateTimeKind.Local).AddTicks(9802)),
                    DeleteTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PartenDepartmentId = table.Column<int>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    IsEnable = table.Column<bool>(nullable: false, defaultValue: true),
                    IsVisible = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThirdPartyOrgMap",
                columns: table => new
                {
                    ThirdPartyOrgId = table.Column<string>(nullable: false),
                    ThirdPartyApp = table.Column<int>(nullable: false),
                    EntityStatus = table.Column<int>(nullable: false, defaultValue: 1),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 6, 17, 11, 59, 0, 322, DateTimeKind.Local).AddTicks(2270)),
                    DeleteTime = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    ThirdPartyOrgName = table.Column<string>(nullable: true),
                    ThirdPartyAppId = table.Column<string>(nullable: true),
                    ThirdPartyAppName = table.Column<string>(nullable: true),
                    PermanentCode = table.Column<string>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: false),
                    IsEnable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdPartyOrgMap", x => new { x.ThirdPartyOrgId, x.ThirdPartyApp });
                    table.ForeignKey(
                        name: "FK_ThirdPartyOrgMap_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentCustomerRelation",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    EntityStatus = table.Column<int>(nullable: false, defaultValue: 1),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 6, 17, 11, 59, 0, 319, DateTimeKind.Local).AddTicks(9114)),
                    DeleteTime = table.Column<DateTime>(nullable: false),
                    CustomerRole = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentCustomerRelation", x => new { x.CustomerId, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_DepartmentCustomerRelation_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartmentCustomerRelation_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Account",
                table: "Customer",
                column: "Account",
                unique: true,
                filter: "[Account] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_OrganizationId",
                table: "Customer",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_OrganizationId",
                table: "Department",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentCustomerRelation_DepartmentId",
                table: "DepartmentCustomerRelation",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPartyOrgMap_OrganizationId",
                table: "ThirdPartyOrgMap",
                column: "OrganizationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentCustomerRelation");

            migrationBuilder.DropTable(
                name: "ThirdPartyOrgMap");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Organization");
        }
    }
}
