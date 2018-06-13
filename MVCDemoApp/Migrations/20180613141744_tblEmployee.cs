using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCDemoApp.Migrations
{
    public partial class tblEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "tblEmployee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblEmployee",
                table: "tblEmployee",
                column: "Employee_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblEmployee",
                table: "tblEmployee");

            migrationBuilder.RenameTable(
                name: "tblEmployee",
                newName: "Employee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Employee_id");
        }
    }
}
