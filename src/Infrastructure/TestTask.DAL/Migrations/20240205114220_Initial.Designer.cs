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
    [Migration("20240205114220_Initial")]
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
                            Id = new Guid("95c3a3fc-cdcf-4288-8991-e64f6a5cd5be"),
                            CurrencyFromId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            CurrencyToId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            Value = 1.47567225742711m
                        },
                        new
                        {
                            Id = new Guid("6395e4e5-1f4b-4cdc-b2f5-eb4df0f71532"),
                            CurrencyFromId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            CurrencyToId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            Value = 1.8676034484307m
                        },
                        new
                        {
                            Id = new Guid("0ca984e5-0457-40ee-9cf5-425fabd861ea"),
                            CurrencyFromId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            CurrencyToId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            Value = 2.72429603119848m
                        },
                        new
                        {
                            Id = new Guid("65416614-a71a-4fa6-9a90-83eb713d7185"),
                            CurrencyFromId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            CurrencyToId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            Value = 3.45448064881854m
                        },
                        new
                        {
                            Id = new Guid("59c2c10d-bdf3-45f5-a0f5-ff5e8e5c7a72"),
                            CurrencyFromId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            CurrencyToId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            Value = 5.51914896135217m
                        },
                        new
                        {
                            Id = new Guid("d2a753b7-b4f1-4122-9f5a-bc58c2e01169"),
                            CurrencyFromId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            CurrencyToId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            Value = 1.86624136835203m
                        },
                        new
                        {
                            Id = new Guid("9dd5b838-6958-46c9-a9dc-554cbcb1a582"),
                            CurrencyFromId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            CurrencyToId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            Value = 2.97320475596912m
                        },
                        new
                        {
                            Id = new Guid("51c191a0-a364-42af-b000-5d0375cb808e"),
                            CurrencyFromId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            CurrencyToId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            Value = 8.99749947318829m
                        },
                        new
                        {
                            Id = new Guid("147ce461-c1b1-415c-8e68-c3677f105ed0"),
                            CurrencyFromId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            CurrencyToId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            Value = 5.88291618177289m
                        },
                        new
                        {
                            Id = new Guid("21a497d8-5a31-4f54-9b14-7c4da02242ef"),
                            CurrencyFromId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            CurrencyToId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            Value = 7.35019691442417m
                        },
                        new
                        {
                            Id = new Guid("920b2599-e782-465a-b7ef-a9bd2f136041"),
                            CurrencyFromId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            CurrencyToId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            Value = 5.79770773882617m
                        },
                        new
                        {
                            Id = new Guid("a9330857-fbcb-4fe5-9617-818b64d1102a"),
                            CurrencyFromId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            CurrencyToId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            Value = 8.35206356351371m
                        },
                        new
                        {
                            Id = new Guid("28525077-0382-49c2-87dc-ac0f2f8b4578"),
                            CurrencyFromId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            CurrencyToId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            Value = 0.886309093455327m
                        },
                        new
                        {
                            Id = new Guid("da1ed5d3-6359-4015-ac70-e6fc308ff113"),
                            CurrencyFromId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            CurrencyToId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            Value = 8.24596405810693m
                        },
                        new
                        {
                            Id = new Guid("c7742747-87a2-48c0-ba8b-4f2a62604a69"),
                            CurrencyFromId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            CurrencyToId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            Value = 5.67199697000153m
                        },
                        new
                        {
                            Id = new Guid("50de7a08-107e-4a48-8304-6130d655f988"),
                            CurrencyFromId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            CurrencyToId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            Value = 0.691888693851692m
                        },
                        new
                        {
                            Id = new Guid("1eee8195-ddb3-4814-bb49-b4c7f848e109"),
                            CurrencyFromId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            CurrencyToId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            Value = 3.67050007044066m
                        },
                        new
                        {
                            Id = new Guid("ce6000fb-a74c-4ae0-9e0c-99e452d46b7c"),
                            CurrencyFromId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            CurrencyToId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            Value = 7.87293382943556m
                        },
                        new
                        {
                            Id = new Guid("8ccb820f-0785-4b72-86b2-241ba429ce85"),
                            CurrencyFromId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            CurrencyToId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            Value = 1.66359018752944m
                        },
                        new
                        {
                            Id = new Guid("9848f644-9e43-4bfa-9141-92f52388b606"),
                            CurrencyFromId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            CurrencyToId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            Value = 5.10298606424193m
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
                            Id = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            AlphabeticCode = "AED",
                            NumericCode = "784",
                            Title = "UAE Dirham"
                        },
                        new
                        {
                            Id = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            AlphabeticCode = "AFN",
                            NumericCode = "971",
                            Title = "Afghan Afghani"
                        },
                        new
                        {
                            Id = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            AlphabeticCode = "ALL",
                            NumericCode = "8",
                            Title = "Albanian Lek"
                        },
                        new
                        {
                            Id = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            AlphabeticCode = "AMD",
                            NumericCode = "51",
                            Title = "Armenian Dram"
                        },
                        new
                        {
                            Id = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
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
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyFromId");

                    b.HasIndex("CurrencyToId");

                    b.ToTable("ExchangeRates");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f8e040e6-1c06-46b2-abc7-53a64125eb75"),
                            CurrencyFromId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            CurrencyToId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 9.02858918602043m
                        },
                        new
                        {
                            Id = new Guid("9b3ccdf1-2c22-46d1-b41a-81a3cd35b2e2"),
                            CurrencyFromId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            CurrencyToId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 5.12705620768923m
                        },
                        new
                        {
                            Id = new Guid("94be7864-75b9-4598-bbf9-219af73cfe93"),
                            CurrencyFromId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            CurrencyToId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 0.375540754241749m
                        },
                        new
                        {
                            Id = new Guid("41c3ac97-2563-4944-aeed-6ef04347c25b"),
                            CurrencyFromId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            CurrencyToId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 0.771742040662266m
                        },
                        new
                        {
                            Id = new Guid("355aeda1-da89-45a6-9571-a8a48a035568"),
                            CurrencyFromId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            CurrencyToId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 2.22921438042379m
                        },
                        new
                        {
                            Id = new Guid("eee76612-13f7-442f-8688-e92c5c3755f7"),
                            CurrencyFromId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            CurrencyToId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 7.87453609369409m
                        },
                        new
                        {
                            Id = new Guid("a39d74f3-67a6-46b0-ae94-14888384fff2"),
                            CurrencyFromId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            CurrencyToId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 2.27538136635462m
                        },
                        new
                        {
                            Id = new Guid("b436306c-23d8-4277-84e0-de82a4d3d0a6"),
                            CurrencyFromId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            CurrencyToId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 1.12527130755973m
                        },
                        new
                        {
                            Id = new Guid("618a91ca-7592-493e-a169-6a46bc8707f6"),
                            CurrencyFromId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            CurrencyToId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 2.53065618990091m
                        },
                        new
                        {
                            Id = new Guid("02569039-a97f-439a-848a-40ac69d6a233"),
                            CurrencyFromId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            CurrencyToId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 8.21807839890546m
                        },
                        new
                        {
                            Id = new Guid("e9f712ee-817e-40aa-a0d0-80dacc3a3370"),
                            CurrencyFromId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            CurrencyToId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 5.03287693135132m
                        },
                        new
                        {
                            Id = new Guid("c70f3f9a-0d50-499d-a175-f93592d919b2"),
                            CurrencyFromId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            CurrencyToId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 3.72566822570559m
                        },
                        new
                        {
                            Id = new Guid("6115075b-5cc7-43cd-b447-b4f325549da7"),
                            CurrencyFromId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            CurrencyToId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 1.71384606475925m
                        },
                        new
                        {
                            Id = new Guid("eb4855b4-9423-4e58-a460-0130db28122e"),
                            CurrencyFromId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            CurrencyToId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 4.96074310781057m
                        },
                        new
                        {
                            Id = new Guid("f5ffe8c6-52e0-427f-abf3-0322dab589c6"),
                            CurrencyFromId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            CurrencyToId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 1.734162200406m
                        },
                        new
                        {
                            Id = new Guid("1a2f85fb-3468-4f56-898a-17cc8e02a43b"),
                            CurrencyFromId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            CurrencyToId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 5.85422826910279m
                        },
                        new
                        {
                            Id = new Guid("b733fcc7-56dc-4793-80c3-e7185ceb71ed"),
                            CurrencyFromId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            CurrencyToId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 3.33632272288771m
                        },
                        new
                        {
                            Id = new Guid("2e19ada1-f8dc-4ee2-89df-fc55ba053085"),
                            CurrencyFromId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            CurrencyToId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 7.01524675795986m
                        },
                        new
                        {
                            Id = new Guid("78b6721e-636c-49a5-aef2-4b581bd4dfea"),
                            CurrencyFromId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            CurrencyToId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 9.12762745283286m
                        },
                        new
                        {
                            Id = new Guid("f4044b4f-f798-4284-9f8b-ce405bb500c8"),
                            CurrencyFromId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            CurrencyToId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 2, 5, 11, 42, 19, 540, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, 0, 0, 0, 0)),
                            Value = 7.99237167573898m
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
                            Id = new Guid("dc2887a6-6669-4a3e-8141-2d979631990f"),
                            Balance = 0m,
                            CurrencyId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            UserId = new Guid("20505800-43c3-43c4-81c6-b028d33421c9")
                        },
                        new
                        {
                            Id = new Guid("d34e316d-76f9-4b65-a8ed-9c6a0e9fce62"),
                            Balance = 0m,
                            CurrencyId = new Guid("10d05faf-e87e-41a9-bbbd-b94bb4fb1c33"),
                            UserId = new Guid("5f876f3f-0653-4f65-94da-1c6d61cc9855")
                        },
                        new
                        {
                            Id = new Guid("0adfa3dd-11b8-48d1-92ce-f0dda1aa1551"),
                            Balance = 0m,
                            CurrencyId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            UserId = new Guid("20505800-43c3-43c4-81c6-b028d33421c9")
                        },
                        new
                        {
                            Id = new Guid("a97608f1-cc31-4ccc-a26d-a995917eabe2"),
                            Balance = 0m,
                            CurrencyId = new Guid("b0ea83ca-4260-44a9-ac40-f24dd285032b"),
                            UserId = new Guid("5f876f3f-0653-4f65-94da-1c6d61cc9855")
                        },
                        new
                        {
                            Id = new Guid("203fd9c1-a137-40f6-9035-5c1f4719c07a"),
                            Balance = 0m,
                            CurrencyId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            UserId = new Guid("20505800-43c3-43c4-81c6-b028d33421c9")
                        },
                        new
                        {
                            Id = new Guid("93ae58fe-c20e-4397-97ea-cd30bc3ee0b0"),
                            Balance = 0m,
                            CurrencyId = new Guid("f632d840-ff58-42bc-ab8f-a2c9de53bdee"),
                            UserId = new Guid("5f876f3f-0653-4f65-94da-1c6d61cc9855")
                        },
                        new
                        {
                            Id = new Guid("63c5c16c-c86b-42fd-ac6d-c59fdf2a666c"),
                            Balance = 0m,
                            CurrencyId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            UserId = new Guid("20505800-43c3-43c4-81c6-b028d33421c9")
                        },
                        new
                        {
                            Id = new Guid("7abda455-a128-4ab9-b9fe-1bffd21c1fe7"),
                            Balance = 0m,
                            CurrencyId = new Guid("4f0be9f2-cb66-4d32-8f67-cf6b40497c94"),
                            UserId = new Guid("5f876f3f-0653-4f65-94da-1c6d61cc9855")
                        },
                        new
                        {
                            Id = new Guid("7dbb16e5-d807-4850-a839-ee1f0536af2f"),
                            Balance = 0m,
                            CurrencyId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            UserId = new Guid("20505800-43c3-43c4-81c6-b028d33421c9")
                        },
                        new
                        {
                            Id = new Guid("ede4cf1f-b73c-4f69-bb64-fcb34b97f762"),
                            Balance = 0m,
                            CurrencyId = new Guid("ad1f6b71-30c7-49fa-9350-bf74ed785e23"),
                            UserId = new Guid("5f876f3f-0653-4f65-94da-1c6d61cc9855")
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
                            Id = new Guid("e9956abf-21bb-47ef-ac56-c0ea1300a813"),
                            Title = "User"
                        },
                        new
                        {
                            Id = new Guid("b6bf79ee-74ae-4c7d-bf44-4e6897fe8e65"),
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
                            Id = new Guid("20505800-43c3-43c4-81c6-b028d33421c9"),
                            Email = "penis@gmail.com",
                            FullName = "Mike Vazovskiy",
                            PasswordHash = "$2a$11$estu3icfrbj8ipgM92N73.UHyTWE6rLdxDOiFoeKmUAFkKAoFPJIi"
                        },
                        new
                        {
                            Id = new Guid("5f876f3f-0653-4f65-94da-1c6d61cc9855"),
                            Email = "popka@gmail.com",
                            FullName = "John Doe",
                            PasswordHash = "$2a$11$mGspcWTKRctWsE3bzYZ2Zu6pmBF2zV9b.xYf38D5AQ.lnlsW.5zPq"
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
                            UserId = new Guid("20505800-43c3-43c4-81c6-b028d33421c9"),
                            RoleId = new Guid("e9956abf-21bb-47ef-ac56-c0ea1300a813")
                        },
                        new
                        {
                            UserId = new Guid("20505800-43c3-43c4-81c6-b028d33421c9"),
                            RoleId = new Guid("b6bf79ee-74ae-4c7d-bf44-4e6897fe8e65")
                        },
                        new
                        {
                            UserId = new Guid("5f876f3f-0653-4f65-94da-1c6d61cc9855"),
                            RoleId = new Guid("e9956abf-21bb-47ef-ac56-c0ea1300a813")
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