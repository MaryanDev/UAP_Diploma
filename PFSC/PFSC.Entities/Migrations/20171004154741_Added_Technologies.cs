using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PFSC.Entities.Migrations
{
    public partial class Added_Technologies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MachineToFactory_Factories_FactoryId",
                table: "MachineToFactory");

            migrationBuilder.DropForeignKey(
                name: "FK_MachineToFactory_MachineModels_MachineId",
                table: "MachineToFactory");

            migrationBuilder.DropForeignKey(
                name: "FK_RegistrationRequest_Factories_FactoryId",
                table: "RegistrationRequest");

            migrationBuilder.DropTable(
                name: "FactoryToCategory");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegistrationRequest",
                table: "RegistrationRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MachineToFactory",
                table: "MachineToFactory");

            migrationBuilder.RenameTable(
                name: "RegistrationRequest",
                newName: "RegistrationRequests");

            migrationBuilder.RenameTable(
                name: "MachineToFactory",
                newName: "MachinesToFactories");

            migrationBuilder.RenameIndex(
                name: "IX_MachineToFactory_MachineId",
                table: "MachinesToFactories",
                newName: "IX_MachinesToFactories_MachineId");

            migrationBuilder.RenameIndex(
                name: "IX_MachineToFactory_FactoryId",
                table: "MachinesToFactories",
                newName: "IX_MachinesToFactories_FactoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegistrationRequests",
                table: "RegistrationRequests",
                column: "FactoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MachinesToFactories",
                table: "MachinesToFactories",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PrintingProductions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrintingProductions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrintingTechnologies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrintingTechnologies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FactoryToProduction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FactoryId = table.Column<int>(type: "int", nullable: false),
                    PrintingProductionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoryToProduction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FactoryToProduction_Factories_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactoryToProduction_PrintingProductions_PrintingProductionId",
                        column: x => x.PrintingProductionId,
                        principalTable: "PrintingProductions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FactoryToTechnology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    FactoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoryToTechnology", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FactoryToTechnology_PrintingTechnologies_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "PrintingTechnologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactoryToTechnology_Factories_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FactoryToProduction_FactoryId",
                table: "FactoryToProduction",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FactoryToProduction_PrintingProductionId",
                table: "FactoryToProduction",
                column: "PrintingProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_FactoryToTechnology_CategoryId",
                table: "FactoryToTechnology",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FactoryToTechnology_FactoryId",
                table: "FactoryToTechnology",
                column: "FactoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_MachinesToFactories_Factories_FactoryId",
                table: "MachinesToFactories",
                column: "FactoryId",
                principalTable: "Factories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MachinesToFactories_MachineModels_MachineId",
                table: "MachinesToFactories",
                column: "MachineId",
                principalTable: "MachineModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegistrationRequests_Factories_FactoryId",
                table: "RegistrationRequests",
                column: "FactoryId",
                principalTable: "Factories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MachinesToFactories_Factories_FactoryId",
                table: "MachinesToFactories");

            migrationBuilder.DropForeignKey(
                name: "FK_MachinesToFactories_MachineModels_MachineId",
                table: "MachinesToFactories");

            migrationBuilder.DropForeignKey(
                name: "FK_RegistrationRequests_Factories_FactoryId",
                table: "RegistrationRequests");

            migrationBuilder.DropTable(
                name: "FactoryToProduction");

            migrationBuilder.DropTable(
                name: "FactoryToTechnology");

            migrationBuilder.DropTable(
                name: "PrintingProductions");

            migrationBuilder.DropTable(
                name: "PrintingTechnologies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegistrationRequests",
                table: "RegistrationRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MachinesToFactories",
                table: "MachinesToFactories");

            migrationBuilder.RenameTable(
                name: "RegistrationRequests",
                newName: "RegistrationRequest");

            migrationBuilder.RenameTable(
                name: "MachinesToFactories",
                newName: "MachineToFactory");

            migrationBuilder.RenameIndex(
                name: "IX_MachinesToFactories_MachineId",
                table: "MachineToFactory",
                newName: "IX_MachineToFactory_MachineId");

            migrationBuilder.RenameIndex(
                name: "IX_MachinesToFactories_FactoryId",
                table: "MachineToFactory",
                newName: "IX_MachineToFactory_FactoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegistrationRequest",
                table: "RegistrationRequest",
                column: "FactoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MachineToFactory",
                table: "MachineToFactory",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FactoryToCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    FactoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoryToCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FactoryToCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactoryToCategory_Factories_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FactoryToCategory_CategoryId",
                table: "FactoryToCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FactoryToCategory_FactoryId",
                table: "FactoryToCategory",
                column: "FactoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_MachineToFactory_Factories_FactoryId",
                table: "MachineToFactory",
                column: "FactoryId",
                principalTable: "Factories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MachineToFactory_MachineModels_MachineId",
                table: "MachineToFactory",
                column: "MachineId",
                principalTable: "MachineModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegistrationRequest_Factories_FactoryId",
                table: "RegistrationRequest",
                column: "FactoryId",
                principalTable: "Factories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
