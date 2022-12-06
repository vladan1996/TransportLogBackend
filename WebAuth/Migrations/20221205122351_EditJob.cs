using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAuth.Migrations
{
    public partial class EditJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalTime",
                table: "Job");

            migrationBuilder.RenameColumn(
                name: "DockOn",
                table: "Job",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "DockOff",
                table: "Job",
                newName: "endDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "Job",
                newName: "DockOn");

            migrationBuilder.RenameColumn(
                name: "endDate",
                table: "Job",
                newName: "DockOff");

            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalTime",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
