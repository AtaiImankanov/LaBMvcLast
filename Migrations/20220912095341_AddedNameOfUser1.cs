using Microsoft.EntityFrameworkCore.Migrations;

namespace lavAspMvclast.Migrations
{
    public partial class AddedNameOfUser1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameOfUser",
                table: "ToDoTasks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameOfUser",
                table: "ToDoTasks");
        }
    }
}
