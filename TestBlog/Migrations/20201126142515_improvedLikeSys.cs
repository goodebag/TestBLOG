using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestBlog.Migrations
{
    public partial class improvedLikeSys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 11, 26, 15, 25, 14, 753, DateTimeKind.Local).AddTicks(7545));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 11, 26, 15, 23, 17, 760, DateTimeKind.Local).AddTicks(1274));
        }
    }
}
