using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataDashboard.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentSocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    AcademicLevel = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    AvgDailyUsageHours = table.Column<decimal>(type: "TEXT", nullable: false),
                    MostUsedPlatform = table.Column<string>(type: "TEXT", nullable: false),
                    AffectsAcademicPerformance = table.Column<bool>(type: "INTEGER", nullable: false),
                    SleepHoursPerNight = table.Column<decimal>(type: "TEXT", nullable: false),
                    MentalHealthScore = table.Column<int>(type: "INTEGER", nullable: false),
                    RelationshipStatus = table.Column<string>(type: "TEXT", nullable: false),
                    ConflictsOverSocialMedia = table.Column<int>(type: "INTEGER", nullable: false),
                    AddictionScore = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSocialMedias", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentSocialMedias");
        }
    }
}
