using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class MigracionLibroUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Editorial",
                keyColumn: "IdEditoria",
                keyValue: new Guid("2abf04b4-c6ab-4646-a2f3-c77600eb586f"));

            migrationBuilder.DeleteData(
                table: "Editorial",
                keyColumn: "IdEditoria",
                keyValue: new Guid("2c75655c-6b7f-4e5a-aa24-d8b0db8ab239"));

            migrationBuilder.DeleteData(
                table: "Editorial",
                keyColumn: "IdEditoria",
                keyValue: new Guid("614e15cc-9fd0-43bd-aa61-c87ff869250d"));

            migrationBuilder.DeleteData(
                table: "Editorial",
                keyColumn: "IdEditoria",
                keyValue: new Guid("7e072a51-1b2a-4a68-afa2-dc416f2eb2a8"));

            migrationBuilder.DeleteData(
                table: "Editorial",
                keyColumn: "IdEditoria",
                keyValue: new Guid("fab3257e-fecb-490a-9f28-830b8cf71a19"));

            migrationBuilder.AlterColumn<Guid>(
                name: "IdEditoria",
                table: "Libro",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Editorial",
                columns: new[] { "IdEditoria", "Nombre" },
                values: new object[,]
                {
                    { new Guid("271cced2-6437-424c-8a1a-fa3988e2ae24"), "Almadía" },
                    { new Guid("9f30d4ce-bf1f-4964-be63-2036a4738764"), "Acantilado" },
                    { new Guid("cf9e0c41-2605-4821-8c62-228491d14a3d"), "Aguilar" },
                    { new Guid("5256401b-e0f4-44ad-9be3-18fccdae0aff"), "Akal" },
                    { new Guid("fcf8403f-8b37-4ffa-95bc-162b07694847"), "Alba" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Editorial",
                keyColumn: "IdEditoria",
                keyValue: new Guid("271cced2-6437-424c-8a1a-fa3988e2ae24"));

            migrationBuilder.DeleteData(
                table: "Editorial",
                keyColumn: "IdEditoria",
                keyValue: new Guid("5256401b-e0f4-44ad-9be3-18fccdae0aff"));

            migrationBuilder.DeleteData(
                table: "Editorial",
                keyColumn: "IdEditoria",
                keyValue: new Guid("9f30d4ce-bf1f-4964-be63-2036a4738764"));

            migrationBuilder.DeleteData(
                table: "Editorial",
                keyColumn: "IdEditoria",
                keyValue: new Guid("cf9e0c41-2605-4821-8c62-228491d14a3d"));

            migrationBuilder.DeleteData(
                table: "Editorial",
                keyColumn: "IdEditoria",
                keyValue: new Guid("fcf8403f-8b37-4ffa-95bc-162b07694847"));

            migrationBuilder.AlterColumn<string>(
                name: "IdEditoria",
                table: "Libro",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.InsertData(
                table: "Editorial",
                columns: new[] { "IdEditoria", "Nombre" },
                values: new object[,]
                {
                    { new Guid("7e072a51-1b2a-4a68-afa2-dc416f2eb2a8"), "Almadía" },
                    { new Guid("fab3257e-fecb-490a-9f28-830b8cf71a19"), "Acantilado" },
                    { new Guid("614e15cc-9fd0-43bd-aa61-c87ff869250d"), "Aguilar" },
                    { new Guid("2abf04b4-c6ab-4646-a2f3-c77600eb586f"), "Akal" },
                    { new Guid("2c75655c-6b7f-4e5a-aa24-d8b0db8ab239"), "Alba" }
                });
        }
    }
}
