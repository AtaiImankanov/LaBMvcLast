using Microsoft.EntityFrameworkCore.Migrations;

namespace lavAspMvclast.Migrations
{
    public partial class EditedStatusNPriority : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "ToDoTasks");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ToDoTasks");

            migrationBuilder.AddColumn<int>(
                name: "Ctatuc",
                table: "ToDoTasks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Prioritet",
                table: "ToDoTasks",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ctatuc",
                table: "ToDoTasks");

            migrationBuilder.DropColumn(
                name: "Prioritet",
                table: "ToDoTasks");

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "ToDoTasks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ToDoTasks",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
