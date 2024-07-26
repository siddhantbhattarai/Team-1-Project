using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GHM.Migrations
{
    /// <inheritdoc />
    public partial class I10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ModuleId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false),
                    FeedbackQuestionId1 = table.Column<int>(type: "INTEGER", nullable: false),
                    FeedbackQuestionId2 = table.Column<int>(type: "INTEGER", nullable: false),
                    FeedbackQuestionId3 = table.Column<int>(type: "INTEGER", nullable: false),
                    FeedbackQuestionId4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Answer1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Answer2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Answer3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Answer4 = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");
        }
    }
}
