using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebUI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FilmCategorileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmCategorileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<double>(type: "float", nullable: false),
                    VizyonaGirisTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VizyonDanKalkisTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilmOzet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilmSuresi = table.Column<double>(type: "float", nullable: false),
                    FilmYönetmeni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilmPosterFotografYolu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seanslar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Saati = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seanslar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmFilmCategori",
                columns: table => new
                {
                    FilmCategorisId = table.Column<int>(type: "int", nullable: false),
                    FilmsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmFilmCategori", x => new { x.FilmCategorisId, x.FilmsId });
                    table.ForeignKey(
                        name: "FK_FilmFilmCategori_FilmCategorileri_FilmCategorisId",
                        column: x => x.FilmCategorisId,
                        principalTable: "FilmCategorileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmFilmCategori_Filmler_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Filmler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmSeans",
                columns: table => new
                {
                    FilmlerId = table.Column<int>(type: "int", nullable: false),
                    SeanslarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmSeans", x => new { x.FilmlerId, x.SeanslarId });
                    table.ForeignKey(
                        name: "FK_FilmSeans_Filmler_FilmlerId",
                        column: x => x.FilmlerId,
                        principalTable: "Filmler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmSeans_Seanslar_SeanslarId",
                        column: x => x.SeanslarId,
                        principalTable: "Seanslar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FilmCategorileri",
                columns: new[] { "Id", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, "Aksiyon" },
                    { 2, "Animasyon" },
                    { 3, "BilimKurgu" },
                    { 4, "Fantastik" },
                    { 5, "Gerilim" },
                    { 6, "Komedi" }
                });

            migrationBuilder.InsertData(
                table: "Seanslar",
                columns: new[] { "Id", "Saati" },
                values: new object[,]
                {
                    { 1, "10:00" },
                    { 2, "12:00" },
                    { 3, "14:00" },
                    { 4, "16:00" },
                    { 5, "18:00" },
                    { 6, "20:00" },
                    { 7, "22:00" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmFilmCategori_FilmsId",
                table: "FilmFilmCategori",
                column: "FilmsId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmSeans_SeanslarId",
                table: "FilmSeans",
                column: "SeanslarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmFilmCategori");

            migrationBuilder.DropTable(
                name: "FilmSeans");

            migrationBuilder.DropTable(
                name: "FilmCategorileri");

            migrationBuilder.DropTable(
                name: "Filmler");

            migrationBuilder.DropTable(
                name: "Seanslar");
        }
    }
}
