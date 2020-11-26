using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestBlog.Migrations
{
    public partial class improved_like_sys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reactions");

            migrationBuilder.DropColumn(
                name: "CommentsId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ReationsId",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "WhoPosted",
                table: "Posts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GetLikes",
                columns: table => new
                {
                    LikeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WhoLiked = table.Column<string>(nullable: true),
                    Likes = table.Column<int>(nullable: false),
                    Postid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetLikes", x => x.LikeId);
                    table.ForeignKey(
                        name: "FK_GetLikes_Posts_Postid",
                        column: x => x.Postid,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 11, 26, 15, 23, 17, 760, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.CreateIndex(
                name: "IX_GetLikes_Postid",
                table: "GetLikes",
                column: "Postid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetLikes");

            migrationBuilder.DropColumn(
                name: "WhoPosted",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "CommentsId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReationsId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Reactions",
                columns: table => new
                {
                    ReactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Angry = table.Column<int>(nullable: false),
                    Care = table.Column<int>(nullable: false),
                    Hate = table.Column<int>(nullable: false),
                    LIke = table.Column<int>(nullable: false),
                    Love = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false),
                    Sad = table.Column<int>(nullable: false),
                    Wow = table.Column<int>(nullable: false)
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

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 11, 24, 8, 21, 8, 35, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_PostId",
                table: "Reactions",
                column: "PostId");
        }
    }
}
