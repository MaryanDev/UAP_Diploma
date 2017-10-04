using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PFSC.Entities.Migrations
{
    public partial class Ren_DescToDescription_ReviewResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desc",
                table: "ReviewResults");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ReviewResults",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ReviewResults");

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "ReviewResults",
                nullable: true);
        }
    }
}
