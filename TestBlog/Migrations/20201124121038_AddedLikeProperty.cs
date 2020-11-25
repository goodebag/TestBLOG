using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestBlog.Migrations
{
    public partial class AddedLikeProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 11, 24, 13, 10, 38, 304, DateTimeKind.Local).AddTicks(3349));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 11, 24, 8, 21, 8, 35, DateTimeKind.Local).AddTicks(2378));
        }
    }
}
