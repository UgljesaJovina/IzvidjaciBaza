﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories.DAL;

#nullable disable

namespace Repositories.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AkcijaClan", b =>
                {
                    b.Property<Guid>("AkcijeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClanoviId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AkcijeId", "ClanoviId");

                    b.HasIndex("ClanoviId");

                    b.ToTable("AkcijaClan");
                });

            modelBuilder.Entity("ClanClanZnanje", b =>
                {
                    b.Property<Guid>("ClanoviId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ZnanjaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClanoviId", "ZnanjaId");

                    b.HasIndex("ZnanjaId");

                    b.ToTable("ClanClanZnanje");
                });

            modelBuilder.Entity("ClanOdredskaFunkcija", b =>
                {
                    b.Property<Guid>("ClanoviId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FunkcijeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClanoviId", "FunkcijeId");

                    b.HasIndex("FunkcijeId");

                    b.ToTable("ClanOdredskaFunkcija");
                });

            modelBuilder.Entity("ClanPosebanProgram", b =>
                {
                    b.Property<Guid>("ClanoviId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PosebniProgramiId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClanoviId", "PosebniProgramiId");

                    b.HasIndex("PosebniProgramiId");

                    b.ToTable("ClanPosebanProgram");
                });

            modelBuilder.Entity("ClanTecaj", b =>
                {
                    b.Property<Guid>("ClanoviId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TecajeviId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClanoviId", "TecajeviId");

                    b.HasIndex("TecajeviId");

                    b.ToTable("ClanTecaj");
                });

            modelBuilder.Entity("Repositories.Models.Akcija", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DatumKraja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPocetka")
                        .HasColumnType("datetime2");

                    b.Property<string>("MestoOdrzavanja")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<Guid?>("OblikId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TipId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OblikId");

                    b.HasIndex("TipId");

                    b.ToTable("Akcije");
                });

            modelBuilder.Entity("Repositories.Models.Clan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresa")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DatumDavanjaZaveta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumUclanjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid?>("VodId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VodId");

                    b.ToTable("Clanovi");
                });

            modelBuilder.Entity("Repositories.Models.ClanZnanje", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Broj")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DatumDobijanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("Znanje")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ClanoviZnanja");
                });

            modelBuilder.Entity("Repositories.Models.Kazna", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DatumDobijanja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumIsteka")
                        .HasColumnType("datetime2");

                    b.Property<string>("DodeljivacKazne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("_ClanId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("_ClanId");

                    b.ToTable("Kazne");
                });

            modelBuilder.Entity("Repositories.Models.OblikAkcije", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("ObliciAkcija");
                });

            modelBuilder.Entity("Repositories.Models.OdredskaFunkcija", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OdredskeFunkcije");
                });

            modelBuilder.Entity("Repositories.Models.Pohvala", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DatumDobijanja")
                        .HasColumnType("datetime2");

                    b.Property<string>("DodeljivacPohvale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("_ClanId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("_ClanId");

                    b.ToTable("Pohvale");
                });

            modelBuilder.Entity("Repositories.Models.PosebanProgram", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<int>("Tip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PosebniProgrami");
                });

            modelBuilder.Entity("Repositories.Models.Tecaj", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MestoOdrzavanja")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tecajevi");
                });

            modelBuilder.Entity("Repositories.Models.TipAkcije", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("TipoviAkcija");
                });

            modelBuilder.Entity("Repositories.Models.Vod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("_Kategorija")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vodovi");
                });

            modelBuilder.Entity("AkcijaClan", b =>
                {
                    b.HasOne("Repositories.Models.Akcija", null)
                        .WithMany()
                        .HasForeignKey("AkcijeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repositories.Models.Clan", null)
                        .WithMany()
                        .HasForeignKey("ClanoviId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClanClanZnanje", b =>
                {
                    b.HasOne("Repositories.Models.Clan", null)
                        .WithMany()
                        .HasForeignKey("ClanoviId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repositories.Models.ClanZnanje", null)
                        .WithMany()
                        .HasForeignKey("ZnanjaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClanOdredskaFunkcija", b =>
                {
                    b.HasOne("Repositories.Models.Clan", null)
                        .WithMany()
                        .HasForeignKey("ClanoviId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repositories.Models.OdredskaFunkcija", null)
                        .WithMany()
                        .HasForeignKey("FunkcijeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClanPosebanProgram", b =>
                {
                    b.HasOne("Repositories.Models.Clan", null)
                        .WithMany()
                        .HasForeignKey("ClanoviId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repositories.Models.PosebanProgram", null)
                        .WithMany()
                        .HasForeignKey("PosebniProgramiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClanTecaj", b =>
                {
                    b.HasOne("Repositories.Models.Clan", null)
                        .WithMany()
                        .HasForeignKey("ClanoviId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repositories.Models.Tecaj", null)
                        .WithMany()
                        .HasForeignKey("TecajeviId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Repositories.Models.Akcija", b =>
                {
                    b.HasOne("Repositories.Models.OblikAkcije", "Oblik")
                        .WithMany("Akcije")
                        .HasForeignKey("OblikId");

                    b.HasOne("Repositories.Models.TipAkcije", "Tip")
                        .WithMany("Akcije")
                        .HasForeignKey("TipId");

                    b.Navigation("Oblik");

                    b.Navigation("Tip");
                });

            modelBuilder.Entity("Repositories.Models.Clan", b =>
                {
                    b.HasOne("Repositories.Models.Vod", "Vod")
                        .WithMany("Clanovi")
                        .HasForeignKey("VodId");

                    b.Navigation("Vod");
                });

            modelBuilder.Entity("Repositories.Models.Kazna", b =>
                {
                    b.HasOne("Repositories.Models.Clan", "_Clan")
                        .WithMany("Kazne")
                        .HasForeignKey("_ClanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_Clan");
                });

            modelBuilder.Entity("Repositories.Models.Pohvala", b =>
                {
                    b.HasOne("Repositories.Models.Clan", "_Clan")
                        .WithMany("Pohvale")
                        .HasForeignKey("_ClanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_Clan");
                });

            modelBuilder.Entity("Repositories.Models.Clan", b =>
                {
                    b.Navigation("Kazne");

                    b.Navigation("Pohvale");
                });

            modelBuilder.Entity("Repositories.Models.OblikAkcije", b =>
                {
                    b.Navigation("Akcije");
                });

            modelBuilder.Entity("Repositories.Models.TipAkcije", b =>
                {
                    b.Navigation("Akcije");
                });

            modelBuilder.Entity("Repositories.Models.Vod", b =>
                {
                    b.Navigation("Clanovi");
                });
#pragma warning restore 612, 618
        }
    }
}