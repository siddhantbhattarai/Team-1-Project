using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GHM.Migrations
{
    /// <inheritdoc />
    public partial class I12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeedbackQuestionId",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "ModuleId",
                table: "Feedbacks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FeedbackQuestionId",
                table: "Feedbacks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModuleId",
                table: "Feedbacks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
