using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharp_Web_Workshop_ForumApp.Data.Migrations
{
    public partial class CreateAndSeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { new Guid("106d87e9-acd8-4541-9868-b67d05bb5ec2"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam interdum consectetur dictum. Proin nisi.", "My third post" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { new Guid("5d74612e-43ce-43b9-bf67-be6a38204515"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris id lobortis odio. Orci varius natoque penatibus et magnis dis parturient.", "My first post" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { new Guid("e6ca5ddb-fd60-4ca0-9614-23694b7d2a41"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec metus ipsum, scelerisque at velit ut, ultricies varius lorem.", "My second post" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
