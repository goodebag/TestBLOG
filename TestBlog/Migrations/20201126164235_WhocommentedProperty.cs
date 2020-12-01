using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestBlog.Migrations
{
    public partial class WhocommentedProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WhoCommented",
                table: "Comments",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "Date", "Discription" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 42, 35, 553, DateTimeKind.Local).AddTicks(8800), 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WhoCommented",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "Date", "Discription" },
                values: new object[] { new DateTime(2020, 11, 26, 15, 25, 14, 753, DateTimeKind.Local).AddTicks(7545), 3 });
        }
    }
}
