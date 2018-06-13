using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCDemoApp.Migrations
{
    public partial class employee_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Employee",
                newName: "employee_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "Employee",
                newName: "ID");
        }
    }
}
