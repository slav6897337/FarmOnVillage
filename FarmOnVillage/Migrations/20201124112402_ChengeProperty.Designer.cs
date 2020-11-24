﻿// <auto-generated />
using System;
using FarmOnVillage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FarmOnVillage.Migrations
{
    [DbContext(typeof(FarmContext))]
    [Migration("20201124112402_ChengeProperty")]
    partial class ChengeProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("FarmOnVillage.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("BildingId")
                        .HasColumnType("int");

                    b.Property<bool>("IsMultyHarvest")
                        .HasColumnType("bit");

                    b.Property<int?>("MarketId")
                        .HasColumnType("int");

                    b.Property<string>("NameAnimal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProduktAnimalProduktOfAnimalId")
                        .HasColumnType("int");

                    b.Property<int?>("RawMaterialId")
                        .HasColumnType("int");

                    b.Property<int>("TimeBetweenHarvests")
                        .HasColumnType("int");

                    b.HasKey("AnimalId");

                    b.HasIndex("BildingId");

                    b.HasIndex("MarketId");

                    b.HasIndex("ProduktAnimalProduktOfAnimalId");

                    b.HasIndex("RawMaterialId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("FarmOnVillage.Bilding", b =>
                {
                    b.Property<int>("BildingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AriaOfBilding")
                        .HasColumnType("int");

                    b.Property<int>("ContentAnimals")
                        .HasColumnType("int");

                    b.Property<int?>("FarmId")
                        .HasColumnType("int");

                    b.Property<string>("NameBilding")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BildingId");

                    b.HasIndex("FarmId");

                    b.ToTable("Bildings");
                });

            modelBuilder.Entity("FarmOnVillage.Farm", b =>
                {
                    b.Property<int>("FarmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<int?>("MarketForFarmMarketId")
                        .HasColumnType("int");

                    b.Property<decimal>("Money")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("NameFarm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RawMaterialOnFarmRawMaterialId")
                        .HasColumnType("int");

                    b.Property<int?>("StockInCountryStockId")
                        .HasColumnType("int");

                    b.HasKey("FarmId");

                    b.HasIndex("MarketForFarmMarketId");

                    b.HasIndex("RawMaterialOnFarmRawMaterialId");

                    b.HasIndex("StockInCountryStockId");

                    b.ToTable("Farms");
                });

            modelBuilder.Entity("FarmOnVillage.GardenBed", b =>
                {
                    b.Property<int>("GardenBedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("FarmId")
                        .HasColumnType("int");

                    b.Property<int>("Square")
                        .HasColumnType("int");

                    b.HasKey("GardenBedId");

                    b.HasIndex("FarmId");

                    b.ToTable("GardenBeds");
                });

            modelBuilder.Entity("FarmOnVillage.Market", b =>
                {
                    b.Property<int>("MarketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("MarketId");

                    b.ToTable("Markets");
                });

            modelBuilder.Entity("FarmOnVillage.Plant", b =>
                {
                    b.Property<int>("PlantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AriaOfSeat")
                        .HasColumnType("int");

                    b.Property<int?>("GardenBedId")
                        .HasColumnType("int");

                    b.Property<int>("Harvest")
                        .HasColumnType("int");

                    b.Property<bool>("IsMultyHarvest")
                        .HasColumnType("bit");

                    b.Property<string>("NamePlant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("RawMaterialId")
                        .HasColumnType("int");

                    b.Property<int>("SeasonGather")
                        .HasColumnType("int");

                    b.Property<int>("SeasonSeat")
                        .HasColumnType("int");

                    b.Property<int?>("StockId")
                        .HasColumnType("int");

                    b.HasKey("PlantId");

                    b.HasIndex("GardenBedId");

                    b.HasIndex("RawMaterialId");

                    b.HasIndex("StockId");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("FarmOnVillage.ProduktOfAnimal", b =>
                {
                    b.Property<int>("ProduktOfAnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Mass")
                        .HasColumnType("int");

                    b.Property<string>("NameProduktOfAnimal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("StockId")
                        .HasColumnType("int");

                    b.HasKey("ProduktOfAnimalId");

                    b.HasIndex("StockId");

                    b.ToTable("ProduktsOfAnimal");
                });

            modelBuilder.Entity("FarmOnVillage.RawMaterial", b =>
                {
                    b.Property<int>("RawMaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("RawMaterialId");

                    b.ToTable("RawMaterials");
                });

            modelBuilder.Entity("FarmOnVillage.Seed", b =>
                {
                    b.Property<int>("SeedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("MarketId")
                        .HasColumnType("int");

                    b.Property<string>("PlantsSeed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SeasonSeat")
                        .HasColumnType("int");

                    b.HasKey("SeedId");

                    b.HasIndex("MarketId");

                    b.ToTable("Seeds");
                });

            modelBuilder.Entity("FarmOnVillage.Stock", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("VolumeStock")
                        .HasColumnType("int");

                    b.HasKey("StockId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("FarmOnVillage.Animal", b =>
                {
                    b.HasOne("FarmOnVillage.Bilding", null)
                        .WithMany("AnimalsOnBild")
                        .HasForeignKey("BildingId");

                    b.HasOne("FarmOnVillage.Market", null)
                        .WithMany("AnimalsToBuy")
                        .HasForeignKey("MarketId");

                    b.HasOne("FarmOnVillage.ProduktOfAnimal", "ProduktAnimal")
                        .WithMany()
                        .HasForeignKey("ProduktAnimalProduktOfAnimalId");

                    b.HasOne("FarmOnVillage.RawMaterial", null)
                        .WithMany("AnimalsFree")
                        .HasForeignKey("RawMaterialId");

                    b.Navigation("ProduktAnimal");
                });

            modelBuilder.Entity("FarmOnVillage.Bilding", b =>
                {
                    b.HasOne("FarmOnVillage.Farm", null)
                        .WithMany("BildingFarm")
                        .HasForeignKey("FarmId");
                });

            modelBuilder.Entity("FarmOnVillage.Farm", b =>
                {
                    b.HasOne("FarmOnVillage.Market", "MarketForFarm")
                        .WithMany()
                        .HasForeignKey("MarketForFarmMarketId");

                    b.HasOne("FarmOnVillage.RawMaterial", "RawMaterialOnFarm")
                        .WithMany()
                        .HasForeignKey("RawMaterialOnFarmRawMaterialId");

                    b.HasOne("FarmOnVillage.Stock", "StockInCountry")
                        .WithMany()
                        .HasForeignKey("StockInCountryStockId");

                    b.Navigation("MarketForFarm");

                    b.Navigation("RawMaterialOnFarm");

                    b.Navigation("StockInCountry");
                });

            modelBuilder.Entity("FarmOnVillage.GardenBed", b =>
                {
                    b.HasOne("FarmOnVillage.Farm", null)
                        .WithMany("GardenBedFarm")
                        .HasForeignKey("FarmId");
                });

            modelBuilder.Entity("FarmOnVillage.Plant", b =>
                {
                    b.HasOne("FarmOnVillage.GardenBed", null)
                        .WithMany("PlantsBed")
                        .HasForeignKey("GardenBedId");

                    b.HasOne("FarmOnVillage.RawMaterial", null)
                        .WithMany("PlantsFree")
                        .HasForeignKey("RawMaterialId");

                    b.HasOne("FarmOnVillage.Stock", null)
                        .WithMany("Plants")
                        .HasForeignKey("StockId");
                });

            modelBuilder.Entity("FarmOnVillage.ProduktOfAnimal", b =>
                {
                    b.HasOne("FarmOnVillage.Stock", null)
                        .WithMany("ProduktsOfAnimal")
                        .HasForeignKey("StockId");
                });

            modelBuilder.Entity("FarmOnVillage.Seed", b =>
                {
                    b.HasOne("FarmOnVillage.Market", null)
                        .WithMany("SeedsToBuy")
                        .HasForeignKey("MarketId");
                });

            modelBuilder.Entity("FarmOnVillage.Bilding", b =>
                {
                    b.Navigation("AnimalsOnBild");
                });

            modelBuilder.Entity("FarmOnVillage.Farm", b =>
                {
                    b.Navigation("BildingFarm");

                    b.Navigation("GardenBedFarm");
                });

            modelBuilder.Entity("FarmOnVillage.GardenBed", b =>
                {
                    b.Navigation("PlantsBed");
                });

            modelBuilder.Entity("FarmOnVillage.Market", b =>
                {
                    b.Navigation("AnimalsToBuy");

                    b.Navigation("SeedsToBuy");
                });

            modelBuilder.Entity("FarmOnVillage.RawMaterial", b =>
                {
                    b.Navigation("AnimalsFree");

                    b.Navigation("PlantsFree");
                });

            modelBuilder.Entity("FarmOnVillage.Stock", b =>
                {
                    b.Navigation("Plants");

                    b.Navigation("ProduktsOfAnimal");
                });
#pragma warning restore 612, 618
        }
    }
}
