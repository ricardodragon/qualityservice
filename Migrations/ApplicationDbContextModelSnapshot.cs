﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using qualityservice.Data;
using System;

namespace qualityservice.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("qualityservice.Model.Analysis", b =>
                {
                    b.Property<int>("analysisId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cobreFosforoso");

                    b.Property<long>("datetime");

                    b.Property<int>("number");

                    b.Property<int?>("productionOrderQualityId");

                    b.Property<string>("status");

                    b.HasKey("analysisId");

                    b.HasIndex("productionOrderQualityId");

                    b.ToTable("Analyses");
                });

            modelBuilder.Entity("qualityservice.Model.AnalysisComp", b =>
                {
                    b.Property<int>("analysisCompId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("analysisId");

                    b.Property<int>("productId");

                    b.Property<string>("productName");

                    b.Property<double>("value");

                    b.Property<double>("valueKg");

                    b.HasKey("analysisCompId");

                    b.HasIndex("analysisId");

                    b.ToTable("AnalysisComps");
                });

            modelBuilder.Entity("qualityservice.Model.MessageCalculates", b =>
                {
                    b.Property<int>("messageId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("analysisId");

                    b.Property<string>("key");

                    b.Property<int?>("productionOrderQualityId");

                    b.Property<string>("value");

                    b.HasKey("messageId");

                    b.HasIndex("analysisId");

                    b.HasIndex("productionOrderQualityId");

                    b.ToTable("MessagesCalculates");
                });

            modelBuilder.Entity("qualityservice.Model.ProductionOrderQuality", b =>
                {
                    b.Property<int>("productionOrderQualityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CobreFosforosoAtual");

                    b.Property<int>("corrida");

                    b.Property<string>("forno");

                    b.Property<string>("posicao");

                    b.Property<int>("productionOrderId");

                    b.Property<string>("productionOrderNumber");

                    b.Property<double>("qntForno");

                    b.Property<string>("recipeCode");

                    b.Property<string>("status");

                    b.HasKey("productionOrderQualityId");

                    b.ToTable("ProductionOrderQualities");
                });

            modelBuilder.Entity("qualityservice.Model.Analysis", b =>
                {
                    b.HasOne("qualityservice.Model.ProductionOrderQuality")
                        .WithMany("Analysis")
                        .HasForeignKey("productionOrderQualityId");
                });

            modelBuilder.Entity("qualityservice.Model.AnalysisComp", b =>
                {
                    b.HasOne("qualityservice.Model.Analysis")
                        .WithMany("comp")
                        .HasForeignKey("analysisId");
                });

            modelBuilder.Entity("qualityservice.Model.MessageCalculates", b =>
                {
                    b.HasOne("qualityservice.Model.Analysis")
                        .WithMany("messages")
                        .HasForeignKey("analysisId");

                    b.HasOne("qualityservice.Model.ProductionOrderQuality")
                        .WithMany("calculateInitial")
                        .HasForeignKey("productionOrderQualityId");
                });
#pragma warning restore 612, 618
        }
    }
}
