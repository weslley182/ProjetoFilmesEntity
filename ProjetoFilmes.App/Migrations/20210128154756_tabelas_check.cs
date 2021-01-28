using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjetoFilmes.App.Migrations
{
    public partial class tabelas_check : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Last_Update",
                table: "Language",
                type: "DateTime",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2021, 1, 28, 12, 16, 59, 160, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Last_Update",
                table: "Film_Actor",
                type: "DateTime",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2021, 1, 28, 12, 16, 59, 154, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Last_Update",
                table: "Film",
                type: "DateTime",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2021, 1, 28, 12, 16, 59, 131, DateTimeKind.Local));

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Film",
                type: "Varchar(10)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Last_Update",
                table: "Category",
                type: "DateTime",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2021, 1, 28, 12, 16, 59, 157, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Last_Update",
                table: "Actor",
                type: "DateTime",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2021, 1, 28, 12, 16, 59, 115, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Film");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Last_Update",
                table: "Language",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 28, 12, 16, 59, 160, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Last_Update",
                table: "Film_Actor",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 28, 12, 16, 59, 154, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Last_Update",
                table: "Film",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 28, 12, 16, 59, 131, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Last_Update",
                table: "Category",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 28, 12, 16, 59, 157, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Last_Update",
                table: "Actor",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 28, 12, 16, 59, 115, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValueSql: "GetDate()");
        }
    }
}
