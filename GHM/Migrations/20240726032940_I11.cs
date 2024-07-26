using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GHM.Migrations
{
    /// <inheritdoc />
    public partial class I11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer1",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Answer2",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Answer3",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Answer4",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "FeedbackQuestionId1",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "FeedbackQuestionId2",
                table: "Feedbacks");

            migrationBuilder.RenameColumn(
                name: "FeedbackQuestionId4",
                table: "Feedbacks",
                newName: "FeedbackQuestionId");

            migrationBuilder.RenameColumn(
                name: "FeedbackQuestionId3",
                table: "Feedbacks",
                newName: "Answer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FeedbackQuestionId",
                table: "Feedbacks",
                newName: "FeedbackQuestionId4");

            migrationBuilder.RenameColumn(
                name: "Answer",
                table: "Feedbacks",
                newName: "FeedbackQuestionId3");

            migrationBuilder.AddColumn<int>(
                name: "Answer1",
                table: "Feedbacks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Answer2",
                table: "Feedbacks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Answer3",
                table: "Feedbacks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Answer4",
                table: "Feedbacks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FeedbackQuestionId1",
                table: "Feedbacks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FeedbackQuestionId2",
                table: "Feedbacks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
