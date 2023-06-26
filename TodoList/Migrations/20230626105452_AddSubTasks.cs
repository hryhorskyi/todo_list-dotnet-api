using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoList.Migrations
{
    /// <inheritdoc />
    public partial class AddSubTasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Todos_ParentId",
                table: "Todos");

            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Todos_TodoId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_ParentId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_TodoId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "TodoId",
                table: "Todos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Todos",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TodoId",
                table: "Todos",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Todos_ParentId",
                table: "Todos",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Todos_TodoId",
                table: "Todos",
                column: "TodoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Todos_ParentId",
                table: "Todos",
                column: "ParentId",
                principalTable: "Todos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Todos_TodoId",
                table: "Todos",
                column: "TodoId",
                principalTable: "Todos",
                principalColumn: "Id");
        }
    }
}
