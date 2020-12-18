using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestBlog.Migrations
{
    public partial class EmailNotificationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "EmailAddresses",
                columns: table => new
                {
                    EmailAddress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAddresses", x => x.EmailAddress);
                });

            migrationBuilder.InsertData(
                table: "EmailAddresses",
                column: "EmailAddress",
                value: "egbule.Smart@gmail.com");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailAddresses");

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Date", "Discription", "Headline", "Photopath", "PosterPhotopath", "WhoPosted", "postWriteUp" },
                values: new object[] { 1, new DateTime(2020, 12, 2, 13, 24, 37, 8, DateTimeKind.Local).AddTicks(315), 2, "End Swat: Nigerians reject police unit replacing", "no to swat.jpg", null, null, "Nigerians are outraged by the unveiling of a new police unit to replace a notorious agency that was disbanded following public outcry over its alleged human rights abuses. he head of the police Mohammed Adamu announced that Swat would carry out the duties which were done by the Special Anti Robbery Squad(Sars). But many are using the hashtag #EndSwat on Twitter to oppose the new unit.They see the changes as not enough to reform the police." });
        }
    }
}
