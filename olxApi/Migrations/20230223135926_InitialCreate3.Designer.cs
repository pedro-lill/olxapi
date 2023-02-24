﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using olxApi.Data;

#nullable disable

namespace olxApi.Migrations
{
    [DbContext(typeof(OlxContext))]
    [Migration("20230223135926_InitialCreate3")]
    partial class InitialCreate3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("olxApi.Models.Anuncio", b =>
                {
                    b.Property<int>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("_id"));

                    b.Property<string>("cat")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("dateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("idUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("price")
                        .HasColumnType("double precision");

                    b.Property<bool>("priceNeg")
                        .HasColumnType("boolean");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("views")
                        .HasColumnType("integer");

                    b.HasKey("_id");

                    b.ToTable("Anuncios");
                });

            modelBuilder.Entity("olxApi.Models.Category", b =>
                {
                    b.Property<int>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("_id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("_id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("olxApi.Models.State", b =>
                {
                    b.Property<string>("_id")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("_id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("olxApi.Models.User", b =>
                {
                    b.Property<int>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("_id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("_id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
