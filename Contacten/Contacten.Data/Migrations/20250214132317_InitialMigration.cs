using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Contacten.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacten",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gemeente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefoon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Geboortedatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacten", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacten",
                columns: new[] { "ContactId", "Adres", "Email", "Geboortedatum", "Gemeente", "Naam", "Postcode", "Telefoon", "Voornaam" },
                values: new object[,]
                {
                    { 1, "Somersstraat 22", "jesse.james@vdab.be", new DateTime(1966, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "James", "2018", "032021711", "Jesse" },
                    { 2, "Interleuvenlaan 2", "jane.calamity@vdab.be", new DateTime(1967, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heverlee", "Calamity", "3001", "016380000", "Jane" },
                    { 3, "Vlamingstraat 10", "billy.thekid@vdab.be", new DateTime(1968, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wevelgem", "The Kid", "8560", "056438080", "Billy" },
                    { 4, "Industrieweg 50", "sarah.bernhardt@vdab.be", new DateTime(1969, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wondelgem", "Bernhardt", "9032", "092541111", "Sarah" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacten");
        }
    }
}
