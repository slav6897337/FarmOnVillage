using Microsoft.EntityFrameworkCore.Migrations;

namespace FarmOnVillage.Migrations
{
    public partial class AddFarmTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockId",
                table: "ProduktsOfAnimal",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Harvest",
                table: "Plants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StockId",
                table: "Plants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FarmId",
                table: "GardenBeds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FarmId",
                table: "Bildings",
                type: "int",
                nullable: true);

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
                name: "Farms",
                columns: table => new
                {
                    FarmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFarm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<int>(type: "int", nullable: false),
                    StockInCountryStockId = table.Column<int>(type: "int", nullable: true),
                    Money = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_ProduktsOfAnimal_StockId",
                table: "ProduktsOfAnimal",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_StockId",
                table: "Plants",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_GardenBeds_FarmId",
                table: "GardenBeds",
                column: "FarmId");

            migrationBuilder.CreateIndex(
                name: "IX_Bildings_FarmId",
                table: "Bildings",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Bildings_Farms_FarmId",
                table: "Bildings",
                column: "FarmId",
                principalTable: "Farms",
                principalColumn: "FarmId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GardenBeds_Farms_FarmId",
                table: "GardenBeds",
                column: "FarmId",
                principalTable: "Farms",
                principalColumn: "FarmId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_Stocks_StockId",
                table: "Plants",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "StockId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProduktsOfAnimal_Stocks_StockId",
                table: "ProduktsOfAnimal",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "StockId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bildings_Farms_FarmId",
                table: "Bildings");

            migrationBuilder.DropForeignKey(
                name: "FK_GardenBeds_Farms_FarmId",
                table: "GardenBeds");

            migrationBuilder.DropForeignKey(
                name: "FK_Plants_Stocks_StockId",
                table: "Plants");

            migrationBuilder.DropForeignKey(
                name: "FK_ProduktsOfAnimal_Stocks_StockId",
                table: "ProduktsOfAnimal");

            migrationBuilder.DropTable(
                name: "Farms");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_ProduktsOfAnimal_StockId",
                table: "ProduktsOfAnimal");

            migrationBuilder.DropIndex(
                name: "IX_Plants_StockId",
                table: "Plants");

            migrationBuilder.DropIndex(
                name: "IX_GardenBeds_FarmId",
                table: "GardenBeds");

            migrationBuilder.DropIndex(
                name: "IX_Bildings_FarmId",
                table: "Bildings");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "ProduktsOfAnimal");

            migrationBuilder.DropColumn(
                name: "Harvest",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "FarmId",
                table: "GardenBeds");

            migrationBuilder.DropColumn(
                name: "FarmId",
                table: "Bildings");
        }
    }
}
