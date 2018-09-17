using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PFSC.Entities.Migrations
{
    public partial class renamed_MachineModel_to_Machine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MachinesToFactories_MachineModels_MachineId",
                table: "MachinesToFactories");

            migrationBuilder.DropTable(
                name: "MachineModels");

            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Machines_MachineManufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "MachineManufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Machines_ManufacturerId",
                table: "Machines",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_MachinesToFactories_Machines_MachineId",
                table: "MachinesToFactories",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MachinesToFactories_Machines_MachineId",
                table: "MachinesToFactories");

            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.CreateTable(
                name: "MachineModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    ManufacturerId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MachineModels_MachineManufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "MachineManufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MachineModels_ManufacturerId",
                table: "MachineModels",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_MachinesToFactories_MachineModels_MachineId",
                table: "MachinesToFactories",
                column: "MachineId",
                principalTable: "MachineModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
