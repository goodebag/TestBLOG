using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestBlog.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Photopath = table.Column<string>(nullable: true),
                    postWriteUp = table.Column<string>(nullable: true),
                    Discription = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Headline = table.Column<string>(nullable: true),
                    CommentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    comments = table.Column<string>(nullable: true),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reactions",
                columns: table => new
                {
                    ReactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LIke = table.Column<int>(nullable: false),
                    Love = table.Column<int>(nullable: false),
                    Sad = table.Column<int>(nullable: false),
                    Angry = table.Column<int>(nullable: false),
                    Wow = table.Column<int>(nullable: false),
                    Care = table.Column<int>(nullable: false),
                    Hate = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.ReactionId);
                    table.ForeignKey(
                        name: "FK_Reactions_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CommentId", "Date", "Discription", "Headline", "Photopath", "postWriteUp" },
                values: new object[] { 1, 0, new DateTime(2020, 11, 18, 14, 8, 17, 831, DateTimeKind.Local).AddTicks(8960), 2, "End Swat: Nigerians reject police unit replacing", "no to swat.jpg", "Nigerians are outraged by the unveiling of a new police unit to replace a notorious agency that was disbanded following public outcry over its alleged human rights abuses. he head of the police Mohammed Adamu announced that Swat would carry out the duties which were done by the Special Anti Robbery Squad(Sars). But many are using the hashtag #EndSwat on Twitter to oppose the new unit.They see the changes as not enough to reform the police." });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_PostId",
                table: "Reactions",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Reactions");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
