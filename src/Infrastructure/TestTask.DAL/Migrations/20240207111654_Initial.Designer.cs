﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestTask.DAL;

#nullable disable

namespace TestTask.DAL.Migrations
{
    [DbContext(typeof(TestTaskDbContext))]
    [Migration("20240207111654_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestTask.Domain.Entities.Commission", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CurrencyFromId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CurrencyToId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Value")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyFromId");

                    b.HasIndex("CurrencyToId");

                    b.ToTable("Commissions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("07392968-8d5d-4c9d-b8c0-793d0a4b8a67"),
                            CurrencyFromId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            CurrencyToId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            Value = 2.2270383442593m
                        },
                        new
                        {
                            Id = new Guid("81875e10-8e75-4c98-93d8-a872466b0087"),
                            CurrencyFromId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            CurrencyToId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            Value = 6.95343438950926m
                        },
                        new
                        {
                            Id = new Guid("bd2cd155-6ec5-4968-8629-72fd64c0f06b"),
                            CurrencyFromId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            CurrencyToId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            Value = 9.86968378204344m
                        },
                        new
                        {
                            Id = new Guid("2f0e8230-38a6-4b1f-a489-c706a20c83fa"),
                            CurrencyFromId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            CurrencyToId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            Value = 5.43549310155683m
                        },
                        new
                        {
                            Id = new Guid("50320c99-d112-4c4b-8bb0-02203ec89fc9"),
                            CurrencyFromId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            CurrencyToId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            Value = 7.87618010800062m
                        },
                        new
                        {
                            Id = new Guid("e7e66c52-97c3-46d4-b9f6-a5d014b1dbb1"),
                            CurrencyFromId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            CurrencyToId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            Value = 1.9759383337984m
                        },
                        new
                        {
                            Id = new Guid("cc64d622-55af-479f-bbd9-08969cab5f58"),
                            CurrencyFromId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            CurrencyToId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            Value = 1.59778150904579m
                        },
                        new
                        {
                            Id = new Guid("8ffac78e-5459-422b-865f-76083608a720"),
                            CurrencyFromId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            CurrencyToId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            Value = 8.52950501608402m
                        },
                        new
                        {
                            Id = new Guid("c51d45cb-11b0-4c71-938e-58b2b443be54"),
                            CurrencyFromId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            CurrencyToId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            Value = 7.67845818639682m
                        },
                        new
                        {
                            Id = new Guid("76acdfc0-28a3-479a-9c1c-53329ccaf75c"),
                            CurrencyFromId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            CurrencyToId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            Value = 2.06334551214867m
                        },
                        new
                        {
                            Id = new Guid("6b669d34-f8d0-4cf0-ba2d-ac2b866db078"),
                            CurrencyFromId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            CurrencyToId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            Value = 8.78802446998824m
                        },
                        new
                        {
                            Id = new Guid("f70276c8-1911-4c3c-b411-8d83fe216181"),
                            CurrencyFromId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            CurrencyToId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            Value = 7.92325677162923m
                        },
                        new
                        {
                            Id = new Guid("a85fb95f-8b06-4816-968e-898c5c43b9be"),
                            CurrencyFromId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            CurrencyToId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            Value = 5.75373600617953m
                        },
                        new
                        {
                            Id = new Guid("fa369e42-9ce1-4f0e-88a8-5b4ffd9d9d6a"),
                            CurrencyFromId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            CurrencyToId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            Value = 0.245477647278161m
                        },
                        new
                        {
                            Id = new Guid("8757d171-8a6f-44eb-88ce-c08030ed0b6e"),
                            CurrencyFromId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            CurrencyToId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            Value = 4.90283570666045m
                        },
                        new
                        {
                            Id = new Guid("3634e0e5-38ca-4b4e-a8d7-d28f6d6d4c78"),
                            CurrencyFromId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            CurrencyToId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            Value = 4.18638209899037m
                        },
                        new
                        {
                            Id = new Guid("9c4aeefa-685e-4dbd-b52d-ba444e43cd2a"),
                            CurrencyFromId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            CurrencyToId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            Value = 8.05226803016824m
                        },
                        new
                        {
                            Id = new Guid("281011aa-12ce-4ee4-8148-24d2064a5c68"),
                            CurrencyFromId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            CurrencyToId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            Value = 0.126517033431398m
                        },
                        new
                        {
                            Id = new Guid("3912270c-40dc-4c94-b4fb-64d44f99ab46"),
                            CurrencyFromId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            CurrencyToId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            Value = 0.666973945298662m
                        },
                        new
                        {
                            Id = new Guid("3d39f381-a9ee-4a92-bd56-0f7964244ab7"),
                            CurrencyFromId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            CurrencyToId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            Value = 4.2374759282518m
                        });
                });

            modelBuilder.Entity("TestTask.Domain.Entities.Currency", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AlphabeticCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("NumericCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.HasKey("Id");

                    b.HasIndex("AlphabeticCode")
                        .IsUnique();

                    b.HasIndex("NumericCode")
                        .IsUnique();

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Currencies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            AlphabeticCode = "AED",
                            NumericCode = "784",
                            Title = "UAE Dirham"
                        },
                        new
                        {
                            Id = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            AlphabeticCode = "AFN",
                            NumericCode = "971",
                            Title = "Afghan Afghani"
                        },
                        new
                        {
                            Id = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            AlphabeticCode = "ALL",
                            NumericCode = "8",
                            Title = "Albanian Lek"
                        },
                        new
                        {
                            Id = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            AlphabeticCode = "AMD",
                            NumericCode = "51",
                            Title = "Armenian Dram"
                        },
                        new
                        {
                            Id = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            AlphabeticCode = "ANG",
                            NumericCode = "532",
                            Title = "Netherlands Antillian Guilder"
                        });
                });

            modelBuilder.Entity("TestTask.Domain.Entities.ExchangeRate", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CurrencyFromId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CurrencyToId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<decimal>("Value")
                        .HasPrecision(19, 4)
                        .HasColumnType("decimal(19,4)");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyFromId");

                    b.HasIndex("CurrencyToId");

                    b.ToTable("ExchangeRates");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ae8ffb23-7b42-476f-b36a-c70c13d8ad45"),
                            CurrencyFromId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            CurrencyToId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 4.966276976087m
                        },
                        new
                        {
                            Id = new Guid("fe0b9966-e070-4881-bded-14c74e35585f"),
                            CurrencyFromId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            CurrencyToId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 8.53871262495142m
                        },
                        new
                        {
                            Id = new Guid("fc3b8bce-cd35-4bc7-8fea-4c328ef5acae"),
                            CurrencyFromId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            CurrencyToId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 1.49080628471838m
                        },
                        new
                        {
                            Id = new Guid("c613c0c8-fa90-44c3-865a-355aa5903a3d"),
                            CurrencyFromId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            CurrencyToId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 3.94577231866189m
                        },
                        new
                        {
                            Id = new Guid("9eae5288-1c49-4269-bdb3-10b41cece012"),
                            CurrencyFromId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            CurrencyToId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 1.79140119088406m
                        },
                        new
                        {
                            Id = new Guid("f1839fe5-d893-4509-b77c-3d9c5894f4d5"),
                            CurrencyFromId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            CurrencyToId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 3.50496773916495m
                        },
                        new
                        {
                            Id = new Guid("7b7ccbd6-cb1f-4d86-a622-d83d92902612"),
                            CurrencyFromId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            CurrencyToId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 2.77725398416325m
                        },
                        new
                        {
                            Id = new Guid("7be6558d-bbd1-41f3-8cd7-ecdab3cba385"),
                            CurrencyFromId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            CurrencyToId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 6.54969046702452m
                        },
                        new
                        {
                            Id = new Guid("f1a94063-dfc9-4eaa-a517-b38c9a8a12f0"),
                            CurrencyFromId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            CurrencyToId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 3.57545146628002m
                        },
                        new
                        {
                            Id = new Guid("57746b40-d4b4-4da9-b4c2-721f969f8f4d"),
                            CurrencyFromId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            CurrencyToId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 6.716622508041m
                        },
                        new
                        {
                            Id = new Guid("9faf1da1-8f09-4c25-a8c2-8b9b3e79d0a6"),
                            CurrencyFromId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            CurrencyToId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 6.58188878167991m
                        },
                        new
                        {
                            Id = new Guid("950d73d8-3e74-4a60-9e57-c2356075f4b6"),
                            CurrencyFromId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            CurrencyToId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 0.46835236663189m
                        },
                        new
                        {
                            Id = new Guid("2f0be45a-5662-4b8e-8b70-7a552eb0f874"),
                            CurrencyFromId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            CurrencyToId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 5.68645418398078m
                        },
                        new
                        {
                            Id = new Guid("2d6ddffe-d0e1-42ea-a1e6-2f1153b1c932"),
                            CurrencyFromId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            CurrencyToId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 5.07777715514935m
                        },
                        new
                        {
                            Id = new Guid("36ef8d82-67ca-4b38-acea-bae3a74078bb"),
                            CurrencyFromId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            CurrencyToId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 7.56158947185133m
                        },
                        new
                        {
                            Id = new Guid("184ca71a-403c-4609-8858-8e69864850e7"),
                            CurrencyFromId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            CurrencyToId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 9.68014375579476m
                        },
                        new
                        {
                            Id = new Guid("84b45975-ed9f-4dd1-9f26-81a07393609f"),
                            CurrencyFromId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            CurrencyToId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 7.17342710784825m
                        },
                        new
                        {
                            Id = new Guid("f810688d-10eb-48b6-9fb7-de3109ed284d"),
                            CurrencyFromId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            CurrencyToId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 7.46985068366841m
                        },
                        new
                        {
                            Id = new Guid("e0d3a1ce-e25a-428c-b0d9-ba8856285ab4"),
                            CurrencyFromId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            CurrencyToId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 0.901346880852377m
                        },
                        new
                        {
                            Id = new Guid("0644fe26-cf82-4c27-8d51-62b06f934359"),
                            CurrencyFromId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            CurrencyToId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 7, 11, 16, 53, 58, DateTimeKind.Unspecified).AddTicks(2808), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 4.46181650288965m
                        });
                });

            modelBuilder.Entity("TestTask.Domain.Entities.MoneyAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Balance")
                        .HasPrecision(19, 4)
                        .HasColumnType("decimal(19,4)");

                    b.Property<Guid>("CurrencyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("UserId");

                    b.ToTable("MoneyAccounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("444b4612-145c-45dd-906a-0a84ea816618"),
                            Balance = 0m,
                            CurrencyId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            UserId = new Guid("895ed007-9c23-4245-882c-217ca7e02b7e")
                        },
                        new
                        {
                            Id = new Guid("aa6b92c0-cda6-4a19-a371-57de4e59a81b"),
                            Balance = 0m,
                            CurrencyId = new Guid("f8af699b-a251-4153-b42b-f0fccaa6bee0"),
                            UserId = new Guid("f1e15df8-87aa-4434-813f-ca92a2af6d52")
                        },
                        new
                        {
                            Id = new Guid("50898eb1-4889-4904-b57b-c65c3d5c52b4"),
                            Balance = 0m,
                            CurrencyId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            UserId = new Guid("895ed007-9c23-4245-882c-217ca7e02b7e")
                        },
                        new
                        {
                            Id = new Guid("e3776ba3-fd49-4036-b735-1066f6b98c24"),
                            Balance = 0m,
                            CurrencyId = new Guid("f2ca62d4-5f5e-491c-8cf7-b456cec368d5"),
                            UserId = new Guid("f1e15df8-87aa-4434-813f-ca92a2af6d52")
                        },
                        new
                        {
                            Id = new Guid("8b967caf-0ec5-469b-8fa9-4b1961206d8f"),
                            Balance = 0m,
                            CurrencyId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            UserId = new Guid("895ed007-9c23-4245-882c-217ca7e02b7e")
                        },
                        new
                        {
                            Id = new Guid("1e9126cf-98d7-42a9-88eb-ccb776689701"),
                            Balance = 0m,
                            CurrencyId = new Guid("5704271f-5817-445a-8a5e-6f7455766d7f"),
                            UserId = new Guid("f1e15df8-87aa-4434-813f-ca92a2af6d52")
                        },
                        new
                        {
                            Id = new Guid("eaffc45f-a1c6-48b4-88f0-81aaa58445a9"),
                            Balance = 0m,
                            CurrencyId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            UserId = new Guid("895ed007-9c23-4245-882c-217ca7e02b7e")
                        },
                        new
                        {
                            Id = new Guid("ac53626d-02cb-4d91-b408-cc20035cd044"),
                            Balance = 0m,
                            CurrencyId = new Guid("73d7a62c-e7fa-4781-8326-7768aa56eb9b"),
                            UserId = new Guid("f1e15df8-87aa-4434-813f-ca92a2af6d52")
                        },
                        new
                        {
                            Id = new Guid("a876ecd0-639c-42d5-807c-40d7974a0fd9"),
                            Balance = 0m,
                            CurrencyId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            UserId = new Guid("895ed007-9c23-4245-882c-217ca7e02b7e")
                        },
                        new
                        {
                            Id = new Guid("cc36e31b-b870-4927-9f9d-751cca34da5a"),
                            Balance = 0m,
                            CurrencyId = new Guid("3213b06e-aa75-4d3d-9d8e-33bf4d8ae673"),
                            UserId = new Guid("f1e15df8-87aa-4434-813f-ca92a2af6d52")
                        });
                });

            modelBuilder.Entity("TestTask.Domain.Entities.MoneyOperation", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("AppliedCommissionValue")
                        .HasPrecision(4, 4)
                        .HasColumnType("decimal(4,4)");

                    b.Property<decimal>("AppliedExchangeRate")
                        .HasPrecision(19, 4)
                        .HasColumnType("decimal(19,4)");

                    b.Property<Guid?>("MoneyAccountFromId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MoneyAccountToId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("MoneyAmount")
                        .HasPrecision(19, 4)
                        .HasColumnType("decimal(19,4)");

                    b.Property<string>("MoveType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("OperationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("OperationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MoneyAccountFromId");

                    b.HasIndex("MoneyAccountToId");

                    b.ToTable("MoneyOperations");
                });

            modelBuilder.Entity("TestTask.Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d6ffd0ce-6f1d-48a8-af37-974ae74b1ae6"),
                            Title = "User"
                        },
                        new
                        {
                            Id = new Guid("8c584b56-feef-4403-af9c-95f4883b7b83"),
                            Title = "Admin"
                        });
                });

            modelBuilder.Entity("TestTask.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("895ed007-9c23-4245-882c-217ca7e02b7e"),
                            Email = "penis@gmail.com",
                            FullName = "Mike Vazovskiy",
                            PasswordHash = "$2a$11$qXxrqcC75oz5NYGZaQ/6p.BtSIYxVGFa45.TTKUeA47k9TbJqdE5m"
                        },
                        new
                        {
                            Id = new Guid("f1e15df8-87aa-4434-813f-ca92a2af6d52"),
                            Email = "popka@gmail.com",
                            FullName = "John Doe",
                            PasswordHash = "$2a$11$UjZF/zc6XPJHXlmd4bBHweoPWrm.6H.FjHBaaVfvV.SayMzKqTwau"
                        });
                });

            modelBuilder.Entity("TestTask.Domain.Entities.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("895ed007-9c23-4245-882c-217ca7e02b7e"),
                            RoleId = new Guid("d6ffd0ce-6f1d-48a8-af37-974ae74b1ae6")
                        },
                        new
                        {
                            UserId = new Guid("895ed007-9c23-4245-882c-217ca7e02b7e"),
                            RoleId = new Guid("8c584b56-feef-4403-af9c-95f4883b7b83")
                        },
                        new
                        {
                            UserId = new Guid("f1e15df8-87aa-4434-813f-ca92a2af6d52"),
                            RoleId = new Guid("d6ffd0ce-6f1d-48a8-af37-974ae74b1ae6")
                        });
                });

            modelBuilder.Entity("TestTask.Domain.Entities.Commission", b =>
                {
                    b.HasOne("TestTask.Domain.Entities.Currency", "From")
                        .WithMany()
                        .HasForeignKey("CurrencyFromId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TestTask.Domain.Entities.Currency", "To")
                        .WithMany()
                        .HasForeignKey("CurrencyToId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("From");

                    b.Navigation("To");
                });

            modelBuilder.Entity("TestTask.Domain.Entities.ExchangeRate", b =>
                {
                    b.HasOne("TestTask.Domain.Entities.Currency", "From")
                        .WithMany()
                        .HasForeignKey("CurrencyFromId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TestTask.Domain.Entities.Currency", "To")
                        .WithMany()
                        .HasForeignKey("CurrencyToId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("From");

                    b.Navigation("To");
                });

            modelBuilder.Entity("TestTask.Domain.Entities.MoneyAccount", b =>
                {
                    b.HasOne("TestTask.Domain.Entities.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestTask.Domain.Entities.User", "User")
                        .WithMany("MoneyAccounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Currency");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestTask.Domain.Entities.MoneyOperation", b =>
                {
                    b.HasOne("TestTask.Domain.Entities.MoneyAccount", "From")
                        .WithMany()
                        .HasForeignKey("MoneyAccountFromId");

                    b.HasOne("TestTask.Domain.Entities.MoneyAccount", "To")
                        .WithMany()
                        .HasForeignKey("MoneyAccountToId");

                    b.Navigation("From");

                    b.Navigation("To");
                });

            modelBuilder.Entity("TestTask.Domain.Entities.UserRole", b =>
                {
                    b.HasOne("TestTask.Domain.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestTask.Domain.Entities.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestTask.Domain.Entities.User", b =>
                {
                    b.Navigation("MoneyAccounts");

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
