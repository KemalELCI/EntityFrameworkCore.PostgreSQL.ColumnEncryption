﻿// <auto-generated />

using EncryptionTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EncryptionTest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211023193124_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasPostgresExtension("pgcrypto")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("AltairCA.SignInWith.Test.Testings", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("encrypted")
                        .HasColumnType("text");

                    b.Property<string>("normal")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Testings");
                });
#pragma warning restore 612, 618
        }
    }
}