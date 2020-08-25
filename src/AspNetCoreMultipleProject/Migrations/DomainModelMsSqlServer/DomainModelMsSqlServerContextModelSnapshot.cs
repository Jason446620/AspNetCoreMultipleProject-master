﻿// <auto-generated />
using System;
using DataAccessMsSqlServerProvider;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetCoreMultipleProject.Migrations.DomainModelMsSqlServer
{
    [DbContext(typeof(DomainModelMsSqlServerContext))]
    partial class DomainModelMsSqlServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainModel.Model.DataEventRecord", b =>
                {
                    b.Property<long>("DataEventRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SourceInfoId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedTimestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("DataEventRecordId");

                    b.HasIndex("SourceInfoId");

                    b.ToTable("DataEventRecords");
                });

            modelBuilder.Entity("DomainModel.Model.SourceInfo", b =>
                {
                    b.Property<long>("SourceInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedTimestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("SourceInfoId");

                    b.ToTable("SourceInfos");
                });

            modelBuilder.Entity("DomainModel.Model.DataEventRecord", b =>
                {
                    b.HasOne("DomainModel.Model.SourceInfo", "SourceInfo")
                        .WithMany("DataEventRecords")
                        .HasForeignKey("SourceInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
