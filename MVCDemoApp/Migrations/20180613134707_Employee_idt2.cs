using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCDemoApp.Migrations
{
    public partial class Employee_idt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "Employee",
                newName: "Employee_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Employee_id",
                table: "Employee",
                newName: "employee_id");
        }
    }
}
