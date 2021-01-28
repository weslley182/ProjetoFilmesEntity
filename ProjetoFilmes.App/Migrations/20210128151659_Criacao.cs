using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjetoFilmes.App.Migrations
{
    public partial class Criacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    Actor_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Last_Update = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValue: new DateTime(2021, 1, 28, 12, 16, 59, 115, DateTimeKind.Local)),
                    First_Name = table.Column<string>(type: "Varchar(45)", nullable: false),
                    Last_Name = table.Column<string>(type: "Varchar(45)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Actor_Id);
                    table.UniqueConstraint("AK_Actor_First_Name_Last_Name", x => new { x.First_Name, x.Last_Name });
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Category_Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Last_Update = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValue: new DateTime(2021, 1, 28, 12, 16, 59, 157, DateTimeKind.Local)),
                    Name = table.Column<string>(type: "Varchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Category_Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    language_Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Last_Update = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValue: new DateTime(2021, 1, 28, 12, 16, 59, 160, DateTimeKind.Local)),
                    Name = table.Column<string>(type: "char(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.language_Id);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    Film_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Release_Year = table.Column<string>(type: "Varchar(4)", nullable: true),
                    Description = table.Column<string>(type: "Text", nullable: true),
                    Length = table.Column<short>(type: "smallint", nullable: false),
                    Language_Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Last_Update = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValue: new DateTime(2021, 1, 28, 12, 16, 59, 131, DateTimeKind.Local)),
                    Original_Language_Id = table.Column<byte>(type: "tinyint", nullable: true),
                    Title = table.Column<string>(type: "Varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.Film_Id);
                    table.ForeignKey(
                        name: "FK_Film_Language_Language_Id",
                        column: x => x.Language_Id,
                        principalTable: "Language",
                        principalColumn: "language_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Film_Language_Original_Language_Id",
                        column: x => x.Original_Language_Id,
                        principalTable: "Language",
                        principalColumn: "language_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Film_Actor",
                columns: table => new
                {
                    Film_Id = table.Column<int>(type: "int", nullable: false),
                    Actor_Id = table.Column<int>(type: "int", nullable: false),
                    Last_Update = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValue: new DateTime(2021, 1, 28, 12, 16, 59, 154, DateTimeKind.Local))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film_Actor", x => new { x.Film_Id, x.Actor_Id });
                    table.ForeignKey(
                        name: "FK_Film_Actor_Actor_Actor_Id",
                        column: x => x.Actor_Id,
                        principalTable: "Actor",
                        principalColumn: "Actor_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Film_Actor_Film_Film_Id",
                        column: x => x.Film_Id,
                        principalTable: "Film",
                        principalColumn: "Film_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Film_Category",
                columns: table => new
                {
                    Film_Id = table.Column<int>(type: "int", nullable: false),
                    Category_Id = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film_Category", x => new { x.Film_Id, x.Category_Id });
                    table.ForeignKey(
                        name: "FK_Film_Category_Category_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "Category",
                        principalColumn: "Category_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Film_Category_Film_Film_Id",
                        column: x => x.Film_Id,
                        principalTable: "Film",
                        principalColumn: "Film_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "idx_actor_last_name",
                table: "Actor",
                column: "Last_Name");

            migrationBuilder.CreateIndex(
                name: "IX_Film_Language_Id",
                table: "Film",
                column: "Language_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Film_Original_Language_Id",
                table: "Film",
                column: "Original_Language_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Film_Actor_Actor_Id",
                table: "Film_Actor",
                column: "Actor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Film_Category_Category_Id",
                table: "Film_Category",
                column: "Category_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Film_Actor");

            migrationBuilder.DropTable(
                name: "Film_Category");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "Language");
        }
    }
}
