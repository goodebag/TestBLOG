using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestBlog.Migrations
{
    public partial class UpdateRelationVarID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Posts",
                newName: "ReationsId");

            migrationBuilder.AddColumn<int>(
                name: "CommentsId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 11, 18, 14, 26, 2, 929, DateTimeKind.Local).AddTicks(2150));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentsId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "ReationsId",
                table: "Posts",
                newName: "CommentId");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 11, 18, 14, 8, 17, 831, DateTimeKind.Local).AddTicks(8960));
        }
    }
}
