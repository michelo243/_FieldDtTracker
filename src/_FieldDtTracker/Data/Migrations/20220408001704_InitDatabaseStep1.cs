using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _FieldDtTracker.Data.Migrations
{
    public partial class InitDatabaseStep1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departements_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Communes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartementId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Communes_Departements_DepartementId",
                        column: x => x.DepartementId,
                        principalTable: "Departements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HACPtables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommuneId = table.Column<int>(type: "int", nullable: true),
                    Organisation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeActivite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Projet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrincipalBailleur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bailleur_Secondaire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bailleur_Secondaire2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeBailleur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QteBailleur = table.Column<int>(type: "int", nullable: false),
                    Annee = table.Column<int>(type: "int", nullable: false),
                    Cible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Beneficiaire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    International = table.Column<bool>(type: "bit", nullable: true),
                    BudgetTotalProjet = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HACPtables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HACPtables_Communes_CommuneId",
                        column: x => x.CommuneId,
                        principalTable: "Communes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Communes_DepartementId",
                table: "Communes",
                column: "DepartementId");

            migrationBuilder.CreateIndex(
                name: "IX_Departements_RegionId",
                table: "Departements",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_HACPtables_CommuneId",
                table: "HACPtables",
                column: "CommuneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HACPtables");

            migrationBuilder.DropTable(
                name: "Communes");

            migrationBuilder.DropTable(
                name: "Departements");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");
        }
    }
}
