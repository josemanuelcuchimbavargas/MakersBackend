using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class MigracionEditorial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Editorial",
                columns: table => new
                {
                    IdEditoria = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editorial", x => x.IdEditoria);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Editorial");
        }
    }
}
