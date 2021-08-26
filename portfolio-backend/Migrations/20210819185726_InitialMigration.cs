using Microsoft.EntityFrameworkCore.Migrations;

namespace portfolio_backend.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maintitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    homehellointro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    homeprofilepiclink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    homeintro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    homeexperienceintro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numskilllogos = table.Column<int>(type: "int", nullable: false),
                    projectsheadline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    projectsintro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resumeiframesrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resumeiframeresourceurl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactinstagramlink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactvscolink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutnormal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutlight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutprofilepicdesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aboutcasualnormal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactlinkedinlink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactemaillink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactgithublink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    altportfoliolink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactemail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userid);
                });

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    experienceid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    positiontitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    timeperiod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bullet1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bullet2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.experienceid);
                    table.ForeignKey(
                        name: "FK_Experience_Users_userid",
                        column: x => x.userid,
                        principalTable: "Users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Identifier",
                columns: table => new
                {
                    identifierid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identifiername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identifier", x => x.identifierid);
                    table.ForeignKey(
                        name: "FK_Identifier_Users_userid",
                        column: x => x.userid,
                        principalTable: "Users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    projectid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projecttitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medialink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mediaorientation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projecturl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imglink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.projectid);
                    table.ForeignKey(
                        name: "FK_Project_Users_userid",
                        column: x => x.userid,
                        principalTable: "Users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Experience_userid",
                table: "Experience",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_Identifier_userid",
                table: "Identifier",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_Project_userid",
                table: "Project",
                column: "userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "Identifier");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
