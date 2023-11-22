using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SıgnalRProject.DataAccess.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MenuTables");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MenuTables");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "MenuTables");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MenuTables");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "MenuTables");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "MenuTables");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "MenuTables",
                newName: "Status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "MenuTables",
                newName: "IsDeleted");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MenuTables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "MenuTables",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "MenuTables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MenuTables",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "MenuTables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "MenuTables",
                type: "datetime2",
                nullable: true);
        }
    }
}
