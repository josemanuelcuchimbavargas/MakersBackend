using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class MigracionLibro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Editorial",
                keyColumn: "IdEditoria",
                keyValue: new Guid("1af92554-5333-423a-8b06-f2530e72a03f"));

            migrationBuilder.DeleteData(
                table: "Editorial",
                keyColumn: "IdEditoria",
                keyValue: new Guid("c12e9cfe-615e-4ee5-86a6-19bc01505ca6"));

            migrationBuilder.DeleteData(
                table: "Editorial",
                keyColumn: "IdEditoria",
                keyValue: new Guid("c7d99b55-c0d0-41e6-abb9-635b35fd4e6f"));

            migrationBuilder.DeleteData(
                table: "Editorial",
                keyColumn: "IdEditoria",
                keyValue: new Guid("d960a3b3-e2e8-4d9c-b54a-0e06289c4c0d"));

            migrationBuilder.DeleteData(
                table: "Editorial",
                keyColumn: "IdEditoria",
                keyValue: new Guid("e973c79a-e444-482d-96a4-ee92c073f990"));

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Editorial",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    IdLibro = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(maxLength: 40, nullable: false),
                    IdEditoria = table.Column<string>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Costo = table.Column<decimal>(nullable: false),
                    PrecioSugerido = table.Column<decimal>(nullable: false),
                    Autor = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libro", x => x.IdLibro);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libro");

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

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Editorial",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.InsertData(
                table: "Editorial",
                columns: new[] { "IdEditoria", "Nombre" },
                values: new object[,]
                {
                    { new Guid("1af92554-5333-423a-8b06-f2530e72a03f"), "Almadía" },
                    { new Guid("d960a3b3-e2e8-4d9c-b54a-0e06289c4c0d"), "Acantilado" },
                    { new Guid("c12e9cfe-615e-4ee5-86a6-19bc01505ca6"), "Aguilar" },
                    { new Guid("e973c79a-e444-482d-96a4-ee92c073f990"), "Akal" },
                    { new Guid("c7d99b55-c0d0-41e6-abb9-635b35fd4e6f"), "Alba" }
                });
        }
    }
}
