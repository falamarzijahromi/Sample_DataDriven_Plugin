using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugin.Repositories.EFCore.Migrations
{
    public partial class AddedSomethingElse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SomethingElseBySample",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    sampleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SomethingElseBySample", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SomethingElseBySample");
        }
    }
}
