using Microsoft.EntityFrameworkCore.Migrations;

namespace Farm.Data.Migrations
{
    public partial class CreateFarmBd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Stocks",
                columns: table => new
                {
                    StockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolumeStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockId);
                });

            migrationBuilder.CreateTable(
                name: "Seeds",
                columns: table => new
                {
                    SeedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantsSeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeasonSeat = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                name: "Farms",
                columns: table => new
                {
                    FarmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFarm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<int>(type: "int", nullable: false),
                    StockInCountryStockId = table.Column<int>(type: "int", nullable: true),
                    Money = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketForFarmMarketId = table.Column<int>(type: "int", nullable: true),
                    RawMaterialOnFarmRawMaterialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farms", x => x.FarmId);
                    table.ForeignKey(
                        name: "FK_Farms_Markets_MarketForFarmMarketId",
                        column: x => x.MarketForFarmMarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Farms_RawMaterials_RawMaterialOnFarmRawMaterialId",
                        column: x => x.RawMaterialOnFarmRawMaterialId,
                        principalTable: "RawMaterials",
                        principalColumn: "RawMaterialId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Farms_Stocks_StockInCountryStockId",
                        column: x => x.StockInCountryStockId,
                        principalTable: "Stocks",
                        principalColumn: "StockId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProduktsOfAnimal",
                columns: table => new
                {
                    ProduktOfAnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProduktOfAnimal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mass = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduktsOfAnimal", x => x.ProduktOfAnimalId);
                    table.ForeignKey(
                        name: "FK_ProduktsOfAnimal_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "StockId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameBuilding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AriaOfBuilding = table.Column<int>(type: "int", nullable: false),
                    ContentAnimals = table.Column<int>(type: "int", nullable: false),
                    FarmId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.BuildingId);
                    table.ForeignKey(
                        name: "FK_Buildings_Farms_FarmId",
                        column: x => x.FarmId,
                        principalTable: "Farms",
                        principalColumn: "FarmId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GardenBeds",
                columns: table => new
                {
                    GardenBedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Square = table.Column<int>(type: "int", nullable: false),
                    FarmId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GardenBeds", x => x.GardenBedId);
                    table.ForeignKey(
                        name: "FK_GardenBeds_Farms_FarmId",
                        column: x => x.FarmId,
                        principalTable: "Farms",
                        principalColumn: "FarmId",
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
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: true),
                    MarketId = table.Column<int>(type: "int", nullable: true),
                    RawMaterialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                    table.ForeignKey(
                        name: "FK_Animals_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "BuildingId",
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
                    Harvest = table.Column<int>(type: "int", nullable: false),
                    GardenBedId = table.Column<int>(type: "int", nullable: true),
                    RawMaterialId = table.Column<int>(type: "int", nullable: true),
                    StockId = table.Column<int>(type: "int", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Plants_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "StockId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_BuildingId",
                table: "Animals",
                column: "BuildingId");

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
                name: "IX_Buildings_FarmId",
                table: "Buildings",
                column: "FarmId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_MarketForFarmMarketId",
                table: "Farms",
                column: "MarketForFarmMarketId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_RawMaterialOnFarmRawMaterialId",
                table: "Farms",
                column: "RawMaterialOnFarmRawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Farms_StockInCountryStockId",
                table: "Farms",
                column: "StockInCountryStockId");

            migrationBuilder.CreateIndex(
                name: "IX_GardenBeds_FarmId",
                table: "GardenBeds",
                column: "FarmId");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_GardenBedId",
                table: "Plants",
                column: "GardenBedId");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_RawMaterialId",
                table: "Plants",
                column: "RawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_StockId",
                table: "Plants",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_ProduktsOfAnimal_StockId",
                table: "ProduktsOfAnimal",
                column: "StockId");

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
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "ProduktsOfAnimal");

            migrationBuilder.DropTable(
                name: "GardenBeds");

            migrationBuilder.DropTable(
                name: "Farms");

            migrationBuilder.DropTable(
                name: "Markets");

            migrationBuilder.DropTable(
                name: "RawMaterials");

            migrationBuilder.DropTable(
                name: "Stocks");
        }
    }
}
