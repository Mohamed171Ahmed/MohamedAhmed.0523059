using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MohamedAhmed._0523059.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "coaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperrienceYears = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coaches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoachID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_teams_coaches_CoachID",
                        column: x => x.CoachID,
                        principalTable: "coaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_players_teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "competitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_competitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_competitions_players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "players",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompetitionTeam",
                columns: table => new
                {
                    CompetitionsId = table.Column<int>(type: "int", nullable: false),
                    TeamsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionTeam", x => new { x.CompetitionsId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_CompetitionTeam_competitions_CompetitionsId",
                        column: x => x.CompetitionsId,
                        principalTable: "competitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionTeam_teams_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_competitions_PlayerId",
                table: "competitions",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionTeam_TeamsId",
                table: "CompetitionTeam",
                column: "TeamsId");

            migrationBuilder.CreateIndex(
                name: "IX_players_TeamID",
                table: "players",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_teams_CoachID",
                table: "teams",
                column: "CoachID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_teams_Name",
                table: "teams",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompetitionTeam");

            migrationBuilder.DropTable(
                name: "competitions");

            migrationBuilder.DropTable(
                name: "players");

            migrationBuilder.DropTable(
                name: "teams");

            migrationBuilder.DropTable(
                name: "coaches");
        }
    }
}
