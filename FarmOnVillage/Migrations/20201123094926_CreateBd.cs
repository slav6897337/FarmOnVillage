using Microsoft.EntityFrameworkCore.Migrations;

namespace FarmOnVillage.Migrations
{
    public partial class CreateBd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bildings",
                columns: table => new
                {
                    BildingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameBilding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AriaOfBilding = table.Column<int>(type: "int", nullable: false),
                    ContentAnimals = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bildings", x => x.BildingId);
                });

            migrationBuilder.CreateTable(
                name: "GardenBeds",
                columns: table => new
                {
                    GardenBedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Square = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GardenBeds", x => x.GardenBedId);
                });

            migrationBuilder.CreateTable(
                name: "Markets",
                columns: table => new
                {
                    MarketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markets", x => x.MarketId);
                });

            migrationBuilder.CreateTable(
                name: "ProduktsOfAnimal",
                columns: table => new
                {
                    ProduktOfAnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProduktOfAnimal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mass = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduktsOfAnimal", x => x.ProduktOfAnimalId);
                });

            migrationBuilder.CreateTable(
                name: "RawMaterials",
                columns: table => new
                {
                    RawMaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawMaterials", x => x.RawMaterialId);
                });

            migrationBuilder.CreateTable(
                name: "Seeds",
                columns: table => new
                {
                    SeedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantsSeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeasonSeat = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    MarketId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seeds", x => x.SeedId);
                    table.ForeignKey(
                        name: "FK_Seeds_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAnimal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProduktAnimalProduktOfAnimalId = table.Column<int>(type: "int", nullable: true),
                    IsMultyHarvest = table.Column<bool>(type: "bit", nullable: false),
                    TimeBetweenHarvests = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    BildingId = table.Column<int>(type: "int", nullable: true),
                    MarketId = table.Column<int>(type: "int", nullable: true),
                    RawMaterialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                    table.ForeignKey(
                        name: "FK_Animals_Bildings_BildingId",
                        column: x => x.BildingId,
                        principalTable: "Bildings",
                        principalColumn: "BildingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Animals_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Animals_ProduktsOfAnimal_ProduktAnimalProduktOfAnimalId",
                        column: x => x.ProduktAnimalProduktOfAnimalId,
                        principalTable: "ProduktsOfAnimal",
                        principalColumn: "ProduktOfAnimalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Animals_RawMaterials_RawMaterialId",
                        column: x => x.RawMaterialId,
                        principalTable: "RawMaterials",
                        principalColumn: "RawMaterialId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    PlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePlant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeasonSeat = table.Column<int>(type: "int", nullable: false),
                    SeasonGather = table.Column<int>(type: "int", nullable: false),
                    AriaOfSeat = table.Column<int>(type: "int", nullable: false),
                    IsMultyHarvest = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    GardenBedId = table.Column<int>(type: "int", nullable: true),
                    RawMaterialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.PlantId);
                    table.ForeignKey(
                        name: "FK_Plants_GardenBeds_GardenBedId",
                        column: x => x.GardenBedId,
                        principalTable: "GardenBeds",
                        principalColumn: "GardenBedId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Plants_RawMaterials_RawMaterialId",
                        column: x => x.RawMaterialId,
                        principalTable: "RawMaterials",
                        principalColumn: "RawMaterialId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_BildingId",
                table: "Animals",
                column: "BildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_MarketId",
                table: "Animals",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_ProduktAnimalProduktOfAnimalId",
                table: "Animals",
                column: "ProduktAnimalProduktOfAnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_RawMaterialId",
                table: "Animals",
                column: "RawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_GardenBedId",
                table: "Plants",
                column: "GardenBedId");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_RawMaterialId",
                table: "Plants",
                column: "RawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Seeds_MarketId",
                table: "Seeds",
                column: "MarketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropTable(
                name: "Seeds");

            migrationBuilder.DropTable(
                name: "Bildings");

            migrationBuilder.DropTable(
                name: "ProduktsOfAnimal");

            migrationBuilder.DropTable(
                name: "GardenBeds");

            migrationBuilder.DropTable(
                name: "RawMaterials");

            migrationBuilder.DropTable(
                name: "Markets");
        }
    }
}
